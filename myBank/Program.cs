using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteRonny = new Gerente(){
                Nome = "Ronny Alberto",
                CPF = "175.953.888-33",
                Salario = 15000,
                NumeroAgencias = 3,
            };
            gerenteRonny.Bonificacao = gerenteRonny.Salario;

            Vendedor vendedorCeres = new Vendedor(){
                Nome = "Céres Regina",
                CPF = "225.087.453.77",
                Salario = 5000,
                NumeroClientesAtendidos = 5,
            };
            vendedorCeres.Bonificacao = vendedorCeres.Salario;

            Vendedor vendedorNatanael = new Vendedor(){
                Nome = "Natanael Gonçalves",
                CPF = "457.072.843-88",
                Salario = 2500,
                NumeroClientesAtendidos = 5,
            };
            vendedorNatanael.Bonificacao = vendedorNatanael.Salario;

            Vendedor vendedorJonatan = new Vendedor(){
                Nome = "Jonatan Alberto",
                CPF = "2195.564.781-33",
                Salario = 2500,
                NumeroClientesAtendidos = 5,
            };
            vendedorJonatan.Bonificacao = vendedorJonatan.Salario;

            ContaCorrente contaVirginiaLeticiaAfonso = new ContaCorrente("Virgínia Letícia Afonso", "572.695.329-66", 1579, 10000, vendedorCeres);
            contaVirginiaLeticiaAfonso.Conta = 557;

            ContaCorrente contaMateusAlberto = new ContaCorrente("Mateus Alberto", "485.965.782-99", 1579, 3000, vendedorNatanael);
            contaMateusAlberto.Conta = 556;

            ContaCorrente contaCarlosDaniel = new ContaCorrente("Carlos Daniel", "885.362.487-55", 2697, 16000, vendedorJonatan);
            contaCarlosDaniel.Conta = 472;

            Console.WriteLine("Contas correntes:");
            Console.WriteLine("Conta 1: \nNome:"+contaVirginiaLeticiaAfonso.Nome+
            "\nCPF: "+contaVirginiaLeticiaAfonso.CPF+
            "\nAgência: "+contaVirginiaLeticiaAfonso.Agencia+
            "\nConta: "+contaVirginiaLeticiaAfonso.Conta+
            "\nSaldo: "+contaVirginiaLeticiaAfonso.Saldo);

            Console.WriteLine("\nConta 2: \nNome:"+contaMateusAlberto.Nome+
            "\nCPF: "+contaMateusAlberto.CPF+
            "\nAgência: "+contaMateusAlberto.Agencia+
            "\nConta: "+contaMateusAlberto.Conta+
            "\nSaldo: "+contaMateusAlberto.Saldo);

            Console.WriteLine("\nConta 3: \nNome:"+contaCarlosDaniel.Nome+
            "\nCPF: "+contaCarlosDaniel.CPF+
            "\nAgência: "+contaCarlosDaniel.Agencia+
            "\nConta: "+contaCarlosDaniel.Conta+
            "\nSaldo: "+contaCarlosDaniel.Saldo);

            Console.WriteLine("\nFuncionários:");
            Console.WriteLine("Vendedor 1: \nNome:"+vendedorCeres.Nome+
            "\nCPF: "+vendedorCeres.CPF+
            "\nSalário: "+vendedorCeres.Salario+
            "\nNúmero de clientes atendidos: "+vendedorCeres.NumeroClientesAtendidos+
            "\nComissão: "+vendedorCeres.Comissao+
            "\nBonificação anual: "+vendedorCeres.Bonificacao+
            "\nRemuneração total: "+vendedorCeres.RemuneracaoTotal(vendedorCeres.Salario, vendedorCeres.Bonificacao)+
            "\nDias de férias: "+vendedorCeres.CalcularFerias());

            Console.WriteLine("\nVendedor 2: \nNome:"+vendedorNatanael.Nome+
            "\nCPF: "+vendedorNatanael.CPF+
            "\nSalário: "+vendedorNatanael.Salario+
            "\nNúmero de clientes atendidos: "+vendedorNatanael.NumeroClientesAtendidos+
            "\nComissão: "+vendedorNatanael.Comissao+
            "\nBonificação anual: "+vendedorNatanael.Bonificacao+
            "\nRemuneração total: "+vendedorNatanael.RemuneracaoTotal(vendedorNatanael.Salario, vendedorNatanael.Bonificacao)+
            "\nDias de férias: "+vendedorNatanael.CalcularFerias());

            Console.WriteLine("\nVendedor 3: \nNome:"+vendedorJonatan.Nome+
            "\nCPF: "+vendedorJonatan.CPF+
            "\nSalário: "+vendedorJonatan.Salario+
            "\nNúmero de clientes atendidos: "+vendedorJonatan.NumeroClientesAtendidos+
            "\nComissão: "+vendedorJonatan.Comissao+
            "\nBonificação anual: "+vendedorJonatan.Bonificacao+
            "\nRemuneração total: "+vendedorJonatan.RemuneracaoTotal(vendedorJonatan.Salario, vendedorJonatan.Bonificacao)+
            "\nDias de férias: "+vendedorJonatan.CalcularFerias());

            Console.WriteLine("\nGerente 1: \nNome:"+gerenteRonny.Nome+
            "\nCPF: "+gerenteRonny.CPF+
            "\nSalário: "+gerenteRonny.Salario+
            "\nNúmero de agências: "+gerenteRonny.NumeroAgencias+
            "\nBonificação anual: "+gerenteRonny.Bonificacao+
            "\nRemuneração total: "+gerenteRonny.RemuneracaoTotal(gerenteRonny.Salario, gerenteRonny.Bonificacao)+
            "\nDias de férias: "+gerenteRonny.CalcularFerias());

            Console.WriteLine("\nTotal de contas criadas: "+ContaCorrente.NumTotalContas);
        }
    }
}
