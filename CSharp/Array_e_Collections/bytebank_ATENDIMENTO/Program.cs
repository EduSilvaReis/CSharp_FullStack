using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Bem vindo ao atendimento do  ByteBank");

new ByteBankAtendimento().AtendimentoCliente();
#region Introdução Array
//void TestaArrayInt()
//{
//    int[] idades = new int[5];
//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;

//    Console.WriteLine($"Tamanho do Array {idades.Length}");

//    int acumulador = 0;
//    for (int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
//        Console.WriteLine($"índice [{i}] = {idade}");
//        acumulador += idade;
//    }

//    int media = acumulador / idades.Length;
//    Console.WriteLine($"Média de idades = {media}");
//}
//void TestaBuscarPalavra()
//{

//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite {i + 1}ª palavra:");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.Write("Digite palavra a ser encontrada:");
//    var busca = Console.ReadLine();

//    foreach (string str in arrayDePalavras)
//    {
//        if (str.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {str}");
//        }
//        else
//        {
//            Console.WriteLine($"Palavra {busca} não encontrada");
//        }
//    }

//}

//// código anterior omitido

//Array amostra = Array.CreateInstance(typeof(double), 5);
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

////[5,9][1,8][7,1][10][6,9]
////TestaMediana(amostra);

//void TestaMediana(Array array)
//{
//    if ((array == null) || (array.Length == 0))
//    {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//    }

//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(numerosOrdenados);
//    //[1,8][5,9][6,9][7,1][10]

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//                                                             (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}


//double MediaDaAmostra(double[] amostra)
//{
//    double media = 0;
//    double acumulador = 0;

//    if ((amostra == null) || (amostra.Length == 0))
//    {
//        Console.WriteLine("Amostra de dados nula ou vazia.");
//        return 0;
//    }
//    else
//    {
//        for (int i = 0; i < amostra.Length; i++)
//        {
//            acumulador = acumulador + amostra[i];
//        }
//        media = acumulador / amostra.Length;
//    }

//    Console.WriteLine($"{media}");

//    return media;
//}

//MediaDaAmostra((double[]) amostra);

#endregion

#region Teste dos arrray de contas correntes
//void TestaArrayDeContasCorrentes()
//{

//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    var contaDoAndre = new ContaCorrente(963, "123456-X");
//    listaDeContas.Adicionar(contaDoAndre);
//    //listaDeContas.ExibeLista();
//    //Console.WriteLine("============");
//    //listaDeContas.Remover(contaDoAndre);
//    //listaDeContas.ExibeLista();

//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
//    }

//}


//TestaArrayDeContasCorrentes();
#endregion

#region ArrayList e desafio
//o ArrayList é uma coleção não genérica de objetos cujo tamanho aumenta dinamicamente.
//É o mesmo que Array, exceto que seu tamanho aumenta dinamicamente

//ArrayList _listaDeContas = new ArrayList() {
//    new ContaCorrente(95, "123456-X") {Saldo=100},
//    new ContaCorrente(95, "951258-X") {Saldo=200},
//    new ContaCorrente(94, "987321-W") {Saldo=60}
//};


/*
 * Exercicio : método que recebe um nome e verifica se ele esta na lista 
 * 
 * List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

bool VerificaNomes(List<string> nomesDosEscolhidos,string escolhido)
{
    return nomesDosEscolhidos.Contains(escolhido);
}
 */
#endregion

#region Exemplos de métodos do List

//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas3[i].Conta}]");
//}

#endregion

