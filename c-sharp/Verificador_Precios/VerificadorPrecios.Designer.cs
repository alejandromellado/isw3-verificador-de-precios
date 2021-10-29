
namespace Verificador_Precios
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.labelInstrucciones = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.timerRegresar = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCodigo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // labelInstrucciones
            // 
            this.labelInstrucciones.AutoSize = true;
            this.labelInstrucciones.Font = new System.Drawing.Font("Arial", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrucciones.ForeColor = System.Drawing.Color.White;
            this.labelInstrucciones.Location = new System.Drawing.Point(157, 205);
            this.labelInstrucciones.Name = "labelInstrucciones";
            this.labelInstrucciones.Size = new System.Drawing.Size(583, 153);
            this.labelInstrucciones.TabIndex = 1;
            this.labelInstrucciones.Text = "Acerca el código de barras\r\ndel producto al lector para \r\nconsultar su precio.";
            this.labelInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Arial", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProducto.Location = new System.Drawing.Point(12, 387);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(213, 51);
            this.labelProducto.TabIndex = 3;
            this.labelProducto.Text = "producto";
            this.labelProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProducto.Visible = false;
            // 
            // timerRegresar
            // 
            this.timerRegresar.Interval = 1000;
            this.timerRegresar.Tick += new System.EventHandler(this.timerRegresar_Tick);
            // 
            // pictureBoxCodigo
            // 
            this.pictureBoxCodigo.BackColor = System.Drawing.Color.Green;
            this.pictureBoxCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCodigo.BackgroundImage")));
            this.pictureBoxCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCodigo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCodigo.Image")));
            this.pictureBoxCodigo.Location = new System.Drawing.Point(574, 246);
            this.pictureBoxCodigo.Name = "pictureBoxCodigo";
            this.pictureBoxCodigo.Size = new System.Drawing.Size(214, 192);
            this.pictureBoxCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCodigo.TabIndex = 2;
            this.pictureBoxCodigo.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(227, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(316, 190);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProducto
            // 
            this.pictureBoxProducto.Location = new System.Drawing.Point(11, 12);
            this.pictureBoxProducto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxProducto.TabIndex = 4;
            this.pictureBoxProducto.TabStop = false;
            this.pictureBoxProducto.Visible = false;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxError.Image")));
            this.pictureBoxError.Location = new System.Drawing.Point(256, 42);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxError.TabIndex = 5;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Arial", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(2, 112);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(789, 255);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "No fue posible leer el código de \r\nbarras.\r\n\r\nPor favor intente de nuevo o solici" +
    "te \r\nayuda del personal.";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(189)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.pictureBoxCodigo);
            this.Controls.Add(this.labelInstrucciones);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxProducto);
            this.Controls.Add(this.pictureBoxError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VentanaPrincipal_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelInstrucciones;
        private System.Windows.Forms.PictureBox pictureBoxCodigo;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
		private System.Windows.Forms.Timer timerRegresar;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Label labelError;
    }
}

