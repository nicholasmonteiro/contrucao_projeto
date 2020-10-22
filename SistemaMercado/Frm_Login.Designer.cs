namespace SistemaMercado
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.btn_cancell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(90, 89);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(120, 20);
            this.txbUser.TabIndex = 4;
            // 
            // btn_entrar
            // 
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(25, 200);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(106, 44);
            this.btn_entrar.TabIndex = 6;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(90, 134);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(120, 20);
            this.txbPass.TabIndex = 7;
            this.txbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cancell
            // 
            this.btn_cancell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancell.Location = new System.Drawing.Point(175, 200);
            this.btn_cancell.Name = "btn_cancell";
            this.btn_cancell.Size = new System.Drawing.Size(106, 44);
            this.btn_cancell.TabIndex = 8;
            this.btn_cancell.Text = "Cancelar";
            this.btn_cancell.UseVisualStyleBackColor = true;
            this.btn_cancell.Click += new System.EventHandler(this.btn_cancell_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(410, 276);
            this.Controls.Add(this.btn_cancell);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Login";
            this.Text = "gerente";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Button btn_cancell;

    }
}