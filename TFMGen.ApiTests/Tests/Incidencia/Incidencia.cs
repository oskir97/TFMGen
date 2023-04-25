using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests.Incidencia
{
    [TestClass]
    public class Incidencia
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

        private IIncidenciaRepository repositoryIncidencia;

        private List<EventoDTOA> eventos;
        private List<UsuarioRegistradoDTOA> usuarios;
        private List<ValoracionDTOA> valoraciones;
        private List<HorarioDTOA> horarios;
        private List<DiaSemanaDTOA> diasSemana;
        private List<EntidadDTOA> entidades;
        private List<PistaDTOA> pistas;
        private List<RolDTOA> roles;
        private List<ReservaDTOA> reservas;

        private List<IncidenciaDTOA> incidencias;

        public Incidencia()
        {

            repositoryIncidencia=new IncidenciaRepository();

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

            incidencias = repositoryIncidencia.Listartodas().data;
        }
        [TestMethod]
        public void ListarTodas()
        {
            var result = repositoryIncidencia.Listartodas();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ObtenerIncidencias()
        {
            var result = repositoryIncidencia.ObtenerIncidencias(eventos.Select(u=>u.Idevento).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Listar()
        {
            var result = repositoryIncidencia.Listar(eventos.Select(u => u.Idevento).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Crear()
        {
            var result = repositoryIncidencia.Crear(new Models.DTO.IncidenciaDTO
            {
                Usuario_oid= usuarios.Select(u => u.Idusuario).FirstOrDefault(),
                Evento_oid= eventos.Select(u => u.Idevento).FirstOrDefault(),
                Asunto="IncidenciaTest",
                Descripcion="Test",
                Fechacancelada=DateTime.Now,
                Fechareemplazada=DateTime.Now.AddDays(1),
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Modificar()
        {
            var result = repositoryIncidencia.Modificar(incidencias.Select(u => u.Idincidencia).FirstOrDefault(), new Models.DTO.IncidenciaDTO
            {
                Usuario_oid = usuarios.Select(u => u.Idusuario).FirstOrDefault(),
                Evento_oid = eventos.Select(u => u.Idevento).FirstOrDefault(),
                Asunto = "IncidenciaTest",
                Descripcion = "Test",
                Fechacancelada = DateTime.Now,
                Fechareemplazada = DateTime.Now.AddDays(1),
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Eliminar()
        {
            var result = repositoryIncidencia.Eliminar(incidencias.Select(u => u.Idincidencia).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
    }
}