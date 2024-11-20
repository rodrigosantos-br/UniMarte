namespace UniMarte.Wpf.Modelo
{
    public class Visitante
    {
        public Visitante(string nome, DateTime dataNascimento, DateTime dataHoraCadastro)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            DataHoraCadastro = dataHoraCadastro;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataHoraCadastro { get; set; }
    }
}
