
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Horario_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class HorarioCEN
{
public int Crear (Nullable<DateTime> p_inicio, Nullable<DateTime> p_fin, int p_pista, System.Collections.Generic.IList<int> p_diaSemana)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Horario_crear_customized) ENABLED START*/

        HorarioEN horarioEN = null;

        int oid;

        //Initialized HorarioEN
        horarioEN = new HorarioEN ();
        horarioEN.Inicio = p_inicio;

        horarioEN.Fin = p_fin;


        if (p_pista != -1) {
                horarioEN.Pista = new TFMGen.ApplicationCore.EN.TFM.PistaEN ();
                horarioEN.Pista.Idpista = p_pista;
        }


        horarioEN.DiaSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
        if (p_diaSemana != null) {
                foreach (int item in p_diaSemana) {
                        TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN en = new TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN ();
                        en.Id = item;
                        horarioEN.DiaSemana.Add (en);
                }
        }

        else{
                horarioEN.DiaSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
        }

        //Call to HorarioRepository

        oid = _IHorarioRepository.Crear (horarioEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
