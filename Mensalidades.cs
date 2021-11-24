using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Mensalidades
    {
        private string Id_Aluno;
        private float Valor;
        private string Mes;
        private bool Pago;

        public void setId_Aluno(string id_aluno)
        {
            this.Id_Aluno = id_aluno;
        }

        public void setValor(float valor)
        {
            this.Valor = valor;
        }

        public void setMes(string mes)
        {
            this.Mes = mes;
        }

        public void setPago(bool pago)
        {
            this.Pago = pago;
        }

        public string getId_Aluno()
        {
            return Id_Aluno;
        }

        public float getValor()
        {
            return Valor;
        }

        public string getMes()
        {
            return Mes;
        }

        public bool getPago()
        {
            return Pago;
        }
    }
}
