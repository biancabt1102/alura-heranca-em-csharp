using bytebank_ADM.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        //override: é uma redefinição
        public override double GetBonificacao()
        {
            // base: Dá acesso a elementos de funcionario
            return this.Salario * 0.5;
        }

        //passando o cpf de funcionário para o cpf de diretor
        public Diretor(string cpf):base(cpf, 5000)
        {
            //Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
