using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.CP.TFM;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.Enumerated.TFM;

namespace TFMGen.UnitTests.Partidos
{

    [TestClass]
    public class Partidos
    {
        Context db;
        public Partidos()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void CrearInscribirsePartido()
        {
            DeporteEN deporteEN = this.db.deportecen.Listar(0, -1).First(d => d.Nombre.Contains("Baloncesto"));
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            PistaEN pistaEn = db.pistacen.Listar().First();
            InstalacionEN instalacionEN = db.instalacioncen.Listar(entidadEN.Identidad).First();
            HorarioEN horarioEN = db.horariocen.Listar(pistaEn.Idpista).First();
            var horario = db.horariocen.Listar(1);
            var usuarios = db.usuariocen.Listar(0, 1);
            var usuario = usuarios.First();

            // Crear Partido
            int idpartido = db.reservacen.Crear(usuario.Nombre, usuario.Apellidos, usuario.Email, usuario.Telefono, false, pistaEn.Idpista, 4, horarioEN.Idhorario, DateTime.Now.AddDays(1), TipoReservaEnum.partido, usuario.Idusuario, deporteEN.Iddeporte, -1, NivelPartidoEnum.medio, -1, "Partido de padel para 4 personas", null);

            //Inscribirse Partido
            int idinscripcion = db.reservacen.Crear(usuario.Nombre, usuario.Apellidos, usuario.Email, usuario.Telefono, 
                false, pistaEn.Idpista, 4, horarioEN.Idhorario, DateTime.Now.AddDays(1), 
                TipoReservaEnum.inscripcion, usuario.Idusuario, deporteEN.Iddeporte, -1, null, -1, null, null);

            db.reservacp.Inscribirsepartido(idpartido, new List<int> { idinscripcion });

            //Pagos
            var pago = db.pagotipocen.Listar(0, 1).First();
            int idpago = db.pagocen.Crear(3.00, 3.63, 0.63, pago.Idtipo, Convert.ToDateTime("12/02/2023 08:00:00"), idinscripcion, null);
            db.pagocen.Crear(3.00, 3.63, 0.63, pago.Idtipo, DateTime.Now, idinscripcion, null);

            ReservaEN partidoCreado = db.reservacen.Obtener(idpartido);
            //ReservaEN inscripcionCreado = db.reservacen.Obtener(idinscripcion);
            var resultado = db.reservacen.Obtenerinscripciones(idpartido);

            Assert.AreEqual(partidoCreado.Tipo, TipoReservaEnum.partido);
            Assert.AreEqual(partidoCreado.Pista.Idpista, pistaEn.Idpista);
            Assert.AreEqual(partidoCreado.Deporte.Iddeporte, deporteEN.Iddeporte);
            Assert.AreEqual(partidoCreado.Nivelpartido, NivelPartidoEnum.medio);
        }

        [TestMethod]
        public void CancelarPartido()
        {
            var partido = db.reservacen.Listartodos(0, -1).First();
            db.reservacen.Cancelar(partido.Idreserva);

            ReservaEN partidoCancelado = db.reservacen.Obtener(partido.Idreserva);

            Assert.AreEqual(partidoCancelado.Cancelada, true);
        }
    }
}
