using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;
using ByteBank;

LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.Fechar();
}
catch (IOException)
{
    leitor.Fechar();
    Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
}
finally{
    leitor.Fechar();
    Console.WriteLine()
}
/*
try
{
    ContaCorrente conta1 = new ContaCorrente(4564, "789684");
    ContaCorrente conta2 = new ContaCorrente(7891, "456794");

    // conta1.Transferir(10000, conta2);
    conta1.Sacar(10000);
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
    
}
catch(OperacaoFinanceiraException ex)
{
    //Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);

    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

    //Console.WriteLine(ex.InnerException.Message);
    //Console.WriteLine(value: ex.InnerException.StackTrace);
}
*/
