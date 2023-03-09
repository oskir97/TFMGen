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
            InstalacionEN instalacionEn = this.db.instalacioncen.Listar(entidad.Identidad).First();

            int idPista = this.db.pistacen.Crear("prueba", 1, entidad.Identidad, estadosPista.Idestado, null, "Tibi", false);
            PistaEN Pista = this.db.pistacen.Obtener(idPista);

            List<int> listaPista = new List<int>();
            listaPista.Add(idPista);

            this.db.instalacioncp.Asignarpista(instalacionEn.Idinstalacion, listaPista);

            InstalacionEN instalacionModificada = this.db.instalacioncen.Obtener(instalacionEn.Idinstalacion);

            Assert.IsTrue(instalacionModificada.Pistas.Contains(Pista));

        }

       
    }
}
