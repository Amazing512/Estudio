using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Matricula
    {
        private string Id_aluno;
        private int Id_turma;
        private DateTime Data_entrada;
        private byte Status;
        private DateTime Data_encerramento;


        public Matricula()
        {

        }

        public Matricula(string Id_Aluno)
        {
            setId_aluno(Id_Aluno);
        }

        public Matricula(int Id_turma)
        {
            setId_turma(Id_turma);
        }

        public Matricula(int Id_turma, string Id_aluno)
        {
            setId_turma(Id_turma);
            setId_aluno(Id_aluno);
        }

        public Matricula(int Id_turma, string Id_Aluno, DateTime Data_entrada, byte Status)
        {
            setId_turma(Id_turma);
            setId_aluno(Id_Aluno);
            setData_entrada(Data_entrada);
            setStatus(Status);
        }


        public int getId_turma()
        {
            return this.Id_turma;
        }

        public void setId_turma(int id_turma)
        {
            this.Id_turma = id_turma;
        }

        public string getId_aluno()
        {
            return this.Id_aluno;
        }

        public void setId_aluno(string id_aluno)
        {
            this.Id_aluno = id_aluno;
        }

        public DateTime getData_entrada()
        {
            return this.Data_entrada;
        }

        public void setData_entrada(DateTime Data_entrada)
        {
            this.Data_entrada = Data_entrada;
        }

        public int getSatus()
        {
            return this.Status;
        }
  
        public void setStatus(byte Status)
        {
            this.Status = Status;
        }

        public DateTime getData_encerramento()
        {
            return this.Data_encerramento;
        }

        public void setData_encerramento(DateTime Data_encerramento)
        {
            this.Data_encerramento = Data_encerramento;
        }

        public void cadastroMatricula(){
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand(
                    $"INSERT INTO MatriculaEstudio (id_aluno, id_turma, data_entrada, status) VALUES (" +
                    $"'{ Id_aluno }'," +
                    $"{ Id_turma }," +
                    $"'{ Data_entrada.Date.ToString("s") }'," +
                    $" 1)",
                    DAO_Conexao.con
                 );

                insere.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }

        public List<Matricula> consultaMatriculas(){
            List<Matricula> matriculasArray = new List<Matricula>(); 
          
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM MatriculaEstudio WHERE id_aluno= '{Id_aluno}' AND status = 1", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();

                while (resultado.Read())
                {
                    Matricula matricula = new Matricula();
                    matricula.setId_aluno(resultado["id_aluno"].ToString());
                    matricula.setId_turma(Convert.ToInt32(resultado["id_turma"].ToString()));
                    matricula.setData_entrada(DateTime.Parse(resultado["data_entrada"].ToString()));
                    matricula.setStatus(1);

                    matriculasArray.Add(matricula);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return matriculasArray;
        }

        public bool excluirMatricula(){
            bool desativado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluirModalidade = new MySqlCommand($"UPDATE MatriculaEstudio SET status=0, data_encerramento = '{ DateTime.Now.Date.ToString("s") }' WHERE id_aluno = '{ Id_aluno }' AND id_turma = { Id_turma } AND status = 1", DAO_Conexao.con);
                int rowsAffected = excluirModalidade.ExecuteNonQuery();
               
                if (rowsAffected != 0)
                {
                    desativado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return desativado;

        }

    }
}
