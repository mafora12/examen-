using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03_PavimentacionCalles;

namespace PruebasUnitarias
{
    [TestClass]
    public class pruebas_unitarias
    {
        [TestMethod]
        public void TotalizaAfectacionesPorDeterioro_shouldCalcAndreturntotalafectados()
        {
            string[] losDeterioros = { "Agrietamientos", "Hundimientos", "Ondulaciones" };
            Calle[] calles = new Calle[2];
            calles[0]=new Calle();
            calles[0].TipoDeterioro = losDeterioros[0];
            calles[0].Longitud = 100;
            calles[0].TramoAfectado = 20;

            calles[1] = new Calle();
            calles[1].TipoDeterioro = losDeterioros[2];
            calles[1].Longitud = 100;
            calles[1].TramoAfectado = 20;
            int[] respuesta = Ex03_PavimentacionCalles.Program.TotalizaAfectacionesPorDeterioro(calles, losDeterioros);
            CollectionAssert.AreEqual(new int[] { 1, 0, 1 }, respuesta); 
        }
        [TestMethod]
        public void ObtieneLongitudPromedioTramosPorDeterioro_shouldCalcAndreturntramospordeterioro()
        {

            string[] losDeterioros = { "Agrietamientos", "Hundimientos", "Ondulaciones" };
            Calle[] calles = new Calle[2];
            calles[0] = new Calle();
            calles[0].TipoDeterioro = losDeterioros[0];
            calles[0].Longitud = 100;
            calles[0].TramoAfectado = 20;
       
            calles[1] = new Calle();
            calles[1].TipoDeterioro = losDeterioros[0];
            calles[1].Longitud = 500;
            calles[1].TramoAfectado = 210;
            double[] respuesta = Ex03_PavimentacionCalles.Program.ObtieneLongitudPromedioTramosPorDeterioro(calles, losDeterioros);
            double[] esperando = new double[3]; esperando[0] = 535;
            Assert.AreEqual(535, respuesta[0]);

             




        }


    }
}
