using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Mensalidade
    {
        private string Id_Aluno;
        private double Valor;
        private string Mes;
        private bool Pago;

        public Mensalidade(string id_Aluno)
        {
            setId_Aluno(id_Aluno);
        }

        public Mensalidade(string id_Aluno, string mes)
        {
            setId_Aluno(id_Aluno);
            setMes(mes);
        }

        public void setId_Aluno(string id_aluno)
        {
            this.Id_Aluno = id_aluno;
        }

        public void setValor(double valor)
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

        public double getValor()
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

        public bool Gerar_Mensalidade()
        {
            bool gerado = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand pegaValorMensalidade = new MySqlCommand($"SELECT sum(modal.preco) AS preco FROM MatriculaEstudio matr INNER JOIN Turmas ON(Turmas.id_turma = matr.id_turma) INNER JOIN Modalidades modal ON(Turmas.id_modalidade = modal.id_modalidade) WHERE id_aluno = '{Id_Aluno}' AND matr.status = 1 group by matr.id_aluno", DAO_Conexao.con);
                MySqlDataReader resultado = pegaValorMensalidade.ExecuteReader();
                if (resultado.Read())
                {
                    setValor(Convert.ToDouble(resultado["preco"].ToString()));
                    if(getValor() == 0) return false;
                }
                else
                {
                    return false;
                }
                DAO_Conexao.con.Close();
                DAO_Conexao.con.Open();

                MySqlCommand existeMensalidade = new MySqlCommand($"SELECT mes FROM Mensalidade where id_aluno ='{Id_Aluno}' && mes = '{Mes}'", DAO_Conexao.con);
                resultado = existeMensalidade.ExecuteReader();

                if (resultado.Read())
                {
                    DAO_Conexao.con.Close();
                    DAO_Conexao.con.Open();
                    MySqlCommand atualizaMes = new MySqlCommand($"UPDATE Mensalidade SET valor = {Valor}, pago = 0 where id_aluno ='{Id_Aluno}'", DAO_Conexao.con);
                    atualizaMes.ExecuteNonQuery();
                }
                else
                {
                    DAO_Conexao.con.Close();
                    DAO_Conexao.con.Open();
                    MySqlCommand insereMensalidade = new MySqlCommand($"INSERT INTO Mensalidade (id_aluno, valor, mes, pago) VALUES ('{Id_Aluno}', {Valor}, '{Mes}', 0)", DAO_Conexao.con);
                    insereMensalidade.ExecuteNonQuery();
                }
                gerado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return gerado;


        }

        public List<Mensalidade> Exibir_Mensalidades()
        {
            List<Mensalidade> mensalidadesList = new List<Mensalidade>();

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM Mensalidade where id_aluno ='{Id_Aluno}' ORDER BY pago", DAO_Conexao.con);

                MySqlDataReader resultado = consulta.ExecuteReader();

                while (resultado.Read())
                {
                    Mensalidade mensalidade = new Mensalidade(resultado["id_aluno"].ToString());
                    mensalidade.setMes(resultado["mes"].ToString());
                    mensalidade.setValor(Convert.ToDouble(resultado["valor"].ToString()));
                    mensalidade.setPago(Convert.ToInt32(resultado["pago"].ToString()) == 1 ? true : false);

                    mensalidadesList.Add(mensalidade);
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
            return mensalidadesList;
        }

        public bool Efetuar_Pagamento()
        {
            bool efetuado = false;


            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand pagarMensalidade = new MySqlCommand($"UPDATE Mensalidade SET pago = 1 where id_aluno ='{Id_Aluno}' && mes = '{Mes}'", DAO_Conexao.con);

                pagarMensalidade.ExecuteNonQuery();

                efetuado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return efetuado;
        }
    }
}
