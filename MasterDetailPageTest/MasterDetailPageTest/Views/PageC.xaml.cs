using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageC : ContentPage
    {
        public PageC()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            Xamarin.Forms.INavigation navigation = Navigation;
            System.Diagnostics.Debug.WriteLine($"{this.GetType().Name} - OnAppearing NAVIGATION STACK: {navigation.NavigationStack.Count}");
            foreach (var page in navigation.NavigationStack)
            {
                System.Diagnostics.Debug.WriteLine($"    : {page.GetType().Name}");
            }
        }

    }
}