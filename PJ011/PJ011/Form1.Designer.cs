namespace PJ011
{
    partial class frmindice
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
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblVpes = new System.Windows.Forms.Label();
            this.lblValt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(719, 90);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(76, 20);
            this.txtpeso.TabIndex = 0;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(719, 139);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(76, 20);
            this.txtaltura.TabIndex = 1;
            // 
            // lblVpes
            // 
            this.lblVpes.AutoSize = true;
            this.lblVpes.Location = new System.Drawing.Point(662, 97);
            this.lblVpes.Name = "lblVpes";
            this.lblVpes.Size = new System.Drawing.Size(31, 13);
            this.lblVpes.TabIndex = 2;
            this.lblVpes.Text = "Peso";
            // 
            // lblValt
            // 
            this.lblValt.AutoSize = true;
            this.lblValt.Location = new System.Drawing.Point(662, 146);
            this.lblValt.Name = "lblValt";
            this.lblValt.Size = new System.Drawing.Size(34, 13);
            this.lblValt.TabIndex = 3;
            this.lblValt.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado = ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(782, 228);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(719, 185);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Calcular);
            // 
            // frmindice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 505);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValt);
            this.Controls.Add(this.lblVpes);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Name = "frmindice";
            this.Text = "Indice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblVpes;
        private System.Windows.Forms.Label lblValt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

