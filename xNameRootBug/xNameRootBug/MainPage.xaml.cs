using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xNameRootBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            collection.ItemsSource = new List<string>
            {
                string.Empty
            };
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine($"Clicked called from {this.GetType()}");
        }
    }
}
