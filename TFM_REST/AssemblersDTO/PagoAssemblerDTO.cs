using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class PagoAssemblerDTO {
public static IList<PagoEN> ConvertList (IList<PagoDTO> lista)
{
        IList<PagoEN> result = new List<PagoEN>();
        foreach (PagoDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PagoEN Convert (PagoDTO dto)
{
        PagoEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PagoEN ();



                        newinstance.Idpago = dto.Idpago;
                        newinstance.Subtotal = dto.Subtotal;
                        newinstance.Total = dto.Total;
                        newinstance.Iva = dto.Iva;
                        if (dto.Tipo_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPagoTipoRepository pagoTipoCAD = new TFMGen.Infraestructure.Repository.TFM.PagoTipoRepository ();

                                newinstance.Tipo = pagoTipoCAD.ReadOIDDefault (dto.Tipo_oid);
                        }
                        newinstance.Fecha = dto.Fecha;
                        if (dto.Reserva_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IReservaRepository reservaCAD = new TFMGen.Infraestructure.Repository.TFM.ReservaRepository ();

                                newinstance.Reserva = reservaCAD.ReadOIDDefault (dto.Reserva_oid);
                        }
                        newinstance.Token = dto.Token;
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
