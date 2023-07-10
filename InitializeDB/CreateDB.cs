
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
                UnitOfWorkRepository unitRep = new UnitOfWorkRepository (session);
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

                var esp = idiomacen.Crear ("Español", "es");
                var ingles = idiomacen.Crear ("Inglés", "en");
                var valen = idiomacen.Crear ("Valenciano", "ca");

                //Roles

                var rolAdmin = rolcen.Crear ("Administrador");
                var rolEntrenador = rolcen.Crear ("Entrenador");
                var rolUsuario = rolcen.Crear ("Usuario");

                //Roles traducidos

                rol_l10ncen.Crear ("Administrador", rolAdmin, esp);
                rol_l10ncen.Crear ("Administrator", rolAdmin, ingles);
                rol_l10ncen.Crear ("Administrador", rolAdmin, valen);

                rol_l10ncen.Crear ("Entrenador", rolEntrenador, esp);
                rol_l10ncen.Crear ("Coach", rolEntrenador, ingles);
                rol_l10ncen.Crear ("Entrenador", rolEntrenador, valen);

                rol_l10ncen.Crear ("Usuario", rolUsuario, esp);
                rol_l10ncen.Crear ("User", rolUsuario, ingles);
                rol_l10ncen.Crear ("Usuari", rolUsuario, valen);

                //Entidad

                var entidadPublica = entidadcen.Crear ("Ayuntamiento de Alcoy", "alcoy@ayuntamiento.com", "659874158", "Avenidad Mayor Nº 89", Convert.ToDateTime ("2/11/2023 12:46:33"), "03801", "Alcoy/Alcoi", "Alicante", "A45697898", null, null, 38.679156565948674, -0.47293230660721197);
                var entidadPrivada = entidadcen.Crear ("Complejo Deportivo Municipal Eduardo Latorre", "info@padeleduardolatorre.com", "659874158", "Carrer Juan Gil Albert, 6", Convert.ToDateTime ("2/11/2023 12:46:33"), "03804", "Alcoy/Alcoi", "Alicante", "C98789852", null, null, 38.70514175374284, -0.4730745998107246);
                var entidadPrivada2 = entidadcen.Crear ("Altamira Pàdel & Fitness", "info@altamira.com", "659874158", "Avinguda de la Serrella, s/n", Convert.ToDateTime ("2/11/2023 12:46:33"), "03804", "Alcoy/Alcoi", "Alicante", "C98789852", null, null, 38.71798605416559, -0.45675760990557196);


                //Usuarios

                var idusuario = usuariocen.Crear ("Usuario", "omm35@gcloud.ua.es", "Gran via 33", "645325495", Convert.ToDateTime ("18/01/1968"), Convert.ToDateTime ("2/11/2022 12:46:33"), "Usuario", "123456", rolUsuario, "03440", "Ibi", "Alicante", null, -1);
                var idusuario2 = usuariocen.Crear ("Usuario2", "usuario@pruebas.es", "Gran via 33", "645325495", Convert.ToDateTime ("18/01/1980"), Convert.ToDateTime ("3/11/2022 12:46:33"), "Usuario2", "123456", rolUsuario, "03801", "Alcoy", "Alicante", null, -1);
                var idadministrador = usuariocen.Crear ("Administrador", "admin@pruebas.es", "Gran via 33", "645325495", Convert.ToDateTime ("18/01/1968"), Convert.ToDateTime ("2/11/2022 12:46:33"), "Administrador Pruebas", "123456", rolAdmin, "03440", "Ibi", "Alicante", null, entidadPublica);
                var idtecnico = usuariocen.Crear ("Entrenador", "entrenador@pruebas.es", "Gran via 33", "645325495", Convert.ToDateTime ("18/01/1968"), Convert.ToDateTime ("2/11/2022 12:46:33"), "Entrenador Pruebas", "123456", rolEntrenador, "03440", "Ibi", "Alicante", null, entidadPublica);

                var usuarioEn = usuariocen.Obtener (idusuario);

                //Asitencia

                asitenciacen.Crear (idusuario, Convert.ToDateTime ("12/02/2023 18:00:00"), true, "Se ha esforzado mucho en esta clase. Progresa adecuadamente.");

                //Instalacion deportiva

                var polideportivo = instalacioncen.Crear ("Polideportivo de Alcoy", entidadPublica, true, 38.679156565948674, -0.47293230660721197, "968887541", "Calle San Lucas Nº 45", null, "03801", "Alcoy/Alcoi", "Alicante", "698572147", "polideportivo@alcoy.es");
                var eduardolatorre = instalacioncen.Crear ("Complejo Deportivo Municipal Eduardo Latorre", entidadPrivada, true, 38.70514175374284, -0.4730745998107246, "659874158", "Carrer Juan Gil Albert, 6", null, "03804", "Alcoy/Alcoi", "Alicante", "698254715", "info@padeleduardolatorre.com");
                var epsa = instalacioncen.Crear ("Universidad de Alcoy EPSA", entidadPublica, true, 38.694240194850074, -0.4774155240370907, "968887541", "Plaça Ferrándiz i Carbonell, s/n", null, "03801", "Alcoy/Alcoi", "Alicante", "698572147", "info@espsa.com");
                var altamirapadel = instalacioncen.Crear ("Club altamira Pàdel & Fitness", entidadPrivada2, true, 38.71798605416559, -0.45675760990557196, "659874158", "Avinguda de la Serrella, s/n", null, "03804", "Alcoy/Alcoi", "Alicante", "698254715", "info@altamira.com");

                //Deporte

                var futbol11 = deportecen.Crear ("Fútbol 11", "Deporte de pies", "ios-football&ionic");
                var basket = deportecen.Crear ("Baloncesto", "Deporte de manos", "basketball&ionic");
                var padel = deportecen.Crear ("Pádel", "Deporte de raqueta pequeña", "tennis&materialcomunnityicons");
                var tenis = deportecen.Crear ("Tenis", "Deporte de raqueta", "tennisball&ionic");
                var atletismo = deportecen.Crear ("Atletismo ", "Deporte de correr", "run-fast&materialcomunnityicons");
                var voleyplaya = deportecen.Crear ("Vóley playa", "Deporte de pelota en playa", "volleyball&materialcomunnityicons");
                var futbol8 = deportecen.Crear ("Fútbol 8", "Deporte de pies", "md-football-outline&ionic");
                var futbolsala = deportecen.Crear ("Fútbol sala", "Deporte de pies", "futbol&fontawesome5");
                var squash = deportecen.Crear ("Squash", "Deporte de raqueta larga", "racquetball&materialcomunnityicons");
                var tenismesa = deportecen.Crear ("Tenis de mesa", "Deporte de raqueta pequeña", "table-tennis&fontawesome5");
                var rocodromo = deportecen.Crear ("Rocódromo", "Rocódromo", "escalator-up&materialcomunnityicons");
                var voley = deportecen.Crear ("Voleibol", "Deporte de pelota", "volleyball-ball&fontawesome5");
                var musculacion = deportecen.Crear ("Musculación", "Salas de musculación", "weight-lifter&materialcomunnityicons");
                var piscina = deportecen.Crear ("Piscina", "Salas de piscina", "swimmer&fontawesome5");
                var pilotavalenciana = deportecen.Crear ("Pilota valenciana", "Deporte de pelota valenciana", "handball&materialcomunnityicons");


                //Deporte traducidos

                deporte_l10ncen.Crear ("Fútbol 11", esp, futbol11);
                deporte_l10ncen.Crear ("11-a-side Football", ingles, futbol11);
                deporte_l10ncen.Crear ("Futbol 11", valen, futbol11);

                deporte_l10ncen.Crear ("Baloncesto", esp, basket);
                deporte_l10ncen.Crear ("Basket", ingles, basket);
                deporte_l10ncen.Crear ("Bàsquet", valen, basket);

                deporte_l10ncen.Crear ("Pádel", esp, padel);
                deporte_l10ncen.Crear ("Paddle", ingles, padel);
                deporte_l10ncen.Crear ("Pàdel", valen, padel);

                deporte_l10ncen.Crear ("Tenis", esp, tenis);
                deporte_l10ncen.Crear ("Tennis", ingles, tenis);
                deporte_l10ncen.Crear ("Tennis", valen, tenis);

                deporte_l10ncen.Crear ("Atletismo", esp, atletismo);
                deporte_l10ncen.Crear ("Athletics", ingles, atletismo);
                deporte_l10ncen.Crear ("Atletisme", valen, atletismo);

                deporte_l10ncen.Crear ("Vóley playa", esp, voleyplaya);
                deporte_l10ncen.Crear ("Beach Volleyball", ingles, voleyplaya);
                deporte_l10ncen.Crear ("Vòlei platja", valen, voleyplaya);

                deporte_l10ncen.Crear ("Fútbol 8", esp, futbol8);
                deporte_l10ncen.Crear ("8-a-side Football", ingles, futbol8);
                deporte_l10ncen.Crear ("Futbol 8", valen, futbol8);

                deporte_l10ncen.Crear ("Fútbol Sala", esp, futbolsala);
                deporte_l10ncen.Crear ("Futsal", ingles, futbolsala);
                deporte_l10ncen.Crear ("Futbol Sala", valen, futbolsala);

                deporte_l10ncen.Crear ("Squash", esp, squash);
                deporte_l10ncen.Crear ("Squash", ingles, squash);
                deporte_l10ncen.Crear ("Squash", valen, squash);

                deporte_l10ncen.Crear ("Tenis de mesa", esp, tenismesa);
                deporte_l10ncen.Crear ("Table Tennis", ingles, tenismesa);
                deporte_l10ncen.Crear ("Tennis de taula", valen, tenismesa);

                deporte_l10ncen.Crear ("Rocódromo", esp, rocodromo);
                deporte_l10ncen.Crear ("Climbing Wall", ingles, rocodromo);
                deporte_l10ncen.Crear ("Rocòdrom", valen, rocodromo);

                deporte_l10ncen.Crear ("Voleibol", esp, voley);
                deporte_l10ncen.Crear ("Volleyball", ingles, voley);
                deporte_l10ncen.Crear ("Voleibol", valen, voley);

                deporte_l10ncen.Crear ("Musculación", esp, musculacion);
                deporte_l10ncen.Crear ("Weight Training", ingles, musculacion);
                deporte_l10ncen.Crear ("Musculació", valen, musculacion);

                deporte_l10ncen.Crear ("Piscina", esp, piscina);
                deporte_l10ncen.Crear ("Swimming Pool", ingles, piscina);
                deporte_l10ncen.Crear ("Piscina", valen, piscina);

                deporte_l10ncen.Crear ("Pilota valenciana", esp, pilotavalenciana);
                deporte_l10ncen.Crear ("Pilota Valenciana", ingles, pilotavalenciana);
                deporte_l10ncen.Crear ("Pilota Valenciana", valen, pilotavalenciana);

                //Material

                materialcen.Crear ("Cansasta de 3,05 metros", 200.45, "Deuba XXL", eduardolatorre, "Canasta reglamentaria para los pavellones", 10, null, null, null, "");

                //Estados pista

                var disponible = pistaestadocen.Crear ("Disponible");
                var ocupada = pistaestadocen.Crear ("Ocupada");
                var cerrada = pistaestadocen.Crear ("Temporalmente cerrada");

                //Estado pista traducidos

                pistaestado_l10ncen.Crear ("Disponible", esp, disponible);
                pistaestado_l10ncen.Crear ("Available", ingles, disponible);
                pistaestado_l10ncen.Crear ("Disponible", valen, disponible);
                pistaestado_l10ncen.Crear ("Ocupada", esp, ocupada);
                pistaestado_l10ncen.Crear ("Occupy", ingles, ocupada);
                pistaestado_l10ncen.Crear ("Ocupada", valen, ocupada);
                pistaestado_l10ncen.Crear ("Temporalmente cerrada", esp, cerrada);
                pistaestado_l10ncen.Crear ("Temporarily closed", ingles, cerrada);
                pistaestado_l10ncen.Crear ("Temporalment tancada", valen, cerrada);

                //Pista

                var pistaLibre = pistacen.Crear ("Pista 1", 1, entidadPublica, disponible, new List<int> { padel }, "Puerta 1A", true, polideportivo, 10.45, 38.4342800, -0.5496300);
                var pistaOcupada = pistacen.Crear ("Pista 2", 1, entidadPublica, ocupada, new List<int> { padel }, "Puerta 1B", true, polideportivo, 10.45, 38.4342800, -0.5496300);
                var pistaCerrada = pistacen.Crear ("Pista 3", 1, entidadPublica, cerrada, new List<int> { padel }, "Puerta 2A", true, polideportivo, 10.45, 38.4342800, -0.5496300);
                var pistaVariasReservas = pistacen.Crear ("Pista 4", 2, entidadPublica, cerrada, new List<int> { padel }, "Puerta 2B", true, polideportivo, 10.45, 38.4342800, -0.5496300);

                var pistaLibre2 = pistacen.Crear ("Pista padel 1", 1, entidadPrivada, disponible, new List<int> { padel }, "1", true, polideportivo, 6, 38.4342800, -0.5496300);
                var pistaOcupada3 = pistacen.Crear ("Pista padel 2", 1, entidadPrivada, ocupada, new List<int> { padel }, "2", true, polideportivo, 6, 38.4342800, -0.5496300);
                var pistaCerrada4 = pistacen.Crear ("Pista padel 3", 1, entidadPrivada, cerrada, new List<int> { padel }, "3", true, polideportivo, 6, 38.4342800, -0.5496300);
                var pistaVariasReservas5 = pistacen.Crear ("Pista padel 4", 2, entidadPrivada, cerrada, new List<int> { padel }, "4", true, polideportivo, 6, 38.4342800, -0.5496300);

                var pistaLibrePavellon = pistacen.Crear ("Pista 1 Pavellon", 1, entidadPublica, disponible, new List<int> { padel }, "Puerta 1A", true, eduardolatorre, 7, 38.4342800, -0.5496300);
                var pistaOcupadaPavellon = pistacen.Crear ("Pista 2 Pavellon", 1, entidadPublica, ocupada, new List<int> { padel }, "Puerta 1B", true, eduardolatorre, 7, 38.4342800, -0.5496300);
                var pistaCerradaPavellon = pistacen.Crear ("Pista 3 Pavellon", 1, entidadPublica, cerrada, new List<int> { padel }, "Puerta 2A", true, eduardolatorre, 7, 38.4342800, -0.5496300);
                var pistaVariasReservasPavellon = pistacen.Crear ("Pista 4 Pavellon", 2, entidadPublica, cerrada, new List<int> { padel }, "Puerta 2B", true, eduardolatorre, 7, 38.4342800, -0.5496300);

                var pistaLibre2Pavellon = pistacen.Crear ("Pista padel 1 Pavellon", 1, entidadPublica, disponible, new List<int> { padel }, "1", true, epsa, 2, 38.4342800, -0.5496300);
                var pistaOcupada3Pavellon = pistacen.Crear ("Pista padel 2 Pavellon", 1, entidadPublica, ocupada, new List<int> { padel }, "2", true, epsa, 2, 38.4342800, -0.5496300);
                var pistaCerrada4Pavellon = pistacen.Crear ("Pista padel 3 Pavellon", 1, entidadPublica, cerrada, new List<int> { padel }, "3", true, epsa, 2, 38.4342800, -0.5496300);
                var pistaVariasReservas5Pavellon = pistacen.Crear ("Pista padel 4 Pavellon", 2, entidadPublica, cerrada, new List<int> { padel }, "4", true, epsa, 2, 38.4342800, -0.5496300);

                var pistaLibrePavellon2 = pistacen.Crear ("Pista 1 Pavellon", 1, entidadPrivada2, disponible, new List<int> { padel }, "Puerta 1A", true, altamirapadel, 3, 38.4342800, -0.5496300);
                var pistaOcupadaPavellon2 = pistacen.Crear ("Pista 2 Pavellon", 1, entidadPrivada2, ocupada, new List<int> { padel }, "Puerta 1B", true, altamirapadel, 3, 38.4342800, -0.5496300);
                var pistaCerradaPavellon2 = pistacen.Crear ("Pista 3 Pavellon", 1, entidadPrivada2, cerrada, new List<int> { padel }, "Puerta 2A", true, altamirapadel, 3, 38.4342800, -0.5496300);
                var pistaVariasReservasPavellon2 = pistacen.Crear ("Pista 4 Pavellon", 2, entidadPrivada2, cerrada, new List<int> { padel }, "Puerta 2B", true, altamirapadel, 3, 38.4342800, -0.5496300);

                //Dia semana

                var lunes = diasemanacen.Crear ("Lunes");
                var martes = diasemanacen.Crear ("Martes");
                var miercoles = diasemanacen.Crear ("Miércoles");
                var jueves = diasemanacen.Crear ("Jueves");
                var viernes = diasemanacen.Crear ("Viernes");
                var sabado = diasemanacen.Crear ("Sábado");
                var domingo = diasemanacen.Crear ("Domingo");

                //Dia semana traducido

                diasemana_l10ncen.Crear (lunes, esp, "Lunes");
                diasemana_l10ncen.Crear (martes, esp, "Martes");
                diasemana_l10ncen.Crear (miercoles, esp, "Miércoles");
                diasemana_l10ncen.Crear (jueves, esp, "Jueves");
                diasemana_l10ncen.Crear (viernes, esp, "Viernes");
                diasemana_l10ncen.Crear (sabado, esp, "Sábado");
                diasemana_l10ncen.Crear (domingo, esp, "Domingo");
                diasemana_l10ncen.Crear (lunes, ingles, "Monday");
                diasemana_l10ncen.Crear (martes, ingles, "Tuesday");
                diasemana_l10ncen.Crear (miercoles, ingles, "Wednesday");
                diasemana_l10ncen.Crear (jueves, ingles, "Thursday");
                diasemana_l10ncen.Crear (viernes, ingles, "Friday");
                diasemana_l10ncen.Crear (sabado, ingles, "Saturday");
                diasemana_l10ncen.Crear (domingo, ingles, "Sunday");
                diasemana_l10ncen.Crear (lunes, valen, "Dilluns");
                diasemana_l10ncen.Crear (martes, valen, "Dimarts");
                diasemana_l10ncen.Crear (miercoles, valen, "Dimecres");
                diasemana_l10ncen.Crear (jueves, valen, "Dijous");
                diasemana_l10ncen.Crear (viernes, valen, "Divendres");
                diasemana_l10ncen.Crear (sabado, valen, "Dissabte");
                diasemana_l10ncen.Crear (domingo, valen, "Diumenge");

                //Horario

                int h1 = horariocen.Crear (DateTime.Parse ("07:00:00"), DateTime.Parse ("08:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h1, new List<int> { pistaLibre });
                int h3 = horariocen.Crear (DateTime.Parse ("08:00:00"), DateTime.Parse ("09:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h3, new List<int> { pistaLibre });
                int h4 = horariocen.Crear (DateTime.Parse ("09:00:00"), DateTime.Parse ("10:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h4, new List<int> { pistaLibre });
                int h5 = horariocen.Crear (DateTime.Parse ("10:00:00"), DateTime.Parse ("11:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h5, new List<int> { pistaLibre });
                int h6 = horariocen.Crear (DateTime.Parse ("11:00:00"), DateTime.Parse ("12:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h6, new List<int> { pistaLibre });
                var horario1213 = horariocen.Crear (DateTime.Parse ("12:00:00"), DateTime.Parse ("13:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(horario1213, new List<int> { pistaLibre });
                int h7 = horariocen.Crear (DateTime.Parse ("13:00:00"), DateTime.Parse ("14:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h7, new List<int> { pistaLibre });
                int h8 = horariocen.Crear (DateTime.Parse ("14:00:00"), DateTime.Parse ("15:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h8, new List<int> { pistaLibre });
                int h9 = horariocen.Crear (DateTime.Parse ("15:00:00"), DateTime.Parse ("16:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h9, new List<int> { pistaLibre });
                int h10 = horariocen.Crear (DateTime.Parse ("16:00:00"), DateTime.Parse ("17:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h10, new List<int> { pistaLibre });
                int horariotarde = horariocen.Crear (DateTime.Parse ("17:00:00"), DateTime.Parse ("18:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(horariotarde, new List<int> { pistaLibre });
                int h11 = horariocen.Crear (DateTime.Parse ("18:00:00"), DateTime.Parse ("19:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h11, new List<int> { pistaLibre });
                int h12 = horariocen.Crear (DateTime.Parse ("19:00:00"), DateTime.Parse ("20:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, domingo }, entidadPublica);
                horariocen.Asignarpistas(h12, new List<int> { pistaLibre });
                int h13 = horariocen.Crear (DateTime.Parse ("20:00:00"), DateTime.Parse ("21:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, domingo }, entidadPublica);
                horariocen.Asignarpistas(h13, new List<int> { pistaLibre });
                int h14 = horariocen.Crear (DateTime.Parse ("21:00:00"), DateTime.Parse ("22:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h14, new List<int> { pistaLibre });
                int h15 = horariocen.Crear (DateTime.Parse ("22:00:00"), DateTime.Parse ("23:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h15, new List<int> { pistaLibre });

                int h1Pavellon = horariocen.Crear(DateTime.Parse("07:00:00"), DateTime.Parse("08:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h1, new List<int> { pistaLibrePavellon });
                int h3Pavellon = horariocen.Crear(DateTime.Parse("08:00:00"), DateTime.Parse("09:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h3, new List<int> { pistaLibrePavellon });
                int h4Pavellon = horariocen.Crear(DateTime.Parse("09:00:00"), DateTime.Parse("10:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h4, new List<int> { pistaLibrePavellon });
                int h5Pavellon = horariocen.Crear(DateTime.Parse("10:00:00"), DateTime.Parse("11:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h5, new List<int> { pistaLibrePavellon });
                int h6Pavellon = horariocen.Crear(DateTime.Parse("11:00:00"), DateTime.Parse("12:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h6, new List<int> { pistaLibrePavellon });
                var horario1213Pavellon = horariocen.Crear(DateTime.Parse("12:00:00"), DateTime.Parse("13:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(horario1213, new List<int> { pistaLibrePavellon });
                int h7Pavellon = horariocen.Crear(DateTime.Parse("13:00:00"), DateTime.Parse("14:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h7, new List<int> { pistaLibrePavellon });
                int h8Pavellon = horariocen.Crear(DateTime.Parse("14:00:00"), DateTime.Parse("15:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h8, new List<int> { pistaLibrePavellon });
                int h9Pavellon = horariocen.Crear(DateTime.Parse("15:00:00"), DateTime.Parse("16:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h9, new List<int> { pistaLibrePavellon });
                int h10Pavellon = horariocen.Crear(DateTime.Parse("16:00:00"), DateTime.Parse("17:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h10, new List<int> { pistaLibrePavellon });
                int horariotardePavellon = horariocen.Crear(DateTime.Parse("17:00:00"), DateTime.Parse("18:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(horariotarde, new List<int> { pistaLibrePavellon });
                int h11Pavellon = horariocen.Crear(DateTime.Parse("18:00:00"), DateTime.Parse("19:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h11, new List<int> { pistaLibrePavellon });
                int h12Pavellon = horariocen.Crear(DateTime.Parse("19:00:00"), DateTime.Parse("20:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, domingo }, entidadPublica);
                horariocen.Asignarpistas(h12, new List<int> { pistaLibrePavellon });
                int h13Pavellon = horariocen.Crear(DateTime.Parse("20:00:00"), DateTime.Parse("21:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, domingo }, entidadPublica);
                horariocen.Asignarpistas(h13, new List<int> { pistaLibrePavellon });
                int h14Pavellon = horariocen.Crear(DateTime.Parse("21:00:00"), DateTime.Parse("22:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h14, new List<int> { pistaLibrePavellon });
                int h15Pavellon = horariocen.Crear(DateTime.Parse("22:00:00"), DateTime.Parse("23:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h15, new List<int> { pistaLibrePavellon });

                int h1Pavellon2 = horariocen.Crear(DateTime.Parse("07:00:00"), DateTime.Parse("08:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h1, new List<int> { pistaLibrePavellon2 });
                int h3Pavellon2 = horariocen.Crear(DateTime.Parse("08:00:00"), DateTime.Parse("09:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h3, new List<int> { pistaLibrePavellon2 });
                int h4Pavellon2 = horariocen.Crear(DateTime.Parse("09:00:00"), DateTime.Parse("10:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h4, new List<int> { pistaLibrePavellon2 });
                int h5Pavellon2 = horariocen.Crear(DateTime.Parse("10:00:00"), DateTime.Parse("11:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h5, new List<int> { pistaLibrePavellon2 });
                int h6Pavellon2 = horariocen.Crear(DateTime.Parse("11:00:00"), DateTime.Parse("12:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h6, new List<int> { pistaLibrePavellon2 });
                var horario1213Pavellon2 = horariocen.Crear(DateTime.Parse("12:00:00"), DateTime.Parse("13:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(horario1213, new List<int> { pistaLibrePavellon2 });
                int h7Pavellon2 = horariocen.Crear(DateTime.Parse("13:00:00"), DateTime.Parse("14:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h7, new List<int> { pistaLibrePavellon2 });
                int h8Pavellon2 = horariocen.Crear(DateTime.Parse("14:00:00"), DateTime.Parse("15:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPrivada2);
                horariocen.Asignarpistas(h8, new List<int> { pistaLibrePavellon2 });
                int h9Pavellon2 = horariocen.Crear(DateTime.Parse("15:00:00"), DateTime.Parse("16:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPrivada2);
                horariocen.Asignarpistas(h9, new List<int> { pistaLibrePavellon2 });
                int h10Pavellon2 = horariocen.Crear(DateTime.Parse("16:00:00"), DateTime.Parse("17:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPrivada2);
                horariocen.Asignarpistas(h10, new List<int> { pistaLibrePavellon2 });
                int horariotardePavellon2 = horariocen.Crear(DateTime.Parse("17:00:00"), DateTime.Parse("18:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(horariotarde, new List<int> { pistaLibrePavellon2 });
                int h11Pavellon2 = horariocen.Crear(DateTime.Parse("18:00:00"), DateTime.Parse("19:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h11, new List<int> { pistaLibrePavellon2 });
                int h12Pavellon2 = horariocen.Crear(DateTime.Parse("19:00:00"), DateTime.Parse("20:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h12, new List<int> { pistaLibrePavellon2 });
                int h13Pavellon2 = horariocen.Crear(DateTime.Parse("20:00:00"), DateTime.Parse("21:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, domingo }, entidadPrivada2);
                horariocen.Asignarpistas(h13, new List<int> { pistaLibrePavellon2 });
                int h14Pavellon2 = horariocen.Crear(DateTime.Parse("21:00:00"), DateTime.Parse("22:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPrivada2);
                horariocen.Asignarpistas(h14, new List<int> { pistaLibrePavellon2 });
                int h15Pavellon2 = horariocen.Crear(DateTime.Parse("22:00:00"), DateTime.Parse("23:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPrivada2);
                horariocen.Asignarpistas(h15, new List<int> { pistaLibrePavellon2 });

                int h1Libre2Pavellon = horariocen.Crear(DateTime.Parse("07:00:00"), DateTime.Parse("08:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h1, new List<int> { pistaLibre2Pavellon });
                int h3Libre2Pavellon = horariocen.Crear(DateTime.Parse("08:00:00"), DateTime.Parse("09:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h3, new List<int> { pistaLibre2Pavellon });
                int h4Libre2Pavellon = horariocen.Crear(DateTime.Parse("09:00:00"), DateTime.Parse("10:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h4, new List<int> { pistaLibre2Pavellon });
                int h5Libre2Pavellon = horariocen.Crear(DateTime.Parse("10:00:00"), DateTime.Parse("11:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h5, new List<int> { pistaLibre2Pavellon });
                int h6Libre2Pavellon = horariocen.Crear(DateTime.Parse("11:00:00"), DateTime.Parse("12:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h6, new List<int> { pistaLibre2Pavellon });
                var horario1213Libre2Pavellon = horariocen.Crear(DateTime.Parse("12:00:00"), DateTime.Parse("13:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(horario1213, new List<int> { pistaLibre2Pavellon });
                int h7Libre2Pavellon = horariocen.Crear(DateTime.Parse("13:00:00"), DateTime.Parse("14:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h7, new List<int> { pistaLibre2Pavellon });
                int h8Libre2Pavellon = horariocen.Crear(DateTime.Parse("14:00:00"), DateTime.Parse("15:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h8, new List<int> { pistaLibre2Pavellon });
                int h9Libre2Pavellon = horariocen.Crear(DateTime.Parse("15:00:00"), DateTime.Parse("16:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h9, new List<int> { pistaLibre2Pavellon });
                int h10Libre2Pavellon = horariocen.Crear(DateTime.Parse("16:00:00"), DateTime.Parse("17:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h10, new List<int> { pistaLibre2Pavellon });
                int horariotardeLibre2Pavellon = horariocen.Crear(DateTime.Parse("17:00:00"), DateTime.Parse("18:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(horariotarde, new List<int> { pistaLibre2Pavellon });
                int h11Libre2Pavellon = horariocen.Crear(DateTime.Parse("18:00:00"), DateTime.Parse("19:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, sabado, domingo }, entidadPublica);
                horariocen.Asignarpistas(h11, new List<int> { pistaLibre2Pavellon });
                int h12Libre2Pavellon = horariocen.Crear(DateTime.Parse("19:00:00"), DateTime.Parse("20:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, domingo }, entidadPublica);
                horariocen.Asignarpistas(h12, new List<int> { pistaLibre2Pavellon });
                int h13Libre2Pavellon = horariocen.Crear(DateTime.Parse("20:00:00"), DateTime.Parse("21:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes, domingo }, entidadPublica);
                horariocen.Asignarpistas(h13, new List<int> { pistaLibre2Pavellon });
                int h14Libre2Pavellon = horariocen.Crear(DateTime.Parse("21:00:00"), DateTime.Parse("22:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h14, new List<int> { pistaLibre2Pavellon });
                int h15Libre2Pavellon = horariocen.Crear(DateTime.Parse("22:00:00"), DateTime.Parse("23:00:00"), new List<int> { lunes, martes, miercoles, jueves, viernes }, entidadPublica);
                horariocen.Asignarpistas(h15, new List<int> { pistaLibre2Pavellon });

                //Valoraciones

                var idvaloracion = valoracioncen.Crear (3, "Está bien pero tiene demaisada arena", idusuario, DateTime.Now);
                valoracioncen.Valorarpista (idvaloracion, pistaLibre);
                idvaloracion = valoracioncen.Crear (1, "Técnico pésimo", idusuario, DateTime.Now);
                valoracioncen.Valorartecnico (idvaloracion, idtecnico);
                idvaloracion = valoracioncen.Crear (5, "Muy buena instalación de padel", idusuario, DateTime.Now);
                valoracioncen.Valorarinstalacion (idvaloracion, eduardolatorre);
                idvaloracion = valoracioncen.Crear (2, "No dispone de muchas pistas de padel, siempre están ocupadas...", idusuario, DateTime.Now);
                valoracioncen.Valorarentidad (idvaloracion, entidadPrivada);
                var idvaloracion2 = valoracioncen.Crear (1, "Pésima instalación de padel", idusuario, DateTime.Now);
                valoracioncen.Valorarinstalacion (idvaloracion2, altamirapadel);
                var idvaloracion3 = valoracioncen.Crear (4, "Están bien las pistas de padel", idusuario, DateTime.Now);
                valoracioncen.Valorarinstalacion (idvaloracion3, epsa);

                //Reservas
                int idreserva = reservacen.Crear (usuarioEn.Nombre, usuarioEn.Apellidos, usuarioEn.Email, usuarioEn.Telefono, false, pistaLibre, 1, horario1213, Convert.ToDateTime ("13/02/2023"), TipoReservaEnum.reserva, usuarioEn.Idusuario, padel, -1, null, -1, null);
                int idpartido = reservacen.Crear (usuarioEn.Nombre, usuarioEn.Apellidos, usuarioEn.Email, usuarioEn.Telefono, false, pistaLibre, 4, horario1213, DateTime.Now.AddDays (8), TipoReservaEnum.partido, idadministrador, padel, -1, NivelPartidoEnum.medio, -1, "Partido de padel para 4 personas");

                //Tipos pagos

                int tarjeta = pagotipocen.Crear ("Con tarjeta");
                int paypal = pagotipocen.Crear ("PayPal");
                int contado = pagotipocen.Crear ("Al contado");

                //Tipos pagos traducidos

                pagotipo_l10ncen.Crear ("Con tarjeta", tarjeta, esp);
                pagotipo_l10ncen.Crear ("PayPal", paypal, esp);
                pagotipo_l10ncen.Crear ("Al contado", contado, esp);
                pagotipo_l10ncen.Crear ("With card", tarjeta, ingles);
                pagotipo_l10ncen.Crear ("PayPal", paypal, ingles);
                pagotipo_l10ncen.Crear ("Cash", contado, ingles);
                pagotipo_l10ncen.Crear ("Amb targeta", tarjeta, valen);
                pagotipo_l10ncen.Crear ("PayPal", paypal, valen);
                pagotipo_l10ncen.Crear ("Al comptat", contado, valen);

                //Pagos
                int idpago = pagocen.Crear (3.00, 3.63, 0.63, tarjeta, Convert.ToDateTime ("12/02/2023 08:00:00"), idreserva, null);

                int idreservapartido = reservacen.Crear (usuarioEn.Nombre, usuarioEn.Apellidos, usuarioEn.Email, usuarioEn.Telefono, false, pistaLibre, 4, horario1213, DateTime.Now.AddDays (7), TipoReservaEnum.partido, idadministrador, padel, -1, NivelPartidoEnum.medio, -1, "Partido de padel para 4 personas");
                reservacp.Inscribirsepartido (idpartido, new List<int> { idreservapartido });

                //Eventos

                int horariotardePavellon3 = horariocen.Crear (DateTime.Parse ("17:00:00"), DateTime.Parse ("18:00:00"), new List<int> { lunes, miercoles }, entidadPrivada2);
                horariocen.Asignarpistas(pistaLibrePavellon2, new List<int> { horariotardePavellon3 });

                int eventoPadel = eventocen.Crear ("Clase de padel miercoles", "Clase de pádel de los miercoles por la tarde", entidadPublica, true, 10, padel, DateTime.Now, DateTime.Now.AddYears (1), polideportivo, 30, null);
                eventocp.Asignarusuario (eventoPadel, new List<int> { idusuario });
                eventocen.Asignarhorarios (eventoPadel, new List<int>() {
                                horariotardePavellon3
                        });
                eventocen.Asignardiassemana (eventoPadel, new List<int>() {
                                miercoles
                        });
                eventocen.Asignartecnico (eventoPadel, new List<int>() {
                                idtecnico
                        });

                //Notificaciones

                int notificacionEnvio = notificacioncen.CrearNotifEvento ("Cambio de clase del día 22 de Febrero", "Buenas Óscar, el día 22 de Febrero no puedo asistir a la clase, ¿me puedes decir otro día que te venga bien?, muchas gracias!!", false, TipoNotificacionEnum.envio, eventoPadel);
                notificacioncen.EnviarAUsuario (notificacioncen.Obtener (notificacionEnvio), usuariocen.Obtener (idusuario), usuariocen.Obtener (idtecnico), null);
                int notificacionGenerada = notificacioncen.CrearNotifReserva ("Alerta tiempo", "Posibilidad de lluvias en la reserva de hoy", false, TipoNotificacionEnum.envio, idreserva);
                notificacioncen.EnviarAUsuario (notificacioncen.Obtener (notificacionGenerada), usuariocen.Obtener (idusuario), null, entidadcen.Obtener (entidadPublica));
                int notificacionEnviadaUsuario = notificacioncen.CrearNotifEvento ("Buenas Entrenador", "Puedo el día 23 a las 18:00, ¿te viene bien?, saludos", false, TipoNotificacionEnum.envio, eventoPadel);
                notificacioncen.EnviarAUsuario (notificacioncen.Obtener (notificacionEnviadaUsuario), usuariocen.Obtener (idtecnico), usuariocen.Obtener (idusuario), null);

                //Incidencia

                instalacioncp.Asignarpista (polideportivo, new List<int> { pistaLibre });

                usuariocp.Cambiarrol (idadministrador, rolEntrenador);

                incidenciacen.Crear (idtecnico, eventoPadel, "Imposibilidad de asistencia", "Imposibilidad de asistir el día 22 de febrero de 2023", Convert.ToDateTime ("22/02/2023 17:00:00"), Convert.ToDateTime ("23/02/2023 18:00:00"));

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
