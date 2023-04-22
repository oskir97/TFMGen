using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests.UsuarioRegistrado
{
    [TestClass]
    public class Horarios
    {
        private IValoracionRepository repositoryValoracion;
        private IUsuarioRegistradoRepository repositoryUsuario;
        private IEventoRepository repositoryEvento;
        private IDiaSemanaRepository repositoryDiasSemana;
        private IEntidadRepository repositoryEntidad;
        private IHorarioRepository repositoryHorario;
        private IPistaRepository repositoryPista;
        private IRolRepository repositoryRol;
        private IReservaRepository repositoryReservas;
        private List<EventoDTOA> eventos;
        private List<UsuarioRegistradoDTOA> usuarios;
        private List<ValoracionDTOA> valoraciones;
        private List<HorarioDTOA> horarios;
        private List<DiaSemanaDTOA> diasSemana;
        private List<EntidadDTOA> entidades;
        private List<PistaDTOA> pistas;
        private List<RolDTOA> roles;
        private List<ReservaDTOA> reservas;
        public Horarios()
        {
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
            valoraciones = repositoryValoracion.Listar(usuarios.FirstOrDefault()?.Idusuario ?? 0).data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;
        }
        [TestMethod]
        public void ListarTodos()
        {
            var result = repositoryHorario.Listartodos();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Listar()
        {
            var result = repositoryHorario.Listar(pistas.Select(u => u.Idpista).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Crear()
        {
            var result = repositoryHorario.Crear(new Models.DTO.HorarioDTO
            {
                Idhorario = 1,
                Pista_oid = pistas.Select(u => u.Idpista).FirstOrDefault(),
                Reserva_oid = reservas.Select(u => u.Idreserva).ToList(),
                Eventos_oid = eventos.Select(u => u.Idevento).ToList(),
                //DiaSemana_oid = horarios.Select(u => u.ObtenerDiasSemana).ToList(),
                Inicio = DateTime.Now,
                Fin = DateTime.Now.AddMinutes(60),
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Editar()
        {
            var result = repositoryHorario.Editar(horarios.Select(u => u.Idhorario).FirstOrDefault(), new Models.DTO.HorarioDTO
            {
                Idhorario = 1,
                Pista_oid = pistas.Select(u => u.Idpista).FirstOrDefault(),
                Reserva_oid = reservas.Select(u => u.Idreserva).ToList(),
                Eventos_oid = eventos.Select(u => u.Idevento).ToList(),
                //DiaSemana_oid = horarios.Select(u => u.ObtenerDiasSemana).ToList(),
                Inicio = DateTime.Now,
                Fin = DateTime.Now.AddMinutes(60),
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Eliminar()
        {
            var result = repositoryHorario.Eliminar(horarios.Select(u => u.Idhorario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
    }
}