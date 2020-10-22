using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelo;
using CamadaDados;
using System.Data;

namespace CamadaControle
{
    public class Distribuidoractrl
    {

        public Object BD(char _c,Object _param)
        
        {
            try
            {
                DistribuidoraDAO dao = new DistribuidoraDAO();
                switch (_c)
                {
                    case 'i':
                        return dao.InserirNoBD((Distribuidora)_param);
                    case 'd':
                        return dao.DeletarNoBD((Int32)_param);
                    case 'u':
                        return dao.AlterarNoBD((Distribuidora)_param);
                    case 't':
                        return dao.listarTodos();

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
