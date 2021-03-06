﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using CamadaModelo;

namespace CamadaControle
{
        public class Gerentectrl
      {

         public Object BD(char _c,Object _param)
         {
             try
             {

           GerenteDAO dao = new GerenteDAO();
                switch (_c)
                {
                    case 'i':
                   return dao.InserirNoBD((Gerente)_param);
                    case 'd':
                  return dao.DeletarNoBD((Int32)_param);
                    case 'u':
                    return dao.AlterarNoBD((Gerente)_param);
                    case 't':
                        return dao.ListarTodos();
                    case 'o':
                        return dao.BuscarPorcpf((Int32)_param);
                    case 'f':
                        return dao.ListarGerentePorDistribuidora((Int32)_param);
                    case 'n':
                        return dao.BuscarListaFiltrada((String)_param);

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