
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Material_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class MaterialCEN
{
public void Editar (int p_Material_OID, string p_nombre, double p_precio, string p_proveedor, string p_descripcion, int p_numexistencias, string p_numeroproveedor, string p_numeroalternativoproveedor, string p_emailproveedor)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Material_editar_customized) START*/

        MaterialEN materialEN = null;

        //Initialized MaterialEN
        materialEN = new MaterialEN ();
        materialEN.Idmaterial = p_Material_OID;
        materialEN.Nombre = p_nombre;
        materialEN.Precio = p_precio;
        materialEN.Proveedor = p_proveedor;
        materialEN.Descripcion = p_descripcion;
        materialEN.Numexistencias = p_numexistencias;
        materialEN.Numeroproveedor = p_numeroproveedor;
        materialEN.Numeroalternativoproveedor = p_numeroalternativoproveedor;
        materialEN.Emailproveedor = p_emailproveedor;
        //Call to MaterialRepository

        _IMaterialRepository.Editar (materialEN);

        /*PROTECTED REGION END*/
}
}
}
