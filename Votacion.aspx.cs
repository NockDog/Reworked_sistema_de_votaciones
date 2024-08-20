using Reworked_sistema_de_votaciones;
using System;
using System.Linq;
using System.Web.UI;

namespace ReworkedSistemaDeVotaciones
{
    public partial class Votacion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var candidatoService = new CandidatoService(new CandidatoRepository());
                ddlCandidatos.DataSource = candidatoService.ObtenerCandidatos().ToList();
                ddlCandidatos.DataTextField = "Nombre";
                ddlCandidatos.DataValueField = "ID_Candidato";
                ddlCandidatos.DataBind();
            }
        }

        protected void btnVotar_Click(object sender, EventArgs e)
        {
            var votacionService = new VotacionService(new VotoRepository(), new CandidatoRepository());
            int idCandidato = int.Parse(ddlCandidatos.SelectedValue);
            votacionService.RegistrarVoto(idCandidato, 1); // ID_Usuario = 1 como ejemplo

            Response.Redirect("Resultados.aspx");
        }
    }
}
