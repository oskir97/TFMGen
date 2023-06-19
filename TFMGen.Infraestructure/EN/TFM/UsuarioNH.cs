
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class UsuarioNH : UsuarioEN {
public UsuarioNH ()
{
}

public UsuarioNH (UsuarioEN dto)
{
        this.Idusuario = dto.Idusuario;


        this.Nombre = dto.Nombre;


        this.Email = dto.Email;


        this.Domicilio = dto.Domicilio;


        this.Telefono = dto.Telefono;


        this.Telefonoalternativo = dto.Telefonoalternativo;


        this.Fechanacimiento = dto.Fechanacimiento;


        this.Alta = dto.Alta;


        this.Baja = dto.Baja;


        this.Ubicacionactual = dto.Ubicacionactual;


        this.Apellidos = dto.Apellidos;


        this.Password = dto.Password;


        this.Codigopostal = dto.Codigopostal;


        this.Localidad = dto.Localidad;


        this.Provincia = dto.Provincia;


        this.Numero = dto.Numero;


        this.Imagen = dto.Imagen;
}
}
}
