using PROSEGUR.Negocio;
using PROSEGUR.Entidades;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PROSEGUR.Test
{
    [TestClass]
    public class EvaluacionServicioTest
    {
        CNEvaluacionServicio objCNEvaluacionServicio = new CNEvaluacionServicio();
        CNDetalleEvaluacionServicio objCNDetalleEvaluacionServicio = new CNDetalleEvaluacionServicio();
        
        [TestMethod]
        public void EsValidoRegistroEvaluacionSinCorreo()
        {
            CEEvaluacionServicio objCEEvaluacionServicio = new CEEvaluacionServicio()
            {
                Nombres = "Manuel Gonzales"
            };

            CERepuesta resultado = objCNEvaluacionServicio.Agregar(objCEEvaluacionServicio);

            Assert.IsFalse(resultado.Resultado);
        }

        [TestMethod]
        public void EsValidoRegistroEvaluacionSinNombres()
        {
            CEEvaluacionServicio objCEEvaluacionServicio = new CEEvaluacionServicio()
            {
                Correo = "manuel123@gmail.com"
            };

            CERepuesta resultado = objCNEvaluacionServicio.Agregar(objCEEvaluacionServicio);

            Assert.IsFalse(resultado.Resultado);
        }

        [TestMethod]
        public void EsValidoRegistroEvaluacionSinDatos()
        {
            CEEvaluacionServicio objCEEvaluacionServicio = new CEEvaluacionServicio();

            CERepuesta resultado = objCNEvaluacionServicio.Agregar(objCEEvaluacionServicio);

            Assert.IsFalse(resultado.Resultado);
        }

        [TestMethod]
        public void EsValidoRegistroEvaluacion()
        {
            CEEvaluacionServicio objCEEvaluacionServicio = new CEEvaluacionServicio()
            {
                Correo = "manuel123@gmail.com",
                Nombres = "Manuel Gonzales"
            };

            CERepuesta resultado = objCNEvaluacionServicio.Agregar(objCEEvaluacionServicio);

            Assert.IsTrue(resultado.Resultado);
        }

        [TestMethod]
        public void EsValidoRegistroDetalleEvaluacionSinCalificacion()
        {
            CEDetalleEvaluacionServicio objCEDetalleEvaluacionServicio = new CEDetalleEvaluacionServicio()
            {
                Fecha = DateTime.Now
            };

            CEEvaluacionServicio objCEEvaluacionServicio = new CEEvaluacionServicio()
            {
                Correo = "manuel123@gmail.com",
                Nombres = "Manuel Gonzales",
                Detalle = objCEDetalleEvaluacionServicio
            };

            CERepuesta resultado = objCNDetalleEvaluacionServicio.Agregar(objCEEvaluacionServicio);

            Assert.IsFalse(resultado.Resultado);
        }

        [TestMethod]
        public void EsValidoRegistroDetalleEvaluacionSinFecha()
        {
            CEDetalleEvaluacionServicio objCEDetalleEvaluacionServicio = new CEDetalleEvaluacionServicio()
            {
                Calificacion = 1
            };

            CEEvaluacionServicio objCEEvaluacionServicio = new CEEvaluacionServicio()
            {
                Correo = "manuel123@gmail.com",
                Nombres = "Manuel Gonzales",
                Detalle = objCEDetalleEvaluacionServicio
            };

            CERepuesta resultado = objCNDetalleEvaluacionServicio.Agregar(objCEEvaluacionServicio);

            Assert.IsFalse(resultado.Resultado);
        }

        [TestMethod]
        public void EsValidoRegistroDetalleEvaluacion()
        {
            CEDetalleEvaluacionServicio objCEDetalleEvaluacionServicio = new CEDetalleEvaluacionServicio()
            {
                Fecha = DateTime.Now,
                Calificacion = 1
            };

            CEEvaluacionServicio objCEEvaluacionServicio = new CEEvaluacionServicio()
            {
                Correo = "manuel123@gmail.com",
                Nombres = "Manuel Gonzales",
                Detalle = objCEDetalleEvaluacionServicio
            };

            CERepuesta resultado = objCNDetalleEvaluacionServicio.Agregar(objCEEvaluacionServicio);

            Assert.IsTrue(resultado.Resultado);
        }
    }
}