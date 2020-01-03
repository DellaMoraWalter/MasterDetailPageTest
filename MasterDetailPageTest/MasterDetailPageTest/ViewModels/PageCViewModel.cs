using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterDetailPageTest.ViewModels
{
    public class PageCViewModel : ViewModelBase
    {
        public PageCViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "PageC";

            GoToPageBCmd = new DelegateCommand(GoToPageBCmd_Do);
        }



        #region GoToPageBCmd
        public DelegateCommand GoToPageBCmd { get; internal set; }

        private async void GoToPageBCmd_Do()
        {
            await NavigationService.GoBackAsync();
        }
        #endregion
    }
}
