

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
        this.estadopistarepository = new EstadoPistaRepository ();
        this.valoracionrepository = new ValoracionRepository ();
        this.pagorepository = new PagoRepository ();
        this.tiporepository = new TipoRepository ();
        this.idiomarepository = new IdiomaRepository ();
        this.deporterepository = new DeporteRepository ();
        this.horariorepository = new HorarioRepository ();
        this.codigopostalrepository = new CodigoPostalRepository ();
}
}
}

