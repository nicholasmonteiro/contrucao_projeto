namespace SistemaMercado
{
    partial class frm_menuprincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menuprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Aarmarzem = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_ajuda = new System.Windows.Forms.Button();
            this.btnDistribuidora = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cadastrarDadosPessoaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.cadastrarDadosPessoaisToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.Location = new System.Drawing.Point(755, 196);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(122, 70);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "Cadastrar Produto";
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.Location = new System.Drawing.Point(214, 194);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(122, 70);
            this.btnCategoria.TabIndex = 5;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btn_Aarmarzem
            // 
            this.btn_Aarmarzem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Aarmarzem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Aarmarzem.Location = new System.Drawing.Point(214, 69);
            this.btn_Aarmarzem.Name = "btn_Aarmarzem";
            this.btn_Aarmarzem.Size = new System.Drawing.Size(122, 70);
            this.btn_Aarmarzem.TabIndex = 6;
            this.btn_Aarmarzem.Text = "Armazém";
            this.btn_Aarmarzem.UseVisualStyleBackColor = false;
            this.btn_Aarmarzem.Click += new System.EventHandler(this.btn_Aarmarzem_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sair.Location = new System.Drawing.Point(24, 190);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(122, 76);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_ajuda
            // 
            this.btn_ajuda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ajuda.Location = new System.Drawing.Point(24, 69);
            this.btn_ajuda.Name = "btn_ajuda";
            this.btn_ajuda.Size = new System.Drawing.Size(122, 70);
            this.btn_ajuda.TabIndex = 8;
            this.btn_ajuda.Text = "Ajuda";
            this.btn_ajuda.UseVisualStyleBackColor = false;
            this.btn_ajuda.Click += new System.EventHandler(this.btn_ajuda_Click);
            // 
            // btnDistribuidora
            // 
            this.btnDistribuidora.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDistribuidora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDistribuidora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuidora.Image = ((System.Drawing.Image)(resources.GetObject("btnDistribuidora.Image")));
            this.btnDistribuidora.Location = new System.Drawing.Point(746, 81);
            this.btnDistribuidora.Name = "btnDistribuidora";
            this.btnDistribuidora.Size = new System.Drawing.Size(131, 70);
            this.btnDistribuidora.TabIndex = 9;
            this.btnDistribuidora.Text = "Cadastrar    Distribuidora";
            this.btnDistribuidora.UseVisualStyleBackColor = false;
            this.btnDistribuidora.Click += new System.EventHandler(this.btnDistribuidora_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 73);
            this.button1.TabIndex = 10;
            this.button1.Text = "Produtos Indisponiveis";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(393, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 70);
            this.button2.TabIndex = 11;
            this.button2.Text = "Estatistica Interativa ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(576, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 70);
            this.button4.TabIndex = 13;
            this.button4.Text = "Area de Trabalho";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(567, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 84);
            this.button5.TabIndex = 14;
            this.button5.Text = "Cadastrar   Dados Pessoais";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cadastrarDadosPessoaisToolStripMenuItem
            // 
            this.cadastrarDadosPessoaisToolStripMenuItem.Name = "cadastrarDadosPessoaisToolStripMenuItem";
            this.cadastrarDadosPessoaisToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastrarDadosPessoaisToolStripMenuItem.Text = "Cadastrar Dados Pessoais";
            this.cadastrarDadosPessoaisToolStripMenuItem.Click += new System.EventHandler(this.cadastrarDadosPessoaisToolStripMenuItem_Click);
            // 
            // frm_menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 420);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDistribuidora);
            this.Controls.Add(this.btn_ajuda);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_Aarmarzem);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menuprincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.frm_menuprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btn_Aarmarzem;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_ajuda;
        private System.Windows.Forms.Button btnDistribuidora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDadosPessoaisToolStripMenuItem;
    }
}

