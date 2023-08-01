namespace TFMGen.ApiTests.Models.Request
{
    public class ExisteReservaRequest
    {
        public DateTime? p_fecha { get; set; }

        // Constructor
        public ExisteReservaRequest(DateTime? p_fecha)
        {
            this.p_fecha = p_fecha;
        }
    }
}