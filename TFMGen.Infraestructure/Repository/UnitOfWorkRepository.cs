

using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.Infraestructure.Repository.TFM;
using TFMGen.Infraestructure.CP;
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

public UnitOfWorkRepository(SessionCPNHibernate session)
{
        this.usuariorepository = new UsuarioRepository ();
        this.usuariorepository.setSessionCP (session);
        this.reservarepository = new ReservaRepository ();
        this.reservarepository.setSessionCP (session);
        this.pistarepository = new PistaRepository ();
        this.pistarepository.setSessionCP (session);
        this.asitenciarepository = new AsitenciaRepository ();
        this.asitenciarepository.setSessionCP (session);
        this.notificacionrepository = new NotificacionRepository ();
        this.notificacionrepository.setSessionCP (session);
        this.rolrepository = new RolRepository ();
        this.rolrepository.setSessionCP (session);
        this.entidadrepository = new EntidadRepository ();
        this.entidadrepository.setSessionCP (session);
        this.instalacionrepository = new InstalacionRepository ();
        this.instalacionrepository.setSessionCP (session);
        this.materialrepository = new MaterialRepository ();
        this.materialrepository.setSessionCP (session);
        this.pistaestadorepository = new PistaEstadoRepository ();
        this.pistaestadorepository.setSessionCP (session);
        this.valoracionrepository = new ValoracionRepository ();
        this.valoracionrepository.setSessionCP (session);
        this.pagorepository = new PagoRepository ();
        this.pagorepository.setSessionCP (session);
        this.pagotiporepository = new PagoTipoRepository ();
        this.pagotiporepository.setSessionCP (session);
        this.idiomarepository = new IdiomaRepository ();
        this.idiomarepository.setSessionCP (session);
        this.deporterepository = new DeporteRepository ();
        this.deporterepository.setSessionCP (session);
        this.horariorepository = new HorarioRepository ();
        this.horariorepository.setSessionCP (session);
        this.pistaestado_l10nrepository = new PistaEstado_l10nRepository ();
        this.pistaestado_l10nrepository.setSessionCP (session);
        this.deporte_l10nrepository = new Deporte_l10nRepository ();
        this.deporte_l10nrepository.setSessionCP (session);
        this.rol_l10nrepository = new Rol_l10nRepository ();
        this.rol_l10nrepository.setSessionCP (session);
        this.pagotipo_l10nrepository = new PagoTipo_l10nRepository ();
        this.pagotipo_l10nrepository.setSessionCP (session);
        this.diasemanarepository = new DiaSemanaRepository ();
        this.diasemanarepository.setSessionCP (session);
        this.diasemana_l10nrepository = new DiaSemana_l10nRepository ();
        this.diasemana_l10nrepository.setSessionCP (session);
        this.eventorepository = new EventoRepository ();
        this.eventorepository.setSessionCP (session);
        this.incidenciarepository = new IncidenciaRepository ();
        this.incidenciarepository.setSessionCP (session);
}
}
}

