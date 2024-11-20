using System.Windows;
using System.Windows.Controls;

namespace UniMarteWpf.Utils
{
    internal class TecladoUtils
    {
        public static void ProcessarTeclaPressionada(string key, Control activeControl, Window cadastroWindow)
        {
            // Verifica se o controle ativo é um TextBox
            if (activeControl is TextBox textBox)
            {
                if (!string.IsNullOrEmpty(key) && key.Length == 1)
                {
                    // Adiciona o caractere ao texto do TextBox
                    int caretIndex = textBox.CaretIndex;
                    textBox.Text = textBox.Text.Insert(caretIndex, key);
                    textBox.CaretIndex = caretIndex + 1; // Move o cursor para o próximo caractere
                }
                else if (key == "BACKSPACE")
                {
                    if (textBox.Text.Length > 0 && textBox.CaretIndex > 0)
                    {
                        int caretIndex = textBox.CaretIndex;
                        textBox.Text = textBox.Text.Remove(caretIndex - 1, 1);
                        textBox.CaretIndex = caretIndex - 1; // Move o cursor para trás
                    }
                }
                // Verifica se o texto é "entraradm"
                if (textBox.Text == "entraradm")
                {
                    // Encontra o botão na janela de Cadastro
                    Button adminButton = (Button)cadastroWindow.FindName("btnAdm    ");

                    if (adminButton != null)
                    {
                        // Exibe o botão para entrar no modo administrativo
                        adminButton.Visibility = Visibility.Visible;
                    }

                    return; // Interrompe a execução para não avançar de tela
                }
            }
            // Verifica se o controle ativo é um PasswordBox
            else if (activeControl is PasswordBox passwordBox)
            {
                if (!string.IsNullOrEmpty(key) && key.Length == 1)
                {
                    // Adiciona o caractere à senha
                    passwordBox.Password += key;
                }
                else if (key == "BACKSPACE")
                {
                    if (passwordBox.Password.Length > 0)
                    {
                        passwordBox.Password = passwordBox.Password.Substring(0, passwordBox.Password.Length - 1);
                    }
                }
            }
            // Foco e comportamento finalizado
            activeControl.Focus();
        }
    }
}
