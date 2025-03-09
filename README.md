<<<<<<< HEAD
# Clean Architecture Project

## ✨ Visão Geral
Este é um projeto de demonstração de uma API desenvolvida com **ASP.NET Core** seguindo os princípios da **Clean Architecture**. Ele implementa uma estrutura modular e escalável, utilizando tecnologias modernas para garantir uma base robusta para aplicações .NET.

## 🛠️ Tecnologias Utilizadas
- **ASP.NET Core Web API**
- **Clean Architecture** (Domain, Application, Infrastructure, API)
- **SQLite** (para persistência de dados)
- **CQRS com MediatR**
- **AutoMapper** (para mapeamento de objetos)

## 📚 Estrutura do Projeto
A estrutura segue a Clean Architecture, separando claramente as responsabilidades:

```
CleanArchitectureProject/
|-- CleanArchitecture.API/        # Camada de apresentação (API)
|-- CleanArchitecture.Application/ # Lógica de negócio e casos de uso
|-- CleanArchitecture.Domain/      # Modelos de domínio
|-- CleanArchitecture.Infrastructure/ # Persistência de dados e serviços externos
|-- CleanArchitecture.Tests/       # Testes unitários e de integração (Ainda irei implementar) 
```

## ⚡ Como Executar o Projeto

### 1. Clone o repositório
```sh
git clone https://github.com/ritafranca/CleanArchitectureProject.git
cd CleanArchitectureProject
```

### 2. Restaure as dependências
```sh
dotnet restore
```

### 3. Compile o projeto
```sh
dotnet build
```

### 4. Execute a API
```sh
dotnet run --project CleanArchitecture.API
```

A API estará rodando em `http://localhost:5000` e a documentação do Swagger pode ser acessada em:
```
http://localhost:5000/swagger
```



=======
# Clean Architecture Project

## ✨ Visão Geral
Este é um projeto de demonstração de uma API desenvolvida com **ASP.NET Core** seguindo os princípios da **Clean Architecture**. Ele implementa uma estrutura modular e escalável, utilizando tecnologias modernas para garantir uma base robusta para aplicações .NET.

## 🛠️ Tecnologias Utilizadas
- **ASP.NET Core Web API**
- **Clean Architecture** (Domain, Application, Infrastructure, API)
- **SQLite** (para persistência de dados)
- **CQRS com MediatR**
- **AutoMapper** (para mapeamento de objetos)

## 📚 Estrutura do Projeto
A estrutura segue a Clean Architecture, separando claramente as responsabilidades:

```
CleanArchitectureProject/
|-- CleanArchitecture.API/        # Camada de apresentação (API)
|-- CleanArchitecture.Application/ # Lógica de negócio e casos de uso
|-- CleanArchitecture.Domain/      # Modelos de domínio
|-- CleanArchitecture.Infrastructure/ # Persistência de dados e serviços externos
|-- CleanArchitecture.Tests/       # Testes unitários e de integração
```

## ⚡ Como Executar o Projeto

### 1. Clone o repositório
```sh
git clone https://github.com/ritafranca/CleanArchitectureProject.git
cd CleanArchitectureProject
```

### 2. Restaure as dependências
```sh
dotnet restore
```

### 3. Compile o projeto
```sh
dotnet build
```

### 4. Execute a API
```sh
dotnet run --project CleanArchitecture.API
```

A API estará rodando em `http://localhost:5000` e a documentação do Swagger pode ser acessada em:
```
http://localhost:5000/swagger
```



>>>>>>> 7fb1cd4 (Publicação inicial do projeto Clean Architecture)
