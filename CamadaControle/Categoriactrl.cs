﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using CamadaModelo;


namespace CamadaControle
{
    public class Categoriactrl
    {

        public Object BD(char _c, Object _param)
        {
            try
            {
                CategoriaDAO dao = new CategoriaDAO();
                switch (_c)
                {
                    case 'i':
                //    return dao.InserirNoBD((Produto)_param);
                    case 'd':
                //    return dao.DeletarNoBD((Int16)_param);
                    case 'u':
                   // return dao.AlterarNoBD((Produto)_param);
                    case 't':
                        return dao.ListarTodos();
                    case 'o':
                        return dao.BuscarPorid((Int32)_param);
                    case 'f':
                        return dao.ListarCategoriaPorProduto((Int32)_param);
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
