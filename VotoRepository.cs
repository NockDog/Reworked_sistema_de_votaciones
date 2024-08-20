using System.Collections.Generic;
using System.IO;

namespace ReworkedSistemaDeVotaciones
{
    public class VotoRepository
    {
        private readonly string _filePath = "Votos.txt";

        public void Add(Voto voto)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{voto.ID_Voto}|{voto.ID_Candidato}|{voto.ID_Usuario}|{voto.Fecha_Voto}");
            }
        }

        public IEnumerable<Voto> GetAll()
        {
            List<Voto> votos = new List<Voto>();
            if (File.Exists(_filePath))
            {
                string[] lines = File.ReadAllLines(_filePath);
                foreach (string line in lines)
                {
                    var data = line.Split('|');
                    Voto voto = new Voto
                    {
                        ID_Voto = int.Parse(data[0]),
                        ID_Candidato = int.Parse(data[1]),
                        ID_Usuario = int.Parse(data[2]),
                        Fecha_Voto = System.DateTime.Parse(data[3])
                    };
                    votos.Add(voto);
                }
            }
            return votos;
        }
    }
}
