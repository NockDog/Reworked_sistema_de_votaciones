using Reworked_sistema_de_votaciones;
using System.Collections.Generic;
using System.Linq;

namespace ReworkedSistemaDeVotaciones
{
    public class VotacionService
    {
        private readonly VotoRepository _votoRepo;
        private readonly CandidatoRepository _candidatoRepo;

        public VotacionService(VotoRepository votoRepo, CandidatoRepository candidatoRepo)
        {
            _votoRepo = votoRepo;
            _candidatoRepo = candidatoRepo;
        }

        public void RegistrarVoto(int idCandidato, int idUsuario)
        {
            var voto = new Voto
            {
                ID_Candidato = idCandidato,
                ID_Usuario = idUsuario,
                Fecha_Voto = System.DateTime.Now
            };
            _votoRepo.Add(voto);
        }

        public IEnumerable<Resultado> ObtenerResultados()
        {
            var candidatos = _candidatoRepo.GetAll();
            var totalVotos = _votoRepo.GetAll().Count();

            return candidatos.Select(c => new Resultado
            {
                Nombre = c.Nombre,
                Total_Votos = c.Votos.Count(),
                Porcentaje_Votos = (c.Votos.Count() / (decimal)totalVotos) * 100
            }).ToList();
        }
    }
}
