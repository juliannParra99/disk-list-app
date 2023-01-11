
namespace records
{
    partial class frmAltaRecord
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
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtCantidadCanciones = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textCanciones = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAceptar_click = new System.Windows.Forms.Button();
            this.btnCancelar_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Location = new System.Drawing.Point(97, 53);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(36, 13);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Titulo:";
            // 
            // txtCantidadCanciones
            // 
            this.txtCantidadCanciones.AutoSize = true;
            this.txtCantidadCanciones.Location = new System.Drawing.Point(28, 78);
            this.txtCantidadCanciones.Name = "txtCantidadCanciones";
            this.txtCantidadCanciones.Size = new System.Drawing.Size(120, 13);
            this.txtCantidadCanciones.TabIndex = 1;
            this.txtCantidadCanciones.Text = "Cantidad de Canciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(151, 46);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(171, 20);
            this.textTitulo.TabIndex = 0;
            // 
            // textCanciones
            // 
            this.textCanciones.Location = new System.Drawing.Point(151, 75);
            this.textCanciones.Name = "textCanciones";
            this.textCanciones.Size = new System.Drawing.Size(171, 20);
            this.textCanciones.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 20);
            this.textBox3.TabIndex = 2;
            // 
            // btnAceptar_click
            // 
            this.btnAceptar_click.Location = new System.Drawing.Point(58, 167);
            this.btnAceptar_click.Name = "btnAceptar_click";
            this.btnAceptar_click.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar_click.TabIndex = 3;
            this.btnAceptar_click.Text = "Aceptar";
            this.btnAceptar_click.UseVisualStyleBackColor = true;
            this.btnAceptar_click.Click += new System.EventHandler(this.btnAceptar_click_Click);
            // 
            // btnCancelar_click
            // 
            this.btnCancelar_click.Location = new System.Drawing.Point(216, 167);
            this.btnCancelar_click.Name = "btnCancelar_click";
            this.btnCancelar_click.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_click.TabIndex = 4;
            this.btnCancelar_click.Text = "Cancelar";
            this.btnCancelar_click.UseVisualStyleBackColor = true;
            this.btnCancelar_click.Click += new System.EventHandler(this.btnCancelar_click_Click);
            // 
            // frmAltaRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 339);
            this.Controls.Add(this.btnCancelar_click);
            this.Controls.Add(this.btnAceptar_click);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textCanciones);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadCanciones);
            this.Controls.Add(this.txtTitulo);
            this.MinimumSize = new System.Drawing.Size(396, 378);
            this.Name = "frmAltaRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaRecord";
            this.Load += new System.EventHandler(this.frmAltaRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label txtCantidadCanciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textCanciones;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAceptar_click;
        private System.Windows.Forms.Button btnCancelar_click;
    }
}