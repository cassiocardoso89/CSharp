namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        private int agencia;
        public int Agencia
        {
            get
            {
                return agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                agencia = value;
            }
        }
        public int Numero { get; set; }

        private double saldo = 100;

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalDeContasCriadas;
            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
