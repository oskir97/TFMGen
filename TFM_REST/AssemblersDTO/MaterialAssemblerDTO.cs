using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class MaterialAssemblerDTO {
public static IList<MaterialEN> ConvertList (IList<MaterialDTO> lista)
{
        IList<MaterialEN> result = new List<MaterialEN>();
        foreach (MaterialDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static MaterialEN Convert (MaterialDTO dto)
{
        MaterialEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new MaterialEN ();



                        newinstance.Idmaterial = dto.Idmaterial;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Descripcion = dto.Descripcion;
                        newinstance.Precio = dto.Precio;
                        newinstance.Proveedor = dto.Proveedor;
                        if (dto.Instalacion_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IInstalacionRepository instalacionCAD = new TFMGen.Infraestructure.Repository.TFM.InstalacionRepository ();

                                newinstance.Instalacion = instalacionCAD.ReadOIDDefault (dto.Instalacion_oid);
                        }
                        newinstance.Numexistencias = dto.Numexistencias;
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
