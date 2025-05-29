using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace rejestracja
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            string email = emailEnrty.Text;
            string password = haslo.Text;
            string repairPassword = ponowne_haslo.Text;

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                wiadomosc.Text = "Nieprawidłowy adres email";
                return;

            }
            if (password != repairPassword)
            {
                wiadomosc.Text = "Hasła się różnią";
                return;
            }
            wiadomosc.Text = $"Witaj {email}";
        }

    }
}
