using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace RegexTester
{
  public static class General
  {
    public static string SettingsFile;
    public static string FontDefaultName;
    public static string FontDefaultSize;
    public static string FontInputName;
    public static string FontInputSize;
    public static string FontPatternName;
    public static string FontPatternSize;
    public static string FontReplaceName;
    public static string FontReplaceSize;
    public static Color SelectColor;
    public static Color ErrorColor;

    public static void ProgramSettings()
    {
      FontDefaultName = GetXmlSetting(SettingsFile, "/Configuration/Font/DefaultName");
      FontDefaultSize = GetXmlSetting(SettingsFile, "/Configuration/Font/DefaultSize");
      FontInputName = GetXmlSetting(SettingsFile, "/Configuration/Font/InputName");
      FontInputSize = GetXmlSetting(SettingsFile, "/Configuration/Font/InputSize");
      FontPatternName = GetXmlSetting(SettingsFile, "/Configuration/Font/PatternName");
      FontPatternSize = GetXmlSetting(SettingsFile, "/Configuration/Font/PatternSize");
      FontReplaceName = GetXmlSetting(SettingsFile, "/Configuration/Font/ReplaceName");
      FontReplaceSize = GetXmlSetting(SettingsFile, "/Configuration/Font/ReplaceSize");

      SelectColor = ConvertStringToColor(GetXmlSetting(SettingsFile, "/Configuration/Colors/SelectColor", ""));
      ErrorColor = ConvertStringToColor(GetXmlSetting(SettingsFile, "/Configuration/Colors/ErrorColor", ""));
    }

    public static void ChangeFontForm(Form frm)
    {
      try
      {
        frm.Font = new Font(FontDefaultName, Convert.ToSingle(FontDefaultSize));
        foreach (Control ctl in frm.Controls)
        {
          ChangeFont(ctl);
        }
      }
      catch (Exception ex)
      {
        //Do Nothing
      }
    }

    public static void ChangeFont(Control ctl)
    {
      ctl.Font = new Font(FontDefaultName, Convert.ToSingle(FontDefaultSize));
    }

    public static string GetXmlSetting(string file, string setting, string defaultValue = "?")
    {
      XPathDocument xDoc = new XPathDocument(file);
      XPathNavigator navigator = xDoc.CreateNavigator();
      XPathNodeIterator iterator = navigator.Select(setting);

      if (iterator.Count > 0)
      {
        return navigator.SelectSingleNode(setting).Value;
      }
      else
      {
        return defaultValue;
      }
    }

    public static void SetXmlSetting(string file, string setting, string name, string value)
    {
      XmlDocument xDoc = new XmlDocument();
      xDoc.Load(file);

      XmlNode keyNode = xDoc.SelectSingleNode(setting + "/" + name);
      if (keyNode != null)
      {
        keyNode.InnerText = value;
        xDoc.Save(file);
      }
      else
      {
        XmlNode parentNode = xDoc.SelectSingleNode("/" + setting);
        XmlNode newNode = xDoc.CreateElement(name);
        newNode.InnerText = value;
        parentNode.AppendChild(newNode);

        xDoc.Save(file);
      }
    }

    public static bool VerifyRegEx(string testPattern)
    {
      bool isValid = true;

      //^(?:(?:[^?+*{}()[\]\\|]+|\\.|\[(?:\^?\\.|\^[^\\]|[^\\^])(?:[^\]\\]+|\\.)*\]|\((?:\?[:=!]|\?<[=!]|\?>|\?<[^\W\d]\w*>|\?'[^\W\d]\w*')?(?<N>)|\)(?<-N>))(?:(?:[?+*]|\{\d+(?:,\d*)?\})[?+]?)?|\|)*$(?(N)(?!))

      if (testPattern != null && testPattern.Trim().Length > 0)
      {
        try
        {
          Regex.Match("", testPattern);
        }
        catch (ArgumentException aex)
        {
          // BAD PATTERN: Syntax error
          isValid = false;
        }
      }
      else
      {
        //BAD PATTERN: Pattern is null or blank
        isValid = false;
      }
      return isValid;
    }

    public static Encoding GetEncoding(string filename)
    {
      // Read the BOM
      dynamic bom = new byte[4];
      using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
      {
        file.Read(bom, 0, 4);
      }

      // Analyze the BOM
      if (bom(0) == 0x2b && bom(1) == 0x2f && bom(2) == 0x76)
      {
        return Encoding.UTF7;
      }
      if (bom(0) == 0xef && bom(1) == 0xbb && bom(2) == 0xbf)
      {
        return Encoding.UTF8;
      }
      if (bom(0) == 0xff && bom(1) == 0xfe)
      {
        return Encoding.Unicode;
      }
      //UTF-16LE
      if (bom(0) == 0xfe && bom(1) == 0xff)
      {
        return Encoding.BigEndianUnicode;
      }
      //UTF-16BE
      if (bom(0) == 0 && bom(1) == 0 && bom(2) == 0xfe && bom(3) == 0xff)
      {
        return Encoding.UTF32;
      }
      return Encoding.Default;
    }

    public static Color ConvertStringToColor(string stringColor)
    {
      int argb = 0;
      Color clr = default(Color);
      if (string.IsNullOrEmpty(stringColor))
      {
        clr = Color.Transparent;
      }
      else
      {
        if (stringColor.StartsWith("#"))
        {
          clr = ColorTranslator.FromHtml(stringColor);
        }
        else
        {
          argb = Int32.Parse(stringColor, System.Globalization.NumberStyles.HexNumber);
          clr = Color.FromArgb(argb);
        }
      }
      return clr;
    }
  }
}
