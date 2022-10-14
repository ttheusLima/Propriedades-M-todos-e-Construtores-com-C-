using exemploExplorando.Models;

Pessoa p1 = new Pessoa("Thaís",20);
p1.Sobrenome = "Rodrigues";

Pessoa p2 = new Pessoa(nome: "Mariana",20);
p2.Sobrenome = "Rodrigues de Lima";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();