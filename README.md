# Blindando Seu Código com TDD e Testes Unitários Usando .NET Core
# Calculadora com TDD e Testes Unitários em .NET Core

Este repositório contém um exemplo prático de como aplicar Test-Driven Development (TDD) e usar testes unitários com o framework .NET Core para desenvolver uma calculadora simples. O projeto também demonstra o uso da biblioteca XUnit para a criação de testes unitários.

## Contexto

O projeto base consiste em uma calculadora que oferece as operações de soma, subtração, multiplicação e divisão, com algumas regras de negócio a serem seguidas:

- A calculadora aceita apenas números inteiros.
- Cada operação deve receber exatamente 2 parâmetros.
- O histórico das últimas 3 operações deve ser mantido.

## Estrutura do Projeto

Este projeto é dividido em três partes principais:

1. **Estruturando o Projeto:** Aqui, criamos a estrutura básica do projeto .NET Core, definindo a organização dos diretórios e arquivos.

2. **Criando Funções de Teste:** Um projeto de testes XUnit é criado para testar as operações da calculadora. Os testes são desenvolvidos antes da implementação do código da calculadora.

3. **Codificando a Função Calculadora:** A classe `Calculadora` é implementada, contendo os métodos `Soma`, `Subtração`, `Multiplicação` e `Divisão`, com base nas regras de negócio. O ciclo TDD é seguido, com testes que validam o comportamento da calculadora.

## Como Usar

Para usar este projeto e executar os testes, siga as etapas abaixo:

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/calculadora-tdd-netcore.git

2. Acesse o diretório do projeto:
   ```bash
   cd calculadora-tdd-netcore
3. Execute os testes unitários usando o comando dotnet test:
   ```bash
   dotnet test

Isso executará os testes unitários e fornecerá feedback sobre se as operações da calculadora estão funcionando conforme o esperado.

## Contribuições
Se você deseja contribuir para este projeto ou fazer melhorias, fique à vontade para criar um fork e enviar um pull request. Suas contribuições são bem-vindas!
