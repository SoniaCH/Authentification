using Authentification.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Authentification
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login", "OK");

            InitializeComponent();

           
        }
	}
}
