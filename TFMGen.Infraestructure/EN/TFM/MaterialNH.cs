
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class MaterialNH : MaterialEN {
public MaterialNH ()
{
}

public MaterialNH (MaterialEN dto)
{
        this.Idmaterial = dto.Idmaterial;


        this.Nombre = dto.Nombre;


        this.Descripcion = dto.Descripcion;


        this.Precio = dto.Precio;


        this.Proveedor = dto.Proveedor;
}
}
}
