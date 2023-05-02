using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApplicationCore.Enumerated.TFM;
using TFMTFMGen.ApiTests.Models_REST.DTOA;

namespace TFMGen.ApiTests.Tests.Reserva
{
    [TestClass]
    public class Reserva
    {
        private IValoracionRepository repositoryValoracion;
        private IPagoRepository repositoryPago;
        private IUsuarioRegistradoRepository repositoryusuarioRegistrado;
        private IUsuarioRegistradoRepository repositoryUsuario;
        private IEventoRepository repositoryEvento;
        private IDiaSemanaRepository repositoryDiasSemana;
        private IEntidadRepository repositoryEntidad;
        private IHorarioRepository repositoryHorario;
        private IPistaRepository repositoryPista;
        private IRolRepository repositoryRol;
        private IReservaRepository repositoryReservas;
        private IInstalacionRepository repositoryInstalaciones;
        private IAsistenciaRepository repositoryAsistencia;

        private IMaterialRepository repositoryMaterial;
        private List<UsuarioRegistradoDTOA> usuariosRegistrados;
        private List<PagoDTOA> pagos;
        private List<AsitenciaDTOA> asistencias;
        private List<InstalacionDTOA> instalaciones;
        private List<EventoDTOA> eventos;
        private List<UsuarioRegistradoDTOA> usuarios;
        private List<ValoracionDTOA> valoraciones;
        private List<HorarioDTOA> horarios;
        private List<DiaSemanaDTOA> diasSemana;
        private List<EntidadDTOA> entidades;
        private List<PistaDTOA> pistas;
        private List<RolDTOA> roles;
        private List<ReservaDTOA> reservas;

        private List<MaterialDTOA> materiales;

        public Reserva()
        {
            repositoryPago = new PagoRepository();
            repositoryusuarioRegistrado = new UsuarioRegistradoRepository();
            repositoryAsistencia=new AsistenciaRepository();
            repositoryMaterial=new MaterialRepository();
            repositoryInstalaciones=new InstalacionRepository();
            repositoryValoracion = new ValoracionRepository();
            repositoryUsuario = new UsuarioRegistradoRepository();
            repositoryEvento = new EventoRepository();
            repositoryHorario = new HorarioRepository();
            repositoryDiasSemana = new DiaSemanaRepository();
            repositoryEntidad = new EntidadRepository();
            repositoryPista = new PistaRepository();
            repositoryRol = new RolRepository();
            repositoryReservas = new ReservaRepository();

            
            usuarios = repositoryUsuario.Listar().data;
            usuariosRegistrados=repositoryusuarioRegistrado.Listar().data;
            valoraciones = repositoryValoracion.Listartodas().data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;
            asistencias = repositoryAsistencia.Listartodos().data;
            instalaciones = repositoryInstalaciones.Listartodos().data;
            materiales = repositoryMaterial.Listartodos().data;
            pagos = repositoryPago.Listartodos().data;
        }
        [TestMethod]
        public void ListarTodos()
        {
            var result = repositoryReservas.Listartodos();
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void ObtenerReservas()
        {
            var result = repositoryReservas.ObtenerReservas(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarReservaUsuario()
        {
            var result = repositoryReservas.Listarreservasusuario();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ObtenerInscripciones()
        {
            var result = repositoryReservas.Reserva_obtenerinscripciones(reservas.Select(u => u.Idreserva).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Crear()
        {
            var usuario = usuarios.FirstOrDefault();
            var result = repositoryReservas.Crear(new Models.DTO.ReservaDTO()
            {
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                Email = usuario.Email,
                Telefono = usuario.Telefono,
                Cancelada = true,
                Usuario_oid = usuario.Idusuario,
                Pista_oid = pistas.Select(u => u.Idpista).FirstOrDefault(),
                Maxparticipantes = 10,
                Pago_oid = pagos.Select(u => u.Idpago).FirstOrDefault(),
                Horario_oid = horarios.Select(u => u.Idhorario).FirstOrDefault(),
                Tipo = TipoReservaEnum.reserva,
                Fecha=DateTime.Now,
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void InscribirsePartido()
        {
            var usuario = usuarios.FirstOrDefault();
            var reserva = repositoryReservas.Crear(new Models.DTO.ReservaDTO()
            {
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                Email = usuario.Email,
                Telefono = usuario.Telefono,
                Cancelada = true,
                Usuario_oid = usuario.Idusuario,
                Pista_oid = pistas.Select(u => u.Idpista).FirstOrDefault(),
                Maxparticipantes = 10,
                Pago_oid = pagos.Select(u => u.Idpago).FirstOrDefault(),
                Horario_oid = horarios.Select(u => u.Idhorario).FirstOrDefault(),
                Tipo = TipoReservaEnum.inscripcion,
                Fecha = DateTime.Now,
            });

            var result = repositoryReservas.Inscribirsepartido(reservas.Where(r=>r.Tipo == TipoReservaEnum.partido).Select(u => u.Idreserva).FirstOrDefault(),new List<int>() { reserva.data.Idreserva });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Cancelar()
        {
            var result = repositoryReservas.Cancelar(reservas.Select(u => u.Idreserva).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarPartidos()
        {
            var result = repositoryReservas.ListarPartidos();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarReservas()
        {
            var result = repositoryReservas.ListarReservas();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarInscripciones()
        {
            var result = repositoryReservas.ListarInscripciones();
            Assert.AreEqual(false, result.error);
        }
    }
}