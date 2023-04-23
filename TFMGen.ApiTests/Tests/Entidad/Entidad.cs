using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests.Entidad
{
    [TestClass]
    public class Entidad
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
        public Entidad()
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
        public void Listar()
        {
            var result = repositoryEntidad.Listar();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Editar()
        {
            var result = repositoryEntidad.Editar(entidades.Select(u => u.Identidad).FirstOrDefault(), new Models.DTO.EntidadDTO
            {
            Identidad = 1,
            Nombre = "Mi entidad",
            Email = "mi.entidad@ejemplo.com",
            Telefono = "123456789",
            Domicilio = "Mi calle 123",
            Cifnif = "01234567X",
            Codigopostal = "08001",
            Localidad = "Barcelona",
            Provincia = "Barcelona",
            Imagen="Imagen.png",
            Configuracion="???",
            Alta=DateTime.Now.AddDays(-400),
            Baja=DateTime.Now.AddDays(400),
        });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void AsignarImagen()
        {
            var result = repositoryEntidad.Asignarimagen(entidades.Select(u => u.Identidad).FirstOrDefault(),"imagen.png");
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void DarseBaja()
        {
            var result = repositoryEntidad.Darsebaja(entidades.Select(u => u.Identidad).FirstOrDefault(), DateTime.Today);
            Assert.AreEqual(false, result.error);//No funciona
        }


        public void Configurar()
        {
            var result = repositoryEntidad.Configurar(entidades.Select(u => u.Identidad).FirstOrDefault(), "Configuracion");
            Assert.AreEqual(false, result.error);
        }
    }
}