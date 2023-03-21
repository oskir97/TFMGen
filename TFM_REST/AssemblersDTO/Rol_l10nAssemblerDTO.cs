using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class Rol_l10nAssemblerDTO {
public static IList<Rol_l10nEN> ConvertList (IList<Rol_l10nDTO> lista)
{
        IList<Rol_l10nEN> result = new List<Rol_l10nEN>();
        foreach (Rol_l10nDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static Rol_l10nEN Convert (Rol_l10nDTO dto)
{
        Rol_l10nEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new Rol_l10nEN ();



                        newinstance.Nombre = dto.Nombre;
                        newinstance.Id = dto.Id;
                        if (dto.Rol_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IRolRepository rolCAD = new TFMGen.Infraestructure.Repository.TFM.RolRepository ();

                                newinstance.Rol = rolCAD.ReadOIDDefault (dto.Rol_oid);
                        }
                        if (dto.Idioma_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IIdiomaRepository idiomaCAD = new TFMGen.Infraestructure.Repository.TFM.IdiomaRepository ();

                                newinstance.Idioma = idiomaCAD.ReadOIDDefault (dto.Idioma_oid);
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
