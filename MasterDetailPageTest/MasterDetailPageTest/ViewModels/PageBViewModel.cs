using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterDetailPageTest.ViewModels
{
    public class PageBViewModel : ViewModelBase
    {
        public PageBViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "PageB";

            GoToPageACmd = new DelegateCommand(GoToPageACmd_Do);
            GoToPageCCmd = new DelegateCommand(GoToPageCCmd_Do);
        }



        #region GoToPageACmd
        public DelegateCommand GoToPageACmd { get; internal set; }

        private async void GoToPageACmd_Do()
        {
            await NavigationService.GoBackAsync();
        }
        #endregion


        #region GoToPageCCmd
        public DelegateCommand GoToPageCCmd { get; internal set; }

        private async void GoToPageCCmd_Do()
        {
            await NavigationService.NavigateAsync("PageC");
        }
        #endregion

    }
}
