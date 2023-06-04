using ByteBankADM.Funcionarios;
using ByteBankADM.Utilitarios;

#region
//Funcionario Eduardo = new Funcionario("78945612355", 2000);
//Eduardo.Nome = "Eduardo";


//Console.WriteLine(Eduardo.Nome);
//Console.WriteLine(Eduardo.GetBonificacao());
//Console.WriteLine(Eduardo.CPF);

//Diretor Lucas = new Diretor("78945612355");
//Lucas.Nome = "Lucas";


//Console.WriteLine(Lucas.Nome);
//Console.WriteLine(Lucas.GetBonificacao());
//Console.WriteLine(Lucas.CPF);


//GerenciaBonificacao gerenciar = new GerenciaBonificacao();

//gerenciar.Registrar(Eduardo);
//gerenciar.Registrar(Lucas);

//Console.WriteLine("Total bonificação: " + gerenciar.TotalBonificacao);
////chamando o construtor total de funcionario(não é necessário para classe diretor pois a mesma herda de funcionario
//// e  o primeiro construtor chamado é o da classe base(ou classe mãe))
//Console.WriteLine("Total funcionario: " + Funcionario.TotalFuncionario);


//Eduardo.AumentarSalario();
//Lucas.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + Eduardo.Salario);
//Console.WriteLine("Novo salário da Roberta: " + Lucas.Salario);
#endregion

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciaBonificacao gerenciador = new GerenciaBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
}

