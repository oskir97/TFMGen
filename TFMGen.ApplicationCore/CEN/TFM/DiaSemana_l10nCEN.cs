

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class DiaSemana_l10nCEN
 *
 */
public partial class DiaSemana_l10nCEN
{
private IDiaSemana_l10nRepository _IDiaSemana_l10nRepository;

public DiaSemana_l10nCEN(IDiaSemana_l10nRepository _IDiaSemana_l10nRepository)
{
        this._IDiaSemana_l10nRepository = _IDiaSemana_l10nRepository;
}

public IDiaSemana_l10nRepository get_IDiaSemana_l10nRepository ()
{
        return this._IDiaSemana_l10nRepository;
}

public int Crear (int p_diaSemana, int p_idioma, string p_nombre)
{
        DiaSemana_l10nEN diaSemana_l10nEN = null;
        int oid;

        //Initialized DiaSemana_l10nEN
        diaSemana_l10nEN = new DiaSemana_l10nEN ();

        if (p_diaSemana != -1) {
                // El argumento p_diaSemana -> Property diaSemana es oid = false
                // Lista de oids id
                diaSemana_l10nEN.DiaSemana = new TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN ();
                diaSemana_l10nEN.DiaSemana.Id = p_diaSemana;
        }


        if (p_idioma != -1) {
                // El argumento p_idioma -> Property idioma es oid = false
                // Lista de oids id
                diaSemana_l10nEN.Idioma = new TFMGen.ApplicationCore.EN.TFM.IdiomaEN ();
                diaSemana_l10nEN.Idioma.Ididioma = p_idioma;
        }

        diaSemana_l10nEN.Nombre = p_nombre;



        oid = _IDiaSemana_l10nRepository.Crear (diaSemana_l10nEN);
        return oid;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> Listar (int p_idIdioma)
{
        return _IDiaSemana_l10nRepository.Listar (p_idIdioma);
}
}
}
