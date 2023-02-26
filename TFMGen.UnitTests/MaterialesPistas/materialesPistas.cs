using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.Exceptions;

namespace TFMGen.UnitTests.MaterialesPistas
{
    [TestClass]
    public class materialesPistas
    {
        Context db;
        public materialesPistas() 
        {
            this.db = new Context();
        }

        [TestMethod]
        public void CrearNuevoMaterial()
        {
            EntidadEN entidadEN = db.entidadcen.Listar(0,1).First();
            InstalacionEN instalacionEN = db.instalacioncen.Listar(entidadEN.Identidad).First();
            int material_id = this.db.materialcen.Crear("Barra Olimpica 20k", 100.50, "Gymnastics", instalacionEN.Idinstalacion, "Barra Olimpica", 5);

            MaterialEN materialEN = this.db.materialcen.Obtener(material_id);

            Assert.AreEqual(true, materialEN != null, "Material agregado: ",materialEN);
        }

        [TestMethod, ExpectedException(typeof(DataLayerException))]
        public void CrearNuevoMaterialSinNombre()
        {
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            InstalacionEN instalacionEN = db.instalacioncen.Listar(entidadEN.Identidad).First();
            int material_id = this.db.materialcen.Crear(null, 100.50, "Gymnastics", instalacionEN.Idinstalacion, "Barra Olimpica", 5);
        }

        [TestMethod]
        public void ModificarMaterial()
        {
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            InstalacionEN instalacionEN = db.instalacioncen.Listar(entidadEN.Identidad).First();
            MaterialEN materialAModificar = db.materialcen.Listar(instalacionEN.Idinstalacion).First();

            string nueva_descripcion = "Canasta grande no reglamentaria";

            MaterialEN materialENModificado = new MaterialEN();
            materialENModificado.Idmaterial = materialAModificar.Idmaterial;
            materialENModificado.Nombre = "Cansasta de 3,05 metros";
            materialENModificado.Descripcion = nueva_descripcion;
            materialENModificado.Precio = 200.45;
            materialENModificado.Proveedor = "Deuba XXL";
            materialENModificado.Numexistencias = 10;
            materialENModificado.Instalacion = instalacionEN;

            this.db.materialcen.Editar(materialENModificado.Idmaterial, materialENModificado.Nombre, 
                materialENModificado.Precio,materialENModificado.Proveedor, materialENModificado.Descripcion, 
                materialENModificado.Numexistencias);

            Assert.AreEqual(materialENModificado, materialAModificar, "Material actualizado correctamente: ", materialAModificar);
        }

        [TestMethod, ExpectedException(typeof(DataLayerException))]
        public void EliminarMaterial()
        {
            int material_id = -1;

            this.db.materialcen.Eliminar(material_id);

            Assert.AreEqual(-1, material_id, "Descripcion del material es obligatorio");
        }
    }
}