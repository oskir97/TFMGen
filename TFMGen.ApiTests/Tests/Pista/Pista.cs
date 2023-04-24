using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests.Pista
{
    [TestClass]
    public class Pista
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
        public Pista()
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
            var result = repositoryPista.Listartodas();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Listar()
        {
            var result = repositoryPista.Listar();
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void ListarEntidad()
        {
            var result = repositoryPista.ListarEntidad(entidades.Select(u => u.Identidad).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Buscar()
        {
            var result = repositoryPista.Buscar(pistas.Select(u=>u.Nombre).FirstOrDefault());
            //var result = repositoryPista.Buscar("");
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ObtenerPistasInstalacion()
        {
            var result = repositoryPista.Obtenerpistasinstalacion(instalaciones.Select(u => u.Idinstalacion).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Crear()
        {
            var result = repositoryPista.Crear(new Models.DTO.PistaDTO()
            {
                Idpista = 1,
                Nombre = "Pista de tenis",
                Ubicacion = "Calle Falsa 123",
                Imagen = "img.png",
                Maxreservas = 10,
                ReservasCreadas_oid = reservas.Select(u => u.Idreserva).ToList(),
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Instalacion_oid = instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(),
                EstadosPista_oid = 1,
                ValoracionesAPistas_oid = new List<int>() { 4, 5 },
                //Horarios= null,
                //Deporte_oid =,
                Visible = true,
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Editar()
        {
            var result = repositoryPista.Editar(pistas.Select(u => u.Idpista).FirstOrDefault(),new Models.DTO.PistaDTO()
            {
                Idpista = 1,
                Nombre = "Pista de tenis",
                Ubicacion = "Calle Falsa 123",
                Imagen = "img.png",
                Maxreservas = 10,
                ReservasCreadas_oid = reservas.Select(u => u.Idreserva).ToList(),
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Instalacion_oid = instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(),
                EstadosPista_oid = 1,
                ValoracionesAPistas_oid = new List<int>() { 4, 5 },
                //Horarios= null,
                //Deporte_oid =,
                Visible = true,
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Eliminar()
        {
            var result = repositoryPista.Eliminar(pistas.Select(u => u.Idpista).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ExisteReserva()
        {
            var result = repositoryPista.ExisteReserva(pistas.Select(u => u.Idpista).FirstOrDefault(),DateTime.Now);
            
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ExisteEvento()
        {
            var result = repositoryPista.ExisteEvento(pistas.Select(u => u.Idpista).FirstOrDefault(), DateTime.Now);

            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarHorariosDisponibles()
        {
            //var result = repositoryPista.Listarhorariosdisponibles(pistas.Select(u => u.Idpista).FirstOrDefault(), horarios.Select(u=>u.Inicio).FirstOrDefault());//MAL
            var result = repositoryPista.Listarhorariosdisponibles(pistas.Select(u => u.Idpista).FirstOrDefault(), DateTime.Now);
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void AsignarImagen()
        {
            var result = repositoryPista.Asignarimagen(pistas.Select(u => u.Idpista).FirstOrDefault(), "imagen.png");

            Assert.AreEqual(false, result.error);
        }
    }
}
