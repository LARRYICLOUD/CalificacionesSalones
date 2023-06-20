using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesSalones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, j, numAlumnos, salones;
            double promedio, sumaAlumnos = 0, sumaCalif = 0, califMin = 10, califMax = 0;
            //Pedimos el numero de salones
            Console.Write("ingrese el numero de salones: ");
            salones = Convert.ToByte(Console.ReadLine());
            //creacion de la matriz
            double[][] calificaciones = new double[salones][];
            //for para pedir calificaciones
            for (i = 0; i < salones; i++)  //salones esta controlada por i
            {
                Console.Write("Ingrese el numero de alumnos para el salon {0}: ", i);
                //lee el numero de alumnos                
                numAlumnos = Convert.ToByte(Console.ReadLine());
                //Acumulamos el numero de alumnos totales, para todo el promedio de  la escuela
                sumaAlumnos += numAlumnos;
                //Instaciamos cada una de las matrices internas (Alumnos en cada salon)
                calificaciones[i] = new double[numAlumnos]; 


            }

            //pedimos las calificaciones de todos los alumnos de cada salon
            for(i=0; i < salones; i++)
            {
                Console.WriteLine("Salon {0}", i);
                for(j=0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("Ingrese la califaicacion del alunmo {0}", j);//calificacion del alumno esta controlada por j
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());
                    //acumulamos calificaciones
                    sumaCalif += calificaciones[i][j];


                }
            }

            promedio = sumaCalif / sumaAlumnos;
            //calculamos la calificacione minima
            for(i=0;i < salones; i++)
            {
                for(j=0; j< calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                }
            }
            //calculamos la calificacion maxima

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }

            //mostramos todas las calificaciones de todos los alumnos d ela escuela
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salon {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("el alumno {0},tiene {1} de calificacion", j, calificaciones[i][j]);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());
                    //acumulamos calificaciones
                    sumaCalif += calificaciones[i][j];


                }
            }














            //mostramos los resultados
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificacion minima es: {0}", califMin);
            Console.WriteLine("La calificacion maxima es: {0}", califMax);






        }
    }
}
