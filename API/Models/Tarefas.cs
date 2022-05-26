namespace API.Models
{
    public class Tarefas
    {
        public Tarefas(string nome, string descricao, DateTime dataInicio, DateTime? dataFim)
        {
            Nome = nome.ToUpper();
            Descricao = descricao.ToUpper();
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public String Descricao { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }  
        

    }
}
