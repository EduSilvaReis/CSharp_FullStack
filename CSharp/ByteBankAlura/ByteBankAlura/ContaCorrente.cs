using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAlura
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public string agencia;
        public double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        } 
    }
}
