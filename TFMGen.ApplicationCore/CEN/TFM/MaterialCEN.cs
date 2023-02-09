

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class MaterialCEN
 *
 */
public partial class MaterialCEN
{
private IMaterialRepository _IMaterialRepository;

public MaterialCEN(IMaterialRepository _IMaterialRepository)
{
        this._IMaterialRepository = _IMaterialRepository;
}

public IMaterialRepository get_IMaterialRepository ()
{
        return this._IMaterialRepository;
}

public void Editar (int p_Material_OID, string p_nombre, decimal p_precio, string p_proveedor)
{
        MaterialEN materialEN = null;

        //Initialized MaterialEN
        materialEN = new MaterialEN ();
        materialEN.Idmaterial = p_Material_OID;
        materialEN.Nombre = p_nombre;
        materialEN.Precio = p_precio;
        materialEN.Proveedor = p_proveedor;
        //Call to MaterialRepository

        _IMaterialRepository.Editar (materialEN);
}

public void Eliminar (int idmaterial
                      )
{
        _IMaterialRepository.Eliminar (idmaterial);
}

public MaterialEN Obtener (int idmaterial
                           )
{
        MaterialEN materialEN = null;

        materialEN = _IMaterialRepository.Obtener (idmaterial);
        return materialEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.MaterialEN> Listar (int p_idInstalacion)
{
        return _IMaterialRepository.Listar (p_idInstalacion);
}
}
}
