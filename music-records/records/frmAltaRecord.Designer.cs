
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCantidadCanciones = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar_click = new System.Windows.Forms.Button();
            this.btnCancelar_click = new System.Windows.Forms.Button();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.pbDiscos = new System.Windows.Forms.PictureBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(104, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Title:";
            // 
            // txtCantidadCanciones
            // 
            this.txtCantidadCanciones.AutoSize = true;
            this.txtCantidadCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCanciones.ForeColor = System.Drawing.Color.White;
            this.txtCantidadCanciones.Location = new System.Drawing.Point(34, 68);
            this.txtCantidadCanciones.Name = "txtCantidadCanciones";
            this.txtCantidadCanciones.Size = new System.Drawing.Size(106, 13);
            this.txtCantidadCanciones.TabIndex = 1;
            this.txtCantidadCanciones.Text = "Number of songs:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.ForeColor = System.Drawing.Color.White;
            this.lblEstilo.Location = new System.Drawing.Point(96, 132);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(39, 13);
            this.lblEstilo.TabIndex = 2;
            this.lblEstilo.Text = "Style:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(143, 36);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(146, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtCanciones
            // 
            this.txtCanciones.Location = new System.Drawing.Point(143, 65);
            this.txtCanciones.Name = "txtCanciones";
            this.txtCanciones.Size = new System.Drawing.Size(146, 20);
            this.txtCanciones.TabIndex = 1;
            // 
            // btnAceptar_click
            // 
            this.btnAceptar_click.Location = new System.Drawing.Point(80, 203);
            this.btnAceptar_click.Name = "btnAceptar_click";
            this.btnAceptar_click.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar_click.TabIndex = 5;
            this.btnAceptar_click.Text = "Done";
            this.btnAceptar_click.UseVisualStyleBackColor = true;
            this.btnAceptar_click.Click += new System.EventHandler(this.btnAceptar_click_Click);
            // 
            // btnCancelar_click
            // 
            this.btnCancelar_click.Location = new System.Drawing.Point(238, 203);
            this.btnCancelar_click.Name = "btnCancelar_click";
            this.btnCancelar_click.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_click.TabIndex = 6;
            this.btnCancelar_click.Text = "Cancel";
            this.btnCancelar_click.UseVisualStyleBackColor = true;
            this.btnCancelar_click.Click += new System.EventHandler(this.btnCancelar_click_Click);
            // 
            // cboEstilo
            // 
            this.cboEstilo.BackColor = System.Drawing.SystemColors.Window;
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(143, 129);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(146, 21);
            this.cboEstilo.TabIndex = 3;
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(143, 162);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(146, 21);
            this.cboEdicion.TabIndex = 4;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicion.ForeColor = System.Drawing.Color.White;
            this.lblEdicion.Location = new System.Drawing.Point(87, 165);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(50, 13);
            this.lblEdicion.TabIndex = 7;
            this.lblEdicion.Text = "Edition:";
            // 
            // pbDiscos
            // 
            this.pbDiscos.Location = new System.Drawing.Point(338, 31);
            this.pbDiscos.Name = "pbDiscos";
            this.pbDiscos.Size = new System.Drawing.Size(213, 165);
            this.pbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscos.TabIndex = 8;
            this.pbDiscos.TabStop = false;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.ForeColor = System.Drawing.Color.White;
            this.lblUrlImagen.Location = new System.Drawing.Point(25, 104);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(115, 13);
            this.lblUrlImagen.TabIndex = 9;
            this.lblUrlImagen.Text = "Image link/Upload:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(143, 97);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(146, 20);
            this.txtUrlImagen.TabIndex = 2;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(295, 97);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(25, 20);
            this.btnAgregarImagen.TabIndex = 10;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // frmAltaRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(571, 261);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.pbDiscos);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.btnCancelar_click);
            this.Controls.Add(this.btnAceptar_click);
            this.Controls.Add(this.txtCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.txtCantidadCanciones);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(587, 300);
            this.MinimumSize = new System.Drawing.Size(587, 300);
            this.Name = "frmAltaRecord";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Disk";
            this.Load += new System.EventHandler(this.frmAltaRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label txtCantidadCanciones;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCanciones;
        private System.Windows.Forms.Button btnAceptar_click;
        private System.Windows.Forms.Button btnCancelar_click;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.PictureBox pbDiscos;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}