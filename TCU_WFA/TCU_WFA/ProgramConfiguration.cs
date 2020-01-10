// Hecho por Luis Porras L.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TCU_WFA
{
    class ProgramConfiguration
    {
        //Constantes
        private const string XML_RUTA_ARCHIVO_CONFIG = @"C:\Program Files (x86)\TCU\config.xml";
        public const string LLAVE_UNIDAD_DE_TIEMPO = "unidadDeTiempo";
        public const string LLAVE_ALERTA_IEP = "alertaIEP";
        public const string LLAVE_ALERTA_PALPACION = "alertaPalpacion";
        public const string LLAVE_ALERTA_PARTO = "alertaParto";

        //Campos
        private XmlDocument configActual;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProgramConfiguration()
        {
            configActual = new XmlDocument();
            try
            {
                //Se intenta abrir el archivo de configuración existente.
                configActual.Load(XML_RUTA_ARCHIVO_CONFIG);
                if (!ValidarConfigActual())
                {
                    //La configuración cargada es incorrecta
                    EliminarConfigActual();
                    CrearConfigPorDefecto();
                }
            }
            catch
            {
                //El archivo de configuración no existe o es incorrecto.
                CrearConfigPorDefecto();
            }
        }

        /// <summary>
        /// Crea un archivo XML con la configuración por defecto de la aplicación y lo guarda en la ruta @xmlRutaArchivoConfig
        /// </summary>
        private void CrearConfigPorDefecto()
        {
            //Declaracion
            XmlDeclaration xmlDeclaration = configActual.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = configActual.DocumentElement;
            configActual.InsertBefore(xmlDeclaration, root);

            //Root
            XmlElement configuracion = configActual.CreateElement(string.Empty, "config", string.Empty);
            configActual.AppendChild(configuracion);

            //Elementos
            AgregarElementoXML(LLAVE_UNIDAD_DE_TIEMPO, "Días", configuracion);
            AgregarElementoXML(LLAVE_ALERTA_IEP, "365", configuracion);
            AgregarElementoXML(LLAVE_ALERTA_PALPACION, "15", configuracion);
            AgregarElementoXML(LLAVE_ALERTA_PARTO, "15", configuracion);

            //Se guarda el archivo XML
            try
            {
                configActual.Save(XML_RUTA_ARCHIVO_CONFIG);
            }
            catch
            {
                //No fue posible guardar el archivo con la configuración por defecto
            }
        }

        /// <summary>
        /// Agrega un elemento XML al archivo XML como hijo de @padre
        /// </summary>
        /// <param name="llave">Nombre del elemento XML a agregar</param>
        /// <param name="valor">Valor del texto del elemento XML a agregar</param>
        /// <param name="padre">Elemento XML al cual agregar el elemento creado</param>
        private void AgregarElementoXML(string llave, string valor, XmlElement padre)
        {
            XmlElement unidadDeTiempo = configActual.CreateElement(string.Empty, llave, string.Empty);
            XmlText textUnidadDeTiempo = configActual.CreateTextNode(valor);
            unidadDeTiempo.AppendChild(textUnidadDeTiempo);
            padre.AppendChild(unidadDeTiempo);
        }

        /// <summary>
        /// Obtiene el valor del texto del elemento XML con nombre @llave
        /// </summary>
        /// <param name="llave"></param>
        /// <returns></returns>
        public string ObtenerConfig(string llave)
        {
            XmlNode node = configActual.GetElementsByTagName(llave)[0];
            if (node != null) return node.InnerText;
            else return null;
        }

        /// <summary>
        /// Cambia el valor del texto del elemento XML con nombre @llave por el valor @valor
        /// </summary>
        /// <param name="llave"></param>
        /// <param name="valor"></param>
        public void CambiarConfig(string llave, string valor)
        {
            XmlNode node = configActual.GetElementsByTagName(llave)[0];
            if (node != null) node.InnerText = valor;
            configActual.Save(XML_RUTA_ARCHIVO_CONFIG);
        }

        /// <summary>
        /// Elimina la configuración actual y carga la configuración por defecto
        /// </summary>
        private void EliminarConfigActual()
        {
            try
            {
                if (File.Exists(XML_RUTA_ARCHIVO_CONFIG)) File.Delete(XML_RUTA_ARCHIVO_CONFIG);
            }
            catch
            {
                //No fue posible eliminar el archivo con la configuracion por defecto
            }
            configActual.RemoveAll();
        }

        private bool ValidarConfigActual()
        {
            string unidadDeTiempo = ObtenerConfig(LLAVE_UNIDAD_DE_TIEMPO);
            if (unidadDeTiempo != "Días" && unidadDeTiempo != "Meses" && unidadDeTiempo != "Semanas") return false;
            if (!int.TryParse(ObtenerConfig(LLAVE_ALERTA_IEP), out int x)) return false;
            if (!int.TryParse(ObtenerConfig(LLAVE_ALERTA_PALPACION), out int y)) return false;
            if (!int.TryParse(ObtenerConfig(LLAVE_ALERTA_PARTO), out int z)) return false;
            return true;
        }
    }
}
