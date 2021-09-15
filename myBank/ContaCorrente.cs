public class ContaCorrente{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo;

    public ContaCorrente() {}

    public ContaCorrente(string contacorrente_titular, int contacorrente_agencia, int contacorrente_conta, double contacorrente_saldo){
        this.titular = contacorrente_titular;
        this.agencia = contacorrente_agencia;
        this.conta = contacorrente_conta;
        this saldo = contacorrente_saldo; 


    }
    public bool Sacar(double valor){
        if(this.saldo < valor){
            return false;
        }
        else{
            this.saldo -= valor;
            return true;
        }
    }
    public void Depositar(double valor){
        this.saldo += valor;
    }

    public bool Transferir (double valor, ContaCorrente contaDestino){
        if(this.saldo < valor){
            return false;
        }
        else{
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }


}


