using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBankADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        //override: palavra reservada para sobreescrita de metodos herdados de outras classes(classe derivada)
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;

            //base: palavra que pode acessar proriedades e metodos da clase base(Classe mãe)
            //return this.Salario + base.GetBonificacao();
        }

        public Diretor(string cpf):base(cpf, 5000)
        {
                
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
