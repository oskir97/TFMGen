using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests.Pago
{
    [TestClass]
    public class Pago
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
        private IIdiomaRepository repositoryIdioma;
        private IPagoRepository repositoryPago;
        private IPagoTipoRepository repositoryPagoTipo;

        private List<PagoTipoDTOA> pagosTipo;
        private List<PagoDTOA> pagos;
        private List<EventoDTOA> eventos;
        private List<UsuarioRegistradoDTOA> usuarios;
        private List<ValoracionDTOA> valoraciones;
        private List<HorarioDTOA> horarios;
        private List<DiaSemanaDTOA> diasSemana;
        private List<EntidadDTOA> entidades;
        private List<PistaDTOA> pistas;
        private List<RolDTOA> roles;
        private List<ReservaDTOA> reservas;
        private List<IdiomaDTOA> idiomas;
        public Pago()
        {
            repositoryPagoTipo = new PagoTipoRepository();
            repositoryPago =new PagoRepository();
            repositoryValoracion = new ValoracionRepository();
            repositoryUsuario = new UsuarioRegistradoRepository();
            repositoryEvento = new EventoRepository();
            repositoryHorario = new HorarioRepository();
            repositoryDiasSemana = new DiaSemanaRepository();
            repositoryEntidad = new EntidadRepository();
            repositoryPista = new PistaRepository();
            repositoryRol = new RolRepository();
            repositoryReservas = new ReservaRepository();
            repositoryIdioma=new IdiomaRepository();

            
            idiomas = repositoryIdioma.Listar().data;
            usuarios = repositoryUsuario.Listar().data;
            valoraciones = repositoryValoracion.Listar(usuarios.FirstOrDefault()?.Idusuario ?? 0).data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;
            pagos = repositoryPago.Listar(reservas.FirstOrDefault()?.Idreserva ?? 0).data;
            pagosTipo = repositoryPagoTipo.Listar().data;
        }
        [TestMethod]
        public void Listar()
        {
            var result = repositoryPago.Listar(reservas.Select(u=>u.Idreserva).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ListarTodos()
        {
            var result = repositoryPago.Listartodos();
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Crear()
        {
            var result = repositoryPago.Crear(new Models.DTO.PagoDTO
            {
                Subtotal= 78,
                Tipo_oid= pagosTipo.Select(u=>u.Idtipo).FirstOrDefault(),
                Total= 22,
                Iva=2,
                Fecha=DateTime.Now,
                //Token= "",
                Reserva_oid = reservas.Select(u => u.Idreserva).FirstOrDefault(),
            });
            Assert.AreEqual(false, result.error);
        }
    }
}