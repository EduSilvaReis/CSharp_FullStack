using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF{ get; private set; }
        
        public double Salario { get; protected set; }
        
        public static int TotalFuncionario { get; private set; }
        public abstract double GetBonificacao();
         
        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.CPF = cpf;
            TotalFuncionario++;

        }

        public abstract void AumentarSalario();

        #region
        /*Anotações:
         * Campo salario visivel soment nessa classe ou em classe que herdam desta  
         * propriedade da classes deve ser static// set = private pois somente a leitura da propriedade será visivel en outras partes
         * virtual: palavra reservada para sobreescrita de método(classe mãe)
         * se a classe se tornar abstrata(abstract) deve ser usado o terno asbtract nos metodos
         * porem isso obriga a toda classe que herde da classe mae(funcionaio no caso) tem a obrigação de implementar o metodo  seu comportamento
         * consrutor da classe  é responsável pela criação do objeto daquela classe, iniciando com valores seus atributos ou realizando outras funções que possam vir a ser necessárias
         *  método destrutor abaixo: que é invocado no momento de “destruir” um objeto de uma classe. 
         *  ~Funcionario() 
         *   {
         *       Console.WriteLine("Liberando recursos
         *     }
         */
        #endregion

    }
}
