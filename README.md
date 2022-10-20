<h1 align="center">
Módulo API
</h1>

Este repositório contém exemplos criados para utilização em uma API com os ensinamentos da plataforma DIO com o bootcamp de C# + .NET provido pela Pottencial.

API com uso de Entity Framework com integração de tabelas por banco de dados (SQL) e conhecimentos de CRUD (Create/Read/Update/Delete).

As migrations espelham as alterações feitas no banco de dados (SQL) utilizando o Entity Framework. São geradas de forma automática pelo Entity Framework. 

## Editor de Código 
* [Visual Studio Code](https://code.visualstudio.com/)

## Aplicação
É necessária a conexão do banco de dados por meio de uma ConnectionStrings em [appsettings.json](appsettings.json). Com isso é possível observar a API pelo swagger com o comando ``` dotnet watch run```

## Métodos e Resultados

- [UsuarioControler](/Controllers/UsuarioController.cs) com métodos:
  - Obter hora e data:
    ```json
    {
      "data": "quinta-feira, 20 de outubro de 2022",
      "hora": "11:41"
    }
    ```
  - Apresentação de nome com uma frase:
    ```json
    {
      "mensagem": "Olá Luiz, seja bem vindo!"
    }
    ```
- [ContatoController](/Controllers/ContatoController.cs) com métodos de CRUD:
  - Criar Contato (Create/Post):
    ```json
    {
      "id": 1,
      "nome": "Luiz",
      "telefone": "15741512",
      "ativo": true
    }
    ```
  - Obter Contato (Read/Get):
    ```json
    {
      "id": 3,
      "nome": "mates",
      "telefone": "1124145215",
      "ativo": true
    }
    ```
  - Atualizar Contato (Update/Put):
    ```json
    {
      "id": 4,
      "nome": "Kimi atualizado",
      "telefone": "1741874 (novo)",
      "ativo": true
    }
    ```
  - Deletar Contato (Delete/Delete)

<br>

- [WeatherForecastControler](/Controllers/WeatherForecastController.cs), método padrão na criação da API:
  ```json
  [
    {
      "date": "2022-10-21T11:44:48.4759608-03:00",
      "temperatureC": 52,
      "temperatureF": 125,
      "summary": "Scorching"
    },
    {
      "date": "2022-10-23T11:47:11.4305049-03:00",
      "temperatureC": 33,
      "temperatureF": 91,
      "summary": "Chilly"
    }
  ]
  ```
