# Employee CRUD API

Este projeto é uma **API CRUD** (Create, Read, Update, Delete) simples para gerenciar informações de funcionários. Desenvolvido em C# utilizando o framework .NET e o SQL Server para persistência de dados, ele serve como um exemplo básico de como implementar operações CRUD em um ambiente web.

## Índice

- [Visão Geral](#visão-geral)
- [Recursos](#recursos)
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Como Usar](#como-usar)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Contribuições](#contribuições)

## Visão Geral

A Employee CRUD API permite o gerenciamento eficiente de dados de funcionários (cargo, turno, etc.), oferecendo operações básicas de criação, leitura, atualização e exclusão em um banco de dados SQL Server.

## Recursos

- *Adicionar Funcionários*: Cadastre novos funcionários com informações detalhadas.
- *Consultar Funcionários*: Visualize uma lista de funcionários cadastrados (ou um em específico).
- *Atualizar Funcionários*: Modifique dados existentes de funcionários.
- *Excluir Funcionários*: Remova funcionários da base de dados.

## Pré-requisitos

- .NET SDK (versão 6.0 ou superior)
- SQL Server em execução
- Docker para imagem do SQL Server (versão 27.2.1 ou superior)

## Instalação

Para rodar o projeto localmente, siga os passos abaixo:

1. Clone o repositório:
```bash
git clone git clone https://github.com/lucasblima-dev/employee-crud.git
```
  
2. Navegue até o diretório do projeto:
```bash
cd seu-repositorio
```

3. Configure a conexão com o banco de dados em appsettings.json:
```bash
"ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=employeeDb;User Id=SEU_USUARIO;Password=SUA_SENHA;"}
```

4. Restaure as dependências do banco de dados:
```bash
dotnet restore
dotnet ef database update
```

5. Execute a aplicação
```bash
dotnet run
```

## Como usar
1. Utilize o **Swagger** para interagir com a API.
2. Teste os endpoints.

## Tecnologias Utilizadas
- C# e .NET Core
- Entity Framework Core
- Docker
- SQL Server
- Swagger

## Contribuições
Contribuições são bem-vindas! Se você encontrar um bug ou tiver uma ideia para melhorar o aplicativo, siga as etapas abaixo:

1. Faça um fork do projeto.
2. Crie uma nova branch (git checkout -b feature/nome-da-feature).
3. Commit suas mudanças (git commit -m 'Adiciona nova feature').
4. Push para a branch (git push origin feature/nome-da-feature).
5. Abra um Pull Request.