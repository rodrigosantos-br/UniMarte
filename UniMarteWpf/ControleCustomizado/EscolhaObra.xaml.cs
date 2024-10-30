using System.Windows.Controls;
using UniMarteWpf.Modelo;

namespace UniMarteWpf.ControleCustomizado
{
    /// <summary>
    /// Interação lógica para EscolhaObra.xam
    /// </summary>
    public partial class EscolhaObra : UserControl, IResposta
    {
        public string RespostaSelecionada { get; private set; }

        public EscolhaObra()
        {
            InitializeComponent();
            // Exemplo de obras (você deve preencher isso com suas obras do banco de dados)
            comboObras.Items.Add("Nenhuma");
            comboObras.Items.Add("Obra 1");
            comboObras.Items.Add("Obra 2");
            comboObras.Items.Add("Obra 3");
            comboObras.Items.Add("Obra 4");
            comboObras.Items.Add("Obra 5");
            comboObras.Items.Add("Obra 6");
            comboObras.Items.Add("Obra 7");
            comboObras.Items.Add("Obra 8");
            comboObras.Items.Add("Obra 9");
            comboObras.Items.Add("Obra 10");
            comboObras.Items.Add("Obra 11");
            comboObras.Items.Add("Obra 12");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RespostaSelecionada = comboObras.SelectedItem?.ToString(); // Captura a resposta
        }

        public List<Resposta> ObterResposta()
        {
            return new List<Resposta> { new Resposta { RespostaTexto = RespostaSelecionada } };
        }
    }
}

