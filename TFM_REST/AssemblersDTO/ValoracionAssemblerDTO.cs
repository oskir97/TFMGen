using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class ValoracionAssemblerDTO {
public static IList<ValoracionEN> ConvertList (IList<ValoracionDTO> lista)
{
        IList<ValoracionEN> result = new List<ValoracionEN>();
        foreach (ValoracionDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static ValoracionEN Convert (ValoracionDTO dto)
{
        ValoracionEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new ValoracionEN ();



                        newinstance.Idvaloracion = dto.Idvaloracion;
                        newinstance.Estrellas = dto.Estrellas;
                        newinstance.Comentario = dto.Comentario;
                        if (dto.Usuario_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Usuario = usuarioCAD.ReadOIDDefault (dto.Usuario_oid);
                        }
                        if (dto.Entidad_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEntidadRepository entidadCAD = new TFMGen.Infraestructure.Repository.TFM.EntidadRepository ();

                                newinstance.Entidad = entidadCAD.ReadOIDDefault (dto.Entidad_oid);
                        }
                        if (dto.Instalacion_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IInstalacionRepository instalacionCAD = new TFMGen.Infraestructure.Repository.TFM.InstalacionRepository ();

                                newinstance.Instalacion = instalacionCAD.ReadOIDDefault (dto.Instalacion_oid);
                        }
                        if (dto.Pista_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaRepository pistaCAD = new TFMGen.Infraestructure.Repository.TFM.PistaRepository ();

                                newinstance.Pista = pistaCAD.ReadOIDDefault (dto.Pista_oid);
                        }
                        if (dto.Tecnico_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Tecnico = usuarioCAD.ReadOIDDefault (dto.Tecnico_oid);
                        }
                        if (dto.Evento_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Evento = eventoCAD.ReadOIDDefault (dto.Evento_oid);
                        }
                        newinstance.Fecha = dto.Fecha;
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
