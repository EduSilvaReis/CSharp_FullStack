using ByteBankADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.SistemaInterno
{
    //define contratos e comportamentos parecido com classe, pore só conterá assinatura dos metodos
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha);

        //public Autenticavel(string cpf, double salario) : base(cpf, salario)
        //{

        //}
    }
}
