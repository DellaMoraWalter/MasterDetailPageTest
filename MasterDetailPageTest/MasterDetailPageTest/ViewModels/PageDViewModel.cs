using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterDetailPageTest.ViewModels
{
    public class PageDViewModel : ViewModelBase
    {
        public PageDViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "PageD";
        }
    }
}
