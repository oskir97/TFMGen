using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;

namespace TFMGen.ApiTests.Tests.Usuario
{
    [TestClass]
    public class Usuario
    {
        private IRol_l10nRepository repositoryRoll10n;

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
        private IUsuarioRepository repositoryUser;
        private List<UsuarioDTOA> Users;
        private List<Rol_l10nDTOA> rolln10;
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

        public Usuario()
        {
            repositoryRoll10n = new Rol_l10nRepository();
            repositoryPagoTipo = new PagoTipoRepository();
            repositoryPago = new PagoRepository();
            repositoryValoracion = new ValoracionRepository();
            repositoryUsuario = new UsuarioRegistradoRepository();
            repositoryEvento = new EventoRepository();
            repositoryHorario = new HorarioRepository();
            repositoryDiasSemana = new DiaSemanaRepository();
            repositoryEntidad = new EntidadRepository();
            repositoryPista = new PistaRepository();
            repositoryRol = new RolRepository();
            repositoryReservas = new ReservaRepository();
            repositoryIdioma = new IdiomaRepository();
            repositoryUser= new UsuarioRepository();

            idiomas = repositoryIdioma.Listar().data;
            usuarios = repositoryUsuario.Listar().data;
            valoraciones = repositoryValoracion.Listar(usuarios.FirstOrDefault()?.Idusuario ?? 0).data;
            rolln10 = repositoryRoll10n.Listar(idiomas.FirstOrDefault()?.Ididioma ?? 0).data;
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
        public void Login()
        {
            var result = repositoryUser.Login(new Models.DTO.UsuarioDTO
            {
                Idusuario=usuarios.Select(u=>u.Idusuario).FirstOrDefault(),
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
       
            });
            Assert.AreEqual(false, result.error);
        }
       
    }
}