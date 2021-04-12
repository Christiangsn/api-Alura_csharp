namespace byteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }

        public static int TotalContas { get; set; }

        private int _agencia;
        public int Agencia { 

            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }
            }

        }

        public int NumeroConta { get; set; }
        private double _saldo { get; set; }

    public double Saldo
        {

            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {

                }
                else
                {
                    _saldo += value;
                }
            }

        }

        public void SetSaldo(double valor)
        {

        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            NumeroConta = numero;
            TotalContas++;
        }



        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }


    }
}