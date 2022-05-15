using System.Windows;

namespace WPF_Beispiel
{
    /// <summary>
    /// Interaktionslogik für ShowAddressDataWindow.xaml
    /// </summary>
    public partial class ShowAddressDataWindow : Window
    {
        private AddressData _addressData;
        /// <summary>
        /// Creates an instance of ShowAddressDataWindow and fill the TextBlock controll with the given address data
        /// </summary>
        /// <param name="addressData">The address data to be shown</param>
        public ShowAddressDataWindow(AddressData addressData)
        {
            InitializeComponent();
            _addressData = addressData;
            this.AddressTextBlock.Text = _addressData.ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
