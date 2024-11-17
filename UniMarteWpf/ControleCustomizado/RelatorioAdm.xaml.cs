using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Wpf;
using System.Windows.Controls;
using UniMarteWpf.DataAccess;

namespace UniMarteWpf.ControleCustomizado
{
    public partial class RelatorioAdm : UserControl
    {
        public readonly RelatorioAdmDAO relatorioAdmDAO;
        public PlotModel PieModel { get; set; }
        public PlotModel BarModel { get; set; }
        public PlotModel LineModel { get; set; }

        public RelatorioAdm()
        {
            InitializeComponent();
            relatorioAdmDAO = new RelatorioAdmDAO();
            CarregarDados();
        }

        private void CarregarDados()
        {
            txbTotalVisitantes.Text = relatorioAdmDAO.ObterTotalVisitantes().ToString();
            txbQuestionariosRespondidos.Text = relatorioAdmDAO.ObterQuestionariosRespondidos().ToString();
            txbMediaGeral.Text = relatorioAdmDAO.ObterMediaAvaliacao().ToString();
            ConfigurarGraficoPizza();
            ConfigurarGraficoBarras();
            ConfigurarGraficoLinhas();
        }

        private void ConfigurarGraficoPizza()
        {
            // Configurando o gráfico de pizza
            var porcentagens = relatorioAdmDAO.ObterPorcentagemRespostasSimNao();
            PieModel = new PlotModel {};

            var pieSeries = new PieSeries
            {
                StrokeThickness = 1,
                InsideLabelPosition = 2,
                Stroke = OxyColors.Black,
                AngleSpan = 360,
                StartAngle = 0
            };

            // Adicionando os dados ao gráfico
            pieSeries.Slices.Add(new PieSlice("Satisfeitos", porcentagens.PorcentagemSim) { Fill = OxyColors.Green });
            pieSeries.Slices.Add(new PieSlice("Insatisfeitos", porcentagens.PorcentagemNao) { Fill = OxyColors.Red });

            PieModel.Series.Add(pieSeries);

            // Atribuir a model ao PlotView
            // Certifique-se de que o nome do PlotView corresponde ao que você tem no XAML
            var plotView = this.FindName("plotViewPie") as PlotView;
            if (plotView != null)
            {
                plotView.Model = PieModel;
            }
        }


        private void ConfigurarGraficoBarras()
        {
            // Título do modelo de gráfico
            var barModel = new PlotModel { Title = "Votos por Obra" };

            // Configuração da série de barras
            var barSeries = new BarSeries
            {
                Title = "Número de Votos",
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1,
                FillColor = OxyColors.BlueViolet
            };

            // Obtenha os resultados da votação
            var resultados = relatorioAdmDAO.ObterQuantidadeVotosPorObra();

            // Adicione os resultados à série de barras
            foreach (var resultado in resultados)
            {
                barSeries.Items.Add(new BarItem { Value = resultado.TotalSelecionado });
            }

            barModel.Series.Add(barSeries);

            // Configuração do eixo das categorias (nomes das obras)
            barModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "ObrasAxis",
                Title = "Obras",
                ItemsSource = resultados.Select(r => r.Resposta).ToList() // Usa as respostas obtidas
            });

            // Configuração do eixo de valores (quantidade de votos)
            barModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Quantidade de Votos",
                MinimumPadding = 0.1,
                AbsoluteMinimum = 0,
                MajorStep = 10,
            });

            // Atribui o modelo ao PlotView
            oxyGraficoBarras.Model = barModel;
        }


        private void ConfigurarGraficoLinhas()
        {
            // Configuração inicial do modelo
            LineModel = new PlotModel { Title = "Avaliação Diária" };

            // Obter avaliações agrupadas por pergunta
            var setores = relatorioAdmDAO.ObterAvaliacoesPorPerguntaUltimos7Dias();

            // Depuração: exibir as avaliações retornadas para verificar os dados
            foreach (var setor in setores)
            {
                Console.WriteLine($"Setor: {setor.Key}");
                foreach (var (data, nota) in setor.Value)
                {
                    Console.WriteLine($"Data: {data}, Nota: {nota}");
                }
            }

            // Criar a lista das datas dos últimos 7 dias
            var datas = Enumerable.Range(0, 7)
                                  .Select(i => DateTime.Today.AddDays(-i))
                                  .ToList();

            // Criação das séries para cada setor
            foreach (var setor in setores)
            {
                var lineSeries = new LineSeries
                {
                    Title = setor.Key,
                    StrokeThickness = 2,
                    MarkerType = MarkerType.Circle,
                    InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
                };

                // Mapeando as médias às datas
                foreach (var data in datas)
                {
                    // Tenta encontrar o valor calculado no dicionário para a data atual
                    var media = setor.Value.FirstOrDefault(x => x.Data.Date == data.Date).Nota;

                    if (media > 0) // Apenas adiciona se a média for maior que 0
                    {
                        lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(data), media));
                    }
                    else
                    {
                        lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(data), double.NaN)); // Usa NaN para não exibir o ponto
                    }
                }

                LineModel.Series.Add(lineSeries);
            }

            // Configuração dos eixos
            LineModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Data",
                Minimum = DateTimeAxis.ToDouble(DateTime.Today.AddDays(-6)), // Exibir de -6 dias até hoje
                Maximum = DateTimeAxis.ToDouble(DateTime.Today),
                MajorStep = 1,
                StringFormat = "dd/MM" // Formato da data
            });

            LineModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Avaliação",
                Minimum = 0,
                Maximum = 5, // Exibir notas de 0 a 5
                MajorStep = 1,
                MinorStep = 0.5
            });

            // Atribui o modelo ao PlotView
            plotViewAvaliacoes.Model = LineModel;
        }
    }
}
