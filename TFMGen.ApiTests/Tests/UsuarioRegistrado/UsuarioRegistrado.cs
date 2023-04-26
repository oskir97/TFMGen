using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests.UsuarioRegistrado
{
    [TestClass]
    public class UsuarioRegistrado
    {
        private IUsuarioRegistradoRepository repository;
        private IEventoRepository repositoryEvento;
        private IDiaSemanaRepository repositoryDiasSemana;
        private IEntidadRepository repositoryEntidad;
        private IHorarioRepository repositoryHorario;
        private IPistaRepository repositoryPista;
        private IRolRepository repositoryRol;
        private IReservaRepository repositoryReservas;

        private List<EventoDTOA> eventos;
        private List<UsuarioRegistradoDTOA> usuarios;
        private List<HorarioDTOA> horarios;
        private List<DiaSemanaDTOA> diasSemana;
        private List<EntidadDTOA> entidades;
        private List<PistaDTOA> pistas;
        private List<RolDTOA> roles;
        private List<ReservaDTOA> reservas;

        public UsuarioRegistrado()
        {
            repository = new UsuarioRegistradoRepository();
            repositoryEvento = new EventoRepository();
            repositoryHorario = new HorarioRepository();
            repositoryDiasSemana = new DiaSemanaRepository();
            repositoryEntidad = new EntidadRepository();
            repositoryPista = new PistaRepository();
            repositoryRol = new RolRepository();
            repositoryReservas = new ReservaRepository();

            usuarios = repository.Listar().data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;
        }
        [TestMethod]
        public void Cambiarrol()
        {
            var result = repository.Cambiarrol(roles.FirstOrDefault().Idrol, usuarios.FirstOrDefault().Idusuario);
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void Crear()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            var result = repository.Crear(new Models.DTO.UsuarioDTO { Nombre = "Usuario de pruebas", Email = string.Format("pruebas{0}@pruebas.com", num), Domicilio = "Calle de pruebas", Telefono = "965554874", Fechanacimiento=Convert.ToDateTime("18/01/1990"), Alta = DateTime.Today, Apellidos = "Pruebas pruebas", Password = "123456", Rol_oid = roles.FirstOrDefault().Idrol, Codigopostal = "03440", Localidad = "Ibi", Provincia = "Alicante", Telefonoalternativo = "695874123", Entidad_oid = entidades.FirstOrDefault().Identidad });
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void Darsealta()
        {
            int idusuario = usuarios.FirstOrDefault().Idusuario;
            var result = repository.Darsealta(DateTime.Today, idusuario);
            Assert.AreEqual(DateTime.Today, repository.Obtenerusuario(idusuario).data.Alta);
        }

        [TestMethod]
        public void Darsebaja()
        {
            int idusuario = usuarios.FirstOrDefault().Idusuario;
            var result = repository.Darsebaja(DateTime.Today, idusuario);
            Assert.AreEqual(DateTime.Today, repository.Obtenerusuario(idusuario).data.Baja);
        }

        [TestMethod]
        public void Editar()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            var usuario = usuarios.Last();
            var result = repository.Editar(usuario.Idusuario, new Models.DTO.UsuarioDTO {Idusuario = usuario.Idusuario, Nombre = "Usuario de pruebas editado", Email = usuario.Email, Domicilio = "Calle de pruebas", Telefono = "965554874", Fechanacimiento = Convert.ToDateTime("18/01/1990"), Alta = DateTime.Today, Apellidos = "Pruebas pruebas", Password = "", Rol_oid = roles.FirstOrDefault().Idrol, Codigopostal = "01234", Localidad = "Ibi", Provincia = "Alicante", Telefonoalternativo = "695874123", Entidad_oid = entidades.FirstOrDefault().Identidad });
            Assert.AreEqual("Usuario de pruebas editado", result.data.Nombre);
        }

        [TestMethod]
        public void Eliminar()
        {
            var usuario = usuarios.Last();
            var result = repository.Eliminar(usuario.Idusuario);
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void Listar()
        {
            var result = repository.Listar();
            Assert.AreNotEqual(true, result.error);
            Assert.AreNotEqual(0, result.data.Count());
        }

        [TestMethod]
        public void Listaralumnosevento()
        {
            var result = repository.Listaralumnosevento(eventos.FirstOrDefault().Idevento);
            Assert.AreNotEqual(true, result.error);
        }

        [TestMethod]
        public void Listartecnicosevento()
        {
            var result = repository.Listartecnicosevento(eventos.FirstOrDefault().Idevento);
            Assert.AreNotEqual(true, result.error);
        }

        [TestMethod]
        public void Listarusuariospartido()
        {
            var result = repository.Listarusuariospartido(reservas.FirstOrDefault(r=>r.Tipo == ApplicationCore.Enumerated.TFM.TipoReservaEnum.partido).Idreserva);
            Assert.AreNotEqual(true, result.error);
        }

        [TestMethod]
        public void Obtener()
        {
            var result = repository.Obtener();
            Assert.AreEqual("omm35@gcloud.ua.es", result.data.Email);
        }

        [TestMethod]
        public void ObtenerAlumnos()
        {
            var result = repository.ObtenerAlumnos(eventos.FirstOrDefault().Idevento);
            Assert.AreNotEqual(true, result.error);
        }

        [TestMethod]
        public void ObtenerUsuarios()
        {
            var result = repository.ObtenerUsuarios(entidades.FirstOrDefault().Identidad);
            Assert.AreNotEqual(true, result.error);
        }

        [TestMethod]
        public void Obtenerusuario()
        {
            var result = repository.Obtenerusuario(usuarios.FirstOrDefault().Idusuario);
            Assert.AreNotEqual(true, result.error);
        }
    }
}