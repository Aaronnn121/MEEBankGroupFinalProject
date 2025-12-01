using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// ✅ Rounded Panel (for the black card)
public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 25;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var rect = new Rectangle(0, 0, Width, Height);
        var path = new GraphicsPath();

        int r = BorderRadius;
        path.AddArc(0, 0, r, r, 180, 90);
        path.AddArc(rect.Width - r, 0, r, r, 270, 90);
        path.AddArc(rect.Width - r, rect.Height - r, r, r, 0, 90);
        path.AddArc(0, rect.Height - r, r, r, 90, 90);
        path.CloseFigure();

        Region = new Region(path);
    }
}

// ✅ Rounded TextBox (Material style)
public class RoundedTextBox : TextBox
{
    public int BorderRadius { get; set; } = 20;

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        var path = new GraphicsPath();
        int r = BorderRadius;

        path.AddArc(0, 0, r, r, 180, 90);
        path.AddArc(Width - r, 0, r, r, 270, 90);
        path.AddArc(Width - r, Height - r, r, r, 0, 90);
        path.AddArc(0, Height - r, r, r, 90, 90);
        path.CloseFigure();

        Region = new Region(path);
    }
}
