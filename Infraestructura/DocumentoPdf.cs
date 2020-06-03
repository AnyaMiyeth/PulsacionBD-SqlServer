using System.Collections.Generic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entity;
using System.IO;
namespace Infraestructura
{
    public class DocumentoPdf
    {

        public void GuardarPdf (List<Persona> personas, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER,40,40,40,40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion Pulsacion");
            document.Open();
            document.Add(new Paragraph ("INFORME DE PERSONAS REGISTRADAS"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(personas));
            document.Close();
        }
        private PdfPTable LlenarTabla(List<Persona> personas)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Identificacion"));
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Edad"));
            tabla.AddCell(new Paragraph("Sexo"));
            tabla.AddCell(new Paragraph("Pulsacion"));
            foreach (var item in personas)
            {
                tabla.AddCell(new Paragraph(item.Identificacion));
                tabla.AddCell(new Paragraph(item.Nombre));
                tabla.AddCell(new Paragraph(item.Edad.ToString()));
                tabla.AddCell(new Paragraph(item.Sexo));
                tabla.AddCell(new Paragraph(item.Pulsacion.ToString()));

            }
            return tabla;
        
        }

    }
}
