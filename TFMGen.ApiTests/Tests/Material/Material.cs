using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMTFMGen.ApiTests.Models_REST.DTOA;

namespace TFMGen.ApiTests.Tests.Material
{
    [TestClass]
    public class Material
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
        private IInstalacionRepository repositoryInstalaciones;

        private IMaterialRepository repositoryMaterial;
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

        public Material()
        {

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
            valoraciones = repositoryValoracion.Listar(usuarios.FirstOrDefault()?.Idusuario ?? 0).data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;

            instalaciones = repositoryInstalaciones.Listar(entidades.FirstOrDefault()?.Identidad ?? 0).data;
            materiales = repositoryMaterial.Listar(instalaciones.FirstOrDefault()?.Idinstalacion ?? 0).data;
        }
        [TestMethod]
        public void ListarTodos()
        {
            var result = repositoryMaterial.Listartodos();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Listar()
        {
            var result = repositoryMaterial.Listar(instalaciones.Select(u=>u.Idinstalacion).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        
        [TestMethod]
        public void Crear()
        {
            var result = repositoryMaterial.Crear(new Models.DTO.MaterialDTO
            {
                Nombre="Balon",
                Precio=20,
                Proveedor="PEPE",
                Instalacion_oid= instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(),
                Numexistencias=2,
                UrlVenta="1234",
                Numeroproveedor="78934789",
                Numeroalternativoproveedor="24323424",
                Emailproveedor="proveedorTest@gmail.com",
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Editar()
        {
            var result = repositoryMaterial.Editar(materiales.Select(u => u.Idmaterial).FirstOrDefault(), new Models.DTO.MaterialDTO
            {
                Nombre = "Balon",
                Precio = 20,
                Proveedor = "PEPE",
                Instalacion_oid = instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(),
                Numexistencias = 2,
                UrlVenta = "1234",
                Numeroproveedor = "78934789",
                Numeroalternativoproveedor = "24323424",
                Emailproveedor = "proveedorTest@gmail.com",
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Eliminar()
        {
            var result = repositoryMaterial.Eliminar(materiales.Select(u => u.Idmaterial).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
    }
}