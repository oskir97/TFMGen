
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class CodigoPostalNH : CodigoPostalEN {
public CodigoPostalNH ()
{
}

public CodigoPostalNH (CodigoPostalEN dto)
{
        this.Idcodigopostal = dto.Idcodigopostal;


        this.Codigo = dto.Codigo;


        this.Localidad = dto.Localidad;


        this.Comunidad = dto.Comunidad;


        this.Provincia = dto.Provincia;


        this.Latitud = dto.Latitud;


        this.Longitud = dto.Longitud;


        this.Precision = dto.Precision;
}
}
}
