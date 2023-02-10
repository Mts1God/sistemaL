
namespace ConsultorioMedico
{
    partial class frmPesquisar
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
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbDescrição = new System.Windows.Forms.RadioButton();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ltbitensPesquisados = new System.Windows.Forms.ListBox();
            this.gpbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.ltbitensPesquisados);
            this.gpbPesquisar.Controls.Add(this.button1);
            this.gpbPesquisar.Controls.Add(this.button2);
            this.gpbPesquisar.Controls.Add(this.textBox1);
            this.gpbPesquisar.Controls.Add(this.lblDescricao);
            this.gpbPesquisar.Controls.Add(this.rdbDescrição);
            this.gpbPesquisar.Controls.Add(this.rdbCodigo);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(21, 27);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(571, 323);
            this.gpbPesquisar.TabIndex = 0;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar por:";
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(26, 50);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigo.TabIndex = 0;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // rdbDescrição
            // 
            this.rdbDescrição.AutoSize = true;
            this.rdbDescrição.Location = new System.Drawing.Point(182, 50);
            this.rdbDescrição.Name = "rdbDescrição";
            this.rdbDescrição.Size = new System.Drawing.Size(69, 24);
            this.rdbDescrição.TabIndex = 1;
            this.rdbDescrição.TabStop = true;
            this.rdbDescrição.Text = "Nome";
            this.rdbDescrição.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(26, 97);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 26);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 119);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 119);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ltbitensPesquisados
            // 
            this.ltbitensPesquisados.FormattingEnabled = true;
            this.ltbitensPesquisados.ItemHeight = 20;
            this.ltbitensPesquisados.Location = new System.Drawing.Point(26, 148);
            this.ltbitensPesquisados.Name = "ltbitensPesquisados";
            this.ltbitensPesquisados.Size = new System.Drawing.Size(352, 144);
            this.ltbitensPesquisados.TabIndex = 7;
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 379);
            this.Controls.Add(this.gpbPesquisar);
            this.Name = "frmPesquisar";
            this.Text = "frmPesquisar";
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisar;
        private System.Windows.Forms.ListBox ltbitensPesquisados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rdbDescrição;
        private System.Windows.Forms.RadioButton rdbCodigo;
    }
}