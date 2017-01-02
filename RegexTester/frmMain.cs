using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace RegexTester
{
  public partial class frmMain : Form
  {
    private DataTable _dtMatchesRes;
    private Thread _worker;
    private FastColoredTextBox _currentControl;
    private int _currentLocation;
    private List<Style> _styleList;
    private delegate void RegexProcessStartEventHandler();
    private event RegexProcessStartEventHandler RegexProcessStart;
    private delegate void RegexProcessEndEventHandler();
    private event RegexProcessEndEventHandler RegexProcessEnd;
    private delegate void RegexProcessTextEventHandler(DateTime dt, string status);
    private event RegexProcessTextEventHandler RegexProcessText;

    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      int counter = 0;

      txtPattern.GotFocus += fctb_GotFocus;
      txtReplace.GotFocus += fctb_GotFocus;
      fctbInput.GotFocus += fctb_GotFocus;
      fctbResult.GotFocus += fctb_GotFocus;

      General.SettingsFile = Path.Combine(Application.StartupPath, "RegexTester.Settings.xml");
      General.ProgramSettings();

      General.ChangeFont(this);

      mnuHelpInfo.Enabled = File.Exists(Path.Combine(Application.StartupPath, "QuickReference.pdf"));

      ToolTip tt = new ToolTip()
      {
        IsBalloon = false,
        ShowAlways = true
      };

      tt.SetToolTip(cbIgnoreCase, "Use case-insensitive matching.");
      tt.SetToolTip(cbMultiline, "Use multiline mode, where ^ and $ match the beginning and end of each line.");
      tt.SetToolTip(cbSingleLine, "Use single-line mode, where the period (.) matches every character.");
      tt.SetToolTip(cbExplicitCapture, "Do not capture unnamed groups.");
      tt.SetToolTip(cbCompiled, "Compile the regular expression to an assembly.");
      tt.SetToolTip(cbIgnoreWhiteSpace, "Exclude unescaped white space from the pattern, and enable comments after a number sign (#).");
      tt.SetToolTip(cbRightToLeft, "Change the search direction. Search moves from right to left instead of from left to right.");
      tt.SetToolTip(cbECMAScript, "Enable ECMAScript-compliant behavior for the expression.");
      tt.SetToolTip(cbCultureInvariant, "Ignore cultural differences in language.");
      tt.SetToolTip(cbGlobal, "Global uses (?=[\\r\\n]|\\z) instead of $ and Multiline to fix the correct matching.");

      DataGridViewTextBoxColumn nrColumn = new DataGridViewTextBoxColumn();
      nrColumn.HeaderText = "#";
      nrColumn.Name = "Nr";
      nrColumn.DataPropertyName = "Nr";
      nrColumn.ReadOnly = true;
      nrColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

      DataGridViewTextBoxColumn indexColumn = new DataGridViewTextBoxColumn();
      indexColumn.HeaderText = "Index";
      indexColumn.Name = "Index";
      indexColumn.DataPropertyName = "Index";
      indexColumn.ReadOnly = true;
      indexColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

      DataGridViewTextBoxColumn lengthColumn = new DataGridViewTextBoxColumn();
      lengthColumn.HeaderText = "Length";
      lengthColumn.Name = "Length";
      lengthColumn.DataPropertyName = "Length";
      lengthColumn.ReadOnly = true;
      lengthColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

      DataGridViewTextBoxColumn groupColumn = new DataGridViewTextBoxColumn();
      groupColumn.HeaderText = "Group";
      groupColumn.Name = "Group";
      groupColumn.DataPropertyName = "Group";
      groupColumn.ReadOnly = true;
      groupColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

      DataGridViewTextBoxColumn stringColumn = new DataGridViewTextBoxColumn();
      stringColumn.HeaderText = "Matched String";
      stringColumn.Name = "MatchedString";
      stringColumn.DataPropertyName = "MatchedString";
      stringColumn.ReadOnly = true;
      stringColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

      grdResult.AutoGenerateColumns = false;
      grdResult.Columns.Add(nrColumn);
      grdResult.Columns.Add(indexColumn);
      grdResult.Columns.Add(lengthColumn);
      grdResult.Columns.Add(groupColumn);
      grdResult.Columns.Add(stringColumn);

      fctbInput.ClearStyle(StyleIndex.All);

      counter = 0;
      XmlDocument xDoc = new XmlDocument();
      xDoc.Load(General.SettingsFile);
      XmlNodeList nodelist = xDoc.SelectNodes("/Configuration/Colors/Color");
      foreach (XmlElement node in nodelist)
      {
        if (node.InnerText != string.Empty)
        {
          counter += 1;
          fctbInput.AddStyle(new MarkerStyle(new SolidBrush(General.ConvertStringToColor(node.InnerText))));
        }

        if (counter == fctbInput.Styles.Length)
        {
          break;
        }
      }

      _styleList = fctbInput.Styles.ToList();
      _styleList.RemoveAll(stl => stl == null);

      fctbInput.SelectionColor = General.SelectColor;
      fctbResult.SelectionColor = General.SelectColor;
      txtPattern.SelectionColor = General.SelectColor;
      txtReplace.SelectionColor = General.SelectColor;

      txtPattern.Font = new Font(General.FontPatternName, Convert.ToSingle(General.FontPatternSize));
      txtReplace.Font = new Font(General.FontReplaceName, Convert.ToSingle(General.FontReplaceSize));
      fctbInput.Font = new Font(General.FontInputName, Convert.ToSingle(General.FontInputSize));
      fctbResult.Font = new Font(General.FontInputName, Convert.ToSingle(General.FontInputSize));

      txtPattern.ClearUndo();
      txtReplace.ClearUndo();
      fctbInput.ClearUndo();
      fctbResult.ClearUndo();
    }

    private void frmMain_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.F5)
      {
        btnMatches.PerformClick();
      }
      else if (e.KeyData == Keys.F6)
      {
        btnReplace.PerformClick();
      }
    }

    private void SetComponentState(bool state)
    {
      if (!state)
      {
        _currentLocation = _currentControl.SelectionStart;
      }

      this.MaximizeBox = state;
      this.MinimizeBox = state;

      btnMatches.Visible = state;
      btnStop.Visible = !state;

      mnuFile.Enabled = state;
      mnuEdit.Enabled = state;
      mnuHelp.Enabled = state;
      btnMatches.Enabled = state;
      btnReplace.Enabled = state;
      txtPattern.Enabled = state;
      txtReplace.Enabled = state;
      fctbInput.Enabled = state;
      fctbResult.Enabled = state;
      grdResult.Enabled = state;

      cbMatchImmediately.Enabled = state;
      cbCompiled.Enabled = state;
      cbCultureInvariant.Enabled = state;
      cbECMAScript.Enabled = state;
      cbExplicitCapture.Enabled = state;
      cbIgnoreCase.Enabled = state;
      cbIgnoreWhiteSpace.Enabled = state;
      cbMultiline.Enabled = state;
      cbRightToLeft.Enabled = state;
      cbSingleLine.Enabled = state;
      cbGlobal.Enabled = state;

      if (state)
      {
        RegexOptionsCheckBoxes();

        mnuHelpInfo.Enabled = File.Exists(Path.Combine(Application.StartupPath, "QuickReference.pdf"));

        if (_currentControl != null)
        {
          _currentControl.SelectionStart = _currentLocation;
          _currentControl.Focus();
        }
      }
    }

    private void btnMatches_Click(object sender, EventArgs e)
    {
      RegexVariables variables = new RegexVariables();
      bool validRegex = false;

      variables.RegexPattern = txtPattern.Text;
      variables.RegexReplace = txtReplace.Text;
      variables.RegexText = fctbInput.Text;
      variables.RegexOptions = GetRegExOptions();
      variables.RegexGlobal = cbGlobal.Checked;

      validRegex = General.VerifyRegEx(variables.RegexPattern);

      SetColorTextBackColor(txtPattern, validRegex ? Color.White : General.ErrorColor);

      if (validRegex)
      {
        SetComponentState(false);

        _worker = new Thread(ApplyRegEx);

        _worker.IsBackground = true;

        RegexProcessStart += OnRegexProcessStart;
        RegexProcessEnd += OnRegexProcessEnd;
        RegexProcessText += OnRegexProcessText;

        _worker.Start(variables);
      }
    }

    private void btnReplace_Click(object sender, EventArgs e)
    {
      RegexVariables variables = new RegexVariables();
      bool validRegex = false;

      variables.RegexPattern = txtPattern.Text;
      variables.RegexReplace = txtReplace.Text;
      variables.RegexText = fctbInput.Text;
      variables.RegexOptions = GetRegExOptions();
      variables.RegexGlobal = cbGlobal.Checked;

      validRegex = General.VerifyRegEx(variables.RegexPattern);

      SetColorTextBackColor(txtPattern, validRegex ? Color.White : General.ErrorColor);

      if (validRegex)
      {
        SetComponentState(false);

        _worker = new Thread(ReplaceRegEx);

        _worker.IsBackground = true;

        RegexProcessStart += OnRegexProcessStart;
        RegexProcessEnd += OnRegexProcessEnd;
        RegexProcessText += OnRegexProcessText;

        _worker.Start(variables);
      }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      if (_worker.IsAlive)
      {
        _worker.Abort();
        sbStatus.Text = "Check Stopped";
        Invoke(new Action<bool>(SetComponentState), true);
      }
    }

    private void ApplyRegEx(object objVariables)
    {
      bool err = false;
      DateTime startTime;
      TimeSpan executionTimeSpan;
      Regex re;
      MatchCollection matches;
      string[] groups = null;
      DataRow r;
      int colorCounter = 0;
      int colorSelect = 0;
      int matchesFound = 0;

      int matchIndex = 0;
      int matchLength = 0;

      RegexVariables variables = (RegexVariables)objVariables;

      if (RegexProcessStart != null)
      {
        RegexProcessStart();
      }

      startTime = DateTime.Now;

      if (RegexProcessText != null)
      {
        RegexProcessText(DateTime.Now, "Initializing");
      }

      ResetQueryText(fctbInput);
      ResetResults(grdResult);

      if (RegexProcessText != null)
      {
        RegexProcessText(DateTime.Now, "Starting");
      }

      try
      {
        if (variables.RegexGlobal)
        {
          variables.RegexPattern = variables.RegexPattern.Replace("$", "(?=[\\r\\n]|\\z)");
        }

        re = new Regex(variables.RegexPattern, variables.RegexOptions);

        if (ShowIsMatch(re, variables.RegexText))
        {
          if (RegexProcessText != null)
          {
            RegexProcessText(DateTime.Now, "Search Started");
          }

          groups = re.GetGroupNames();
          matches = re.Matches(variables.RegexText);
          matchesFound = matches.Count;

          if (RegexProcessText != null)
          {
            RegexProcessText(DateTime.Now, "Search Ended");
          }

          _dtMatchesRes = CreateTable();

          if (RegexProcessText != null)
          {
            RegexProcessText(DateTime.Now, "Highlight Started");
          }

          for (int i = 0; i <= matchesFound - 1; i++)
          {
            colorCounter = 0;

            for (int j = 0; j <= matches[i].Groups.Count - 1; j++)
            {
              matchIndex = j == 0 ? matches[i].Index : matches[i].Groups[j].Index;
              matchLength = j == 0 ? matches[i].Length : matches[i].Groups[j].Length;

              r = _dtMatchesRes.NewRow();
              r["Match"] = i.ToString();
              r["Nr"] = j == 0 ? i.ToString() : string.Empty;
              r["Index"] = matchIndex.ToString();
              r["Length"] = matchLength.ToString();
              r["Group"] = groups[j];
              r["MatchedString"] = matches[i].Groups[j].Value;
              _dtMatchesRes.Rows.Add(r);

              if (j == 0)
              {
                colorSelect = 0;
              }
              else
              {
                colorSelect = colorCounter;
              }

              ColorizeMatches(Convert.ToInt32(groups[j]), matchIndex, matchLength, colorSelect);

              colorCounter += 1;

              if (colorCounter == _styleList.Count)
              {
                colorCounter = 0;
              }
            }
          }

          if (RegexProcessText != null)
          {
            RegexProcessText(DateTime.Now, "Highlight Ended");
          }

          GridAddSource(_dtMatchesRes);

          if (RegexProcessText != null)
          {
            RegexProcessText(DateTime.Now, "Finished");
          }
        }
        else
        {
          if (RegexProcessText != null)
          {
            RegexProcessText(DateTime.Now, "No Matches");
          }
        }
      }
      catch (Exception ex)
      {
        err = true;
      }
      finally
      {
        re = null;
      }

      SetColorTextBackColor(txtPattern, err ? General.ErrorColor : Color.White);

      executionTimeSpan = DateTime.Now.Subtract(startTime);
      if (executionTimeSpan.TotalHours > 1)
      {
        sbTime.Text = string.Format("{0} hs.", executionTimeSpan.TotalHours.ToString("##.##"));
      }
      else if (executionTimeSpan.TotalMinutes > 1)
      {
        sbTime.Text = string.Format("{0} mins.", executionTimeSpan.TotalMinutes.ToString("##.##"));
      }
      else if (executionTimeSpan.TotalSeconds > 1)
      {
        sbTime.Text = string.Format("{0} s.", executionTimeSpan.TotalSeconds.ToString("##.##"));
      }
      else if (executionTimeSpan.TotalMilliseconds > 1)
      {
        sbTime.Text = string.Format("{0} ms.", executionTimeSpan.TotalMilliseconds.ToString("#"));
      }

      sbMatches.Text = string.Format("{0} matches", matchesFound.ToString());

      if (RegexProcessEnd != null)
      {
        RegexProcessEnd();
      }
    }

    private void ReplaceRegEx(object objVariables)
    {
      bool err = false;
      DateTime startTime;
      TimeSpan executionTimeSpan;
      Regex re;

      RegexVariables variables = (RegexVariables)objVariables;

      if (RegexProcessStart != null)
      {
        RegexProcessStart();
      }

      startTime = DateTime.Now;

      try
      {
        if (variables.RegexGlobal)
        {
          variables.RegexPattern = variables.RegexPattern.Replace("$", "(?=[\\r\\n]|\\z)");
        }

        re = new Regex(variables.RegexPattern, variables.RegexOptions);

        SetText(fctbResult, re.Replace(variables.RegexText, variables.RegexReplace));
      }
      catch (System.Exception ex)
      {
        err = true;
      }

      executionTimeSpan = DateTime.Now.Subtract(startTime);
      if (executionTimeSpan.TotalHours > 1)
      {
        sbTime.Text = string.Format("{0} hs.", executionTimeSpan.TotalHours.ToString("##.##"));
      }
      else if (executionTimeSpan.TotalMinutes > 1)
      {
        sbTime.Text = string.Format("{0} mins.", executionTimeSpan.TotalMinutes.ToString("##.##"));
      }
      else if (executionTimeSpan.TotalSeconds > 1)
      {
        sbTime.Text = string.Format("{0} s.", executionTimeSpan.TotalSeconds.ToString("##.##"));
      }
      else if (executionTimeSpan.TotalMilliseconds > 1)
      {
        sbTime.Text = string.Format("{0} ms.", executionTimeSpan.TotalMilliseconds.ToString("#"));
      }

      if (RegexProcessEnd != null)
      {
        RegexProcessEnd();
      }
    }

    private void SetLabelText(Label lbl, string text)
    {
      if (lbl.InvokeRequired)
      {
        lbl.Invoke(new Action<Label, string>(SetLabelText), lbl, text);
      }
      else
      {
        lbl.Text = text;
      }
    }

    private void SetColorTextBackColor(FastColoredTextBox fctb, Color clr)
    {
      if (fctb.InvokeRequired)
      {
        fctb.Invoke(new Action<FastColoredTextBox, Color>(SetColorTextBackColor), fctb, clr);
      }
      else
      {
        fctb.BackColor = clr;
      }
    }

    private void SetText(FastColoredTextBox fctb, string text)
    {
      if (fctb.InvokeRequired)
      {
        fctb.Invoke(new Action<FastColoredTextBox, string>(SetText), fctb, text);
      }
      else
      {
        fctb.Text = text;
      }
    }

    private void ColorizeMatches(int index, int start, int length, int colornumber)
    {
      if (fctbInput.InvokeRequired)
      {
        fctbInput.Invoke(new Action<int, int, int, int>(ColorizeMatches), index, start, length, colornumber);
      }
      else
      {
        Style clrStyle = default(Style);
        Range r = default(Range);

        clrStyle = _styleList[colornumber];

        fctbInput.BeginUpdate();

        r = fctbInput.GetRange(start, start + length);
        r.SetStyle(clrStyle);

        fctbInput.EndUpdate();
      }
    }

    private void ResetQueryText(FastColoredTextBox fctb)
    {
      if (fctb.InvokeRequired)
      {
        fctb.Invoke(new Action<FastColoredTextBox>(ResetQueryText), fctb);
      }
      else
      {
        fctb.ClearStyle(StyleIndex.All);
      }
    }

    private void ResetResults(DataGridView grd)
    {
      if (grd.InvokeRequired)
      {
        grd.Invoke(new Action<DataGridView>(ResetResults), grd);
      }
      else
      {
        _dtMatchesRes = null;
        grd.DataSource = null;
      }
    }

    private bool ShowIsMatch(Regex re, string text)
    {
      bool hasMatches = false;
      hasMatches = re.IsMatch(text);

      if (!hasMatches)
      {
        ResetResults(grdResult);
      }

      return hasMatches;
    }

    private RegexOptions GetRegExOptions()
    {
      RegexOptions optionsRegEx = RegexOptions.None;

      if (cbCompiled.Checked && cbCompiled.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.Compiled;
      }

      if (cbCultureInvariant.Checked && cbCultureInvariant.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.CultureInvariant;
      }

      if (cbECMAScript.Checked && cbECMAScript.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.ECMAScript;
      }

      if (cbExplicitCapture.Checked && cbExplicitCapture.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.ExplicitCapture;
      }

      if (cbIgnoreCase.Checked && cbIgnoreCase.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.IgnoreCase;
      }

      if (cbIgnoreWhiteSpace.Checked && cbIgnoreWhiteSpace.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.IgnorePatternWhitespace;
      }

      if (cbMultiline.Checked && cbMultiline.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.Multiline;
      }

      if (cbRightToLeft.Checked && cbRightToLeft.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.RightToLeft;
      }

      if (cbSingleLine.Checked && cbSingleLine.Enabled)
      {
        optionsRegEx = optionsRegEx | RegexOptions.Singleline;
      }

      return optionsRegEx;
    }

    private void GridAddSource(DataTable source)
    {
      if (grdResult.InvokeRequired)
      {
        grdResult.Invoke(new Action<DataTable>(GridAddSource), source);
      }
      else
      {
        grdResult.DataSource = source;
      }
    }

    private DataTable CreateTable()
    {
      DataTable dt = new DataTable("MatchResult");
      dt.Columns.Add("Match", Type.GetType("System.String"));
      dt.Columns.Add("Nr", Type.GetType("System.String"));
      dt.Columns.Add("Index", Type.GetType("System.String"));
      dt.Columns.Add("Length", Type.GetType("System.String"));
      dt.Columns.Add("Group", Type.GetType("System.String"));
      dt.Columns.Add("MatchedString", Type.GetType("System.String"));
      return dt;
    }

    private void OnRegexProcessStart()
    {

    }

    private void OnRegexProcessEnd()
    {
      Invoke(new Action<bool>(SetComponentState), true);
    }

    private void OnRegexProcessText(DateTime dt, string status)
    {
      sbStatus.Text = status;
    }

    private void cb_CheckChanged(object sender, EventArgs e)
    {
      RegexOptionsCheckBoxes();
    }

    private void RegexOptionsCheckBoxes()
    {
      if (cbCompiled.Checked || cbCultureInvariant.Checked || cbExplicitCapture.Checked || cbIgnoreWhiteSpace.Checked || cbRightToLeft.Checked || cbSingleLine.Checked)
      {
        cbECMAScript.Enabled = false;
      }
      else
      {
        cbECMAScript.Enabled = true;
      }

      cbCompiled.Enabled = !cbECMAScript.Checked;
      cbCultureInvariant.Enabled = !cbECMAScript.Checked;
      cbExplicitCapture.Enabled = !cbECMAScript.Checked;
      cbIgnoreWhiteSpace.Enabled = !cbECMAScript.Checked;
      cbRightToLeft.Enabled = !cbECMAScript.Checked;
      cbSingleLine.Enabled = !cbECMAScript.Checked;
    }

    private void txtPattern_KeyUp(object sender, KeyEventArgs e)
    {
      {
        if (!cbMatchImmediately.Checked)
        {
          return;
        }

        if (e.KeyCode == Keys.Alt || e.KeyCode == Keys.Control || e.KeyCode == Keys.ShiftKey)
        {
          return;
        }

        switch (e.KeyCode)
        {
          case Keys.Tab:
          case Keys.PageUp:
          case Keys.PageDown:
          case Keys.End:
          case Keys.Home:
          case Keys.Insert:
          case Keys.Up:
          case Keys.Down:
          case Keys.Left:
          case Keys.Right:
            return;
        }

        btnMatches.PerformClick();
        e.Handled = true;
      }
    }

    private string FormatStringForCS(string unformattedString)
    {
      unformattedString = unformattedString.Replace("\\", "\\\\");
      return unformattedString.Replace("\"", "\\\"");
    }

    private string FormatStringForVB(string unformattedString)
    {
      return unformattedString.Replace("\"", "\"\"");
    }

    private void mnuFileOpenTestFile_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog openFile = new OpenFileDialog())
      {
        openFile.Title = "Open Test File";
        openFile.Filter = "Text File (*.txt)|*.txt|CSV File (.csv)|*.csv|All Files (*.*)|*.*";
        openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        DialogResult result = openFile.ShowDialog(this);

        if (result == DialogResult.OK)
        {
          Encoding fileEncoding = General.GetEncoding(openFile.FileName);

          using (StreamReader testFileStream = new StreamReader(openFile.FileName, fileEncoding))
          {
            fctbInput.Text = testFileStream.ReadToEnd();
          }
        }
      }
    }

    private void mnuFileSaveResultsAs_Click(object sender, EventArgs e)
    {
      using (SaveFileDialog saveFile = new SaveFileDialog())
      {
        List<int> maxLengthCol;
        StringBuilder output;
        int maxLength = 0;
        string value = null;
        string Delimiter = null;
        bool bWriteFile = false;
        DialogResult result;

        saveFile.Title = "Save Results As";
        saveFile.DefaultExt = "txt";
        saveFile.Filter = "Text File (*.txt)|*.txt|CSV File (.csv)|*.csv|XML File (*.xml)|*.xml|All Files (*.*)|*.*";
        saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        result = saveFile.ShowDialog(this);

        output = new StringBuilder();
        Delimiter = string.Empty;
        bWriteFile = false;
        maxLengthCol = null;


        if (result == DialogResult.OK)
        {
          switch (saveFile.FilterIndex)
          {
            case 1:
              bWriteFile = true;
              Delimiter = string.Empty;
              break;
            case 3:
              if ((_dtMatchesRes != null))
              {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                using (XmlWriter writer = XmlWriter.Create(saveFile.FileName, settings))
                {
                  DataSet ds = new DataSet("Results");
                  ds.Tables.Add(_dtMatchesRes);

                  writer.WriteStartDocument();
                  writer.WriteStartElement("RegexResult");

                  writer.WriteStartElement("Pattern");
                  writer.WriteCData(txtPattern.Text);
                  writer.WriteEndElement();

                  ds.WriteXml(writer);

                  writer.WriteEndElement();
                  writer.WriteEndDocument();
                }
              }
              break;
            default:
              bWriteFile = true;
              Delimiter = ",";
              break;
          }

          if (bWriteFile)
          {
            using (StreamWriter resultFileStream = new StreamWriter(saveFile.FileName, false, Encoding.UTF8))
            {
              if (Delimiter == string.Empty)
              {
                resultFileStream.WriteLine("Pattern: " + txtPattern.Text);
                resultFileStream.WriteLine("Replace: " + txtReplace.Text);
                resultFileStream.WriteLine(string.Empty);

                maxLengthCol = Enumerable.Range(0, _dtMatchesRes.Columns.Count).Select(col => _dtMatchesRes.AsEnumerable().Select(row => row[col]).OfType<string>().Max(val => val.Length)).ToList();
              }

              if (_dtMatchesRes.Rows.Count > 0)
              {
                foreach (DataGridViewColumn col in grdResult.Columns)
                {
                  value = col.HeaderText;

                  if (Delimiter == string.Empty)
                  {
                    maxLength = maxLengthCol[col.Index];
                    if (value.Length > maxLength)
                    {
                      maxLength = value.Length;
                      maxLengthCol[col.Index] = maxLength;
                    }

                    output.Append(string.Format("{0,-" + maxLength + 5 + "}", value));
                  }
                  else
                  {
                    output.Append(value);
                    if (col.Index != grdResult.Columns.Count - 1)
                    {
                      output.Append(Delimiter);
                    }
                  }
                }

                foreach (DataGridViewRow row in grdResult.Rows)
                {
                  output.AppendLine();
                  foreach (DataGridViewCell cell in row.Cells)
                  {
                    value = cell.Value.ToString().Replace("\n", " ").Replace("\r", "");

                    if (Delimiter == string.Empty)
                    {
                      maxLength = maxLengthCol[cell.ColumnIndex];
                      output.Append(string.Format("{0,-" + maxLength + 5 + "}", value));
                    }
                    else
                    {
                      if (value.Contains(Delimiter))
                      {
                        output.Append(Convert.ToChar(34));
                      }
                      output.Append(value);
                      if (value.Contains(Delimiter))
                      {
                        output.Append(Convert.ToChar(34));
                      }
                      if (cell.ColumnIndex != grdResult.Columns.Count - 1)
                      {
                        output.Append(Delimiter);
                      }
                    }
                  }
                }

                resultFileStream.Write(output.ToString());
              }
            }
          }
        }
      }
    }

    private void mnuFileExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void mnuEditCopyWholeRegExAsC_Click(object sender, EventArgs e)
    {
      Clipboard.SetDataObject(Convert.ToString("\"") + FormatStringForCS(txtPattern.Text) + "\"", true);
    }

    private void mnuEditCopyWholeRegExAsVB_Click(object sender, EventArgs e)
    {
      Clipboard.SetDataObject(Convert.ToString("\"") + FormatStringForVB(txtPattern.Text) + "\"", true);
    }

    private void mnuEditZoomIn_Click(object sender, EventArgs e)
    {
      switch (ActiveControl.Name)
      {
        case "txtPattern":
          txtPattern.Font = new Font(txtPattern.Font.FontFamily, txtPattern.Font.Size + 1);
          break;
        case "txtReplace":
          txtReplace.Font = new Font(txtReplace.Font.FontFamily, txtReplace.Font.Size + 1);
          break;
        case "fctbInput":
          fctbInput.Font = new Font(fctbInput.Font.FontFamily, fctbInput.Font.Size + 1);
          break;
        case "fctbResult":
          fctbResult.Font = new Font(fctbResult.Font.FontFamily, fctbResult.Font.Size + 1);
          break;
      }
    }

    private void mnuEditZoomOut_Click(object sender, EventArgs e)
    {
      switch (ActiveControl.Name)
      {
        case "txtPattern":
          txtPattern.Font = new Font(txtPattern.Font.FontFamily, txtPattern.Font.Size - 1);
          break;
        case "txtReplace":
          txtReplace.Font = new Font(txtReplace.Font.FontFamily, txtReplace.Font.Size - 1);
          break;
        case "fctbInput":
          fctbInput.Font = new Font(fctbInput.Font.FontFamily, fctbInput.Font.Size - 1);
          break;
        case "fctbResult":
          fctbResult.Font = new Font(fctbResult.Font.FontFamily, fctbResult.Font.Size - 1);
          break;
      }
    }

    private void mnuHelpInfo_Click(object sender, EventArgs e)
    {
      Process.Start(Path.Combine(Application.StartupPath, "QuickReference.pdf"));
    }

    private void mnuHelpAbout_Click(object sender, EventArgs e)
    {
      using (frmAbout frm = new frmAbout())
      {
        frm.ShowDialog(this);
      }
    }

    private void fctb_GotFocus(object sender, EventArgs e)
    {
      _currentControl = sender as FastColoredTextBox;
    }

    private void txtPattern_TextChanged(object sender, TextChangedEventArgs e)
    {
      if (txtPattern.Text != string.Empty)
      {
        btnMatches.Enabled = true;
      }
      else
      {
        btnMatches.Enabled = false;
      }
    }

    private void txtReplace_TextChanged(object sender, TextChangedEventArgs e)
    {
      if (txtReplace.Text != string.Empty && txtPattern.Text != string.Empty)
      {
        btnReplace.Enabled = true;
      }
      else
      {
        btnReplace.Enabled = false;
      }
    }

    private void splitInputResult_SplitterMoved(object sender, SplitterEventArgs e)
    {
      if (splitInputResult.CanFocus)
      {
        _currentControl.Focus();
      }
    }

    private void chkInputWordWrap_CheckedChanged(object sender, EventArgs e)
    {
      fctbInput.WordWrap = chkInputWordWrap.Checked;
    }

    private void chkResultWordWrap_CheckedChanged(object sender, EventArgs e)
    {
      fctbResult.WordWrap = chkResultWordWrap.Checked;
    }
  }
}
