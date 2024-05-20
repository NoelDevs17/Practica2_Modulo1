using Practica2_Modulo1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Modulo1.Entidades
{
     class ImpresoraCuentas: Banco
    {
        public void ImprimirCuenta(ICuentaBancaria cuenta, string nombre, int saldo)
        {
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Saldo: {1}", saldo);
        }
    }
}
