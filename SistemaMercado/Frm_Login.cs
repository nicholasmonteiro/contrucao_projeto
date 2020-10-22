using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaModelo;

namespace SistemaMercado
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            try
            {
                Gerente user = new Gerente();
                user.nome = txbPass.Text;
                user.senha = txbPass.Text;

                if (ValidarLogin(user))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Tag = user;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
          }

          private bool ValidarLogin(Gerente _user)
        {
            bool resultado;
            try
            {
                if (_user.nome.Equals("teste") && _user.senha.Equals("teste"))
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
        }

          private void btn_cancell_Click(object sender, EventArgs e)
          {
              this.Close();
          }


        }
    }


    

  // private void frmPrincipal_Load(object sender, EventArgs e)
        //{
       //     timer.Enabled = true;

        //    this.Hide();
         //   frmLogin form = new frmLogin();

        ///    if (form.ShowDialog() == DialogResult.OK)
       //     {
         //       Usuario user = (Usuario)form.Tag;
//
         //       lblUserLogado.Text = user.Nome;

        //        this.Show();
      //      }
        //    else
      //      {
       //         this.Close();
    //        }
   //     }