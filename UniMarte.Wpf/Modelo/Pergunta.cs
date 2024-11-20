namespace UniMarte.Wpf.Modelo
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string TipoResposta { get; set; } // Ex: "SimNao", "Estrelas", "EscolhaObra"
    }
}
