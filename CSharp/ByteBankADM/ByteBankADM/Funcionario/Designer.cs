using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
                                    //base: palavra que pode acessar proriedades e metodos da clase base(Classe mãe)
            //return this.Salario + base.GetBonificacao();
        }

        public Designer(string cpf) : base(cpf, 3000)
        {

        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
