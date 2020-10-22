using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlServerCe;
using System.Data;

//C:\Program Files\Microsoft SQL server compact Edition\v4.0\Desktop//
// busca esse arquivo//

namespace CamadaDados
{
    public static class BD
    {
        static String strConexao =  @"Data Source=C:\Users\HP\Documents\Visual Studio 2012\Projects\SistemaMercado\MyDatadados#1.sdf;Password=nicholas;Persist Security Info=True";
        static SqlCeConnection conexao;

        public static void AbrirConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.ConnectionString = strConexao;
                        conexao.Open();
                    }
                }
                else
                {
                    conexao = new SqlCeConnection();
                    conexao.ConnectionString = strConexao;
                    conexao.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static SqlCeDataReader ExecutarSelect(string _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                SqlCeDataReader data = comando.ExecuteReader();

                return data;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }
        }

        public static int ExecutarIDU(string _SQL)
        {
            int linhasAfetadas = 0;
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                linhasAfetadas = comando.ExecuteNonQuery();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }
        }

        public static Object ExecutarInsertComRetornoID(String _SQL, List<SqlCeParameter> _parametros)
        {
            try
            {
                AbrirConexao();

                //Executar INSERT do registro no banco de dados
                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);
                comando.Parameters.AddRange(_parametros.ToArray());
                comando.ExecuteNonQuery();

                //Executar o SELECT e pegar o último ID inserido (Que é a chave primária da coluna)
                comando.CommandText = "SELECT @@IDENTITY";
                Object chavePrimaria = comando.ExecuteScalar();

                FecharConexao();

                return chavePrimaria;
            }
            catch (Exception ex)
            {
                FecharConexao();
                throw new Exception("ERRO AO EXECUTAR OPERAÇÃO DE INSERT COM RETORNO DE ID NO BD: " + ex.Message);
            }
        }
    }
}

