# 🏖️ SistemaFerias.API - Sistema de Gerenciamento de Férias

 Uma Web API desenvolvida em **C# / .NET** e **Entity Framework Core** para gerenciamento de colaboradores e controle de solicitações de férias, criada como projeto de aprendizado no curso Técnico em Desenvolvimento de Sistemas (SENAC TDS - Módulo 1).

---

## 🎯 Objetivo do Projeto

O objetivo do projeto é desenvolver um **sistema completo de gerenciamento de férias**, permitindo:
- **Cadastro de Colaboradores**: Registro e manutenção dos dados dos funcionários da empresa.
- **Solicitação de Férias**: Registro de pedidos de férias com validações automáticas de período (20 ou 30 dias).
- **Fluxo de Aprovação e Negação**: Avaliação e controle dos pedidos de férias solicitados pelos colaboradores (em desenvolvimento/planejamento).

---

## 🚀 Tecnologias Utilizadas

- **C#** (Linguagem de programação)
- **.NET / ASP.NET Core Web API** (Framework Web)
- **Entity Framework Core** (ORM para persistência e manipulação de dados)
- **Swagger / OpenAPI** (Documentação e testes interativos da API)

---

## 🛠️ Modelos de Dados (Models)

### 1. `Funcionario` (Colaborador)
Representa o colaborador no sistema.

| Propriedade | Tipo | Descrição |
| :--- | :--- | :--- |
| `Id` | `string` | Identificador único do colaborador |
| `Nome` | `string` | Nome do colaborador |
| `DataCriacao` | `DateTime` | Data e hora em que foi cadastrado |

### 2. `SolicitacaoFerias`
Representa o pedido de férias de um colaborador.

| Propriedade | Tipo | Descrição |
| :--- | :--- | :--- |
| `Id` | `int` | Identificador único da solicitação |
| `NomeFuncionario` | `string` | Nome do colaborador solicitante |
| `Dias` | `int` | Quantidade de dias solicitados (20 ou 30 dias) |
| `DataInicio` | `DateTime` | Data de início das férias |
| `DataFim` | `DateTime` | Data de término das férias (calculada automaticamente) |
| `DataSolicitacao` | `DateTime` | Data e hora em que a solicitação foi registrada |

---

## 🔌 Rotas da API (Endpoints)

### `SolicitacoesFeriasController` (`/api/SolicitacoesFerias`)

- **`GET /api/SolicitacoesFerias`**
  - Retorna a lista completa de solicitações de férias registradas.

- **`POST /api/SolicitacoesFerias`**
  - Cria uma nova solicitação de férias com as seguintes regras de negócio:
    - O campo `NomeFuncionario` é obrigatório.
    - Apenas solicitações de **20 ou 30 dias** são permitidas.
    - A `DataFim` é calculada automaticamente (`DataInicio + Dias`).
    - A `DataSolicitacao` armazena a data/hora exata da requisição (`DateTime.Now`).

- **`DELETE /api/SolicitacoesFerias?id={id}`**
  - Remove uma solicitação de férias pelo seu `Id`.

---

## 📋 Funcionalidades em Desenvolvimento / Próximos Passos

- [x] Cadastro e listagem de solicitações de férias
- [x] Validação de regras de dias e cálculo automático de datas
- [ ] CRUD completo de colaboradores (`FuncionariosController`)
- [ ] Status de solicitação (Pendente, Aprovado, Negado)
- [ ] Endpoint para Aprovação / Negação de férias pela gestão

---

## ▶️ Como Executar o Projeto

1. Abra o terminal na pasta do projeto (`SistemaFerias.API`).
2. Compile e execute a aplicação:
   ```bash
   dotnet run
   ```
3. Acesse o endereço indicado no console (ex: `https://localhost:7000/swagger`) para testar as rotas via **Swagger**.

---

## 🎓 Contexto Acadêmico

Projeto prático desenvolvido durante o **Módulo 1 do curso Técnico em Desenvolvimento de Sistemas (SENAC TDS)** para consolidação de conceitos de Web API, Controllers, Models e ORM.
