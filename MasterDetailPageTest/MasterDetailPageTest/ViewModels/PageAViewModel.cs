using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterDetailPageTest.ViewModels
{
    public class PageAViewModel : ViewModelBase
    {
        public PageAViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "PageA";

            GoToMainPageCmd = new DelegateCommand(GoToMainPageCmd_Do);
            GoToPageBCmd = new DelegateCommand(GoToPageBCmd_Do);
        }



        #region GoToMainPageCmd
        public DelegateCommand GoToMainPageCmd { get; internal set; }

        private async void GoToMainPageCmd_Do()
        {
            await NavigationService.GoBackAsync();
        }
        #endregion


        #region GoToPageBCmd
        public DelegateCommand GoToPageBCmd { get; internal set; }

        private async void GoToPageBCmd_Do()
        {
            await NavigationService.NavigateAsync("PageB");
        }
        #endregion
    }
}
