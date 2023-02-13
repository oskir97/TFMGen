
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Entidad_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class EntidadCEN
{
public void Editar (int p_Entidad_OID, string p_nombre, string p_email, string p_telefono, string p_domicilio, Nullable<DateTime> p_alta, string p_codigopostal, string p_localidad, string p_provincia, string p_cifnif, string p_telefonoalternativo)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Entidad_editar_customized) START*/

        EntidadEN entidadEN = null;

        //Initialized EntidadEN
        entidadEN = new EntidadEN ();
        entidadEN.Identidad = p_Entidad_OID;
        entidadEN.Nombre = p_nombre;
        entidadEN.Email = p_email;
        entidadEN.Telefono = p_telefono;
        entidadEN.Domicilio = p_domicilio;
        entidadEN.Alta = p_alta;
        entidadEN.Codigopostal = p_codigopostal;
        entidadEN.Localidad = p_localidad;
        entidadEN.Provincia = p_provincia;
        entidadEN.Cifnif = p_cifnif;
        entidadEN.Telefonoalternativo = p_telefonoalternativo;
        //Call to EntidadRepository

        _IEntidadRepository.Editar (entidadEN);

        /*PROTECTED REGION END*/
}
}
}
