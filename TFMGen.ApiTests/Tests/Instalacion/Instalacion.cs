using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMTFMGen.ApiTests.Models_REST.DTOA;

namespace TFMGen.ApiTests.Tests.Instalacion
{
    [TestClass]
    public class Instalacion
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

        public Instalacion()
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
            var result = repositoryInstalaciones.Listartodos();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Listar()
        {
            var result = repositoryInstalaciones.Listar(entidades.Select(u => u.Identidad).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        
        [TestMethod]
        public void Crear()
        {
            var result = repositoryInstalaciones.Crear(new Models.DTO.InstalacionDTO
            {
                Pistas_oid= new List<int>(){ pistas.Select(u => u.Idpista).FirstOrDefault()},
                Nombre = "Instalacion Pruebas",
                Telefono = "693335784",
                Telefonoalternativo = "987445612",
                Domicilio = "Calle de pruebas",
                Ubicacion = "Inventada",
                //Materiales=instalaciones.Select(u => u.ObtenerMateriales),
                Entidad_oid =entidades.Select(u=>u.Identidad).FirstOrDefault(),
                Visible=true,
            });
            Assert.AreEqual("Instalacion Pruebas", result.data.Nombre);
        }
        [TestMethod]
        public void Editar()
        {
            var result = repositoryInstalaciones.Editar(instalaciones.Select(u=>u.Idinstalacion).FirstOrDefault(), new Models.DTO.InstalacionDTO
            {
                Pistas_oid = new List<int>() { pistas.Select(u => u.Idpista).FirstOrDefault() },
                Nombre = "Instalacion Pruebas editada",
                Telefono = "693335784",
                Telefonoalternativo = "987445612",
                Domicilio = "Calle de pruebas",
                Ubicacion = "Inventada",
                //Materiales=instalaciones.Select(u => u.ObtenerMateriales),
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Visible = true,
            });
            Assert.AreEqual("Instalacion Pruebas editada", result.data.Nombre);
        }
        [TestMethod]
        public void Eliminar()
        {
            var result = repositoryInstalaciones.Eliminar(instalaciones.Select(u => u.Idinstalacion).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void AsignarPista()
        {
            var result = repositoryInstalaciones.Asignarpista(instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(), new List<int>
            {
                pistas.Select(u => u.Idpista).FirstOrDefault()
            });
            //var result = repositoryInstalaciones.Asignarpista(pistas.Select(u => u.ObtenerInstalaciones.Idinstalacion).FirstOrDefault(), pistas.Select(u=>u.Idpista).ToList());

            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void AsignarImagen()
        {
            var result = repositoryInstalaciones.Asignarimagen(instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(), "imagen.png");
            Assert.AreEqual(false, result.error);
        }
    }
}