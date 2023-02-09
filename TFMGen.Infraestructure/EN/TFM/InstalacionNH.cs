
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class InstalacionNH : InstalacionEN {
public InstalacionNH ()
{
}

public InstalacionNH (InstalacionEN dto)
{
        this.Idinstalacion = dto.Idinstalacion;


        this.Nombre = dto.Nombre;


        this.Telefono = dto.Telefono;


        this.Domicilio = dto.Domicilio;


        this.Idcodigopostal = dto.Idcodigopostal;


        this.Ubicacion = dto.Ubicacion;


        this.Imagen = dto.Imagen;
}
}
}
