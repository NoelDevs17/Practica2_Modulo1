using Practica2_Modulo1.Interfaces;


namespace Practica2_Modulo1.Entidades
{
    class Cliente : ICuentaBancaria
    {
        private string nombre;
        private int saldo;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.saldo = 0;
        }

        public void Depositar(int monto)
        {
            this.saldo += monto;
        }

        public void Extraer(int monto)
        {
            this.saldo -= monto;
        }

        public int ConsultarSaldo()
        {
            return this.saldo;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }
        public void Imprimir()
        {
            ImpresoraCuentas impresora = new ImpresoraCuentas();
            impresora.ImprimirCuenta(this, this.Nombre, this.Saldo); // Se pasan los valores como parámetros
        }
    }

}