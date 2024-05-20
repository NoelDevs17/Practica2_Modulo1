

namespace Practica2_Modulo1.Interfaces
{
     interface ICuentaBancaria
    {
        void Depositar(int monto);
        void Extraer(int monto);
        int ConsultarSaldo();
        void Imprimir();
    }
}
