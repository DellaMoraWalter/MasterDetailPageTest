using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailPageTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region leftBarItems
        private ObservableCollection<LeftBarItem> _leftBarItems = null;
        public ObservableCollection<LeftBarItem> leftBarItems
        {
            get { return _leftBarItems; }
            set { SetProperty(ref _leftBarItems, value); }
        }
        #endregion



        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";


            if (Device.RuntimePlatform == Device.UWP)
            {
                leftBarItems = new ObservableCollection<LeftBarItem>()
                {
                    new LeftBarItem("PageA", "/MainPage/NavigationPage/PageA"),
                    new LeftBarItem("PageD", "/MainPage/NavigationPage/PageD")
                };
            }
            else
            {
                leftBarItems = new ObservableCollection<LeftBarItem>()
                {
                    new LeftBarItem("PageA", "MainPage/NavigationPage/PageA"),
                    new LeftBarItem("PageD", "MainPage/NavigationPage/PageD")
                };
            }



            GoToPageACmd = new DelegateCommand<LeftBarItem>(GoToPageACmd_Do);
            NavigateToPageCmd = new DelegateCommand<LeftBarItem>(NavigateToPageCmd_Do);
        }



        #region GoToPageACmd
        public DelegateCommand<LeftBarItem> GoToPageACmd { get; internal set; }

        private async void GoToPageACmd_Do(LeftBarItem leftBarItem)
        {
            await NavigationService.NavigateAsync(leftBarItem.destination);
        }
        #endregion



        #region NavigateToPageCmd
        public DelegateCommand<LeftBarItem> NavigateToPageCmd { get; internal set; }

        private async void NavigateToPageCmd_Do(LeftBarItem leftBarItem)
        {
            if (leftBarItem == null)
                return;

            var result = await NavigationService.NavigateAsync(leftBarItem.destination);
            if (!result.Success)
            {
            }
        }
        #endregion

    }
}
