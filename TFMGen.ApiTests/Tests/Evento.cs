using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests
{
    [TestClass]
    public class Evento
    {
        private IEventoRepository repository;
        private IUsuarioRegistradoRepository repositoryUsuario;
        private IDiaSemanaRepository repositoryDiasSemana;
        private IEntidadRepository repositoryEntidad;
        private IHorarioRepository repositoryHorario;
        private IPistaRepository repositoryPista;
        private List<EventoDTOA> eventos;
        private List<UsuarioRegistradoDTOA> usuarios;
        private List<HorarioDTOA> horarios;
        private List<DiaSemanaDTOA> diasSemana;
        private List<EntidadDTOA> entidades;
        private List<PistaDTOA> pistas;

        public Evento()
        {
            repository = new EventoRepository();
            repositoryUsuario = new UsuarioRegistradoRepository();
            repositoryHorario = new HorarioRepository();
            repositoryDiasSemana = new DiaSemanaRepository();
            repositoryEntidad = new EntidadRepository();
            repositoryPista = new PistaRepository();

            eventos = repository.Listartodos().data;
            usuarios = repositoryUsuario.Listar().data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
        }
        [TestMethod]
        public void Asignarusuario()
        {
            var result = repository.Asignarusuario(eventos.Select(e=>e.Idevento).FirstOrDefault(), new List<int> { usuarios.Select(u=>u.Idusuario).FirstOrDefault()});
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void Crear()
        {
            var result = repository.Crear(new EventoDTO {Nombre = "Nuevo evento", Descripcion = "Descripcion del evento", Entidad_oid = entidades.Select(e=>e.Identidad).FirstOrDefault(), Horarios_oid = new List<int> { horarios.Select(h=>h.Idhorario).First()}, DiasSemana_oid = new List<int> { diasSemana.Select(h => h.Iddiasemana).First() }, Activo = true, Plazas = 100 });
            Assert.AreNotEqual(null, result.data);
        }

        [TestMethod]
        public void Editar()
        {
            var result = repository.Editar(eventos.Select(e=>e.Idevento).FirstOrDefault(),new EventoDTO { Nombre = "Evento editado", Descripcion = "Descripcion del evento", Entidad_oid = entidades.Select(e => e.Identidad).FirstOrDefault(), Horarios_oid = new List<int> { horarios.Select(h => h.Idhorario).First() }, DiasSemana_oid = new List<int> { diasSemana.Select(h => h.Iddiasemana).First() }, Activo = true, Plazas = 100 });
            Assert.AreEqual("Evento editado", result.data.Nombre);
        }

        [TestMethod]
        public void Eliminar()
        {
            var result = repository.Eliminar(eventos.FirstOrDefault().Idevento);
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void Listar()
        {
            var result = repository.Listar(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void ListarEntidad()
        {
            var result = repository.Listarentidad(entidades.Select(u => u.Identidad).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void Obtener()
        {
            var evento = eventos.FirstOrDefault();
            var result = repository.Obtener(evento.Idevento);
            Assert.AreEqual(evento.Descripcion, result.data.Descripcion);
        }

        [TestMethod]
        public void ObtenerEventosImpartidos()
        {
            var result = repository.ObtenerEventosImpartidos(usuarios.FirstOrDefault().Idusuario);
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void ObtenerEventosInscrito()
        {
            var result = repository.ObtenerEventosInscrito(usuarios.FirstOrDefault().Idusuario);
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void Obtenereventospista()
        {
            var result = repository.Obtenereventospista(pistas.FirstOrDefault().Idpista, Convert.ToDateTime("01/01/2020"), diasSemana.FirstOrDefault().Iddiasemana);
            Assert.AreEqual(false, result.error);
        }
    }
}