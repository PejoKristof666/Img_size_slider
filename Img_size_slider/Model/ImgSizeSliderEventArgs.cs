using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Img_size_slider.Model
{
    public class ImgSizeSliderEventArgs : EventArgs
    {
        public string Size { get; private set; }
        public ImgSizeSliderEventArgs(string Size) 
        {
            this.Size = Size;
        }     
    }
}
