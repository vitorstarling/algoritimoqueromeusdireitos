
namespace OrdenadorDeLista
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
            this.btnOrdenaLista = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrdenaLista
            // 
            this.btnOrdenaLista.Location = new System.Drawing.Point(275, 252);
            this.btnOrdenaLista.Name = "btnOrdenaLista";
            this.btnOrdenaLista.Size = new System.Drawing.Size(121, 62);
            this.btnOrdenaLista.TabIndex = 0;
            this.btnOrdenaLista.Text = "OrdenaLista";
            this.btnOrdenaLista.UseVisualStyleBackColor = true;
            this.btnOrdenaLista.Click += new System.EventHandler(this.btnOrdenaLista_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(296, 331);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 1;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(275, 206);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 22);
            this.txtNumeros.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnOrdenaLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenaLista;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNumeros;
    }
}

