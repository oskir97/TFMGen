using System;

namespace TFM_REST.DTO
{
    public partial class FilterReservaDTO
    {
        private string filtro;
        private string localidad;
        private string latitud;
        private string longitud;
        private DateTime? fecha;
        private int deporte;
        private string orden;
        private string nivel;

        public string Filtro { get => filtro; set => filtro = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Latitud { get => latitud; set => latitud = value; }
        public string Longitud { get => longitud; set => longitud = value; }
        public DateTime? Fecha { get => fecha; set => fecha = value; }
        public int Deporte { get => deporte; set => deporte = value; }
        public string Orden { get => orden; set => orden = value; }
        public string Nivel { get => nivel; set => nivel = value; }
    }
}
