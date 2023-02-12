

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class Deporte_l10nCEN
 *
 */
public partial class Deporte_l10nCEN
{
private IDeporte_l10nRepository _IDeporte_l10nRepository;

public Deporte_l10nCEN(IDeporte_l10nRepository _IDeporte_l10nRepository)
{
        this._IDeporte_l10nRepository = _IDeporte_l10nRepository;
}

public IDeporte_l10nRepository get_IDeporte_l10nRepository ()
{
        return this._IDeporte_l10nRepository;
}

public int Crear (string p_nombre, int p_idioma, int p_deporte)
{
        Deporte_l10nEN deporte_l10nEN = null;
        int oid;

        //Initialized Deporte_l10nEN
        deporte_l10nEN = new Deporte_l10nEN ();
        deporte_l10nEN.Nombre = p_nombre;


        if (p_idioma != -1) {
                // El argumento p_idioma -> Property idioma es oid = false
                // Lista de oids id
                deporte_l10nEN.Idioma = new TFMGen.ApplicationCore.EN.TFM.IdiomaEN ();
                deporte_l10nEN.Idioma.Ididioma = p_idioma;
        }


        if (p_deporte != -1) {
                // El argumento p_deporte -> Property deporte es oid = false
                // Lista de oids id
                deporte_l10nEN.Deporte = new TFMGen.ApplicationCore.EN.TFM.DeporteEN ();
                deporte_l10nEN.Deporte.Iddeporte = p_deporte;
        }



        oid = _IDeporte_l10nRepository.Crear (deporte_l10nEN);
        return oid;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> Listar (int p_idIdioma)
{
        return _IDeporte_l10nRepository.Listar (p_idIdioma);
}
}
}
