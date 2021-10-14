using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidades
    {
        
        private int Id_Modalidade;
        private string Descricao;
        private double Preco;
        private int Qtde_aulas;
        private int Qtde_alunos;
        private bool Ativo;

        public Modalidades()
        {

        }

        public Modalidades(string descricao, double preco, int aulas, int alunos)
        {
            setDescricao(descricao);
            setPreco(preco);
            setQtde_aulas(aulas);
            setQtde_alunos(alunos);
        }

        public Modalidades(int id_Modalidade, string descricao, double preco, int aulas, int alunos)
        {
            setId_Modalidade(id_Modalidade);
            setDescricao(descricao);
            setPreco(preco);
            setQtde_aulas(aulas);
            setQtde_alunos(alunos);
        }

        public Modalidades(int id_Modalidade)
        {
            setId_Modalidade(id_Modalidade);
        }

        public int getId_Modalidade()
        {
            return this.Id_Modalidade;
        }

        public void setId_Modalidade(int id_Modalidade)
        {
            this.Id_Modalidade = id_Modalidade;
        }

        public string getDescricao()
        {
            return this.Descricao;
        }
        public void setDescricao(string descricao)
        {
            this.Descricao = descricao;
        }

        public double getPreco()
        {
            return this.Preco;
        }
        public void setPreco(double preco)
        {
            this.Preco = preco;
        }

        public int getQtde_aulas()
        {
            return this.Qtde_aulas;
        }
        public void setQtde_aulas(int aulas)
        {
            this.Qtde_aulas = aulas;
        }

        public int getQtde_alunos()
        {
            return this.Qtde_alunos;
        }
        public void setQtde_alunos(int alunos)
        {
            this.Qtde_alunos = alunos;
        }

        public bool cadastrarModalidade()
        {
            bool cadastrou = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand(
                    $"INSERT INTO Modalidades (descricao, preco, qtde_aulas,  qtde_alunos, ativo) VALUES (" +
                    $"'{ Descricao }'," +
                    $"{ Preco }," +
                    $"{ Qtde_aulas }," +
                    $"{ Qtde_alunos }, 1)",
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

        public static List<Modalidades> buscaModalidades()
        {

            List<Modalidades> arrayModalidades = new List<Modalidades>();
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM Modalidades WHERE ativo = 1 ORDER BY descricao ASC" , DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader(); 
                while (resultado.Read())
                {
                    Modalidades modalidades = new Modalidades();
                    modalidades.setId_Modalidade(Convert.ToInt32(resultado["id_modalidade"]));
                    modalidades.setDescricao(resultado["descricao"].ToString());
                    modalidades.setPreco(Convert.ToInt32(resultado["preco"]));
                    modalidades.setQtde_alunos(Convert.ToInt32(resultado["qtde_alunos"]));
                    modalidades.setQtde_aulas(Convert.ToInt32(resultado["qtde_aulas"]));
                    arrayModalidades.Add(modalidades);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return arrayModalidades;
        }

        public static Modalidades buscaModalidade(int id_modalidade)
        {
            Modalidades modalidade = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM Modalidades WHERE id_modalidade = {id_modalidade} AND ativo = 1  ", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    modalidade = new Modalidades();
                    modalidade.setId_Modalidade(Convert.ToInt32(resultado["id_modalidade"]));
                    modalidade.setDescricao(resultado["descricao"].ToString());
                    modalidade.setPreco(Convert.ToInt32(resultado["preco"]));
                    modalidade.setQtde_alunos(Convert.ToInt32(resultado["qtde_alunos"]));
                    modalidade.setQtde_aulas(Convert.ToInt32(resultado["qtde_aulas"]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return modalidade;
        }

        public bool excluirModalidade()
        {
            bool desativado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluirModalidade = new MySqlCommand($"UPDATE Modalidades SET ativo=0 where id_modalidade = { Id_Modalidade } AND ativo = 1", DAO_Conexao.con);
                int rowsAffected = excluirModalidade.ExecuteNonQuery();
               
                if (rowsAffected != 0)
                {
                    desativado = true;
                    MySqlCommand excluirTurmas = new MySqlCommand($"UPDATE Turmas SET ativo=0 where id_modalidade = { Id_Modalidade }", DAO_Conexao.con);
                    excluirTurmas.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return desativado;
        }

        public bool alterarModalidade()
        {
            bool alterado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand alterar = new MySqlCommand(
                    $"UPDATE Modalidades SET " +
                    $"descricao = '{ Descricao }', " +
                    $"preco = { Preco }, " +
                    $"qtde_alunos = { Qtde_alunos }, " +
                    $"qtde_aulas = { Qtde_aulas } " +
                    $"WHERE id_modalidade = { Id_Modalidade };", DAO_Conexao.con
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
