﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelo;
using System.Data.SqlServerCe;

namespace CamadaDados
{
   public class ArmazemDAO
    {


       public Dictionary<Int32, Armazem > ListarTodos()
        {
            Dictionary<Int32, Armazem> mapaArmazem = new Dictionary<Int32, Armazem>();
            try
            {
                String SQL = "SELECT * FROM Armazem;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

              while (data.Read())
                {
               Armazem armazem = new Armazem();

                   armazem.id = data.GetInt32(0);
                  armazem.codigo = data.GetInt32(1);

                  armazem.nome = data.GetString(2);
                  armazem.valor = data.GetInt32(3);
                  armazem.categoria = data.GetString(4);
                  armazem.deposito = data.GetInt32(5);
                 armazem.quantidade = data.GetInt32(7);


                  mapaArmazem.Add(armazem.id, armazem);
               }



                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaArmazem;
        }

        public Armazem BuscarPorNome(Int32 _id)
        {
            Armazem o = null;
            try
            {
                String SQL = "SELECT * FROM Armazem;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    o = new Armazem();

                  o.id = data.GetInt32(0);
                  o.codigo = data.GetInt32(1);
                  o.nome = data.GetString(2);
                  o.valor = data.GetInt32(3);
                  o.categoria = data.GetString(4);
                  o.deposito = data.GetInt32(5);
                  o.quantidade = data.GetInt32(7);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return o;
        }
    }
}
    

