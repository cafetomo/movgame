﻿using movgame.Wpf.Views;
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
    public class TitleViewModel : BindableBase
    {
        public IRegionManager regionManager { get; }

        public ReactiveCommand StartCommand { get; } = new ReactiveCommand();
        public ReactiveCommand ConfigCommand { get; } = new ReactiveCommand();

        public TitleViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            StartCommand.Subscribe(() => { this.regionManager.RequestNavigate("MainRegion", nameof(GameView)); });
            ConfigCommand.Subscribe(() => { this.regionManager.RequestNavigate("MainRegion", nameof(ConfigView)); });
        }
    }
}
