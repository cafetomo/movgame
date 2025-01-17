﻿using movgame.Wpf.Models;
using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movgame.Wpf.ViewModels
{
    public class ConfigViewModel : BindableBase
    {
        public ReadOnlyReactiveCollection<ConfigModel> Models { get; }
        public IRegionManager regionManager { get; }

        public ConfigViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

        }
    }
}
