using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08.Entities
{
    public class Present : Abstractions.Toy
    {
        public SolidBrush PresentColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color color1, Color color2)
        {
            PresentColor = new SolidBrush(color1);
            RibbonColor = new SolidBrush(color2);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, Width / 2, 0, Width / 5, Height);
            g.FillRectangle(RibbonColor, 0, Height / 2, Width, Height / 5);
        }
    }
}
