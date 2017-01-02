using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace RegexTester
{
  public partial class frmAbout : Form
  {
    public frmAbout()
    {
      InitializeComponent();
    }

    private void frmAbout_Load(object sender, EventArgs e)
    {
      General.ChangeFont(this);

      AssemblyCopyrightAttribute copyright = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0] as AssemblyCopyrightAttribute;

      lblName.Text = Application.ProductName + " v" + Application.ProductVersion;
      lblName.Font = new Font(lblName.Font.Name, lblName.Font.Size, FontStyle.Bold);
      lblCopyright.Text = copyright.Copyright;
      lblCopyright.Font = new Font(lblCopyright.Font.Name, 7);
    }
  }
}
