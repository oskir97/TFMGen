

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class PistaEstado_l10nCEN
 *
 */
public partial class PistaEstado_l10nCEN
{
private IPistaEstado_l10nRepository _IPistaEstado_l10nRepository;

public PistaEstado_l10nCEN(IPistaEstado_l10nRepository _IPistaEstado_l10nRepository)
{
        this._IPistaEstado_l10nRepository = _IPistaEstado_l10nRepository;
}

public IPistaEstado_l10nRepository get_IPistaEstado_l10nRepository ()
{
        return this._IPistaEstado_l10nRepository;
}

public int Crear (string p_nombre, int p_idioma, int p_estadoPista)
{
        PistaEstado_l10nEN pistaEstado_l10nEN = null;
        int oid;

        //Initialized PistaEstado_l10nEN
        pistaEstado_l10nEN = new PistaEstado_l10nEN ();
        pistaEstado_l10nEN.Nombre = p_nombre;


        if (p_idioma != -1) {
                // El argumento p_idioma -> Property idioma es oid = false
                // Lista de oids id
                pistaEstado_l10nEN.Idioma = new TFMGen.ApplicationCore.EN.TFM.IdiomaEN ();
                pistaEstado_l10nEN.Idioma.Ididioma = p_idioma;
        }


        if (p_estadoPista != -1) {
                // El argumento p_estadoPista -> Property estadoPista es oid = false
                // Lista de oids id
                pistaEstado_l10nEN.EstadoPista = new TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN ();
                pistaEstado_l10nEN.EstadoPista.Idestado = p_estadoPista;
        }



        oid = _IPistaEstado_l10nRepository.Crear (pistaEstado_l10nEN);
        return oid;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> Listar (int p_idIdioma)
{
        return _IPistaEstado_l10nRepository.Listar (p_idIdioma);
}
public System.Collections.Generic.IList<PistaEstado_l10nEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<PistaEstado_l10nEN> list = null;

        list = _IPistaEstado_l10nRepository.Listartodos (first, size);
        return list;
}
}
}
