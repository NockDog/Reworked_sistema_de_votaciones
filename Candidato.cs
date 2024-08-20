using System.Collections.Generic;

namespace ReworkedSistemaDeVotaciones
{
    public class Candidato
    {
        public int ID_Candidato { get; set; }
        public string Nombre { get; set; }
        public string Partido_Politico { get; set; }
        public string Plataforma { get; set; }
        public System.DateTime Fecha_Registro { get; set; }

        public List<Voto> Votos { get; set; } = new List<Voto>();
    }
}
