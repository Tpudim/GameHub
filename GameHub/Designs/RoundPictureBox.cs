using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GameHub.Extras
{
    public class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grpath);
            pe.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            base.OnPaint(pe);
        }
    }
}
