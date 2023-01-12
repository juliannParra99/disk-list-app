
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
            this.lblEstilo = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.txtCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar_click = new System.Windows.Forms.Button();
            this.btnCancelar_click = new System.Windows.Forms.Button();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.lblEdicion = new System.Windows.Forms.Label();
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
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(110, 110);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 2;
            this.lblEstilo.Text = "Estilo:";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(151, 46);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(171, 20);
            this.textTitulo.TabIndex = 0;
            // 
            // txtCanciones
            // 
            this.txtCanciones.Location = new System.Drawing.Point(151, 75);
            this.txtCanciones.Name = "txtCanciones";
            this.txtCanciones.Size = new System.Drawing.Size(171, 20);
            this.txtCanciones.TabIndex = 1;
            // 
            // btnAceptar_click
            // 
            this.btnAceptar_click.Location = new System.Drawing.Point(79, 206);
            this.btnAceptar_click.Name = "btnAceptar_click";
            this.btnAceptar_click.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar_click.TabIndex = 3;
            this.btnAceptar_click.Text = "Aceptar";
            this.btnAceptar_click.UseVisualStyleBackColor = true;
            this.btnAceptar_click.Click += new System.EventHandler(this.btnAceptar_click_Click);
            // 
            // btnCancelar_click
            // 
            this.btnCancelar_click.Location = new System.Drawing.Point(237, 206);
            this.btnCancelar_click.Name = "btnCancelar_click";
            this.btnCancelar_click.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_click.TabIndex = 4;
            this.btnCancelar_click.Text = "Cancelar";
            this.btnCancelar_click.UseVisualStyleBackColor = true;
            this.btnCancelar_click.Click += new System.EventHandler(this.btnCancelar_click_Click);
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(151, 107);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(171, 21);
            this.cboEstilo.TabIndex = 5;
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(151, 140);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(171, 21);
            this.cboEdicion.TabIndex = 6;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(100, 143);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(45, 13);
            this.lblEdicion.TabIndex = 7;
            this.lblEdicion.Text = "Edicion:";
            // 
            // frmAltaRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 339);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.btnCancelar_click);
            this.Controls.Add(this.btnAceptar_click);
            this.Controls.Add(this.txtCanciones);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.lblEstilo);
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
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox txtCanciones;
        private System.Windows.Forms.Button btnAceptar_click;
        private System.Windows.Forms.Button btnCancelar_click;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.Label lblEdicion;
    }
}