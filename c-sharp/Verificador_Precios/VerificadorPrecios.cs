using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class VentanaPrincipal : Form
    {
        private int segundos = 0;
        private String codigo = "";

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.Location = new Point(this.Width / 2 - pictureBoxLogo.Width / 2, 50);
            pictureBoxCodigo.Location = new Point(this.Width / 2 - pictureBoxCodigo.Width / 2, this.Height / 2 + 50);
            labelInstrucciones.Location = new Point(this.Width / 2 - (labelInstrucciones.Width / 2), pictureBoxLogo.Height + 100);
        }

        private void TogglePantallaProducto(bool estado)
        {
            pictureBoxProducto.Location = new Point(this.Width / 2 - pictureBoxProducto.Width / 2, this.Height / 2 + 50);
            labelProducto.Location = new Point(this.Width / 2 - (labelProducto.Width / 2), pictureBoxLogo.Height + 100);
            labelProducto.Visible = estado;
            pictureBoxProducto.Visible = estado;
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void TogglePantallaInicio(bool estado)
        {
            pictureBoxCodigo.Visible = estado;
            labelInstrucciones.Visible = estado;
        }

        private void TogglePantallaError(bool estado)
        {
            pictureBoxLogo.Visible = !estado;
            pictureBoxError.Location = new Point(
                this.Width / 2 - pictureBoxError.Width / 2,
                this.Height / 2 - pictureBoxError.Height / 2 - 200
                );
            pictureBoxError.Visible = estado;
            labelError.Location = new Point(this.Width / 2 - labelError.Width / 2, this.Height / 2 - labelError.Height / 2 + 150);
            labelError.Visible = estado;
        }

        private void VentanaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && string.IsNullOrEmpty(codigo) == false)
            {
                //MessageBox.Show("vamos a buscar el producto "+ codigo);
                try
                {
                    MySqlConnection servidor;
                    servidor = new MySqlConnection("server = 127.0.0.1; user = root; database = isw3; SSL Mode = None; ");
                    servidor.Open();

                    string query = "SELECT ProductoNombre, ProductoPrecio, ProductoCantidad, ProductoImagen " +
                        "FROM productos " +
                        "WHERE ProductoCodigo = " + codigo + ";";

                    //MessageBox.Show(query);
                    MySqlCommand consulta = new MySqlCommand(query, servidor);
                    MySqlDataReader resultado = consulta.ExecuteReader();

                    TogglePantallaInicio(false);

                    if (resultado.HasRows)
                    {
                        resultado.Read();

                        // Leer los datos del producto
                        pictureBoxProducto.ImageLocation = resultado.GetString(3);
                        labelProducto.Text = resultado.GetString(0) + Environment.NewLine + 
                            "Precio: $" + resultado.GetString(1) + Environment.NewLine +
                            "Disponibles: " + resultado.GetString(2);

                        TogglePantallaError(false);
                        TogglePantallaProducto(true);
                    }
                    else
                    {
                        TogglePantallaProducto(false);
                        TogglePantallaError(true);
                    }

                    // Activar timer para regresar.
                    segundos = 0;
                    timerRegresar.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString(), "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }

                codigo = "";
            }
            else if (e.KeyChar != 13)
            {
                codigo += e.KeyChar;
            }
        }

		private void timerRegresar_Tick(object sender, EventArgs e)
		{
            segundos++;

            if (segundos == 4)
            {
                timerRegresar.Enabled = false;
                TogglePantallaError(false);
                TogglePantallaProducto(false);
                TogglePantallaInicio(true);
                labelProducto.Text = "";
            }
		}
	}
}