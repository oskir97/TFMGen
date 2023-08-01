using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests.Valoraciones
{
    [TestClass]
    public class Valoracion
    {
        private IValoracionRepository repository;
        private IInstalacionRepository repositoryInstalaciones;
        private IUsuarioRegistradoRepository repositoryUsuario;
        private IEventoRepository repositoryEvento;
        private IDiaSemanaRepository repositoryDiasSemana;
        private IEntidadRepository repositoryEntidad;
        private IHorarioRepository repositoryHorario;
        private IPistaRepository repositoryPista;
        private IRolRepository repositoryRol;
        private IReservaRepository repositoryReservas;
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
        public Valoracion()
        {
            repositoryInstalaciones = new InstalacionRepository();
            repository = new ValoracionRepository();
            repositoryUsuario = new UsuarioRegistradoRepository();
            repositoryEvento = new EventoRepository();
            repositoryHorario = new HorarioRepository();
            repositoryDiasSemana = new DiaSemanaRepository();
            repositoryEntidad = new EntidadRepository();
            repositoryPista = new PistaRepository();
            repositoryRol = new RolRepository();
            repositoryReservas = new ReservaRepository();

            usuarios = repositoryUsuario.Listar().data;
            valoraciones = repository.Listar(usuarios.FirstOrDefault()?.Idusuario ?? 0).data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;
            instalaciones = repositoryInstalaciones.Listar(entidades.FirstOrDefault()?.Identidad ?? 0).data;
        }
        [TestMethod]
        public void ListarTodas()
        {
            var result = repository.Listartodas();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Listar()
        {
            var result = repository.Listar(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarTecnico()//NSE
        {
            var result = repository.Listartecnico(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarEntidad()
        {
            var result = repository.Listarentidad(entidades.Select(u => u.Identidad).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarPista()
        {
            var result = repository.Listarpista(pistas.Select(u => u.Idpista).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ObtenerValoracionesRealizadas()
        {
            var result=repository.ObtenerValoracionesRealizadas(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Crear()
        {
            var result = repository.Crear(new Models.DTO.ValoracionDTO
            {
                //Idvaloracion = 1,
                Estrellas = 4,
                Comentario = "Excelente servicio",
                Usuario_oid = usuarios.Select(u => u.Idusuario).FirstOrDefault(),
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Instalacion_oid = instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(),
                Pista_oid = pistas.Select(u => u.Idpista).FirstOrDefault(),
                Tecnico_oid = usuarios.Select(u => u.Idusuario).FirstOrDefault(),
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Borrar()
        {
            var result = repository.Eliminar(valoraciones.Select(u => u.Idvaloracion).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Editar()
        {
            var result1 = repository.Crear(new Models.DTO.ValoracionDTO
            {
                //Idvaloracion = 1,
                Estrellas = 4,
                Comentario = "Excelente servicio",
                Usuario_oid = usuarios.Select(u => u.Idusuario).FirstOrDefault(),
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Instalacion_oid = instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(),
                Pista_oid = pistas.Select(u => u.Idpista).FirstOrDefault(),
                Tecnico_oid = usuarios.Select(u => u.Idusuario).FirstOrDefault(),
            });
            var result = repository.Editar(result1.data.Idvaloracion, new Models.DTO.ValoracionDTO
            {
                Idvaloracion = result1.data.Idvaloracion,
                Estrellas = 2,
                Comentario = "Horrible servicio",
                Fecha = null
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ValorarPista()
        {
            var result = repository.Valorarpista(valoraciones.Select(u => u.Idvaloracion).FirstOrDefault(), pistas.Select(u => u.Idpista).FirstOrDefault());//KEK
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ValorarEntidad()
        {
            var result = repository.Valorarentidad(valoraciones.Select(u => u.Idvaloracion).FirstOrDefault(), entidades.Select(u => u.Identidad).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ValorarTecnico()
        {
            var result = repository.Valorartecnico(valoraciones.Select(u => u.Idvaloracion).FirstOrDefault(), usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ValorarInstalacion()
        {
            var result = repository.Valorarinstalacion(valoraciones.Select(u => u.Idvaloracion).FirstOrDefault(), instalaciones.Select(u => u.Idinstalacion).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
    }
}
