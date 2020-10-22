namespace SistemaMercado
{
    partial class frm_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCodigoP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.text_valor = new System.Windows.Forms.TextBox();
            this.text_produto = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.groupdeposito = new System.Windows.Forms.GroupBox();
            this.rdbDeposito2 = new System.Windows.Forms.RadioButton();
            this.rdbDeposito1 = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupdeposito.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCodigoP
            // 
            this.labelCodigoP.AutoSize = true;
            this.labelCodigoP.Location = new System.Drawing.Point(24, 42);
            this.labelCodigoP.Name = "labelCodigoP";
            this.labelCodigoP.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoP.TabIndex = 0;
            this.labelCodigoP.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // text_codigo
            // 
            this.text_codigo.Location = new System.Drawing.Point(91, 39);
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(100, 20);
            this.text_codigo.TabIndex = 4;
            // 
            // text_valor
            // 
            this.text_valor.Location = new System.Drawing.Point(271, 42);
            this.text_valor.Name = "text_valor";
            this.text_valor.Size = new System.Drawing.Size(100, 20);
            this.text_valor.TabIndex = 6;
            // 
            // text_produto
            // 
            this.text_produto.Location = new System.Drawing.Point(103, 90);
            this.text_produto.Name = "text_produto";
            this.text_produto.Size = new System.Drawing.Size(100, 20);
            this.text_produto.TabIndex = 7;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "massa",
            "frios ",
            "biscoito"});
            this.cmbCategoria.Location = new System.Drawing.Point(281, 93);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(102, 21);
            this.cmbCategoria.TabIndex = 8;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(9, 157);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(217, 157);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(317, 157);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // groupdeposito
            // 
            this.groupdeposito.Controls.Add(this.rdbDeposito2);
            this.groupdeposito.Controls.Add(this.rdbDeposito1);
            this.groupdeposito.Location = new System.Drawing.Point(418, 42);
            this.groupdeposito.Name = "groupdeposito";
            this.groupdeposito.Size = new System.Drawing.Size(93, 78);
            this.groupdeposito.TabIndex = 15;
            this.groupdeposito.TabStop = false;
            this.groupdeposito.Text = "Depósito";
            // 
            // rdbDeposito2
            // 
            this.rdbDeposito2.AutoSize = true;
            this.rdbDeposito2.Location = new System.Drawing.Point(7, 53);
            this.rdbDeposito2.Name = "rdbDeposito2";
            this.rdbDeposito2.Size = new System.Drawing.Size(31, 17);
            this.rdbDeposito2.TabIndex = 1;
            this.rdbDeposito2.TabStop = true;
            this.rdbDeposito2.Text = "2";
            this.rdbDeposito2.UseVisualStyleBackColor = true;
            // 
            // rdbDeposito1
            // 
            this.rdbDeposito1.AutoSize = true;
            this.rdbDeposito1.Location = new System.Drawing.Point(7, 30);
            this.rdbDeposito1.Name = "rdbDeposito1";
            this.rdbDeposito1.Size = new System.Drawing.Size(31, 17);
            this.rdbDeposito1.TabIndex = 0;
            this.rdbDeposito1.TabStop = true;
            this.rdbDeposito1.Text = "1";
            this.rdbDeposito1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(116, 157);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 198);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupdeposito);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.text_produto);
            this.Controls.Add(this.text_valor);
            this.Controls.Add(this.text_codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCodigoP);
            this.Name = "frm_Produto";
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.frm_Produto_Load);
            this.groupdeposito.ResumeLayout(false);
            this.groupdeposito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.TextBox text_valor;
        private System.Windows.Forms.TextBox text_produto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnsair;
      
        private System.Windows.Forms.GroupBox groupdeposito;
      
        
        private System.Windows.Forms.RadioButton rdbDeposito2;
        private System.Windows.Forms.RadioButton rdbDeposito1;
        private System.Windows.Forms.Button btnSalvar;
    }
}