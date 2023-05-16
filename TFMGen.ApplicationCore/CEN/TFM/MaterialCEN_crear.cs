
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Material_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class MaterialCEN
{
public int Crear (string p_nombre, double p_precio, string p_proveedor, int p_instalacion, string p_descripcion, int p_numexistencias, string p_numeroproveedor, string p_numeroalternativoproveedor, string p_emailproveedor, string p_urlventa)
{
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Material_crear_customized) ENABLED START*/

            MaterialEN materialEN = null;

        int oid;

        //Initialized MaterialEN
        materialEN = new MaterialEN ();
        materialEN.Nombre = p_nombre;

        materialEN.Precio = p_precio;

        materialEN.Proveedor = p_proveedor;


        if (p_instalacion != -1) {
                materialEN.Instalacion = new TFMGen.ApplicationCore.EN.TFM.InstalacionEN ();
                materialEN.Instalacion.Idinstalacion = p_instalacion;
        }

        materialEN.Descripcion = p_descripcion;

        materialEN.Numexistencias = p_numexistencias;

        materialEN.Numeroproveedor = p_numeroproveedor;

        materialEN.Numeroalternativoproveedor = p_numeroalternativoproveedor;

        materialEN.Emailproveedor = p_emailproveedor;

        materialEN.Urlventa = p_urlventa;

        //Call to MaterialRepository

        oid = _IMaterialRepository.Crear (materialEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
