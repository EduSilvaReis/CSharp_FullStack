using ByteBankADM.Funcionarios;
using ByteBankADM.Utilitarios;


Funcionario Eduardo = new Funcionario();
Eduardo.Nome = "Eduardo";
Eduardo.CPF = "79865322-55";
Eduardo.Salario = 3200;


Console.WriteLine(Eduardo.Nome);
Console.WriteLine(Eduardo.GetBonificacao());
Console.WriteLine(Eduardo.CPF);

Diretor Lucas = new Diretor();
Lucas.Nome = "Eduardo";
Lucas.CPF = "88887322-55";
Lucas.Salario = 5000;


Console.WriteLine(Lucas.Nome);
Console.WriteLine(Lucas.GetBonificacao());
Console.WriteLine(Lucas.CPF);


GerenciaBonificacao gerenciar = new GerenciaBonificacao();

gerenciar.Registrar(Eduardo);
gerenciar.Registrar(Lucas);

Console.WriteLine("Total bonificação: " + gerenciar.TotalBonificacao);




