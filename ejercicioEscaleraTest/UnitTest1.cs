using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicioEscalera;

namespace ejercicioEscaleraTest
{
    [TestClass]
    public class UnitTest1
    {
        int[] cartas;
        bool respuesta;

        [TestMethod]
        public void controlarEscaleraPerfectaInvertida()
        {
            cartas = new int[7] { 7, 6, 5, 4, 3, 2, 1 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraPerfecta()
        {
            cartas = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraCorrectaInicial()
        {
            cartas = new int[7] { 9, 10, 11, 12, 13, 6, 7 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraCorrectaFinal()
        {
            cartas = new int[7] { 3, 2, 9, 10, 11, 12, 13 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraIncorrecta()
        {
            cartas = new int[7] { 3, 2, 9, 10, 11, 12, 7 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsFalse(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraDafiti1Correcta()
        {
            cartas = new int[5] { 14, 2, 3, 4, 5 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraDafiti2Correcta()
        {
            cartas = new int[5] { 9, 10, 11, 12, 13 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraDafiti3Correcta()
        {
            cartas = new int[7] { 2, 7, 8, 5, 10, 9, 11 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraDafiti4Incorrecta()
        {
            cartas = new int[5] { 7, 8, 12, 13, 14 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsFalse(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraDafiti5Correcta()
        {
            cartas = new int[5] { 2, 3, 4, 5, 6 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraDafiti6Correcta()
        {
            cartas = new int[5] { 14, 5, 4, 2, 3 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraDafiti7Incorrecta()
        {
            cartas = new int[7] { 7, 7, 12, 11, 3, 4, 14 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsFalse(respuesta);
        }

        [TestMethod]
        public void controlarEscaleraDafiti8Incorrecta()
        {
            cartas = new int[3] { 7, 3, 2 };
            Program programa = new Program(cartas);
            respuesta = programa.comprobarEscalera();
            Assert.IsFalse(respuesta);
        }
    }
}
