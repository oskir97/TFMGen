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
    public class Pistas
    {
        Context db;

        public Pistas()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void CrearPistaenInstalacion()
        {
            EntidadEN entidad = this.db.entidadcen.Listar(0, 1).First();
            PistaEstadoEN estadosPista = this.db.pistaestadocen.Listar(0, 1).First();

            int idInstalacion = this.db.instalacioncen.Crear("Instalación de padel", entidad.Identidad, "666666666", "Calle padel", null, "03801", "Alcoy", "Alicante", null, true);
            InstalacionEN instalacionEn = this.db.instalacioncen.Obtener(idInstalacion);
            int idPista = this.db.pistacen.Crear("prueba", 1, entidad.Identidad, estadosPista.Idestado, null, "Tibi", false);
            PistaEN pista = this.db.pistacen.Obtener(idPista);

            instalacionEn.Pistas.Add(pista);



            Assert.IsTrue(instalacionEn.Pistas.Contains(pista));

        }

       
    }
}
