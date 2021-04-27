using Syncfusion.SfPicker.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerLocalization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
            PickerResourceManager.Manager = new ResourceManager("PickerLocalization.Resources.Syncfusion.SfPicker.XForms", Application.Current.GetType().Assembly);
         
            picker.ItemsSource = new string[]
            {
                "Red",
                "Yellow",
                "Black",
                "Brown",
                "White",
                "Skyblue",
                "Orange",
                "Blue",
                "Green",
                "Pink"
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            picker.IsOpen = true;
        }

    }
}
