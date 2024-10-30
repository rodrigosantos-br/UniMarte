using System;
using System.Windows;

namespace UniMarteWpf.Apresentacao
{
    public partial class PopupSatisfacao : Window
    {
        public event Action? PopupFechado;

        public PopupSatisfacao()
        {
            InitializeComponent();
        }

        private void btnNao_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSim_Click(object sender, RoutedEventArgs e)
        {
            Satisfacao satisfacao = new Satisfacao();
            satisfacao.ShowDialog();
            PopupFechado?.Invoke(); // Dispara o evento
            this.Close();
        }
    }
}
