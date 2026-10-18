using System.Collections.Generic;
using SoporteTecnicoEquipos.Models;

namespace SoporteTecnicoEquipos.Services
{
    public class SoporteService
    {
        public List<Equipo> Equipos { get; } = new();
        public List<ReporteSoporte> Reportes { get; } = new();
        public List<Cliente> Clientes { get; } = new();
        public List<Tecnico> Tecnicos { get; } = new();

        private int siguienteEquipoId = 1;
        private int siguienteReporteId = 1;
        private int siguienteClienteId = 1;
        private int siguienteTecnicoId = 1;

        public void AgregarEquipo(Equipo equipo)
        {
            equipo.Id = siguienteEquipoId++;
            Equipos.Add(equipo);
        }

        public void AgregarReporte(ReporteSoporte reporte)
        {
            reporte.Id = siguienteReporteId++;
            Reportes.Add(reporte);
        }

        public void AgregarCliente(Cliente cliente)
        {
            cliente.Id = siguienteClienteId++;
            Clientes.Add(cliente);
        }

        public void AgregarTecnico(Tecnico tecnico)
        {
            tecnico.Id = siguienteTecnicoId++;
            Tecnicos.Add(tecnico);
        }
    }
}