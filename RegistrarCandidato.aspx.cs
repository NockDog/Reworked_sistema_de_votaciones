using Reworked_sistema_de_votaciones;
using System;
using System.Web.UI;

namespace ReworkedSistemaDeVotaciones
{
    public partial class RegistrarCandidato : Page
    {
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            var candidatoService = new CandidatoService(new CandidatoRepository());
            var candidato = new Candidato
            {
                Nombre = txtNombre.Text,
                Partido_Politico = txtPartido.Text,
                Plataforma = txtPlataforma.Text,
                Fecha_Registro = DateTime.Now
            };

            candidatoService.RegistrarCandidato(candidato);

            Response.Redirect("Inicio.aspx");
        }
    }
}
