﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Tests.Horarios;

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
        private IPistaEstadoRepository repositoryEstados;


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
        private List<PistaEstadoDTOA> pistaEstados;
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
            repositoryEstados = new PistaEstadoRepository();

            usuarios = repositoryUsuario.Listar().data;
            valoraciones = repository.Listartodas().data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;
            instalaciones = repositoryInstalaciones.Listartodos().data;
            pistaEstados = repositoryEstados.Listar().data;
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
                Nombre = "Pista de tenis",
                Ubicacion = "Calle Falsa 123",
                Imagen = "img.png",
                Maxreservas = 10,
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Instalacion_oid = instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(),
                EstadosPista_oid = pistaEstados.Select(p=>p.Idestado).FirstOrDefault(),
                //Horarios= null,
                //Deporte_oid =,
                Visible = true,
                Precio = Convert.ToDecimal(10.00)
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
                EstadosPista_oid = pistaEstados.Select(p => p.Idestado).FirstOrDefault(),
                ValoracionesAPistas_oid = new List<int>() { 4, 5 },
                //Horarios= null,
                //Deporte_oid =,
                Visible = true,
                Precio = Convert.ToDecimal(10.00)
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Eliminar()
        {
            var result1 = repositoryPista.Crear(new Models.DTO.PistaDTO()
            {
                Nombre = "Pista de tenis",
                Ubicacion = "Calle Falsa 123",
                Imagen = "img.png",
                Maxreservas = 10,
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Instalacion_oid = instalaciones.Select(u => u.Idinstalacion).FirstOrDefault(),
                EstadosPista_oid = pistaEstados.Select(p => p.Idestado).FirstOrDefault(),
                //Horarios= null,
                //Deporte_oid =,
                Visible = true,
                Precio = Convert.ToDecimal(10.00)
            });
            var result = repositoryPista.Eliminar(result1.data.Idpista);
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
            var result = repositoryPista.ExisteEvento(pistas.First().Idpista, DateTime.Now);

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
        [TestMethod]
        public void ObtenerPistaHorario()
        {
            var horario = repositoryHorario.Crear(new Models.DTO.HorarioDTO
            {
                Idhorario = 1,
                Pista_oid = pistas.Select(u => u.Idpista).FirstOrDefault(),
                Reserva_oid = reservas.Select(u => u.Idreserva).ToList(),
                Eventos_oid = eventos.Select(u => u.Idevento).ToList(),
                //DiaSemana_oid = horarios.Select(u => u.ObtenerDiasSemana).ToList(),
                Inicio = DateTime.Now,
                Fin = DateTime.Now.AddMinutes(60),
            });

            var result = repositoryPista.ObtenerPistaHorario(horario.data.Idhorario);

            Assert.AreEqual(false, result.error);
        }
    }
}
