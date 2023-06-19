﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Funcionarios
{
    internal class Auxiliar:Funcionario
    {
        public Auxiliar(string cpf):base(cpf, 2000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

    }
}
