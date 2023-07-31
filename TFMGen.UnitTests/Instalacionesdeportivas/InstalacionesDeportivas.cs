using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFMGen.UnitTests.Instalaciones_deportivas
{
    [TestClass]
    public class InstalacionesDeportivas
    {
        Context db;

        public InstalacionesDeportivas()
        {
            this.db = new Context();    
        }

        [TestMethod]
        public void CrearInstalacion()
        {
            EntidadEN entidad = this.db.entidadcen.Listar(0,1).First();
            int idInstalacion = this.db.instalacioncen.Crear("Instalación de padel", entidad.Identidad,true,-0.4814900, 38.3451700, "666666666", "Calle padel", null, "03801", "Alcoy", "Alicante", null, "dasdasd@pruebas.com");
            InstalacionEN instalacionEn = this.db.instalacioncen.Obtener(idInstalacion);

            Assert.AreEqual(true, instalacionEn != null);
        }

        [TestMethod]
        public void CrearInstalacionSinNombre()
        {
            EntidadEN entidad = this.db.entidadcen.Listar(0, 1).First();
            int idInstalacion = this.db.instalacioncen.Crear(null, entidad.Identidad, true, -0.4814900, 38.3451700, "666666666", "Calle padel", null, "03801", "Alcoy", "Alicante", null, "dasdasd@pruebas.com");

            Assert.AreEqual(true, idInstalacion == -1);
        }

        [TestMethod]
        public void ModificarInstalacion()
        {
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            InstalacionEN instalacionAModificar = db.instalacioncen.Listar(entidadEN.Identidad).First();

            InstalacionEN instalacionENModificado = new InstalacionEN();
            instalacionENModificado.Idinstalacion = instalacionAModificar.Idinstalacion;
            instalacionENModificado.Nombre = "Pista modificada";
            instalacionENModificado.Telefono = "666777888";
            instalacionENModificado.Domicilio = "Calle padel";
            instalacionENModificado.Ubicacion = null;
            instalacionENModificado.Codigopostal = "03450";
            instalacionENModificado.Localidad = "Banyeres";
            instalacionENModificado.Provincia = "Alicante";
            instalacionENModificado.Telefonoalternativo = "999666111";


            this.db.instalacioncen.Editar(instalacionENModificado.Idinstalacion, instalacionENModificado.Nombre,
                instalacionENModificado.Telefono, instalacionENModificado.Domicilio, instalacionENModificado.Ubicacion,
                instalacionENModificado.Codigopostal, instalacionENModificado.Localidad, instalacionENModificado.Provincia, instalacionENModificado.Telefonoalternativo, -0.4814900, 38.3451700, "dasdasd@pruebas.com");

            Assert.AreEqual(instalacionENModificado, instalacionAModificar, "Instalación actualizada correctamente: ", instalacionAModificar);
        }

        [TestMethod, ExpectedException(typeof(DataLayerException))]
        public void EliminarInstalacion()
        {
            int instalacion_id = -1;

            this.db.instalacioncen.Eliminar(instalacion_id);

            Assert.AreEqual(-1, instalacion_id, "Descripcion de la instalación obligatoria");
        }
    }
}
