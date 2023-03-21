using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class RolAssemblerDTO {
public static IList<RolEN> ConvertList (IList<RolDTO> lista)
{
        IList<RolEN> result = new List<RolEN>();
        foreach (RolDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RolEN Convert (RolDTO dto)
{
        RolEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RolEN ();



                        newinstance.Idrol = dto.Idrol;
                        newinstance.Nombre = dto.Nombre;
                        if (dto.Usuarios_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IUsuarioRepository usuarioCAD = new TFMGen.Infraestructure.Repository.TFM.UsuarioRepository ();

                                newinstance.Usuarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                                foreach (int entry in dto.Usuarios_oid) {
                                        newinstance.Usuarios.Add (usuarioCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.Rol_l10n != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IRol_l10nRepository rol_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.Rol_l10nRepository ();

                                newinstance.Rol_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN>();
                                foreach (Rol_l10nDTO entry in dto.Rol_l10n) {
                                        newinstance.Rol_l10n.Add (Rol_l10nAssemblerDTO.Convert (entry));
                                }
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
