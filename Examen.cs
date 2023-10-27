using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU2_DGGR
{
    public class Examen
    {
        public void Calificaciones()
        {
            int[] calificaciones;
            calificaciones= new int[100];
            Random random= new Random(101);
            for (int i= 0; i <calificaciones.Length; i++)
            {
                calificaciones[i] = random.Next(101);
                Console.Write(calificaciones[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Las calificaciones ordenadas son");
            int temporal = 0;
            for (int y=0; y< calificaciones.Length-1; y++)
            {
                for(int x= y +1; x< calificaciones.Length; x++)
                {
                    if (calificaciones[y] < calificaciones[x])
                    {
                        temporal = calificaciones[y];
                        calificaciones[y] = calificaciones[x];
                        calificaciones[x]= temporal;
                    }
                }
            }
            for (int a =0; a<calificaciones.Length; a++)
            {
                Console.Write(calificaciones[a]+ ",");
            }
            Console.WriteLine();
            Console.WriteLine("¿Que numeroro decea buscar?");
            int buscar=Convert.ToInt32(Console.ReadLine());
            int primero = 0;
            int ultimo = calificaciones.Length- 1;
            int posicion = -1;
            while(primero < ultimo)
            {
                int medio = (primero + ultimo)/2;
                if (calificaciones[medio] == buscar)
                {
                    posicion= medio;
                    
                }
                else if (calificaciones[medio] < buscar)
                {
                    primero = medio - 1;
                    
                }
                else if(calificaciones[medio] > buscar)
                {
                    ultimo = medio +1;
                    
                }
                
            }
            if (posicion != -1)
            {
                Console.WriteLine($"El numero {buscar} se encuentra en la pocicion {posicion}");
            }
            else
            { Console.WriteLine($"El numero {buscar} no se encuentra"); }

        }

        public void vandedores()
        {
            int[,] productovendedor = new int[5, 4] { { 500, 3000, 100, 400 }, { 1000, 150, 200, 500 }, { 250, 1800, 2900, 300 }, { 400, 130, 90, 2400 }, { 60, 20, 4000, 3600 } };
            for (int i=0; i < productovendedor.GetLength(0); i++)
            {
                for (int j=0; i<productovendedor.GetLength(1);j++)
                {
                    Console.Write(productovendedor[i,j] + "|");
                }
            }
        }
    }
}
