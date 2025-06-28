# 🍔 Snack Flow
Olá! Me chamo **Samuel Ribeiro** e este é o backend que estou desenvolvendo para a aplicação de gestão de uma
**lanchonete local em Manaus-AM 🍔🍟**.

O sistema está sendo criado com o objetivo de oferecer à lanchonete um controle mais eficiente das operações e das finanças, permitindo gerenciar receitas, despesas e fluxo de caixa de forma simples e organizada.

## 🏛️ Arquitetura

O projeto segue os princípios de **Clean Architecture**, organizando as dependências em camadas bem definidas:

- **Domain**: Entidades e regras de negócio puros
- **Application**: Casos de uso e orquestração
- **Infrastructure**: Implementações de persistência e serviços externos
- **API**: Controladores e configurações web

## 🛠️ Tecnologias Principais

- **.NET 9.0** - Framework principal
- **PostgreSQL** - Banco de dados
- **Entity Framework Core** - ORM
- **ASP.NET Core Identity** - Autenticação e autorização
- **MediatR** - Padrão Mediator/CQRS
- **FluentValidation** - Validações
- **JWT** - Tokens de autenticação
- **Serilog** - Logging estruturado
- **xUnit** - Testes unitários