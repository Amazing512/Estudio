﻿using MySql.Data.MySqlClient;
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
            setCPF(CPF);
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

        public bool verificaCPF(string CPF)
        {
            int soma, resto, cont = 0;
            soma = 0;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            for (int i = 0; i < CPF.Length; i++)
            {
                int a = CPF[0] - '0';
                int b = CPF[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (11 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(9, 1))) return false;

            soma = 0;

            for (int i = 1; i <= 10; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (12 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(10, 1))) return false;

            return true;
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
                throw ex;
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
        

        public bool excluirAluno()
        {
            bool desativado = DAO_Conexao.excluirAluno(this.CPF);

            #region Código DAO_Conexao.excluirAluno
            /*
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
             */
            #endregion

            return desativado;
        }

        public bool alterarAluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, int cep, string cidade, string estado, int telefone, string email, byte[] foto)
        {
            bool alterado = DAO_Conexao.alterarAluno(cpf, nome, rua, numero, bairro, complemento, cep, cidade, estado, telefone, email, foto);

            #region Código DAO_Conexao.alterarAluno
            /*
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
             */
            #endregion
            return alterado;
        }

    }
    }
