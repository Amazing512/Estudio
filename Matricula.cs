using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Matricula
    {
        private int Id_turma;
        private int Id_aluno;

        public Matricula()
        {

        }

        public Matricula(int Id_turma, int Id_Aluno)
        {
            setId_turma(Id_turma);
            setId_aluno(Id_Aluno);
        }

        public int getId_turma()
        {
            return this.Id_turma;
        }

        public void setId_turma(int id_turma)
        {
            this.Id_turma = id_turma;
        }

        public int getId_aluno()
        {
            return this.Id_aluno;
        }

        public void setId_aluno(int id_aluno)
        {
            this.Id_aluno = id_aluno;
        }
    }
}
