using Img_size_slider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Img_size_slider.ViewModel
{
    public class VieWModel : ViewModelBase
    {
        private PModel model;
        public string Size { get; private set; }
        public VieWModel(PModel model)
        {
            this.model = model;
            model.sizeChanged += Model_sizeChanged;
        }

        private void Model_sizeChanged(object sender, ImgSizeSliderEventArgs e)
        {
            Size = e.Size;
            OnPropertyChanged(nameof(Size));
        }

        public int Width {  get { return model.Width; } set { if(model.Width != value) { model.setWidth(value); OnPropertyChanged(nameof(Width)); } } }
        public int Height { get { return model.Height; } set { if(model.Height != value) { model.setHeight(value); OnPropertyChanged(nameof(Height)); } } }
    }
}
