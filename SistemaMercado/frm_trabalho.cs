using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SistemaMercado
{
    public partial class frm_trabalho : Form
    {
        public frm_trabalho()
        {
            InitializeComponent();
        }

        private void btn_Word_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {

            Process.Start("excel");
        }

        private void btn_Paint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");

        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach ( var process in Process.GetProcessesByName(comboBox1.Text))
            {
                process.Kill();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_trabalho_Load(object sender, EventArgs e)
        {

        }


    }
}
