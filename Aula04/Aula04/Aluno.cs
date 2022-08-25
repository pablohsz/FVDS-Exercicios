using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    internal class Aluno
    {
        private string nome;
        private int matricula;
        private double nota;

        public Aluno()
        {
            nome = "";
            matricula = 0;
            nota = 0.0;
        }
        public Aluno(string nome, int matricula, double nota)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.nota = nota;
        }


    }
}
