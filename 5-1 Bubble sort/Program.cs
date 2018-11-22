using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("BUBBLE SORT");
                int valor = 0;//valor que ayudara a mantener valores lo suficiente para lograr el metodo

                Console.Write("¿Cuantos numeros va a ingresar? ");
                int NumIngresar = int.Parse(Console.ReadLine());
                int[] Numeros = new int[NumIngresar];//Arreglo con tamaño que asigno usuario
                for (int i = 0; i < NumIngresar; i++)
                {
                    Console.Write("Numero {0}: ", i + 1);
                    Numeros[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < NumIngresar; i++)//Bubblesort
                {
                    for (int j = 0; j < NumIngresar - 1; j++)
                    {
                        if (Numeros[i] < Numeros[j])//Condicion de ordenamiento
                        {
                            valor = Numeros[i];//Conserva los valores antes de cambiarlos
                            //intercambio de valores 
                            Numeros[i] = Numeros[j];
                            Numeros[j] = valor;
                        }
                    }
                }
                Console.WriteLine("Numeros despues de Bubblesort:");
                for (int i = 0; i < NumIngresar; i++)
                {
                    Console.WriteLine("{0}",  Numeros[i]);//imprime elementos ordenados
                }
                Console.ReadKey();
           
        }
    }
}
