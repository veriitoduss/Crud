using crud.ViewsModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace crud.Infraestructure
{
    class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
