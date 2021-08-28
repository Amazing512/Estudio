using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class DAO_Conexao
    {
        public static MySqlConnection con;

        public static void getConexao(String local, String banco, String user, String senha)
        {
            //Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";User ID=" + user + ";database=" + banco + ";password=" + senha + ";SslMode=none");
                //con.Open();
                //retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           /* finally
            {
               //con.Close();
            }
            return retorno;*/
        }

        public static int login(String usuario, String senha)
        {
            int tipo = 0; //0 quando não encontra
            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("Select * from Estudio_Login where usuario ='" + usuario + "' and senha ='" + senha + "'", con);
                MySqlDataReader resultado = login.ExecuteReader();
                if (resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }

        /*public static Aluno consultaAluno(String cpf)
        {
            Aluno aluno = new Aluno();
            try
            {
                con.Open();
                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM AlunoEstudio WHERE cpf='{cpf}'");
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    aluno.setCPF(resultado["cpf"].ToString());
                    aluno.setNome(resultado["nome"].ToString());
                    aluno.setRua(resultado["rua"].ToString());
                    aluno.setNumero(resultado["numero"].ToString());
                    aluno.setBairro(resultado["bairro"].ToString());
                    aluno.setComplemento(resultado["complemento"].ToString());
                    aluno.setCEP(int.Parse(resultado["cep"].ToString()));
                    aluno.setCidade(resultado["cidade"].ToString());
                    aluno.setEstado(resultado["estado"].ToString());
                    aluno.setTelefone(int.Parse(resultado["telefone"].ToString()));
                    aluno.setEmail(resultado["email"].ToString());
                    aluno.setAtivo(Boolean.Parse(resultado["ativo"].ToString()));

                    aluno.setFoto(Encoding.ASCII.GetBytes(resultado["foto"].ToString()));
                }
                else
                {
                    throw new Exception("Aluno não existe!");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return aluno;
        }
        */

        public static bool consultaAluno(String cpf)
        {
            bool existe = false;
            try
            {
                con.Open();
                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM AlunoEstudio WHERE cpf='{cpf}'",con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
                else
                {
                    throw new Exception("Aluno não existe!");
                }
            }
            catch (Exception ex)
            {
                throw ex; // a exceção é manipulada no Form onde o consultaAluno é chamado
            }
            finally
            {
                con.Close();
            }
            return existe;
        }

        public static bool excluirAluno(String cpf)
        {
            bool desativado = false;
            try
            {
                con.Open();
                MySqlCommand excluir = new MySqlCommand($"UPDATE AlunoEstudio SET ativo=0 where cpf = '{cpf}'", con);
                excluir.ExecuteNonQuery();
                desativado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return desativado;
        }

        /*public static bool alterarAluno(Aluno al)
        {
            bool desativado = false;
            try
            {
                con.Open();
                MySqlCommand alterar = new MySqlCommand($"UPDATE AlunoEstudio SET" +
                                                        $"nome = '{al.getNome()}'" +
                                                        $"rua = '{al.getRua()}'" +
                                                        $"numero = '{al.getNumero()}'" +
                                                        $"bairro = '{al.getBairro()}'" +
                                                        $"complemento = '{al.getComplemento()}'" +
                                                        $"cep = {al.getCEP()}" +
                                                        $"cidade = '{al.getCidade()}'" +
                                                        $"estado = '{al.getEstado()}'" +
                                                        $"telefone = {al.getTelefone()}" +
                                                        $"email = '{al.getEmail()}'" +
                                                        $"foto = {al.getFoto()}" +
                                                        $"ativo = {al.getAtivo()}" +
                                                        $"where cpf = '{al.getCPF()}'", con);

                alterar.Parameters.AddWithValue("foto", al.ConverterFotoParaByteArray());
                alterar.ExecuteNonQuery();
                desativado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return desativado;
        }
        */

        public static bool alterarAluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, int cep, string cidade, string estado, int telefone, string email, byte[] foto)
        {
            bool desativado = false;
            try
            {
                con.Open();
                MySqlCommand alterar = new MySqlCommand(
                    $"UPDATE AlunoEstudio SET"       +
                    $"nome = '{nome}'"               +
                    $"rua = '{rua}'"                 +
                    $"numero = '{numero}'"           +
                    $"bairro = '{bairro}'"           +
                    $"complemento = '{complemento}'" +
                    $"cep = {cep}"                   +
                    $"cidade = '{cidade}'"           +
                    $"estado = '{estado}'"           +
                    $"telefone = {telefone}"         +
                    $"email = '{email}'"             +
                    $"foto = {foto}"                 +
                    $"where cpf = '{cpf}'", con
                );

                alterar.ExecuteNonQuery();
                desativado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return desativado;
        }
    }
}
