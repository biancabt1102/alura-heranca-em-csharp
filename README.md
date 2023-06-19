# Bytebank_ADM

Bytebank_ADM é um programa de exemplo que simula um sistema de gerenciamento de funcionários e autenticação. O programa inclui classes que representam diferentes tipos de funcionários, como assistentes, designers, diretores e gerentes de contas. Ele também inclui uma classe de parceiro comercial e um sistema interno de autenticação.

## Classes

O programa consiste nas seguintes classes:

- `Auxiliar`: Representa um auxiliar, um tipo de funcionário. Ela herda da classe abstrata `Funcionario` e implementa métodos específicos, como `AumentarSalario` e `GetBonificacao`.
- `Designer`: Representa um designer, outro tipo de funcionário. Ela herda da classe `Funcionario` e implementa métodos personalizados.
- `Diretor`: Representa um diretor, um tipo de funcionário com recursos adicionais de autenticação. Ela herda da classe `FuncionarioAutenticavel` e redefine métodos, como `GetBonificacao` e `AumentarSalario`.
- `Funcionario`: É uma classe abstrata que serve como base para os diferentes tipos de funcionários. Ela contém propriedades e métodos comuns a todos os funcionários, como `AumentarSalario` e `GetBonificacao`.
- `FuncionarioAutenticavel`: É uma classe abstrata que herda da classe `Funcionario` e adiciona recursos de autenticação. Ela implementa a interface `IAutenticavel` e contém uma propriedade `Senha` e o método `Autenticar`.
- `GerenteDeContas`: Representa um gerente de contas, um tipo de funcionário com recursos de autenticação. Ela herda da classe `FuncionarioAutenticavel` e redefine métodos específicos.
- `ParceiroComercial`: Representa um parceiro comercial que também pode ser autenticado. Ela implementa a interface `IAutenticavel` e possui a propriedade `Senha`.
- `SistemaInterno`: É uma classe que simula um sistema interno de autenticação. Ela possui um método `Logar` que verifica a autenticação de um objeto `IAutenticavel` com uma determinada senha.
- `IAutenticavel`: É uma interface que define os métodos e propriedades necessários para autenticação. Ela é implementada pelas classes `FuncionarioAutenticavel` e `ParceiroComercial`.
- `GerenciadorDeBonificacao`: É uma classe utilitária que calcula e registra a bonificação total dos funcionários.

## Funcionalidades

O programa possui duas principais funcionalidades:

1. Cálculo de Bonificação: O método `CalcularBonificacao` cria instâncias de diferentes tipos de funcionários e as registra no `GerenciadorDeBonificacao` para calcular a bonificação total. O resultado é exibido no console.
2. Utilização do Sistema Interno: O método `UsarSistema` demonstra a autenticação de diferentes objetos usando o `SistemaInterno`. São criadas instâncias de diretores, gerentes de contas e um parceiro comercial, e o método `Logar` é chamado para verificar se a autenticação é bem-sucedida.

## Como Executar

Para executar o programa, basta chamar o método `UsarSistema` no arquivo `Program.cs`.
