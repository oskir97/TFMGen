using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.UnitTests.Asistencias
{
    [TestClass]
    public class Asistencias
    {
        Context db;

        public Asistencias()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void RegistrarAsistencia()
        {
            UsuarioEN usuario = this.db.usuariocen.Listar(0, 1).First();
            DateTime date = DateTime.Now;
            int idAsistencia = this.db.asitenciacen.Crear(usuario.Idusuario, date, true, "Notas");
            AsitenciaEN asistenciaEn = this.db.asitenciacen.Obtener(idAsistencia);

            Assert.AreEqual(true, asistenciaEn != null);
        }

        [TestMethod]
        public void ListarAsistenciasDeUsuario()
        {
            UsuarioEN usuario = this.db.usuariocen.Listar(0, 1).First();
            IList<AsitenciaEN> asistenciaEn = this.db.asitenciacen.Listar(usuario.Idusuario);

            Assert.AreEqual(true, asistenciaEn.Count > 0);
        }
    }
}
