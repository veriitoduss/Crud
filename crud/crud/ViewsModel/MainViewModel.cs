using System;
using System.Collections.Generic;
using System.Text;

namespace crud.ViewsModel
{
    class MainViewModel
    {
        public inicioViewModel inicial { get; set; }
        public agregarViewModel agregar { get; set; }
        public MainViewModel()
        {
            this.inicial = new inicioViewModel();
        }
    }
}
