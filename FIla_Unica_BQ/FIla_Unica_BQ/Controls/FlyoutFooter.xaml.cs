using Fila_Unica_BQ.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fila_Unica_BQ.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutFooter : ContentView
    {
        public FlyoutFooter()
        {
            InitializeComponent();

            lbl_Desenvolvedor.Text = AppResources.Desenvolvedor;
        }
    }
}