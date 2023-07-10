using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class HorarioAssemblerDTO {
public static IList<HorarioEN> ConvertList (IList<HorarioDTO> lista)
{
        IList<HorarioEN> result = new List<HorarioEN>();
        foreach (HorarioDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static HorarioEN Convert (HorarioDTO dto)
{
        HorarioEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new HorarioEN ();



                        newinstance.Idhorario = dto.Idhorario;
                        newinstance.Inicio = dto.Inicio;
                        newinstance.Fin = dto.Fin;
                        if (dto.Pistas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaRepository pistaCAD = new TFMGen.Infraestructure.Repository.TFM.PistaRepository ();

                                newinstance.Pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                                foreach (int entry in dto.Pistas_oid) {
                                        newinstance.Pistas.Add (pistaCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Reserva_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IReservaRepository reservaCAD = new TFMGen.Infraestructure.Repository.TFM.ReservaRepository ();

                                newinstance.Reserva = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                                foreach (int entry in dto.Reserva_oid) {
                                        newinstance.Reserva.Add (reservaCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.DiaSemana_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDiaSemanaRepository diaSemanaCAD = new TFMGen.Infraestructure.Repository.TFM.DiaSemanaRepository ();

                                newinstance.DiaSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
                                foreach (int entry in dto.DiaSemana_oid) {
                                        newinstance.DiaSemana.Add (diaSemanaCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Eventos_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                                foreach (int entry in dto.Eventos_oid) {
                                        newinstance.Eventos.Add (eventoCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Entidad_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEntidadRepository entidadCAD = new TFMGen.Infraestructure.Repository.TFM.EntidadRepository ();

                                newinstance.Entidad = entidadCAD.ReadOIDDefault (dto.Entidad_oid);
                        }
                }
        }
        catch (Exception)
        {
                throw;
        }
        return newinstance;
}
}
}
