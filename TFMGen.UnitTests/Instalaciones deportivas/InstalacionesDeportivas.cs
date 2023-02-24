using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.EN.TFM;
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
            EntidadEN entidad = this.db.entidadcen.Obtener(196609);
            int idInstalacion = this.db.instalacioncen.Crear("Instalación de padel", entidad.Identidad, "666666666", "Calle padel", null, "03801", "Alcoy", "Alicante", null);
            InstalacionEN instalacionEn = this.db.instalacioncen.Obtener(idInstalacion);

            Assert.AreEqual(true, instalacionEn != null);
        }
    }
}
