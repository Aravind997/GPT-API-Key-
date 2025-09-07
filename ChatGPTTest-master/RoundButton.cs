using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ChatGPTTest
{
    internal class RoundButton : Button
    {
        public RoundButton()
        {
            // Set default properties
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(80, 80); // Default size - you can change this
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);

            this.Region = new Region(graphicsPath);
            base.OnPaint(pevent);
        }

        // Optional: Ensure the button stays circular when resized
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Force the button to maintain a circular shape
            if (this.Width != this.Height)
            {
                this.Height = this.Width; // Makes it square
            }

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            this.Region = new Region(graphicsPath);
        }
    }
}