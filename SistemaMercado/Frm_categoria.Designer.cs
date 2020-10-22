namespace SistemaMercado
{
    partial class Frm_categoria
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridCategoria = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insira o id do produto:";
            // 
            // dataGridCategoria
            // 
            this.dataGridCategoria.AllowUserToDeleteRows = false;
            this.dataGridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridCategoria.Location = new System.Drawing.Point(0, 76);
            this.dataGridCategoria.Name = "dataGridCategoria";
            this.dataGridCategoria.ReadOnly = true;
            this.dataGridCategoria.Size = new System.Drawing.Size(343, 303);
            this.dataGridCategoria.TabIndex = 15;
            this.dataGridCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategoria_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "codigo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "nome";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "valor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(163, 32);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(118, 20);
            this.textPesquisa.TabIndex = 21;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // Frm_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 408);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridCategoria);
            this.Controls.Add(this.label2);
            this.Name = "Frm_categoria";
            this.Text = "categoria";
            this.Load += new System.EventHandler(this.Frm_categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridCategoria;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}