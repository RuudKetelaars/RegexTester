namespace RegexTester
{
  partial class frmAbout
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblCopyright = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblCopyright
      // 
      this.lblCopyright.Location = new System.Drawing.Point(12, 164);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new System.Drawing.Size(354, 15);
      this.lblCopyright.TabIndex = 5;
      this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      // 
      // lblName
      // 
      this.lblName.Location = new System.Drawing.Point(12, 8);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(354, 15);
      this.lblName.TabIndex = 4;
      this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // frmAbout
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(378, 186);
      this.Controls.Add(this.lblCopyright);
      this.Controls.Add(this.lblName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmAbout";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About";
      this.Load += new System.EventHandler(this.frmAbout_Load);
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Label lblCopyright;
    internal System.Windows.Forms.Label lblName;
  }
}