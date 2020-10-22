namespace SistemaMercado
{
    partial class Frm_Distribuidora
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_cnpj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCodigoP = new System.Windows.Forms.Label();
            this.text_cidade = new System.Windows.Forms.TextBox();
            this.text_valor = new System.Windows.Forms.TextBox();
            this.text_estado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(135, 160);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(362, 157);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 27;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(251, 157);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(15, 157);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 25;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(341, 19);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(121, 20);
            this.text_nome.TabIndex = 22;
            // 
            // text_cnpj
            // 
            this.text_cnpj.Location = new System.Drawing.Point(54, 16);
            this.text_cnpj.Name = "text_cnpj";
            this.text_cnpj.Size = new System.Drawing.Size(100, 20);
            this.text_cnpj.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome Da Distribuidora";
            // 
            // labelCodigoP
            // 
            this.labelCodigoP.AutoSize = true;
            this.labelCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoP.Location = new System.Drawing.Point(12, 19);
            this.labelCodigoP.Name = "labelCodigoP";
            this.labelCodigoP.Size = new System.Drawing.Size(35, 16);
            this.labelCodigoP.TabIndex = 17;
            this.labelCodigoP.Text = "Cnpj";
            // 
            // text_cidade
            // 
            this.text_cidade.Location = new System.Drawing.Point(362, 69);
            this.text_cidade.Name = "text_cidade";
            this.text_cidade.Size = new System.Drawing.Size(100, 20);
            this.text_cidade.TabIndex = 30;
            // 
            // text_valor
            // 
            this.text_valor.Location = new System.Drawing.Point(148, 66);
            this.text_valor.Name = "text_valor";
            this.text_valor.Size = new System.Drawing.Size(100, 20);
            this.text_valor.TabIndex = 31;
            // 
            // text_estado
            // 
            this.text_estado.Location = new System.Drawing.Point(69, 111);
            this.text_estado.Name = "text_estado";
            this.text_estado.Size = new System.Drawing.Size(94, 20);
            this.text_estado.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Valor Da mercadoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cidade Origem:";
            // 
            // Frm_Distribuidora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 195);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_estado);
            this.Controls.Add(this.text_valor);
            this.Controls.Add(this.text_cidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.text_cnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCodigoP);
            this.Name = "Frm_Distribuidora";
            this.Text = "Cadastrar Distribuidora";
            this.Load += new System.EventHandler(this.Frm_Distribuidora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_cnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCodigoP;
        private System.Windows.Forms.TextBox text_cidade;
        private System.Windows.Forms.TextBox text_valor;
        private System.Windows.Forms.TextBox text_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}