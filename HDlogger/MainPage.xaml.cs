using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HDlogger
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DataPackage datapackage = new DataPackage();
        public MainPage()
        {
            InitializeComponent();
        }

        
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(DescriptionField.Text);
            LogField.Text = "Name: " + NameField.Text + Environment.NewLine +
                            "Venue: " + VenueField.Text + Environment.NewLine +
                            "Number: " + NumberField.Text + Environment.NewLine +
                            "Description: " + DescriptionField.Text;
            datapackage.RequestedOperation = DataPackageOperation.Copy;
            datapackage.SetText(LogField.Text);
            Clipboard.SetContent(datapackage);

        }

        private void Field_Click(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
