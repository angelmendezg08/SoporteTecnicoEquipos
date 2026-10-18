namespace SoporteTecnicoEquipos.Models
{
    public class ReporteSoporte
    {
        public int Id { get; set; }
        public string Equipo { get; set; } = string.Empty;
        public string Problema { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Estado { get; set; } = "Pendiente";
    }
}
