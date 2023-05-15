
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class EntidadNH : EntidadEN {
public EntidadNH ()
{
}

public EntidadNH (EntidadEN dto)
{
        this.Identidad = dto.Identidad;


        this.Nombre = dto.Nombre;


        this.Email = dto.Email;


        this.Telefono = dto.Telefono;


        this.Domicilio = dto.Domicilio;


        this.Alta = dto.Alta;


        this.Baja = dto.Baja;


        this.Cifnif = dto.Cifnif;


        this.Telefonoalternativo = dto.Telefonoalternativo;


        this.Codigopostal = dto.Codigopostal;


        this.Localidad = dto.Localidad;


        this.Provincia = dto.Provincia;


        this.Imagen = dto.Imagen;


        this.Configuracion = dto.Configuracion;


        this.Latitud = dto.Latitud;


        this.Longitud = dto.Longitud;
}
}
}
