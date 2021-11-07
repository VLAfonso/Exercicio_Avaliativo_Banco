public class ContaCorrente:IPessoaFisica{
    public string Nome {get; set;}
    public string CPF {get; set;}
    public int Agencia {get; set;}
    public static int NumTotalContas {get; set;}
    public static double TotalComissao {get; set;}
    private double _saldo;

    public double Saldo{
        get{
            return this._saldo;
        }
        set{
            if(value>=0){
                this._saldo = value;
            }
        }
    }

    public ContaCorrente(){}
    public ContaCorrente(string nome, string cpf, int agencia, double saldo, Funcionario funcionario){
        this.Nome = nome;
        this.CPF = cpf;
        this.Agencia = agencia;
        this.Saldo = saldo;

        NumTotalContas ++;
        TotalComissao+=saldo*0.01;
        funcionario.Comissao += saldo*0.01;
    }

    public void Depositar(double valor){
        this.Saldo += valor;
    }

    public bool Sacar(double valor){
        if(this.Saldo < valor){
            return false;
        }
        else{
            this.Saldo -= valor;
            return true;
        }
    }

    public bool Transferir(double valor, ContaCorrente contaDestino){
        if(this.Sacar(valor)){
            contaDestino.Depositar(valor);
            return true;
        }
        else{
            return false;
        }
    }
}