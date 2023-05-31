using System;
using ByteBankAlura;

ContaCorrente contaCorrenteEdu = new ContaCorrente
{
    titular = "Eduardo Reis",
    conta = "784512",
    saldo = 1827.00,
    agencia = "8975"
};

Console.WriteLine("Saldo: " + contaCorrenteEdu.saldo);
contaCorrenteEdu.Depositar(100);
Console.WriteLine("Saldo atualizado: " + contaCorrenteEdu.saldo);

