
namespace EmpresaABC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckblivro = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstlistagem = new System.Windows.Forms.ListBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.cbblista = new System.Windows.Forms.ComboBox();
            this.pctimagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(135, 362);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // ckblivro
            // 
            this.ckblivro.AutoSize = true;
            this.ckblivro.Location = new System.Drawing.Point(135, 290);
            this.ckblivro.Name = "ckblivro";
            this.ckblivro.Size = new System.Drawing.Size(45, 17);
            this.ckblivro.TabIndex = 1;
            this.ckblivro.Text = "livro";
            this.ckblivro.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(137, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(81, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Insira seu nome";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(140, 88);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lstlistagem
            // 
            this.lstlistagem.FormattingEnabled = true;
            this.lstlistagem.Location = new System.Drawing.Point(135, 166);
            this.lstlistagem.Name = "lstlistagem";
            this.lstlistagem.Size = new System.Drawing.Size(120, 95);
            this.lstlistagem.TabIndex = 5;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(135, 325);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 6;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // cbblista
            // 
            this.cbblista.FormattingEnabled = true;
            this.cbblista.Location = new System.Drawing.Point(342, 88);
            this.cbblista.Name = "cbblista";
            this.cbblista.Size = new System.Drawing.Size(121, 21);
            this.cbblista.TabIndex = 7;
            // 
            // pctimagem
            // 
            this.pctimagem.Location = new System.Drawing.Point(342, 166);
            this.pctimagem.Name = "pctimagem";
            this.pctimagem.Size = new System.Drawing.Size(121, 95);
            this.pctimagem.TabIndex = 8;
            this.pctimagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctimagem);
            this.Controls.Add(this.cbblista);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.lstlistagem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.ckblivro);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox ckblivro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox mskCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lstlistagem;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.ComboBox cbblista;
        private System.Windows.Forms.PictureBox pctimagem;
    }
}

