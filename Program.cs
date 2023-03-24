using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4
{
    class Program
    {

    //        Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla
    //        el estado del Telefono.
    //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
    //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string
    //con la leyenda "Llamando a " + contacto
    //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

        static void Main(string[] args)
        {

            Telefono t1 = new Telefono();
            t1.NumeroTelefonico = "15304584569";

            Telefono t2 = new Telefono("Redmi Note", "Xiaomi");
            t2.CodigoOperador= 1;
            t1.CodigoOperador = 4;
            Console.WriteLine("la marca es " + t2.Marca);
            Console.WriteLine(t1.NumeroTelefonico);
            Console.WriteLine("El código del primero es " + t1.CodigoOperador);
            Console.WriteLine("El Código del 2do es " + t2.CodigoOperador);
            

            Console.WriteLine(t1.Llamar());

            Console.WriteLine(t2.Llamar("Pablo"));



            Console.ReadKey();

        }
    }
}
