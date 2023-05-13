using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.CP.TFM;
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
            InstalacionEN instalacionEn = this.db.instalacioncen.Listar(entidad.Identidad).First();

            int idPista = this.db.pistacen.Crear("prueba", 1, entidad.Identidad, estadosPista.Idestado, null, "Tibi", false, -1,10.45);
            PistaEN Pista = this.db.pistacen.Obtener(idPista);

            this.db.instalacioncp.Asignarpista(instalacionEn.Idinstalacion, new List<int> { idPista });

            InstalacionEN instalacionModificada = this.db.instalacioncen.Obtener(instalacionEn.Idinstalacion);
            var instalacionCen = this.db.pistacen.Obtenerpistasinstalacion(instalacionModificada.Idinstalacion);


            Assert.IsTrue(instalacionCen.Contains(Pista));
        }

        [TestMethod]
        public void crearPistaSinNombre()
        {
            EntidadEN entidad = this.db.entidadcen.Listar(0, 1).First();
            int idPista = this.db.instalacioncen.Crear(null, entidad.Identidad, "666666666", "Calle padel", null, "03801", "Alcoy", "Alicante", null, true);


            Assert.AreEqual(true, idPista == -1);
        }

        [TestMethod]
        public void crearPistaenInstalacionNoExiste()
        {

            try
            {
                EntidadEN entidad = this.db.entidadcen.Listar(0, 1).First();
                PistaEstadoEN estadosPista = this.db.pistaestadocen.Listar(0, 1).First();

                int idPista = this.db.pistacen.Crear("prueba", 1, entidad.Identidad, estadosPista.Idestado, null, "Tibi", false, -1, 10.45);

                this.db.instalacioncp.Asignarpista(-23123, new List<int> { idPista });

            } catch (Exception Ex ) 
            {
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod]
        public void EliminarPista()
        {
            EntidadEN entidad = this.db.entidadcen.Listar(0, 1).First();
            PistaEstadoEN estadosPista = this.db.pistaestadocen.Listar(0, 1).First();
            InstalacionEN instalacionEn = this.db.instalacioncen.Listar(entidad.Identidad).First();

            int idPista = this.db.pistacen.Crear("prueba", 1, entidad.Identidad, estadosPista.Idestado, null, "Tibi", false, -1, 10.45);
            PistaEN Pista = this.db.pistacen.Obtener(idPista);

            this.db.pistacen.Eliminar(idPista);

            PistaEN pistaError = this.db.pistacen.Obtener(idPista);
            Assert.AreEqual(pistaError, null);
        }

    }
}
