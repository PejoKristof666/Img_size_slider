using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Img_size_slider.Model
{
    public class PModel
    {
        public PModel()
        {
            Width = 100;
            Height = 100;
        }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public event EventHandler<ImgSizeSliderEventArgs> sizeChanged;

        public void setWidth(int num)
        {
            if (num >= 10 && num <= 200)
            {
                Width = num;
                Sizecalculate();
            }
        }
        public void setHeight(int num)
        {
            if (num >= 10 && num <= 200)
            {
                Height = num;
                Sizecalculate();
            }
        }

        public void Sizecalculate()
        {
            switch (Width * Height)
            {
                case < 2500: sizeChanged.Invoke(this, new ImgSizeSliderEventArgs("small")); break;
                case < 10000: sizeChanged.Invoke(this, new ImgSizeSliderEventArgs("medium")); break;
                case <= 40000: sizeChanged.Invoke(this, new ImgSizeSliderEventArgs("large")); break;
                default: sizeChanged.Invoke(this, new ImgSizeSliderEventArgs("Invalid")); break;
            }
        }
    }
}
