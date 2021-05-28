using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipodeFutbol
{
    public class Jugadores
        {
            string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
    }
    public class Equipo 
    {
        string nombreEquipo;
        string ciudad;
        DateTime añoFundacion;
        List<Jugadores> Jugadores = new List<Jugadores>();

        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public DateTime AñoFundacion { get => añoFundacion; set => añoFundacion = value; }
        public List<Jugadores> Jugadores1 { get => Jugadores; set => Jugadores = value; }

        public Equipo()
        {
            Jugadores = new List<Jugadores>();
        }
    }

    
}