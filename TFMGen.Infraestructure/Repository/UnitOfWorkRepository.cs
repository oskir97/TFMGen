

using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.Infraestructure.Repository.TFM;
using System;
using System.Collections.Generic;
using System.Text;

namespace TFMGen.Infraestructure.Repository
{
public class UnitOfWorkRepository : GenericUnitOfWorkRepository
{
public UnitOfWorkRepository()
{
        this.usuariorepository = new UsuarioRepository ();
        this.reservarepository = new ReservaRepository ();
        this.pistarepository = new PistaRepository ();
        this.asitenciarepository = new AsitenciaRepository ();
        this.notificacionrepository = new NotificacionRepository ();
        this.rolrepository = new RolRepository ();
        this.entidadrepository = new EntidadRepository ();
        this.instalacionrepository = new InstalacionRepository ();
        this.materialrepository = new MaterialRepository ();
        this.pistaestadorepository = new PistaEstadoRepository ();
        this.valoracionrepository = new ValoracionRepository ();
        this.pagorepository = new PagoRepository ();
        this.pagotiporepository = new PagoTipoRepository ();
        this.idiomarepository = new IdiomaRepository ();
        this.deporterepository = new DeporteRepository ();
        this.horariorepository = new HorarioRepository ();
        this.pistaestado_l10nrepository = new PistaEstado_l10nRepository ();
        this.deporte_l10nrepository = new Deporte_l10nRepository ();
        this.rol_l10nrepository = new Rol_l10nRepository ();
        this.pagotipo_l10nrepository = new PagoTipo_l10nRepository ();
        this.diasemanarepository = new DiaSemanaRepository ();
        this.diasemana_l10nrepository = new DiaSemana_l10nRepository ();
        this.eventorepository = new EventoRepository ();
        this.incidenciarepository = new IncidenciaRepository ();
}
}
}

