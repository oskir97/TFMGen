

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class PagoTipo_l10nCEN
 *
 */
public partial class PagoTipo_l10nCEN
{
private IPagoTipo_l10nRepository _IPagoTipo_l10nRepository;

public PagoTipo_l10nCEN(IPagoTipo_l10nRepository _IPagoTipo_l10nRepository)
{
        this._IPagoTipo_l10nRepository = _IPagoTipo_l10nRepository;
}

public IPagoTipo_l10nRepository get_IPagoTipo_l10nRepository ()
{
        return this._IPagoTipo_l10nRepository;
}

public int Crear (string p_nombre, int p_pagoTipo, int p_idioma)
{
        PagoTipo_l10nEN pagoTipo_l10nEN = null;
        int oid;

        //Initialized PagoTipo_l10nEN
        pagoTipo_l10nEN = new PagoTipo_l10nEN ();
        pagoTipo_l10nEN.Nombre = p_nombre;


        if (p_pagoTipo != -1) {
                // El argumento p_pagoTipo -> Property pagoTipo es oid = false
                // Lista de oids id
                pagoTipo_l10nEN.PagoTipo = new TFMGen.ApplicationCore.EN.TFM.PagoTipoEN ();
                pagoTipo_l10nEN.PagoTipo.Idtipo = p_pagoTipo;
        }


        if (p_idioma != -1) {
                // El argumento p_idioma -> Property idioma es oid = false
                // Lista de oids id
                pagoTipo_l10nEN.Idioma = new TFMGen.ApplicationCore.EN.TFM.IdiomaEN ();
                pagoTipo_l10nEN.Idioma.Ididioma = p_idioma;
        }



        oid = _IPagoTipo_l10nRepository.Crear (pagoTipo_l10nEN);
        return oid;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> Listar (int p_idIdioma)
{
        return _IPagoTipo_l10nRepository.Listar (p_idIdioma);
}
}
}
