using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReworkedSistemaDeVotaciones
{
    public class CandidatoRepository
    {
        private readonly string _filePath = "Candidatos.txt";

        public void Add(Candidato candidato)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{candidato.ID_Candidato}|{candidato.Nombre}|{candidato.Partido_Politico}|{candidato.Plataforma}|{candidato.Fecha_Registro}");
            }
        }

        public IEnumerable<Candidato> GetAll()
        {
            List<Candidato> candidatos = new List<Candidato>();
            if (File.Exists(_filePath))
            {
                string[] lines = File.ReadAllLines(_filePath);
                foreach (string line in lines)
                {
                    var data = line.Split('|');
                    Candidato candidato = new Candidato
                    {
                        ID_Candidato = int.Parse(data[0]),
                        Nombre = data[1],
                        Partido_Politico = data[2],
                        Plataforma = data[3],
                        Fecha_Registro = System.DateTime.Parse(data[4])
                    };
                    candidatos.Add(candidato);
                }
            }
            return candidatos;
        }
    }
}
