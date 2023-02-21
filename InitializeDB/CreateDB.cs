
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.Infraestructure.Repository.TFM;
using TFMGen.Infraestructure.CP;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.CP.TFM;
using TFMGen.Infraestructure.Repository;
using System.Net.Http.Headers;
using Antlr.Runtime.Tree;
using TFMGen.ApplicationCore.Enumerated.TFM;
using TFMGen.Infraestructure.EN.TFM;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        try
        {
                // Initialising  CENs
                UsuarioRepository usuariorepository = new UsuarioRepository ();
                UsuarioCEN usuariocen = new UsuarioCEN (usuariorepository);
                ReservaRepository reservarepository = new ReservaRepository ();
                ReservaCEN reservacen = new ReservaCEN (reservarepository);
                PistaRepository pistarepository = new PistaRepository ();
                PistaCEN pistacen = new PistaCEN (pistarepository);
                AsitenciaRepository asitenciarepository = new AsitenciaRepository ();
                AsitenciaCEN asitenciacen = new AsitenciaCEN (asitenciarepository);
                NotificacionRepository notificacionrepository = new NotificacionRepository ();
                NotificacionCEN notificacioncen = new NotificacionCEN (notificacionrepository);
                RolRepository rolrepository = new RolRepository ();
                RolCEN rolcen = new RolCEN (rolrepository);
                EntidadRepository entidadrepository = new EntidadRepository ();
                EntidadCEN entidadcen = new EntidadCEN (entidadrepository);
                InstalacionRepository instalacionrepository = new InstalacionRepository ();
                InstalacionCEN instalacioncen = new InstalacionCEN (instalacionrepository);
                MaterialRepository materialrepository = new MaterialRepository ();
                MaterialCEN materialcen = new MaterialCEN (materialrepository);
                PistaEstadoRepository pistaestadorepository = new PistaEstadoRepository ();
                PistaEstadoCEN pistaestadocen = new PistaEstadoCEN (pistaestadorepository);
                ValoracionRepository valoracionrepository = new ValoracionRepository ();
                ValoracionCEN valoracioncen = new ValoracionCEN (valoracionrepository);
                PagoRepository pagorepository = new PagoRepository ();
                PagoCEN pagocen = new PagoCEN (pagorepository);
                PagoTipoRepository pagotiporepository = new PagoTipoRepository ();
                PagoTipoCEN pagotipocen = new PagoTipoCEN (pagotiporepository);
                IdiomaRepository idiomarepository = new IdiomaRepository ();
                IdiomaCEN idiomacen = new IdiomaCEN (idiomarepository);
                DeporteRepository deporterepository = new DeporteRepository ();
                DeporteCEN deportecen = new DeporteCEN (deporterepository);
                HorarioRepository horariorepository = new HorarioRepository ();
                HorarioCEN horariocen = new HorarioCEN (horariorepository);
                PistaEstado_l10nRepository pistaestado_l10nrepository = new PistaEstado_l10nRepository ();
                PistaEstado_l10nCEN pistaestado_l10ncen = new PistaEstado_l10nCEN (pistaestado_l10nrepository);
                Deporte_l10nRepository deporte_l10nrepository = new Deporte_l10nRepository ();
                Deporte_l10nCEN deporte_l10ncen = new Deporte_l10nCEN (deporte_l10nrepository);
                Rol_l10nRepository rol_l10nrepository = new Rol_l10nRepository ();
                Rol_l10nCEN rol_l10ncen = new Rol_l10nCEN (rol_l10nrepository);
                PagoTipo_l10nRepository pagotipo_l10nrepository = new PagoTipo_l10nRepository ();
                PagoTipo_l10nCEN pagotipo_l10ncen = new PagoTipo_l10nCEN (pagotipo_l10nrepository);
                DiaSemanaRepository diasemanarepository = new DiaSemanaRepository ();
                DiaSemanaCEN diasemanacen = new DiaSemanaCEN (diasemanarepository);
                DiaSemana_l10nRepository diasemana_l10nrepository = new DiaSemana_l10nRepository ();
                DiaSemana_l10nCEN diasemana_l10ncen = new DiaSemana_l10nCEN (diasemana_l10nrepository);
                EventoRepository eventorepository = new EventoRepository ();
                EventoCEN eventocen = new EventoCEN (eventorepository);
                IncidenciaRepository incidenciarepository = new IncidenciaRepository ();
                IncidenciaCEN incidenciacen = new IncidenciaCEN (incidenciarepository);

                // Initialising  CPs
                SessionCPNHibernate session = new SessionCPNHibernate ();
                UnitOfWorkRepository unitRep = new UnitOfWorkRepository ();
                UsuarioCP usuariocp = new UsuarioCP (session, unitRep);
                ReservaCP reservacp = new ReservaCP (session, unitRep);
                PistaCP pistacp = new PistaCP (session, unitRep);
                AsitenciaCP asitenciacp = new AsitenciaCP (session, unitRep);
                NotificacionCP notificacioncp = new NotificacionCP (session, unitRep);
                RolCP rolcp = new RolCP (session, unitRep);
                EntidadCP entidadcp = new EntidadCP (session, unitRep);
                InstalacionCP instalacioncp = new InstalacionCP (session, unitRep);
                MaterialCP materialcp = new MaterialCP (session, unitRep);
                PistaEstadoCP pistaestadocp = new PistaEstadoCP (session, unitRep);
                ValoracionCP valoracioncp = new ValoracionCP (session, unitRep);
                PagoCP pagocp = new PagoCP (session, unitRep);
                PagoTipoCP pagotipocp = new PagoTipoCP (session, unitRep);
                IdiomaCP idiomacp = new IdiomaCP (session, unitRep);
                DeporteCP deportecp = new DeporteCP (session, unitRep);
                HorarioCP horariocp = new HorarioCP (session, unitRep);
                PistaEstado_l10nCP pistaestado_l10ncp = new PistaEstado_l10nCP (session, unitRep);
                Deporte_l10nCP deporte_l10ncp = new Deporte_l10nCP (session, unitRep);
                Rol_l10nCP rol_l10ncp = new Rol_l10nCP (session, unitRep);
                PagoTipo_l10nCP pagotipo_l10ncp = new PagoTipo_l10nCP (session, unitRep);
                DiaSemanaCP diasemanacp = new DiaSemanaCP (session, unitRep);
                DiaSemana_l10nCP diasemana_l10ncp = new DiaSemana_l10nCP (session, unitRep);
                EventoCP eventocp = new EventoCP (session, unitRep);
                IncidenciaCP incidenciacp = new IncidenciaCP (session, unitRep);


                /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/

                // You must write the initialisation of the entities inside the PROTECTED comments.
                // IMPORTANT:please do not delete them.

                //Idiomas

                IdiomaCEN idioma = new IdiomaCEN (idiomarepository);
                var esp = idioma.Crear ("Español", "es-ES");
                var ingles = idioma.Crear ("Inglés", "en-US");
                var valen = idioma.Crear ("Valenciano", "ca-ES");

                //Roles

                RolCEN rol = new RolCEN (rolrepository);
                var rolAdmin = rol.Crear ("Administrador");
                var rolEntrenador = rol.Crear ("Entrenador");
                var rolUsuario = rol.Crear ("Usuario");

                //Roles traducidos

                Rol_l10nCEN rolL10N = new Rol_l10nCEN (rol_l10nrepository);
                rolL10N.Crear ("Administrador", rolAdmin, esp);
                rolL10N.Crear ("Administrator", rolAdmin, ingles);
                rolL10N.Crear ("Administrador", rolAdmin, valen);

                rolL10N.Crear ("Entrenador", rolEntrenador, esp);
                rolL10N.Crear ("Coach", rolEntrenador, ingles);
                rolL10N.Crear ("Entrenador", rolEntrenador, valen);

                rolL10N.Crear ("Usuario", rolUsuario, esp);
                rolL10N.Crear ("User", rolUsuario, ingles);
                rolL10N.Crear ("Usuari", rolUsuario, valen);

                //Usuarios
                UsuarioCEN usuario = new UsuarioCEN (usuariorepository);
                var idusuario = usuario.Crear ("Usuario", "omm35@gcloud.ua.es", "Gran via 33", "645325495", Convert.ToDateTime ("18/01/1968"), Convert.ToDateTime ("2/11/2022 12:46:33"), "Usuario", "123456", rolUsuario, "03440", "Ibi", "Alicante", null);
                var idusuario2 = usuario.Crear ("Usuario2", "usuario@pruebas.es", "Gran via 33", "645325495", Convert.ToDateTime ("18/01/1980"), Convert.ToDateTime ("3/11/2022 12:46:33"), "Usuario2", "123456", rolUsuario, "03801", "Alcoy", "Alicante", null);
                var idtecnico = usuario.Crear ("Administrador", "admin@pruebas.es", "Gran via 33", "645325495", Convert.ToDateTime ("18/01/1968"), Convert.ToDateTime ("2/11/2022 12:46:33"), "Administrador Pruebas", "123456", rolAdmin, "03440", "Ibi", "Alicante", null);
                usuario.Crear ("Entrenador", "entrenador@pruebas.es", "Gran via 33", "645325495", Convert.ToDateTime ("18/01/1968"), Convert.ToDateTime ("2/11/2022 12:46:33"), "Entrenador Pruebas", "123456", rolEntrenador, "03440", "Ibi", "Alicante", null);

                var usuarioEn = usuario.Obtener (idusuario);

                //Asitencia

                AsitenciaCEN asistencia = new AsitenciaCEN (asitenciarepository);
                asistencia.Crear (idusuario, Convert.ToDateTime ("12/02/2023 18:00:00"), true, "Se ha esforzado mucho en esta clase. Progresa adecuadamente.");

                //Entidad

                EntidadCEN entidad = new EntidadCEN (entidadrepository);
                var entidadPublica = entidad.Crear ("Ayuntamiento de San Vicente", "sanvicente@ayuntamiento.com", "659874158", "Avenidad Mayor Nº 89", Convert.ToDateTime ("2/11/2023 12:46:33"), "03009", "San Vicente del Raspeig", "Alicante", "A45697898", null, null);
                var entidadPrivada = entidad.Crear ("PadelMania San Vicente", "info@padelmaniasanvi.com", "659874158", "Avenidad del padel Nº45", Convert.ToDateTime ("2/11/2023 12:46:33"), "03009", "San Vicente del Raspeig", "Alicante", "C98789852", null, null);

                //Instalacion deportiva

                InstalacionCEN instalacion = new InstalacionCEN (instalacionrepository);
                var polideportivo = instalacion.Crear ("Polideportivo de San Vicente", entidadPublica, "968887541", "Calle San Lucas Nº 45", null, "03009", "San Vicente del Raspeig", "Alicante", "698572147");
                var pavellon = instalacion.Crear ("Pavellón Área Norte", entidadPublica, "965874123", "Calle Estadio Nº0", null, "03009", "San Vicente del Raspeig", "Alicante", "698254715");

                //Deporte

                DeporteCEN deporte = new DeporteCEN (deporterepository);
                var futbol = deporte.Crear ("Fútbol", "Deporte de pies");
                var basket = deporte.Crear ("Baloncesto", "Deporte de manos");
                var padel = deporte.Crear ("Pádel", "Deporte de raqueta");

                //Deporte traducidos

                Deporte_l10nCEN deporteL10N = new Deporte_l10nCEN (deporte_l10nrepository);
                deporteL10N.Crear ("Fútbol", esp, futbol);
                deporteL10N.Crear ("Football", ingles, futbol);
                deporteL10N.Crear ("Futbol", valen, futbol);
                deporteL10N.Crear ("Baloncesto", esp, basket);
                deporteL10N.Crear ("Basket", ingles, basket);
                deporteL10N.Crear ("Bàsquet", valen, basket);
                deporteL10N.Crear ("Pádel", esp, padel);
                deporteL10N.Crear ("Paddle", ingles, padel);
                deporteL10N.Crear ("Pàdel", valen, padel);

                //Material

                MaterialCEN material = new MaterialCEN (materialrepository);
                material.Crear ("Cansasta de 3,05 metros", 200.45, "Deuba XXL", pavellon, "Canasta reglamentaria para los pavellones", 10);

                //Estados pista

                PistaEstadoCEN pistaEstado = new PistaEstadoCEN (pistaestadorepository);
                var disponible = pistaEstado.Crear ("Disponible");
                var ocupada = pistaEstado.Crear ("Ocupada");
                var cerrada = pistaEstado.Crear ("Temporalmente cerrada");

                //Estado pista traducidos

                PistaEstado_l10nCEN pistaEstado_l10n = new PistaEstado_l10nCEN (pistaestado_l10nrepository);
                pistaEstado_l10n.Crear ("Disponible", esp, disponible);
                pistaEstado_l10n.Crear ("Available", ingles, disponible);
                pistaEstado_l10n.Crear ("Disponible", valen, disponible);
                pistaEstado_l10n.Crear ("Ocupada", esp, ocupada);
                pistaEstado_l10n.Crear ("Occupy", ingles, ocupada);
                pistaEstado_l10n.Crear ("Ocupada", valen, ocupada);
                pistaEstado_l10n.Crear ("Temporalmente cerrada", esp, cerrada);
                pistaEstado_l10n.Crear ("Temporarily closed", ingles, cerrada);
                pistaEstado_l10n.Crear ("Temporalment tancada", valen, cerrada);

                //Pista

                PistaCEN pista = new PistaCEN (pistarepository);
                var pistaLibre = pista.Crear ("Pista 1", 1, entidadPublica, disponible, new List<int> { padel }, "Puerta 1A");
                var pistaOcupada = pista.Crear ("Pista 2", 1, entidadPublica, ocupada, new List<int> { padel }, "Puerta 1B");
                var pistaCerrada = pista.Crear ("Pista 3", 1, entidadPublica, cerrada, new List<int> { padel }, "Puerta 2A");
                var pistaVariasReservas = pista.Crear ("Pista 4", 2, entidadPublica, cerrada, new List<int> { padel }, "Puerta 2B");

                var pistaLibre2 = pista.Crear ("Pista padel 1", 1, entidadPrivada, disponible, new List<int> { padel }, "1");
                var pistaOcupada3 = pista.Crear ("Pista padel 2", 1, entidadPrivada, ocupada, new List<int> { padel }, "2");
                var pistaCerrada4 = pista.Crear ("Pista padel 3", 1, entidadPrivada, cerrada, new List<int> { padel }, "3");
                var pistaVariasReservas5 = pista.Crear ("Pista padel 4", 2, entidadPrivada, cerrada, new List<int> { padel }, "4");

                //Dia semana

                DiaSemanaCEN diaSemana = new DiaSemanaCEN (diasemanarepository);
                var lunes = diaSemana.Crear ("Lunes");
                var martes = diaSemana.Crear ("Martes");
                var miercoles = diaSemana.Crear ("Miércoles");
                var jueves = diaSemana.Crear ("Jueves");
                var viernes = diaSemana.Crear ("Viernes");
                var sabado = diaSemana.Crear ("Sábado");
                var domingo = diaSemana.Crear ("Domingo");

                //Dia semana traducido

                DiaSemana_l10nCEN diaSemanaL10N = new DiaSemana_l10nCEN (diasemana_l10nrepository);
                diaSemanaL10N.Crear (lunes, esp, "Lunes");
                diaSemanaL10N.Crear (martes, esp, "Martes");
                diaSemanaL10N.Crear (miercoles, esp, "Miércoles");
                diaSemanaL10N.Crear (jueves, esp, "Jueves");
                diaSemanaL10N.Crear (viernes, esp, "Viernes");
                diaSemanaL10N.Crear (sabado, esp, "Sábado");
                diaSemanaL10N.Crear (domingo, esp, "Domingo");
                diaSemanaL10N.Crear (lunes, ingles, "Monday");
                diaSemanaL10N.Crear (martes, ingles, "Tuesday");
                diaSemanaL10N.Crear (miercoles, ingles, "Wednesday");
                diaSemanaL10N.Crear (jueves, ingles, "Thursday");
                diaSemanaL10N.Crear (viernes, ingles, "Friday");
                diaSemanaL10N.Crear (sabado, ingles, "Saturday");
                diaSemanaL10N.Crear (domingo, ingles, "Sunday");
                diaSemanaL10N.Crear (lunes, valen, "Dilluns");
                diaSemanaL10N.Crear (martes, valen, "Dimarts");
                diaSemanaL10N.Crear (miercoles, valen, "Dimecres");
                diaSemanaL10N.Crear (jueves, valen, "Dijous");
                diaSemanaL10N.Crear (viernes, valen, "Divendres");
                diaSemanaL10N.Crear (sabado, valen, "Dissabte");
                diaSemanaL10N.Crear (domingo, valen, "Diumenge");

                //Horario

                HorarioCEN horario = new HorarioCEN (horariorepository);
                horario.Crear (DateTime.Parse ("07:00:00"), DateTime.Parse ("08:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                horario.Crear (DateTime.Parse ("08:00:00"), DateTime.Parse ("09:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                horario.Crear (DateTime.Parse ("09:00:00"), DateTime.Parse ("10:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                horario.Crear (DateTime.Parse ("10:00:00"), DateTime.Parse ("11:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                horario.Crear (DateTime.Parse ("11:00:00"), DateTime.Parse ("12:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                var horario1213 = horario.Crear (DateTime.Parse ("12:00:00"), DateTime.Parse ("13:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                horario.Crear (DateTime.Parse ("13:00:00"), DateTime.Parse ("14:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                horario.Crear (DateTime.Parse ("14:00:00"), DateTime.Parse ("15:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes });
                horario.Crear (DateTime.Parse ("15:00:00"), DateTime.Parse ("16:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes });
                horario.Crear (DateTime.Parse ("16:00:00"), DateTime.Parse ("17:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes });
                int horariotarde = horario.Crear (DateTime.Parse ("17:00:00"), DateTime.Parse ("18:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                horario.Crear (DateTime.Parse ("18:00:00"), DateTime.Parse ("19:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo });
                horario.Crear (DateTime.Parse ("19:00:00"), DateTime.Parse ("20:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, domingo });
                horario.Crear (DateTime.Parse ("20:00:00"), DateTime.Parse ("21:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes, domingo });
                horario.Crear (DateTime.Parse ("21:00:00"), DateTime.Parse ("22:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes });
                horario.Crear (DateTime.Parse ("22:00:00"), DateTime.Parse ("23:00:00"), pistaLibre, new List<int> { lunes, martes, miercoles, jueves, viernes });

                //Valoraciones

                ValoracionCEN valoracion = new ValoracionCEN (valoracionrepository);
                var idvaloracion = valoracion.Crear (3, "Está bien pero tiene demaisada arena", idusuario);
                valoracion.Valorarpista (valoracion.Obtener (idvaloracion), pista.Obtener (pistaLibre));
                idvaloracion = valoracion.Crear (1, "Técnico pésimo", idusuario);
                valoracion.Valorartecnico (valoracion.Obtener (idvaloracion), usuario.Obtener (idtecnico));
                idvaloracion = valoracion.Crear (5, "Muy buena instalación de padel", idusuario);
                valoracion.Valorarinstalacion (valoracion.Obtener (idvaloracion), instalacion.Obtener (pavellon));
                idvaloracion = valoracion.Crear (2, "No dispone de muchas pistas de padel, siempre están ocupadas...", idusuario);
                valoracion.Valorarentidad (valoracion.Obtener (idvaloracion), entidad.Obtener (entidadPrivada));

                //Reservas
                ReservaCEN reserva = new ReservaCEN (reservarepository);
                int idreserva = reserva.Crear (usuarioEn.Nombre, usuarioEn.Apellidos, usuarioEn.Email, usuarioEn.Telefono, idusuario, false, pistaLibre, 1, horario1213, Convert.ToDateTime ("13/02/2023"), TipoReservaEnum.reserva);
                int idpartido = reserva.Crear (usuarioEn.Nombre, usuarioEn.Apellidos, usuarioEn.Email, usuarioEn.Telefono, idusuario, false, pistaLibre, 4, horario1213, Convert.ToDateTime ("13/02/2023"), TipoReservaEnum.partido);

                //Tipos pagos

                PagoTipoCEN tipoPago = new PagoTipoCEN (pagotiporepository);
                int tarjeta = tipoPago.Crear ("Con tarjeta");
                int paypal = tipoPago.Crear ("PayPal");
                int contado = tipoPago.Crear ("Al contado");

                //Tipos pagos traducidos

                PagoTipo_l10nCEN tipoPagoL10N = new PagoTipo_l10nCEN (pagotipo_l10nrepository);
                tipoPagoL10N.Crear ("Con tarjeta", tarjeta, esp);
                tipoPagoL10N.Crear ("PayPal", paypal, esp);
                tipoPagoL10N.Crear ("Al contado", contado, esp);
                tipoPagoL10N.Crear ("With card", tarjeta, ingles);
                tipoPagoL10N.Crear ("PayPal", paypal, ingles);
                tipoPagoL10N.Crear ("Cash", contado, ingles);
                tipoPagoL10N.Crear ("Amb targeta", tarjeta, valen);
                tipoPagoL10N.Crear ("PayPal", paypal, valen);
                tipoPagoL10N.Crear ("Al comptat", contado, valen);

                //Pagos
                PagoCEN pago = new PagoCEN (pagorepository);
                int idpago = pago.Crear (3.00, 3.63, 0.63, tarjeta, Convert.ToDateTime ("12/02/2023 08:00:00"), idreserva);

                reserva.Inscribirsepartido (reserva.Obtener (idpartido), usuario.Obtener (idusuario2));

                //Eventos

                EventoCEN evento = new EventoCEN (eventorepository);
                int eventoPadel = evento.Crear ("Clase de padel miercoles", "Clase de pádel de los miercoles por la tarde", entidadPublica, new List<int>() {
                                horariotarde
                        }, new List<int> { miercoles });
                evento.Asignarusuario (eventoPadel, usuario.Obtener (idusuario), usuario.Listaralumnosevento (eventoPadel).Count);

                //Notificaciones

                NotificacionCEN notificacion = new NotificacionCEN (notificacionrepository);
                int notificacionEnvio = notificacion.CrearNotifEvento ("Cambio de clase del día 22 de Febrero", "Buenas Óscar, el día 22 de Febrero no puedo asistir a la clase, ¿me puedes decir otro día que te venga bien?, muchas gracias!!", false, TipoNotificacionEnum.envio, eventoPadel);
                notificacion.EnviarAUsuario (notificacion.Obtener (notificacionEnvio), usuario.Obtener (idusuario), usuario.Obtener (idtecnico), null);
                int notificacionGenerada = notificacion.CrearNotifReserva ("Alerta tiempo", "Posibilidad de lluvias en la reserva de hoy", false, TipoNotificacionEnum.alerta, idreserva);
                notificacion.EnviarAUsuario (notificacion.Obtener (notificacionGenerada), usuario.Obtener (idusuario), null, entidad.Obtener (entidadPublica));
                int notificacionEnviadaUsuario = notificacion.CrearNotifEvento ("Buenas Entrenador", "Puedo el día 23 a las 18:00, ¿te viene bien?, saludos", false, TipoNotificacionEnum.envio, eventoPadel);
                notificacion.EnviarAUsuario (notificacion.Obtener (notificacionEnviadaUsuario), usuario.Obtener (idtecnico), usuario.Obtener (idusuario), null);

                //Incidencia

                IncidenciaCEN incidencia = new IncidenciaCEN (incidenciarepository);
                incidencia.Crear (idtecnico, eventoPadel, "Imposibilidad de asistencia", "Imposibilidad de asistir el día 22 de febrero de 2023", Convert.ToDateTime ("22/02/2023 17:00:00"), Convert.ToDateTime ("23/02/2023 18:00:00"));

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
