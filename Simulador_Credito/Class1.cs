using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Credito
{
    class Class1
    {
        //Atributos

        public string nombre;
        public string apellido;
        public int monto_solicitado;
        public int cuotas;
        public int interes;
        public int monto_total;

        //Metodos

        public void Monto_requerido()
        {
            if (monto_solicitado > 500000)
                }
      


















        public void Contar_cuotas()
        {
            int cuotas = int.Parse(Console.ReadLine());
            if (cuotas < 1)
            {
                Console.WriteLine("El mínimo de cuotas es 1");
            }
            else if (cuotas > 36)
            {
                Console.WriteLine("El máximo de cuotas son 36");
            }

            Console.ReadLine();




        }
    } }
