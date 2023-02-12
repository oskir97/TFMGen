

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class Rol_l10nCEN
 *
 */
public partial class Rol_l10nCEN
{
private IRol_l10nRepository _IRol_l10nRepository;

public Rol_l10nCEN(IRol_l10nRepository _IRol_l10nRepository)
{
        this._IRol_l10nRepository = _IRol_l10nRepository;
}

public IRol_l10nRepository get_IRol_l10nRepository ()
{
        return this._IRol_l10nRepository;
}

public int Crear (string p_nombre, int p_rol, int p_idioma)
{
        Rol_l10nEN rol_l10nEN = null;
        int oid;

        //Initialized Rol_l10nEN
        rol_l10nEN = new Rol_l10nEN ();
        rol_l10nEN.Nombre = p_nombre;


        if (p_rol != -1) {
                // El argumento p_rol -> Property rol es oid = false
                // Lista de oids id
                rol_l10nEN.Rol = new TFMGen.ApplicationCore.EN.TFM.RolEN ();
                rol_l10nEN.Rol.Idrol = p_rol;
        }


        if (p_idioma != -1) {
                // El argumento p_idioma -> Property idioma es oid = false
                // Lista de oids id
                rol_l10nEN.Idioma = new TFMGen.ApplicationCore.EN.TFM.IdiomaEN ();
                rol_l10nEN.Idioma.Ididioma = p_idioma;
        }



        oid = _IRol_l10nRepository.Crear (rol_l10nEN);
        return oid;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> Listar (int p_idIdioma)
{
        return _IRol_l10nRepository.Listar (p_idIdioma);
}
}
}
