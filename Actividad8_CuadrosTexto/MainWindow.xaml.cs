
using System.Windows;
using System.Windows.Input;

namespace Actividad8_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textoAyudaNombreTextBlock.Visibility = Visibility.Hidden;
            textoAyudaApellidoTextBlock.Visibility = Visibility.Hidden;
            textoAyudaEdadTextBlock.Visibility = Visibility.Hidden;
        }

        private void nombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (textoAyudaNombreTextBlock.Visibility == Visibility.Hidden)
                    textoAyudaNombreTextBlock.Visibility = Visibility.Visible;
                else
                    textoAyudaNombreTextBlock.Visibility = Visibility.Hidden;
            }
        }

        private void apellidoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (textoAyudaApellidoTextBlock.Visibility == Visibility.Hidden)
                    textoAyudaApellidoTextBlock.Visibility = Visibility.Visible;
                else
                    textoAyudaApellidoTextBlock.Visibility = Visibility.Hidden;
            }
        }

        private void edadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            int valor = 0;
            if (e.Key == Key.F2)
            {
                if (!int.TryParse(textoAyudaEdadTextBlock.Text, out valor))
                    textoAyudaEdadTextBlock.Visibility = Visibility.Visible;
                else
                    textoAyudaEdadTextBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
