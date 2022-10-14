namespace exemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        //public List<aqui vem o tipo de retorno. O retorno "Pessoa" é de um tipo objeto, a classe Pessoa

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        //O tipo de retorno do método tem que bater o com tipo de retorno retornado
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count();
            return quantidade; //Aqui
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso: {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}