using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fila_Unica_BQ.Resources;

namespace Fila_Unica_BQ.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutHeader : ContentView
    {
        public FlyoutHeader()
        {
            InitializeComponent();

            lbl_titulo.Text = AppResources.AppName;
            lbl_email.Text = AppResources.Email_Contato;
        }
    }
}