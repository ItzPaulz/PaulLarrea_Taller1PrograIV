namespace PaulLarrea_Taller1PrograIV.Models
{
    public class Jugador
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        public Equipo Equipo { get; set; }
    }
}
