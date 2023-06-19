using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.Sistema;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registar(pedro);
//gerenciador.Registar(roberta);

//Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
//Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo salário do Pedro: {pedro.Salario}");
//Console.WriteLine($"Novo salário da Roberta: {roberta.Salario}");
#endregion

//CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456789");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987654321");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("123456");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("123789");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registar(camila);
    gerenciador.Registar(igor);
    gerenciador.Registar(paula);
    gerenciador.Registar(ulisses);

    Console.WriteLine($"Total de Bonificação = {gerenciador.TotalDeBonificacao}");
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("12369854");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("147852369");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";
        
    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
    sistema.Logar(caio, "999");
}

UsarSistema();