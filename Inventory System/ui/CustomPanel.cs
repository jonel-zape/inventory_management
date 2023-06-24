using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Inventory_System.ui
{
    class CustomPanel : Panel
    {
        private int borderSize = 1;
        private int borderRadius = 20;
        private Color borderColor = Color.LightBlue;

        [Category("Custom Panel")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Panel")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Custom Panel")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Panel")]
        public Color BackgroundColor
        {
            get
            {
                return this.BackColor;
            }

            set
            {
                this.BackColor = value;
            }
        }

        [Category("Custom Panel")]
        public Color TextColor
        {
            get
            {
                return this.ForeColor;
            }

            set
            {
                this.ForeColor = value;
            }
        }

        public CustomPanel()
        {            
            this.Size = new Size(300, 300);
            this.BackColor = Color.LightBlue;
            this.ForeColor = Color.Black;
        }

        private GraphicsPath getFigurePath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectangleSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectangleBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            using (GraphicsPath pathSurface = this.getFigurePath(rectangleSurface, BorderRadius))
            using (GraphicsPath pathBorder = this.getFigurePath(rectangleBorder, BorderRadius - 1F))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
            using (Pen penBorder = new Pen(this.BorderColor, BorderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);
                pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(this.backgroundColorChanged);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }

        private void backgroundColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
