using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public override double GetBonificacao()
        {                           //base: palavra que pode acessar proriedades e metodos da clase base(Classe mãe)
            return this.Salario * 0.2;
            //return this.Salario + base.GetBonificacao();
        }

        public Auxiliar(string cpf) : base(cpf, 2000)//ja passa valor do salario pois o salario base ja é conhecido
        {

        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
