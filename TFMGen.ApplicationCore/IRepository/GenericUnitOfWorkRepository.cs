
using System;
using System.Collections.Generic;
using System.Text;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public abstract class GenericUnitOfWorkRepository
{
public IUsuarioRepository usuariorepository {
        set; get;
}
public IReservaRepository reservarepository {
        set; get;
}
public IPistaRepository pistarepository {
        set; get;
}
public IAsitenciaRepository asitenciarepository {
        set; get;
}
public INotificacionRepository notificacionrepository {
        set; get;
}
public IRolRepository rolrepository {
        set; get;
}
public IEntidadRepository entidadrepository {
        set; get;
}
public IInstalacionRepository instalacionrepository {
        set; get;
}
public IMaterialRepository materialrepository {
        set; get;
}
public IPistaEstadoRepository pistaestadorepository {
        set; get;
}
public IValoracionRepository valoracionrepository {
        set; get;
}
public IPagoRepository pagorepository {
        set; get;
}
public IPagoTipoRepository pagotiporepository {
        set; get;
}
public IIdiomaRepository idiomarepository {
        set; get;
}
public IDeporteRepository deporterepository {
        set; get;
}
public IHorarioRepository horariorepository {
        set; get;
}
public IPistaEstado_l10nRepository pistaestado_l10nrepository {
        set; get;
}
public IDeporte_l10nRepository deporte_l10nrepository {
        set; get;
}
public IRol_l10nRepository rol_l10nrepository {
        set; get;
}
public IPagoTipo_l10nRepository pagotipo_l10nrepository {
        set; get;
}
public IDiaSemanaRepository diasemanarepository {
        set; get;
}
public IDiaSemana_l10nRepository diasemana_l10nrepository {
        set; get;
}
}
}
