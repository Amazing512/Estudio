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
        private int CEP;
        private string Cidade;
        private string Estado;
        private int Telefone;
        private string Email;
        private byte[] Foto;
        private bool Ativo;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, int cep, string cidade, string estado, int telefone, string email, byte[] foto)
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
            this.CPF = cpf;
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

        public void setCEP(int CEP)
        {
            this.CEP = CEP;
        }

        public int getCEP()
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

        public void setTelefone(int Telefone)
        {
            this.Telefone = Telefone;
        }

        public int getTelefone()
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
                MySqlCommand alterar = new MySqlCommand(
                    $"INSERT INTO AlunoEstudio (cpf, nome, rua,  numero, bairro, complemento, cep, " +
                    $"cidade, estado, telefone, email, foto) VALUES (" +
                    $"'{ CPF }'" +
                    $"'{Rua}'" +
                    $"'{Numero}'" +
                    $"'{Bairro}'" +
                    $"'{Complemento}'" +
                    $"{CEP}" +
                    $"'{Cidade}'" +
                    $"'{Estado}'" +
                    $"{Telefone}" +
                    $"'{Email}'" +
                    $"{Foto}" , DAO_Conexao.con
                );

                alterar.ExecuteNonQuery();
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

        #region buscaAluno
        /*public static Aluno buscaAluno(String cpf)
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
        #endregion

        public bool excluirAluno()
        {
            bool desativado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluir = new MySqlCommand($"UPDATE AlunoEstudio SET ativo=0 where cpf = '{CPF}'", DAO_Conexao.con);
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

        public bool alterarAluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, int cep, string cidade, string estado, int telefone, string email, byte[] foto)
        {
            bool alterado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand alterar = new MySqlCommand(
                    $"UPDATE AlunoEstudio SET" +
                    $"nome = '{nome}'" +
                    $"rua = '{rua}'" +
                    $"numero = '{numero}'" +
                    $"bairro = '{bairro}'" +
                    $"complemento = '{complemento}'" +
                    $"cep = {cep}" +
                    $"cidade = '{cidade}'" +
                    $"estado = '{estado}'" +
                    $"telefone = {telefone}" +
                    $"email = '{email}'" +
                    $"foto = {foto}" +
                    $"where cpf = '{cpf}'", DAO_Conexao.con
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
