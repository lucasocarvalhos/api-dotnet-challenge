# api-dotnet-challenge
# BancoAPI - Desafio Técnico

API de CRUD de clientes construída com .NET

## Configuração do Ambiente

Para rodar este projeto localmente, você precisará configurar a connection string do banco de dados usando o Secret Manager.

1.  Clone o repositório.
2.  Certifique-se de que tenha uma instância do SQL Server rodando (localmente ou via Docker).
3.  Na raiz do projeto, inicialize o Secret Manager:
    ```bash
    dotnet user-secrets init
    ```
4.  Defina a connection string:
    ```bash
    dotnet user-secrets set "ConnectionStrings:DefaultConnection" "SUA_CONNECTION_STRING_AQUI"
    ```
5.  Execute o projeto:
    ```bash
    dotnet run
    ```
