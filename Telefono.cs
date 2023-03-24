using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo4
{
//    Crear un proyecto de consola.Net Framework.
//Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
//Agregale los siguientes atributos:
//Modelo string.
//Marca string.
//NumeroTelefonico string.
//CodigoOperador int (1, 2 o 3).
//Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
//Modelo: solo lectura. Es decir, solo get.
//Marca: solo lectura.
//NumeroTelefonico: lectura y escritura.
//CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
//Agregar Constructor que reciba Modelo y Marca.

    class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        public Telefono() { }

        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

       

        public string Modelo {
            get { return modelo; } }
        

        public string Marca {

            get { return marca; } }

        public string NumeroTelefonico { get; set; }

        public int CodigoOperador
        {
            get { return codigoOperador; }

            set
            {
                if (value == 1 || value == 2 || value == 3)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        
        public string Llamar(string contacto)
        {
            return "Llamando a " +  contacto;
        }

       

        



        }



        
    }


