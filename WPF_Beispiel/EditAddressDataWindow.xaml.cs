using System.Windows;

namespace WPF_Beispiel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EditAddressDataWindow : Window
    {
        public EditAddressDataWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            AddressData addressData =
                new AddressData(FirstnameTextbox.Text, LastnameTextbox.Text, StreetTextbox.Text, CityTextbox.Text, CountryCombobox.Text, ZipcodeTextbox.Text);

            this.Hide();
            ShowAddressDataWindow dataWindow = new ShowAddressDataWindow(addressData);
            dataWindow.ShowDialog();
            this.Close();           
        }
    }
}
