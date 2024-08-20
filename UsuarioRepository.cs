using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Reworked_sistema_de_votaciones
{
    public class UsuarioRepository
    {
        private readonly string _filePath = "Usuarios.txt";

        public void Add(Usuario usuario)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{usuario.ID_Usuario}|{usuario.Nombre_Usuario}|{usuario.Contraseña}|{usuario.Rol}");
            }
        }

        public Usuario GetByNombreUsuario(string nombreUsuario)
        {
            if (File.Exists(_filePath))
            {
                string[] lines = File.ReadAllLines(_filePath);
                foreach (string line in lines)
                {
                    var data = line.Split('|');
                    if (data[1] == nombreUsuario)
                    {
                        return new Usuario
                        {
                            ID_Usuario = int.Parse(data[0]),
                            Nombre_Usuario = data[1],
                            Contraseña = data[2],
                            Rol = int.Parse(data[3])
                        };
                    }
                }
            }
            return null;
        }
    }
}