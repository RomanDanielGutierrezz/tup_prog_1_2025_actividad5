using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_del_super
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Line, cantProd, cantFallos, cantAceptados, contadorPara;
            double kcal, sodio, grasa, carbos, fibra;
            bool bandera;
            Console.WriteLine("Ingrese la cantidad de productos a cargar:");
            cantProd = Convert.ToInt32(Console.ReadLine());
            kcal = 0;
            cantFallos = 0;
            for ( contadorPara = 1; contadorPara <= cantProd; contadorPara++)
            {
                bandera = false;
                Line = 1;
                while (bandera == false && Line <= 5)
                {
                    switch (Line)
                    {
                        case 1: //kcal
                            Console.WriteLine("Ingrese las kcal del producto:");
                            kcal = Convert.ToInt32(Console.ReadLine());
                            if (kcal > 200 | kcal < 100)
                            {
                                bandera = true;
                            }
                            break;
                        case 2: //carbohidratos
                            Console.WriteLine("Ingrese los carbohidratos (en Gr):");
                            carbos = Convert.ToInt32(Console.ReadLine());
                            carbos = (carbos / kcal) * 100;
                            if (carbos > 15 || carbos < 0)
                            {
                                bandera = true;
                            }
                            break;
                        case 3: // grasa
                            Console.WriteLine("Ingrese la grasa (en Gr):");
                            grasa = Convert.ToInt32(Console.ReadLine());
                            grasa = (grasa / kcal) * 100;
                            if (grasa > 13 & grasa < 1)
                            {
                                bandera = true;
                            }
                            break;
                        case 4: // fibra
                            Console.WriteLine("Ingrese la fibra (en Gr):");
                            fibra = Convert.ToInt32(Console.ReadLine());
                            fibra = (fibra / 28) * 100;
                            if (fibra > 15 || fibra < 0)
                            {
                                bandera = true;
                            }
                            break;
                        case 5: // sodio
                            Console.WriteLine("Ingrese el sodio (en Mg):");
                            sodio = Convert.ToInt32(Console.ReadLine());
                            sodio = (sodio / 2300) * 100;
                            if (sodio > 2 || sodio < 0)
                            {
                                bandera = true;
                            }
                            break;
                    }
                    Line++;
                }
                if (!bandera)
                {
                    cantFallos++;
                }
            }
            cantAceptados = cantProd - cantFallos;
            Console.WriteLine($"La cantidad de productos que no cumplieron los requisitos fueron {cantFallos} y los que si {cantAceptados}");
            Console.ReadKey();
        }
    }
}