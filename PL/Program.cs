using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClassB refb = new ClassB();
            int x = 2;
            int y = 1;
            y = refb.test(x, y);
            Console.WriteLine("Paso 1, res =" + y);
            y = refb.test(x, y);
            Console.WriteLine("Paso 2, res =" + y);
            x = refb.test(x, 0);
            Console.WriteLine("Paso 3, res =" + x);
            Console.Read();
            
        }
        




        //Persona persona = new Persona();
        //persona.Nombre = "Fernanda";
        //persona.Edad = 25;
        //persona.Peso = 60;

        //Console.WriteLine(persona.CambiaNombre());
        //Console.WriteLine("Calculo de peso * edad: " + persona.Calcula());

        //Console.ReadKey();

        //string cadena = "adcdefg";
        //char[] caracteres = new char[cadena.Length];
        //cadena.CopyTo(0, caracteres, 0, caracteres.Length);

        //Array.Reverse(caracteres);
        //for (int i = 0; i < caracteres.Length; i++)
        //{
        //    Console.Write(caracteres[i]);
        //}




        //1er error: no es void, sino mas bien retorna un tipo de dato int
        //2do error: falta declarar i
        //3er error: se esta igualando un tipo de dato booleano a un entero en i = pos
        //4to error: le falta un identificador al parametro int [] el cual debe ser vec
        //public int metodoA(int[] vec, bool pos)
        //{
        //    int sum = 0;
        //    bool i;

        //    while ( i = pos)
        //    {
        //        sum = sum + vec[1];
        //    }
        //    return sum;
        //}


        //public Triangulo achatar(Triangulo triangulo)
        //{
        //    PL.Triangulo triangulo1 = new Triangulo();
        //    triangulo1.altura = triangulo.altura - (triangulo.altura * 10 / 100);
        //    return triangulo1;
        //}
    }

}

