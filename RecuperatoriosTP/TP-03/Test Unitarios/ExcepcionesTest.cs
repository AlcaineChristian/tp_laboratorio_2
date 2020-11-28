using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using EntidadesInstanciadas;
using Excepciones;


namespace Test_Unitarios
{
    [TestClass]
    public class ExcepcionesTest
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void Test_AlumnoRepetidoException()
        {
            Universidad u = new Universidad();
            Alumno a = new Alumno(1694, "Tomas", "Alcaine", "41668879", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.AlDia);

            u += a;
            u += a;
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void Test_DniInvalidoException()
        {
            Alumno a = new Alumno(1694, "Tomas", "Alcaine", "hola", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.AlDia);
            
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void Test_NacionalidadInvalidaException()
        {
            Alumno a = new Alumno(1694, "Tomas", "Alcaine", "90000000", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.AlDia);

        }
        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestSinProfesor()
        {
            Universidad universidadAux = new Universidad();
            universidadAux += Universidad.EClases.Laboratorio;
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]
        public void TestArchivoInvalido()
        {
            Texto archivoDeTexto = new Texto();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Jornada.txt";
            archivoDeTexto.Leer(path, out string datosLeidos);
        }
    }
}
