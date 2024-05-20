using Practica2_Modulo1.Interfaces;


namespace Practica2_Modulo1.Entidades
{
    class Banco
    {
        private List<ICuentaBancaria> clientes;


        public Banco()
        {
            clientes = new List<ICuentaBancaria> ();
            clientes.Add(new Cliente("Igor"));
            clientes.Add(new Cliente("Adderly"));
            clientes.Add(new Cliente("Penco"));
        }


        public void Operar()
        {
            foreach (var cliente in clientes)
            {
                cliente.Depositar(100);
            }

            clientes[2].Extraer(150);
        }

        public void DepositosTotales()
        {
            int total = 0;
            foreach (var cliente in clientes)
            {
                total += cliente.ConsultarSaldo();
            }

            Console.WriteLine("El total de dinero en el banco es: {0}", total);

            foreach (var cliente in clientes)
            {
                cliente.Imprimir();
            }
        }

    }
}
