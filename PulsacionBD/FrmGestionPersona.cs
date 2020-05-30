using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
namespace PulsacionBD
{
    public partial class FrmGestionPersona : Form
    {
        PersonaService personaService;
        Persona persona;
        public FrmGestionPersona()
        {
            InitializeComponent();
             personaService = new PersonaService(ConfigConnection.ConnectionString);
        }
        private Persona MapearPersona()
        {
            persona = new Persona();
            persona.Identificacion = txtIdentificacion.Text;
            persona.Nombre = txtNombre.Text;
            persona.Edad = int.Parse(txtEdad.Text);
            persona.Sexo = cmbSexo.Text;
            return persona;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = MapearPersona();
            string mensaje = personaService.Guardar(persona);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();

        }

        private void Limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtPulsaciones.Text = "";
            cmbSexo.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            BusquedaPersonaRespuesta respuesta = new BusquedaPersonaRespuesta();
            string identificacion = txtIdentificacion.Text;
            if (identificacion != "")
            {
                respuesta = personaService.BuscarxIdentificacion(identificacion);

                if (respuesta.Persona != null)
                {
                    txtNombre.Text = respuesta.Persona.Nombre;
                    txtEdad.Text = respuesta.Persona.Edad.ToString();
                    txtPulsaciones.Text = respuesta.Persona.Pulsacion.ToString();
                    cmbSexo.Text = respuesta.Persona.Sexo;
                    txtPulsaciones.Text = respuesta.Persona.Pulsacion.ToString();
                    MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Por favor digite una identificación", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnCalcularPulsacion_Click(object sender, EventArgs e)
        {
            Persona persona = MapearPersona();
            persona.CalcularPulsacion();
            txtPulsaciones.Text = persona.Pulsacion.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Persona persona = MapearPersona();
                string mensaje = personaService.Modificar(persona);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            if (identificacion != "")
            {
                var respuesta = MessageBox.Show("Está seguro de eliminar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = personaService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor digite la cedula de la persona a modificar y presione el boton buscar", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmGestionPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
