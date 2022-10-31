using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Agenda
{
    public partial class frmSulaco : Form
    {
        string[] nombre = new string[32];
        int[] numero = new int[32];

        public frmSulaco()
        {
            InitializeComponent();
        }
        static bool ValidarNumero(int numero_validar)
        {
            string contar = numero_validar.ToString();
            int contador;
            contador = contar.Length;
            if (contador == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Validar número
        public int Contador(int contados)
        {
            lblCantidad.Text = contados.ToString();
            int espacio = 31 - contados;
            lblCantidad.Text = espacio.ToString();
            return espacio;
        }//Metodo contador
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int disponibles = lstContactos.Items.Count;
            try
            {
                nombre[disponibles] = txbNombre.Text;
                numero[disponibles] = int.Parse(txbTelefono.Text);
                if (disponibles != 31)
                {
                    for (int i = 0; i < disponibles; i++)
                    {
                        if (txbNombre.Text == nombre[i] || txbTelefono.Text == numero[i].ToString())
                        {
                            MessageBox.Show("El contacto ya existe", "ERROR");
                            txbNombre.Text = "";
                            txbTelefono.Text = "";
                        }
                    }//Revisa si existe un contacto existente
                    if (ValidarNumero(int.Parse(txbTelefono.Text)))
                    {
                        lstContactos.Items.Add("[" + nombre[disponibles] + "] - [+56 " + numero[disponibles] + "]");
                    }//Si la funcion valida el número,se añade el contacto
                    else
                    {
                        MessageBox.Show("Debe ingresar un número válido de 9 caracteres", "FORMATO INCORRECTO");
                    }
                }
                else
                {
                    MessageBox.Show("Agenda llena. Elimine contactos para añadir más.", "AGENDA LLENA");
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("No se añadió el contacto","ERROR");
            }
            lblCantidad.Text = Contador(disponibles).ToString(); //Aplicación del método para contar los espacios disponibles
            txbNombre.Text = "";
            txbTelefono.Text = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lstContactos.Items.RemoveAt(lstContactos.SelectedIndex); //Elimina el contacto seleccionado, identifica el índice a eliminar
                int lbldisponibles = lstContactos.Items.Count;
                lbldisponibles = 31 - lbldisponibles;
                lbldisponibles++;
                if (lbldisponibles == 33)
                {
                    lbldisponibles = 32;
                }
                lblCantidad.Text = (lbldisponibles.ToString());
            }
            catch (SystemException)
            {
                MessageBox.Show("Debe seleccionar un contacto para eliminar", "ERROR");
            }
        }//Eliminar Contacto

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txbNombreBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre válido", "BUSQUEDA");
            }
            string nombreBuscado = txbNombreBuscar.Text;
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombreBuscado == nombre[i])
                {
                    MessageBox.Show("[" + nombre[i] + "] - [+56 " + numero[i] + "]", "BUSQUEDA");
                    return;
                }
            }
            txbNombreBuscar.Text = "";

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }
    }
}


