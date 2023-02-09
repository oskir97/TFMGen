
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
public IEstadoPistaRepository estadopistarepository {
        set; get;
}
public IValoracionRepository valoracionrepository {
        set; get;
}
public IPagoRepository pagorepository {
        set; get;
}
public ITipoRepository tiporepository {
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
public ICodigoPostalRepository codigopostalrepository {
        set; get;
}
}
}
