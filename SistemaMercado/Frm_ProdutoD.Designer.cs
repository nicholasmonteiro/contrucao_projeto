namespace SistemaMercado
{
    partial class Frm_ProdutoD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProdutoD));
            this.imagFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblfoto = new System.Windows.Forms.Label();
            this.btnImagem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imagFotos
            // 
            this.imagFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagFotos.ImageStream")));
            this.imagFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imagFotos.Images.SetKeyName(0, "lasanha sadia.png");
            this.imagFotos.Images.SetKeyName(1, "nissan mini.png");
            this.imagFotos.Images.SetKeyName(2, "pizzaSA.png");
            // 
            // lblfoto
            // 
            this.lblfoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoto.ImageIndex = 0;
            this.lblfoto.ImageList = this.imagFotos;
            this.lblfoto.Location = new System.Drawing.Point(21, 23);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(145, 125);
            this.lblfoto.TabIndex = 0;
            this.lblfoto.Text = "Produtos";
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(12, 164);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(113, 27);
            this.btnImagem.TabIndex = 1;
            this.btnImagem.Text = "Carregar Produtos";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ProdutoD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.lblfoto);
            this.Name = "Frm_ProdutoD";
            this.Text = "Carregar Produtos";
            this.Load += new System.EventHandler(this.Frm_ProdutoD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imagFotos;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.Button button1;
    }
}