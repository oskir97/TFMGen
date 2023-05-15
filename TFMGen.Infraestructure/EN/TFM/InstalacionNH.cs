
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


        this.Ubicacion = dto.Ubicacion;


        this.Imagen = dto.Imagen;


        this.Codigopostal = dto.Codigopostal;


        this.Localidad = dto.Localidad;


        this.Provincia = dto.Provincia;


        this.Telefonoalternativo = dto.Telefonoalternativo;


        this.Visible = dto.Visible;


        this.Latitud = dto.Latitud;


        this.Longitud = dto.Longitud;
}
}
}
