﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RegexTester
{
  public partial class SplitContainerEx : SplitContainer
  {

    /// <summary>Determines the thickness of the splitter.</summary>
    [DefaultValue(typeof(int), "5"), Description("Determines the thickness of the splitter.")]
    public new virtual int SplitterWidth
    {
      get { return base.SplitterWidth; }
      set
      {
        if (value < 5)
          value = 5;

        base.SplitterWidth = value;
      }
    }

    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
      base.OnPaint(e);
      //paint the three dots
      Point[] points = new Point[3];
      //Rectangle pointRect = Rectangle.Empty;

      //calculate the position of the points
      if (Orientation == Orientation.Horizontal)
      {
        points[0] = new Point((base.Width / 2), SplitterDistance + (SplitterWidth / 2));
        points[1] = new Point(points[0].X - 10, points[0].Y);
        points[2] = new Point(points[2].X + 10, points[0].Y);
        //pointRect = new Rectangle(points[1].X - 2, points[1].Y - 2, 25, 5);
      }
      else
      {
        points[0] = new Point(SplitterDistance + (SplitterWidth / 2), (base.Height / 2));
        points[1] = new Point(points[0].X, points[0].Y - 10);
        points[2] = new Point(points[0].X, points[0].Y + 10);
        //pointRect = new Rectangle(points[1].X - 2, points[1].Y - 2, 5, 25);
      }

      //e.Graphics.FillRectangle(Brushes.Gray, pointRect)

      foreach (Point pLoopVariable in points)
      {
        pLoopVariable.Offset(-2, -1);
        e.Graphics.FillEllipse(Brushes.Black, new Rectangle(pLoopVariable, new Size(3, 3)));
      }
    }
  }
}
