
namespace _02_byteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
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