namespace AnalizadorParentesisWinForms.UI
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkTrazas;
        private System.Windows.Forms.ListBox lstPasos;
        private System.Windows.Forms.Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkTrazas = new System.Windows.Forms.CheckBox();
            this.lstPasos = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Consolas", 14F);
            this.txtEntrada.Location = new System.Drawing.Point(12, 12);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(400, 29);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(418, 12);
            this.btnAnalizar.Size = new System.Drawing.Size(75, 29);
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(499, 12);
            this.btnLimpiar.Size = new System.Drawing.Size(75, 29);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkTrazas
            // 
            this.chkTrazas.AutoSize = true;
            this.chkTrazas.Checked = true;
            this.chkTrazas.Location = new System.Drawing.Point(12, 47);
            this.chkTrazas.Text = "Mostrar pasos";
            // 
            // lstPasos
            // 
            this.lstPasos.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstPasos.Location = new System.Drawing.Point(12, 72);
            this.lstPasos.Size = new System.Drawing.Size(562, 200);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(12, 280);
            this.lblResultado.Size = new System.Drawing.Size(562, 40);
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.chkTrazas);
            this.Controls.Add(this.lstPasos);
            this.Controls.Add(this.lblResultado);
            this.Name = "FormMain";
            this.Text = "Analizador de Paréntesis con Pilas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}