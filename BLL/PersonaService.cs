using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        private readonly ConnectionManager conexion;
        private readonly PersonaRepository repositorio;
        public PersonaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new PersonaRepository(conexion);
        }
        public string Guardar(Persona persona)
        {
            try
            {
                persona.CalcularPulsacion();
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(persona.Identificacion)==null)
                {
                    repositorio.Guardar(persona);                 
                    return $"Se guardaron los datos satisfactoriamente";
                }
                    return $"La persona ya existe";              
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaPersonaRespuesta ConsultarTodos()
        {
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
            try
            {
                
                conexion.Open();
                respuesta.Personas = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Personas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje= $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var persona = repositorio.BuscarPorIdentificacion(identificacion);
                if (persona != null)
                {
                    repositorio.Eliminar(persona);
                    conexion.Close();
                    return ($"El registro {persona.Nombre} se ha eliminado satisfactoriamente.");
                }
                   return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(Persona personaNueva)
        {
            try
            {
                personaNueva.CalcularPulsacion();
                conexion.Open();
                var personaVieja = repositorio.BuscarPorIdentificacion(personaNueva.Identificacion);
                if (personaVieja != null)
                {
                    repositorio.Modificar(personaNueva);
                    return ($"El registro de {personaNueva.Nombre} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, la persona con Identificación {personaNueva.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public BusquedaPersonaRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaPersonaRespuesta respuesta = new BusquedaPersonaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Persona = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Persona!=null)?  "Se encontró la Persona buscada" : "La persona buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error =true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConteoPersonaRespuesta Totalizar()
        {
            ConteoPersonaRespuesta respuesta = new ConteoPersonaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.Totalizar(); ;
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";
                
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
           
        }
        public ConteoPersonaRespuesta TotalizarTipo(string tipo)
        {
            ConteoPersonaRespuesta respuesta = new ConteoPersonaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.TotalizarTipo(tipo);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";
               
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
           
        }
       
    }

    public class ConsultaPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Persona> Personas { get; set; }
    }


    public class BusquedaPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
    }



    public class ConteoPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
