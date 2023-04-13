using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos
{



    public class Aluno
    {
        private string nome = "";
        private int idade = 0;
        private string curso= "";
        private string turma = "";

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        public string Curso
        {
            get => curso;
            set => curso = value;
        }

        public string Turma
        {
            get => turma;
            set => turma = value;
        }
    }




}
