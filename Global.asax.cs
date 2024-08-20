using System;
using System.Web;

namespace ReworkedSistemaDeVotaciones
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Aquí podrías inicializar configuraciones globales, si es necesario

            // Configuración inicial para los servicios o componentes si es necesario
            // Por ejemplo, cargar configuraciones de aplicación

            // Podrías agregar inicialización de datos si es necesario
            InicializarDatos();
        }

        private void InicializarDatos()
        {
            // Método de ejemplo para inicializar datos de prueba o realizar configuraciones adicionales
            // Aquí puedes agregar código para inicializar tus archivos de texto o configurar algo en el inicio

            // Ejemplo: Crear archivos de texto si no existen
            CrearArchivoSiNoExiste("Candidatos.txt");
            CrearArchivoSiNoExiste("Votos.txt");
        }

        private void CrearArchivoSiNoExiste(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.Create(filePath).Dispose();
            }
        }
    }
}
