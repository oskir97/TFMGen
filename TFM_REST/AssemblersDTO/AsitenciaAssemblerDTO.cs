using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class AsitenciaAssemblerDTO {
public static IList<AsitenciaEN> ConvertList (IList<AsitenciaDTO> lista)
{
        IList<AsitenciaEN> result = new List<AsitenciaEN>();
        foreach (AsitenciaDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static AsitenciaEN Convert (AsitenciaDTO dto)
{
        AsitenciaEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new AsitenciaEN ();



                        newinstance.Idasitencia = dto.Idasitencia;
                        if (dto.Usuario_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Usuario = usuarioCAD.ReadOIDDefault (dto.Usuario_oid);
                        }
                        newinstance.Fecha = dto.Fecha;
                        newinstance.Asiste = dto.Asiste;
                        newinstance.Notas = dto.Notas;
                        if (dto.Evento_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Evento = eventoCAD.ReadOIDDefault (dto.Evento_oid);
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
