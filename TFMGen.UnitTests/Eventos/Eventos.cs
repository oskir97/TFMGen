using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.Exceptions;

namespace TFMGen.UnitTests.Eventos
{
    [TestClass]
    public class Eventos
    {
        Context db;

        public Eventos()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void CrearEvento()
        {

            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            PistaEN pistaEN = db.pistacen.Listar().First();
            DeporteEN deporteEN = db.deportecen.Listar(0, 1).First();
            IList<int> horariosEN = db.horariocen.Listar(pistaEN.Idpista).Select(x => x.Idhorario).ToList();
            IList<int> diasSemanaEN = db.diasemanacen.Listar(0, 7).Select(x => x.Iddiasemana).ToList();

            UsuarioEN usuario = this.db.usuariocen.Listar(0, 1).First();
       

            int idEvento = this.db.eventocen.Crear("Nuevo evento", "Descripcion del evento", entidadEN.Identidad, true, 15, deporteEN.Iddeporte);
            EventoEN eventoEN = this.db.eventocen.Obtener(idEvento);

            Assert.AreEqual(true, eventoEN != null);
        }

        [TestMethod]
        public void InscribirseEnEvento()
        {
        }

        [TestMethod, ExpectedException(typeof(DataLayerException))]
        public void CancelarEvento()
        {
            int evento_id = -1;

            this.db.eventocen.Eliminar(evento_id);

            Assert.AreEqual(-1, evento_id, "Descripcion de la instalación obligatoria");
        }
    }
}
