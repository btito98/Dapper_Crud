# Dapper CRUD - Solidificando conhecimento em Dapper

## Descrição

Este projeto tem como objetivo solidificar o conhecimento em Dapper, uma biblioteca ORM leve e eficiente para o mapeamento de objetos em bancos de dados relacionais. O Dapper permite que você execute consultas SQL de forma rápida e simples, sem a necessidade de um mapeamento complexo de classes.

## Funcionalidades

Neste projeto, implementamos um CRUD (Create, Read, Update, Delete) básico para a entidade "Students", representando uma tabela de alunos em um banco de dados. O projeto utiliza o Dapper como camada de acesso a dados e a linguagem C# para a implementação.

## Tecnologias Utilizadas

- .NET Core 3.1 (ou superior)
- Dapper
- SQL Server

## Configuração do Banco de Dados

Antes de executar o projeto, certifique-se de configurar a conexão com o banco de dados no arquivo `appsettings.json` e criar a tabela "Students" no banco de dados com a estrutura adequada.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "sua_string_de_conexão"
  },
  // ...
}
```

A tabela "Students" deve conter as seguintes colunas:

- Id (int, chave primária)
- FullName (varchar)
- BirthDate (datetime)
- SchoolClass (varchar)
- IsActive (bit)

## Funcionalidades Implementadas

- **Criar Aluno**: Adiciona um novo aluno à tabela "Students" no banco de dados.
- **Buscar Aluno por ID**: Recupera um aluno específico do banco de dados com base no ID fornecido.
- **Buscar Todos os Alunos**: Recupera todos os alunos da tabela "Students" no banco de dados.
- **Atualizar Aluno**: Atualiza os dados de um aluno existente no banco de dados com base no ID fornecido.
- **Excluir Aluno**: Remove um aluno específico do banco de dados com base no ID fornecido.

## Como Executar o Projeto

1. Clone o repositório para sua máquina local.
2. Certifique-se de que possui o .NET Core 3.1 (ou superior) instalado.
3. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.
4. Abra o terminal na pasta raiz do projeto e execute o seguinte comando para restaurar as dependências:

```
dotnet restore
```

5. Execute o comando a seguir para executar o projeto:

```
dotnet run
```

## Contribuições

Contribuições são bem-vindas! Se você deseja adicionar mais funcionalidades, corrigir bugs ou melhorar o projeto, sinta-se à vontade para fazer um fork deste repositório e criar uma pull request com suas alterações.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE). Sinta-se à vontade para usá-lo e modificá-lo de acordo com suas necessidades.

## Contato

Se você tiver alguma dúvida ou sugestão, entre em contato pelo e-mail: seu-email@example.com.

Divirta-se aprendendo e praticando o Dapper neste projeto! 🚀
