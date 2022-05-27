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

        public int Id { get;  set; }
        public string Nome { get;  set; }
        public String Descricao { get;  set; }
        public DateTime DataInicio { get;  set; }
        public DateTime? DataFim { get;  set; }  
        

    }
}
