using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Telefono
    {
        // Agregale los siguientes atributos:
        //
        // Modelo string.
        // Marca string.
        // NumeroTelefonico string.
        // CodigoOperador int (1, 2 o 3).
        //
        // Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
        //
        // Modelo: solo lectura. Es decir, solo get.
        // Marca: solo lectura.
        // NumeroTelefonico: lectura y escritura.
        // CodigoOperador: lectura y escritura.
        // Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
        // Agregar Constructor que reciba Modelo y Marca.

        public Telefono(string modelo, string marca)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        private int codigoOperador;

        public string Modelo { get; }
        public string Marca { get; }
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

        // Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        // Sobrecargar el método Llamar(string contacto) para que reciba un contacto
        // y devuelva un string con la leyenda "Llamando a " + contacto

        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto + "...";
        }

    }
}
