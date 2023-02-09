

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class InstalacionCEN
 *
 */
public partial class InstalacionCEN
{
private IInstalacionRepository _IInstalacionRepository;

public InstalacionCEN(IInstalacionRepository _IInstalacionRepository)
{
        this._IInstalacionRepository = _IInstalacionRepository;
}

public IInstalacionRepository get_IInstalacionRepository ()
{
        return this._IInstalacionRepository;
}

public int Crear (string p_nombre, int p_entidad)
{
        InstalacionEN instalacionEN = null;
        int oid;

        //Initialized InstalacionEN
        instalacionEN = new InstalacionEN ();
        instalacionEN.Nombre = p_nombre;


        if (p_entidad != -1) {
                // El argumento p_entidad -> Property entidad es oid = false
                // Lista de oids idinstalacion
                instalacionEN.Entidad = new TFMGen.ApplicationCore.EN.TFM.EntidadEN ();
                instalacionEN.Entidad.Identidad = p_entidad;
        }



        oid = _IInstalacionRepository.Crear (instalacionEN);
        return oid;
}

public void Editar (int p_Instalacion_OID, string p_nombre)
{
        InstalacionEN instalacionEN = null;

        //Initialized InstalacionEN
        instalacionEN = new InstalacionEN ();
        instalacionEN.Idinstalacion = p_Instalacion_OID;
        instalacionEN.Nombre = p_nombre;
        //Call to InstalacionRepository

        _IInstalacionRepository.Editar (instalacionEN);
}

public void Eliminar (int idinstalacion
                      )
{
        _IInstalacionRepository.Eliminar (idinstalacion);
}

public InstalacionEN Obtener (int idinstalacion
                              )
{
        InstalacionEN instalacionEN = null;

        instalacionEN = _IInstalacionRepository.Obtener (idinstalacion);
        return instalacionEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> Listar (int p_idEntidad)
{
        return _IInstalacionRepository.Listar (p_idEntidad);
}
}
}
