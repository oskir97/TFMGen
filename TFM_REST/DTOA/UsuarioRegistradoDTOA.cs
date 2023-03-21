using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class UsuarioRegistradoDTOA
{
private int idusuario;
public int Idusuario
{
        get { return idusuario; }
        set { idusuario = value; }
}


private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}

private string email;
public string Email
{
        get { return email; }
        set { email = value; }
}

private string apellidos;
public string Apellidos
{
        get { return apellidos; }
        set { apellidos = value; }
}

private string domicilio;
public string Domicilio
{
        get { return domicilio; }
        set { domicilio = value; }
}
}
}
