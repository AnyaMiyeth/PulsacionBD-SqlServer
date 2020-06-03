using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PulsacionBD
{
    public partial class FrmConsultaPersona : Form
    {
        PersonaService personaService;
        List<Persona> personas;
        public FrmConsultaPersona()
        {
            
            personaService = new PersonaService(ConfigConnection.ConnectionString);
            InitializeComponent();
            personas = new List<Persona>();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
            
            string tipo = CmbTipo.Text;
            if (tipo == "Todos")
            {
                DtgPersona.DataSource = null;
                respuesta = personaService.ConsultarTodos();
                personas = respuesta.Personas.ToList();
                DtgPersona.DataSource = respuesta.Personas;
                TxtTotal.Text = personaService.Totalizar().Cuenta.ToString();
                TxtTotalMujeres.Text = personaService.TotalizarTipo("F").Cuenta.ToString();
                TxtTotalHombres.Text = personaService.TotalizarTipo("M").Cuenta.ToString();
                MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Solo se implento la consulta para todos ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Informe";
            saveFileDialog.InitialDirectory = @"c:/document";
            saveFileDialog.DefaultExt = "pdf";
            string filename = "";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                filename = saveFileDialog.FileName;
                if (filename != "" && personas.Count>0)
                {
                    string mensaje=personaService.GenerarPdf(personas,filename);

                    MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
