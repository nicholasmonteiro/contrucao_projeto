﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;

namespace CamadaControle
{
  public  class Armazenctrl
    {
        public Object BD(char _c, Object _param)
        {

             try
            {
                ArmazemDAO dao = new ArmazemDAO();
                switch (_c)
                {
                    case 'i':
              //      return dao.InserirNoBD((produto)_param);
                    case 'd':
                    //return dao.DeletarNoBD((Int64)_param);
                    case 'u':
                    //return dao.AlterarNoBD((Produto)_param);
                    case 't':
                        return dao.ListarTodos();
                    case 'o':
                        return dao.BuscarPorNome((Int32)_param);
                    //case 'f':
                  //  return dao.BuscarListaFiltrada((String)_param);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
