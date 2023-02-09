
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
        SqlConnection cnn = new SqlConnection (@"Server=(local); database=master; integrated security=yes");

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
                EstadoPistaRepository estadopistarepository = new EstadoPistaRepository ();
                EstadoPistaCEN estadopistacen = new EstadoPistaCEN (estadopistarepository);
                ValoracionRepository valoracionrepository = new ValoracionRepository ();
                ValoracionCEN valoracioncen = new ValoracionCEN (valoracionrepository);
                PagoRepository pagorepository = new PagoRepository ();
                PagoCEN pagocen = new PagoCEN (pagorepository);
                TipoRepository tiporepository = new TipoRepository ();
                TipoCEN tipocen = new TipoCEN (tiporepository);
                IdiomaRepository idiomarepository = new IdiomaRepository ();
                IdiomaCEN idiomacen = new IdiomaCEN (idiomarepository);
                DeporteRepository deporterepository = new DeporteRepository ();
                DeporteCEN deportecen = new DeporteCEN (deporterepository);
                HorarioRepository horariorepository = new HorarioRepository ();
                HorarioCEN horariocen = new HorarioCEN (horariorepository);
                CodigoPostalRepository codigopostalrepository = new CodigoPostalRepository ();
                CodigoPostalCEN codigopostalcen = new CodigoPostalCEN (codigopostalrepository);

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
                EstadoPistaCP estadopistacp = new EstadoPistaCP (session, unitRep);
                ValoracionCP valoracioncp = new ValoracionCP (session, unitRep);
                PagoCP pagocp = new PagoCP (session, unitRep);
                TipoCP tipocp = new TipoCP (session, unitRep);
                IdiomaCP idiomacp = new IdiomaCP (session, unitRep);
                DeporteCP deportecp = new DeporteCP (session, unitRep);
                HorarioCP horariocp = new HorarioCP (session, unitRep);
                CodigoPostalCP codigopostalcp = new CodigoPostalCP (session, unitRep);


                /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/

                // You must write the initialisation of the entities inside the PROTECTED comments.
                // IMPORTANT:please do not delete them.

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
