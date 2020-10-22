namespace SistemaMercado
{
    partial class frm_trabalho
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_calculadora = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Paint = new System.Windows.Forms.Button();
            this.btn_Word = new System.Windows.Forms.Button();
            this.process = new System.Diagnostics.Process();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "winword",
            "excel",
            "mspaint",
            "calc"});
            this.comboBox1.Location = new System.Drawing.Point(2, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.Location = new System.Drawing.Point(173, 111);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(81, 51);
            this.btn_calculadora.TabIndex = 9;
            this.btn_calculadora.Text = "Calculadora";
            this.btn_calculadora.UseVisualStyleBackColor = true;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(173, 31);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(76, 52);
            this.btn_Excel.TabIndex = 8;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Paint
            // 
            this.btn_Paint.Location = new System.Drawing.Point(28, 111);
            this.btn_Paint.Name = "btn_Paint";
            this.btn_Paint.Size = new System.Drawing.Size(80, 51);
            this.btn_Paint.TabIndex = 7;
            this.btn_Paint.Text = "Paint";
            this.btn_Paint.UseVisualStyleBackColor = true;
            this.btn_Paint.Click += new System.EventHandler(this.btn_Paint_Click);
            // 
            // btn_Word
            // 
            this.btn_Word.Location = new System.Drawing.Point(28, 31);
            this.btn_Word.Name = "btn_Word";
            this.btn_Word.Size = new System.Drawing.Size(80, 52);
            this.btn_Word.TabIndex = 6;
            this.btn_Word.Text = "Word";
            this.btn_Word.UseVisualStyleBackColor = true;
            this.btn_Word.Click += new System.EventHandler(this.btn_Word_Click);
            // 
            // process
            // 
            this.process.StartInfo.Domain = "";
            this.process.StartInfo.LoadUserProfile = false;
            this.process.StartInfo.Password = null;
            this.process.StartInfo.StandardErrorEncoding = null;
            this.process.StartInfo.StandardOutputEncoding = null;
            this.process.StartInfo.UserName = "";
            this.process.SynchronizingObject = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Fechar Aplicação";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_trabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(287, 307);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_calculadora);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Paint);
            this.Controls.Add(this.btn_Word);
            this.Name = "frm_trabalho";
            this.Text = "Area de trabalho";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_trabalho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_calculadora;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Paint;
        private System.Windows.Forms.Button btn_Word;
        private System.Diagnostics.Process process;
        private System.Windows.Forms.Button button2;
    }
}