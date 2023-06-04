using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
                    //base: palavra que pode acessar proriedades e metodos da clase base(Classe mãe)
            //return this.Salario + base.GetBonificacao();
        }

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
