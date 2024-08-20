using Reworked_sistema_de_votaciones;
using System;
using System.Web.UI;

namespace ReworkedSistemaDeVotaciones
{
    public partial class Resultados : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var votacionService = new VotacionService(new VotoRepository(), new CandidatoRepository());
                rptResultados.DataSource = votacionService.ObtenerResultados();
                rptResultados.DataBind();
            }
        }
    }
}
