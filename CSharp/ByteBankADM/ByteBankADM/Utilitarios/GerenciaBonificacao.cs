﻿using ByteBankADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ByteBankADM.Utilitarios
{
    public class GerenciaBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.GetBonificacao();
        }

        //SOBRECARGA DE MÉTODO
        public void Registrar(Diretor diretor)
        {
            this.TotalBonificacao += diretor.GetBonificacao();
        }
    }
}
