using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2
{
    public class Car
    {       // atributos del carro
        string color;
        int cilindraje;
        int modelo;


        //metodo
        public string stop()
        {
            string msj = "el carro esta detenido";
            return msj;
        }
    }
}