﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.UnitTests.Instructores
{
    [TestClass]
    public class Instructores
    {
        Context db;

        public Instructores()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void CrearInstructor()
        {
            int rolid = this.db.rolcen.Listar(1, 0).Where(x=>x.Nombre == "Entrenador").Select(x=>x.Idrol).First();
            DateTime date = DateTime.Now;
            TimeSpan time = TimeSpan.FromDays(15);
            int idUsuario = this.db.usuariocen.Crear(
                "Andy",
                "ejemplo@test.com",
                "Calle San Juan", 
                "666777888",
                date.Subtract(time), 
                date,
                "McAllow",
                "Password",
                rolid,
                "03450",
                "Banyeres",
                "Alicante",
                "123456789",
                -1);
            UsuarioEN usuarioEn = this.db.usuariocen.Obtener(idUsuario);

            Assert.AreEqual(true, usuarioEn != null);
        }

        [TestMethod]
        public void ModificarInstructor()
        {
            int rolid = this.db.rolcen.Listar(1, 0).Where(x => x.Nombre == "Entrenador").Select(x => x.Idrol).First();
            UsuarioEN instructorModificar = this.db.usuariocen.Listar(1, 0).Where(x =>x.Email != "omm35@gcloud.ua.es" && x.Rol.Idrol == rolid).First();

            UsuarioEN instructorModificada = instructorModificar;
            instructorModificada.Nombre = "Instructor Modificado";

            this.db.usuariocen.Editar(instructorModificada.Idusuario, instructorModificada.Nombre, instructorModificada.Email, instructorModificada.Domicilio,
                instructorModificada.Telefono, DateTime.Now, DateTime.Now, instructorModificada.Apellidos, instructorModificada.Password, instructorModificada.Codigopostal,
                instructorModificada.Localidad, instructorModificada.Provincia, -1);

            Assert.AreEqual(instructorModificar,instructorModificada);
        }

        [TestMethod]
        public void CambiarNormalaInstructor()
        {
            UsuarioEN instructorModificar = this.db.usuariocen.Listar(1, 0).First();
            int entrenadorid = this.db.rolcen.Listar(1, 0).Where(x => x.Nombre == "Entrenador").Select(x => x.Idrol).First();
            RolEN rolEN = this.db.rolcen.Listar(1, 0).Where(x => x.Nombre == "Entrenador").First();

            this.db.usuariocp.Cambiarrol(instructorModificar.Idusuario, rolEN.Idrol);

            var usu = this.db.usuariocen.Obtener(instructorModificar.Idusuario);

            Assert.AreEqual(entrenadorid, usu.Rol.Idrol);
        }

        [TestMethod]
        public void EliminarInstructor()
        {
            int rolid = this.db.rolcen.Listar(1, 0).Where(x => x.Nombre == "Entrenador").Select(x => x.Idrol).First();
            int idUsuario = this.db.usuariocen.Crear(
                "Andy",
                "ejemplo@test.com",
                "Calle San Juan",
                "666777888",
                DateTime.Now,
                DateTime.Now,
                "McAllow",
                "Password",
                rolid,
                "03450",
                "Banyeres",
                "Alicante",
                "123456789",
                -1);
            UsuarioEN usuarioEn = this.db.usuariocen.Obtener(idUsuario);
            this.db.usuariocen.Eliminar(idUsuario);


            UsuarioEN usuarioError = this.db.usuariocen.Obtener(idUsuario);
            Assert.AreEqual(usuarioError, null);
        }
    }
}
