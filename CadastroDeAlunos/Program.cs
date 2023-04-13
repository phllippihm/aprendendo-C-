using CadastroDeAlunos;

public class Programa
{
    static void Main(string[] args)
    {
        Escola escola = new Escola();

        // cadastrar um aluno
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "João";
        aluno1.Idade = 20;
        aluno1.Curso = "Engenharia";
        aluno1.Turma = "A";
        escola.AdicionarAluno(aluno1);

        // cadastrar outro aluno
        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Maria";
        aluno2.Idade = 22;
        aluno2.Curso = "Direito";
        aluno2.Turma = "B";
        escola.AdicionarAluno(aluno2);

        // listar os alunos cadastrados
        List<Aluno> alunos = escola.ListarAlunos();
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Idade: " + aluno.Idade);
            Console.WriteLine("Curso: " + aluno.Curso);
            Console.WriteLine("Turma: " + aluno.Turma);
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
