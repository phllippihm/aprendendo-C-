using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos
{
    public class Escola
    {
        private List<Aluno> alunos = new List<Aluno>();

        public void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public List<Aluno> ListarAlunos()
        {
            return alunos;
        }
    }

}
