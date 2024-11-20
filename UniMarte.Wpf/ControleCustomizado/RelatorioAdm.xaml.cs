using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.Wpf;
using System.Windows.Controls;
using UniMarte.Wpf.DataAccess;

namespace UniMarte.Wpf.ControleCustomizado
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
            try
            {
                // Configuração inicial do modelo
                LineModel = new PlotModel { Title = "Avaliação Diária" };

                // Obtém as avaliações agrupadas por setor
                var setores = relatorioAdmDAO.ObterAvaliacoesPorSetorUltimos7Dias();

                if (setores == null || !setores.Any())
                {
                    Console.WriteLine("Não há dados para o gráfico de linhas.");
                    return;
                }

                // Lista das datas dos últimos 7 dias (do mais antigo para o mais recente)
                var datas = Enumerable.Range(0, 7)
                                    .Select(i => DateTime.Today.AddDays(-6 + i))
                                    .OrderBy(d => d)
                                    .ToList();

                // Define cores específicas para cada setor
                var cores = new Dictionary<string, OxyColor>
        {
            { "Arquitetura", OxyColor.FromRgb(255, 0, 0) },     // Vermelho para Arquitetura
            { "Atendimento dos Funcionários", OxyColor.FromRgb(0, 255, 0) },        // Verde para Atendimento
            { "Ambiente e Limpeza", OxyColor.FromRgb(255, 255, 0) },         // Amarelo para Ambiente
            { "Qualidade de Obras", OxyColor.FromRgb(255, 165, 0) }            // Laranja para Obras
        };

                // Cria as séries para cada setor
                foreach (var setor in setores)
                {
                    var lineSeries = new LineSeries
                    {
                        Title = setor.Key,
                        Color = cores[setor.Key],
                        StrokeThickness = 2,
                        MarkerType = MarkerType.Circle,
                        MarkerSize = 4,
                        MarkerStroke = cores[setor.Key],
                        MarkerFill = cores[setor.Key],
                        InterpolationAlgorithm = null
                    };

                    // Garantir que há pelo menos um ponto válido antes de adicionar a série
                    bool temPontoValido = false;

                    // Adiciona os pontos às séries
                    foreach (var data in datas)
                    {
                        var item = setor.Value.FirstOrDefault(x => x.Data.Date == data.Date);

                        // Se encontrou um valor para esta data
                        if (!item.Equals(default((DateTime, double))))
                        {
                            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(data), item.Nota));
                            temPontoValido = true;
                        }
                        else
                        {
                            // Adiciona um ponto nulo para manter a continuidade
                            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(data), double.NaN));
                        }
                    }

                    // Só adiciona a série se tiver pelo menos um ponto válido
                    if (temPontoValido)
                    {
                        LineModel.Series.Add(lineSeries);
                    }
                }

                // Configura os eixos
                LineModel.Axes.Clear(); // Limpa os eixos existentes

                var dateAxis = new DateTimeAxis
                {
                    Position = AxisPosition.Bottom,
                    Title = "Data",
                    StringFormat = "dd/MM",
                    MinorIntervalType = DateTimeIntervalType.Days,
                    IntervalType = DateTimeIntervalType.Days,
                    Minimum = DateTimeAxis.ToDouble(datas.First()),
                    Maximum = DateTimeAxis.ToDouble(datas.Last()),
                    MajorStep = 1,
                    MinorStep = 1
                };

                var valueAxis = new LinearAxis
                {
                    Position = AxisPosition.Left,
                    Title = "Avaliação",
                    Minimum = 0,
                    Maximum = 5,
                    MajorStep = 1,
                    MinorStep = 0.5,
                    StringFormat = "0.0"
                };

                LineModel.Axes.Add(dateAxis);
                LineModel.Axes.Add(valueAxis);

                // Atualiza o modelo
                plotViewAvaliacoes.Model = LineModel;
                plotViewAvaliacoes.InvalidatePlot(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao configurar gráfico: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }

    }
}
