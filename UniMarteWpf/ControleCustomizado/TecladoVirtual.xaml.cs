using System.Windows;
using System.Windows.Controls;

namespace UniMarteWpf.ControleCustomizado
{
    /// <summary>
    /// Interação lógica para TecladoVirtual.xam
    /// </summary>
    public partial class TecladoVirtual : UserControl
    {
        public event EventHandler<string> OnKeyPressed;

        public TecladoVirtual()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                string inputChar = btn.Tag.ToString();
                if (chkShift.IsChecked == true)
                {
                    inputChar = inputChar.ToUpper();
                    chkShift.IsChecked = false; // Desativa o Shift após a tecla ser pressionada.
                }
                else
                {
                    inputChar = inputChar.ToLower();
                }

                // Dispara o evento OnKeyPressed passando o caractere digitado
                OnKeyPressed?.Invoke(this, inputChar);
            }
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            OnKeyPressed?.Invoke(this, "BACKSPACE");
        }
    }
}
