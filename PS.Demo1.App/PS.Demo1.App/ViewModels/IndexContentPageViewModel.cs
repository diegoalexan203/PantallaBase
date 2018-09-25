using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PS.Demo1.App.ViewModels
{
	public class IndexContentPageViewModel : ViewModelBase
    {
        public IndexContentPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
	}
}
