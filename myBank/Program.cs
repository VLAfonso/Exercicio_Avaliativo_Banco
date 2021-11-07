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

            Vendedor vendedorCeres = new Vendedor(){
                Nome = "Céres Regina",
                CPF = "225.087.453.77",
                Salario = 5000,
                NumeroClientesAtendidos = 5,
            };

            Vendedor vendedorNatanael = new Vendedor(){
                Nome = "Natanael Gonçalves",
                CPF = "457.072.843-88",
                Salario = 2500,
                NumeroClientesAtendidos = 5,
            };

            Vendedor vendedorJonatan = new Vendedor(){
                Nome = "Jonatan Alberto",
                CPF = "2195.564.781-33",
                Salario = 2500,
                NumeroClientesAtendidos = 5,
            };

            ContaCorrente contaVirginiaLeticiaAfonso = new ContaCorrente("Virgínia Letícia Afonso", "572.695.329-66", 1579, 10000, vendedorCeres);
            contaVirginiaLeticiaAfonso.Conta = 557;

            ContaCorrente contaMateusAlberto = new ContaCorrente("Mateus Alberto", "485.965.782-99", 1579, 3000, vendedorNatanael);
            contaMateusAlberto.Conta = 556;

            ContaCorrente contaCarlosDaniel = new ContaCorrente("Carlos Daniel", "885.362.487-55", 2697, 16000, vendedorJonatan);
            contaCarlosDaniel.Conta = 472;
        }
    }
}
