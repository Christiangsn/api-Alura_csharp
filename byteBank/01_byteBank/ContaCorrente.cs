public class ContaCorrente
{
    public string titular;
    public string titularCPF;
    public string titularProfissao;

    public int numeroAgencia;
    public int numeroConta;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;

    }

    public bool Transferir(
        double valor,
        ContaCorrente ContaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            ContaDestino.Depositar(valor);
            return true;
        }
    }
}
