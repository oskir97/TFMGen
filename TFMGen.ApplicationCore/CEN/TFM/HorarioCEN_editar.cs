
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Horario_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class HorarioCEN
{
public void Editar (int p_Horario_OID, Nullable<DateTime> p_inicio, Nullable<DateTime> p_fin, int p_pista, System.Collections.Generic.IList<int> p_diaSemana)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Horario_editar_customized) ENABLED START*/

        HorarioEN horarioEN = null;

        //Initialized HorarioEN
        horarioEN = new HorarioEN ();
        horarioEN.Idhorario = p_Horario_OID;
        horarioEN.Inicio = p_inicio;
        horarioEN.Fin = p_fin;
        if (p_pista != -1) {
                horarioEN.Pista = new TFMGen.ApplicationCore.EN.TFM.PistaEN ();
                horarioEN.Pista.Idpista = p_pista;
        }
        if (p_diaSemana != null) {
                horarioEN.DiaSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
                foreach (int item in p_diaSemana) {
                        TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN en = new TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN ();
                        en.Iddiasemana = item;
                        horarioEN.DiaSemana.Add (en);
                }
        }
        else{
                horarioEN.DiaSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
        }
        //Call to HorarioRepository

        _IHorarioRepository.Editar (horarioEN);

        /*PROTECTED REGION END*/
}
}
}
