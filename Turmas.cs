using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turmas
    {
        private int Id_turma;
        private int Id_modalidade;
        private string Professor;
        private string Dia_semana;
        private string Hora;
        private bool ativo;

        public Turmas()
        { 
        
        }

        public Turmas(int Id_turma)
        {
            setId_turma(Id_turma);
        }

        public Turmas(int Id_modalidade, string Professor, string Dia_semana, string Hora)
        {
            setId_modalidade(Id_modalidade);
            setProfessor(Professor);
            setDia_semana(Dia_semana);
            setHora(Hora);
        }

        public int getId_turma()
        {
            return this.Id_turma;
        }
        public int getId_modalidade()
        {
            return this.Id_modalidade;
        }

        public string getProfessor()
        {
            return this.Professor;
        }
        public string getDia_semana()
        {
            return this.Dia_semana;
        }
        public string getHora()
        {
            return this.Hora;
        }

        public bool getAtivo()
        {
            return this.ativo;
        }

        public void setId_turma(int id_turma)
        {
            this.Id_turma = id_turma;
        }
        public void setId_modalidade(int id_modalidade)
        {
            this.Id_modalidade = id_modalidade;
        }
        public void setProfessor(string professor)
        {
            this.Professor = professor;
        }
        public void setDia_semana(string dia_semana)
        {
            this.Dia_semana = dia_semana;
        }
        public void setHora(string hora)
        {
            this.Hora = hora;
        }

        public void setAtivo(bool ativo)
        {
            this.ativo = ativo;
        }

        public bool cadastrarTurma()
        {
            bool cadastrou = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand(
                    $"INSERT INTO Turmas (id_modalidade, professor,  dia_semana, hora, ativo) VALUES (" +
                    $"{ Id_modalidade }," +
                    $"'{ Professor }'," +
                    $"'{ Dia_semana }'," +
                    $"'{ Hora }'," +
                    $" 1);",
                    DAO_Conexao.con
                 );
                insere.ExecuteNonQuery();
                cadastrou = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cadastrou;
        }

        public static List<Turmas> buscaTurmas(int id_modalidade)
        {
            List<Turmas> turmasArray = new List<Turmas>(); 
          
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM Turmas WHERE id_modalidade={id_modalidade} AND ativo = 1");
                MySqlDataReader resultado = consulta.ExecuteReader();

                while (resultado.Read())
                {
                    Turmas turma = new Turmas();
                    turma.setId_turma(Convert.ToInt32(resultado["id_turma"]));
                    turma.setId_modalidade(Convert.ToInt32(resultado["id_modalidade"].ToString()));
                    turma.setProfessor(resultado["professor"].ToString());
                    turma.setDia_semana(resultado["dia_semana"].ToString());
                    turma.setHora(resultado["hora"].ToString());
                    turma.setAtivo(Boolean.Parse(resultado["ativo"].ToString()));

                    turmasArray.Add(turma);
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
            return turmasArray;
        }


        public bool excluirTurma()
        {
            bool desativado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluir = new MySqlCommand($"UPDATE Turmas SET ativo=0 where id_turma = { Id_turma }", DAO_Conexao.con);
                excluir.ExecuteNonQuery();
                desativado = true;
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

        public bool alterarTurma(int id_turma, int id_modalidade, string professor, string dia_semana, string hora)
        {
            bool alterado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand alterar = new MySqlCommand(
                    $"UPDATE Turmas SET" +
                    $"id_modalidade = { id_modalidade }," +
                    $"professor = '{ professor }'," +
                    $"dia_semana = '{ dia_semana }'," +
                    $"hora = '{ hora }'" +
                    $"where id_turma = '{ id_turma }'", DAO_Conexao.con
                );
                alterar.ExecuteNonQuery();
                alterado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return alterado;
        }
    }
}
