using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        private byte[] Foto;
        private bool Ativo;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email, byte[] foto)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl19118", "cl19118", "192103"); 
            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setFoto(foto);
        }

        public Aluno()
        {

        }

        public Aluno(string cpf)
        {
            setCPF(cpf);
        }

      
        public void setCPF(string CPF)
        {
            this.CPF = CPF; 
        }

        public string getCPF()
        {
            return this.CPF;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setRua(string Rua)
        {
            this.Rua = Rua;
        }

        public string getRua()
        {
            return this.Rua;
        }

        public void setNumero(string Numero)
        {
            this.Numero = Numero;
        }

        public string getNumero()
        {
            return this.Numero;
        }

        public void setBairro(string Bairro)
        {
            this.Bairro = Bairro;
        }

        public string getBairro()
        {
            return this.Bairro;
        }

        public void setComplemento(string Complemento)
        {
            this.Complemento = Complemento;
        }

        public string getComplemento()
        {
            return this.Complemento;
        }

        public void setCEP(string CEP)
        {
            this.CEP = CEP;
        }

        public string getCEP()
        {
            return this.CEP;
        }

        public void setCidade(string Cidade)
        {
            this.Cidade = Cidade;
        }

        public string getCidade()
        {
            return this.Cidade;
        }

        public void setEstado(string Estado)
        {
            this.Estado = Estado;
        }

        public string getEstado()
        {
            return this.Estado;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public void setFoto(byte[] Foto)
        {
            this.Foto = Foto;
        }

        public byte[] getFoto()
        {
            return this.Foto;
        }

        public void setAtivo(bool ativo)
        {
            this.Ativo = ativo;
        }

        public bool getAtivo()
        {
            return this.Ativo;
        }

        public bool cadastrarAluno()
        {
            bool cadastrou = false;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand(
                    $"INSERT INTO AlunoEstudio (cpf, nome, rua,  numero, bairro, complemento, cep, " +
                    $"cidade, estado, telefone, email, foto) VALUES (" +
                    $"'{ CPF }'," +
                    $"'{ Nome }'," +
                    $"'{Rua}'," +
                    $"'{Numero}'," +
                    $"'{Bairro}'," +
                    $"'{Complemento}'," +
                    $"'{CEP}'," +
                    $"'{Cidade}'," +
                    $"'{Estado}'," +
                    $"'{Telefone}'," +
                    $"'{Email}'," +
                    "@foto)" , DAO_Conexao.con
                 );
                insere.Parameters.AddWithValue("foto", this.Foto);
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

        public bool consultaAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM AlunoEstudio WHERE cpf='{CPF}'", DAO_Conexao.con);
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
                DAO_Conexao.con.Close();
            }
            return existe;
        }

        public static Aluno buscaAluno(String cpf)
        {
            Aluno aluno = new Aluno();
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand($"SELECT * FROM AlunoEstudio WHERE cpf='{cpf}' AND ativo=1",DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    aluno.setCPF(resultado["cpf"].ToString());
                    aluno.setNome(resultado["nome"].ToString());
                    aluno.setRua(resultado["rua"].ToString());
                    aluno.setNumero(resultado["numero"].ToString());
                    aluno.setBairro(resultado["bairro"].ToString());
                    aluno.setComplemento(resultado["complemento"].ToString());
                    aluno.setCEP(resultado["cep"].ToString());
                    aluno.setCidade(resultado["cidade"].ToString());
                    aluno.setEstado(resultado["estado"].ToString());
                    aluno.setTelefone(resultado["telefone"].ToString());
                    aluno.setEmail(resultado["email"].ToString());
                    if (resultado["ativo"].ToString().Equals("1")) aluno.setAtivo(true);
                    else aluno.setAtivo(false);

                    aluno.setFoto((Byte[]) resultado["foto"]);
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
                DAO_Conexao.con.Close();
            }
            return aluno;
        }
       

        public bool excluirAluno()
        {
            bool desativado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluir = new MySqlCommand($"UPDATE AlunoEstudio SET ativo=0 where cpf = '{CPF}' AND ativo=1", DAO_Conexao.con);
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

        public bool alterarAluno()
        {
            bool alterado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand alterar = new MySqlCommand(
                    $"UPDATE AlunoEstudio SET " +
                    $"nome = '{Nome}'," +
                    $"rua = '{Rua}'," +
                    $"numero = '{Numero}'," +
                    $"bairro = '{Bairro}'," +
                    $"complemento = '{Complemento}'," +
                    $"cep = '{CEP}'," +
                    $"cidade = '{Cidade}'," +
                    $"estado = '{Estado}'," +
                    $"telefone = '{Telefone}'," +
                    $"email = '{Email}'," +
                    $"foto = @foto" +
                    $" where cpf = '{CPF}'", DAO_Conexao.con
                );

                alterar.Parameters.AddWithValue("foto", this.Foto);
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
