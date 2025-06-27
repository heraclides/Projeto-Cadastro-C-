# 💼 *ClientLab - Cadastro de Pessoas com Cálculo de Imposto*

Este projeto é um aplicativo de console em C# que permite o **cadastro de Pessoa Física ou Jurídica**, 
calculando o imposto sobre o valor de uma compra de acordo com o tipo de cliente.

## 🧾 Funcionalidades

- Cadastro de Pessoa Física (CPF, RG)
- Cadastro de Pessoa Jurídica (CNPJ, IE)
- Cálculo de imposto:
  - **10%** para Pessoa Física
  - **20%** para Pessoa Jurídica
- Exibição detalhada dos dados e valores calculados
- Possibilidade de cadastrar múltiplas pessoas sem encerrar o programa

---

## 📁 Estrutura do Projeto

ClientLab/
├── Program.cs
├── Clientes.cs
├── Pessoa_Fisica.cs
├── Pessoa_Juridica.cs
└── ClientLab.csproj


## 🚀 Como rodar o projeto localmente

após fazer toda instalação abrir o terminal na pasta do projeto e utilizar o comando *dotnet run*

### ✅ Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado (versão 6.0 ou superior)

### ▶️ Passo a passo

1. **Clone o repositório:**

```bash
git clone https://github.com/seu-usuario/ClientLab.git
cd ClientLab
Compile e execute o projeto:

bash
Copiar
Editar
dotnet run
🧪 Como testar o sistema
Ao executar, o sistema pedirá:

Nome da pessoa

Endereço

Tipo de pessoa (f para física ou j para jurídica)

Dependendo do tipo, ele solicitará:

Pessoa Física: CPF, RG e valor da compra

Pessoa Jurídica: CNPJ, IE e valor da compra

O programa exibirá:

Dados do pessoa cadastrada

Valor de imposto calculado

Total a pagar

No final, será perguntado se deseja cadastrar outra pessoa:

Digite s para continuar

Digite n para encerrar

💡 Exemplo de uso

Informar Nome: João da Silva
Informar Endereço: Rua das Flores, 123
Pessoa Física (f) ou Jurídica (j)? f
Informar CPF: 123.456.789-00
Informar RG: 12.345.678-9
Informar Valor de Compra: 1000

-------- Pessoa Física --------
Nome ..........: João da Silva
Endereço ......: Rua das Flores, 123
CPF ...........: 123.456.789-00
RG ............: 12.345.678-9
Valor de Compra: R$ 1.000,00
Imposto .......: R$ 100,00
Total a Pagar : R$ 1.100,00
🛠️ Tecnologias
C#
Entrada e saída de dados;
Declaração de variáveis.
Operadores aritméticos;
Estruturas condicionais e de repetição se necessário;
Operadores relacionais e lógicos.

Também irá aplicar conceitos de Programação Orientada a Objetos – POO:
Abstração;
Classes, propriedades e métodos;
Herança;
Polimorfismo;
Encapsulamento.
