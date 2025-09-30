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

        public VieWModel(PModel model)
        {
            this.model = model;
        }

        public int Width {  get { return model.Width; } set { if(model.Width != value) { model.setWidth(value); OnPropertyChanged(nameof(Width)); } } }
        public int Height { get { return model.Height; } set { if(model.Height != value) { model.setHeight(value); OnPropertyChanged(nameof(Height)); } } }
    }
}
