using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08.Entities
{
    public class PresentFactory : Abstractions.IToyFactory
    {
        public Color PresentColor { get; set; }
        public Color RibbonColor { get; set; }
        public Abstractions.Toy CreateNew()
        {
            return new Present(PresentColor, RibbonColor);
        }
    }
}
