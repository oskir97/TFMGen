using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMTFMGen.ApiTests.Models_REST.DTOA;

namespace TFMGen.ApiTests.Tests.Asistencia
{
    [TestClass]
    public class Asistencia
    {
        private IValoracionRepository repositoryValoracion;
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

        public Asistencia()
        {
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
            valoraciones = repositoryValoracion.Listar(usuarios.FirstOrDefault()?.Idusuario ?? 0).data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;
            asistencias = repositoryAsistencia.Listar(usuarios.FirstOrDefault()?.Idusuario ?? 0).data;
            instalaciones = repositoryInstalaciones.Listar(entidades.FirstOrDefault()?.Identidad ?? 0).data;
            materiales = repositoryMaterial.Listar(instalaciones.FirstOrDefault()?.Idinstalacion ?? 0).data;
        }
        [TestMethod]
        public void ListarTodos()
        {
            var result = repositoryAsistencia.Listartodos();
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void ObtenerAsistencias()
        {
            var result = repositoryAsistencia.ObtenerAsistencias(usuariosRegistrados.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ObtenerAsistenciasEvento()
        {
            var result = repositoryAsistencia.ObtenerAsistenciasEvento(eventos.Select(u => u.Idevento).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void Listar()
        {
            var result = repositoryAsistencia.Listar(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        
        [TestMethod]
        public void Crear()
        {
            var result = repositoryAsistencia.Crear(new Models.DTO.AsitenciaDTO
            {

                Usuario_oid= usuarios.Select(u => u.Idusuario).FirstOrDefault(),
                Fecha=DateTime.Now,
                Asiste=true,
                Notas="Test Nota",
                Evento_oid= eventos.Select(u => u.Idevento).FirstOrDefault(),
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Editar()
        {
            var result = repositoryAsistencia.Editar(asistencias.Select(u => u.Idasitencia).FirstOrDefault(), new Models.DTO.AsitenciaDTO
            {

                Usuario_oid = usuarios.Select(u => u.Idusuario).FirstOrDefault(),
                Fecha = DateTime.Now,
                Asiste = true,
                Notas = "Test Nota",
                Evento_oid = eventos.Select(u => u.Idevento).FirstOrDefault(),
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Eliminar()
        {
            var result = repositoryAsistencia.Eliminar(asistencias.Select(u => u.Idasitencia).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
    }
}