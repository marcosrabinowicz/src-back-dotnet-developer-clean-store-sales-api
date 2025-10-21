# 🧱 Store Sales API

**Clean Architecture + DDD study project — Store Sales API in .NET 8.**

---

## 📍 Overview

Este projeto nasceu como um **laboratório de estudo** em torno da **Clean Architecture** e do **Domain-Driven Design (DDD)**, com foco na construção progressiva de uma API de vendas de loja (**Store Sales API**).

A ideia central é começar **simples** — um único projeto com `Program.cs`, entidades básicas e regras de domínio puras — e, ao longo do tempo, **evoluir** até uma estrutura completa e modular, com camadas separadas e testes automatizados.

---

## 🎯 Objetivos de Estudo

- Entender a essência do domínio antes de aplicar padrões.
- Evoluir de um design monolítico para uma arquitetura limpa e desacoplada.
- Praticar princípios de **SOLID**, **CQRS**, **Clean Code** e **TDD**.
- Implementar entidades e casos de uso expressivos e testáveis.

---

## 🧩 Etapas de Evolução

| Etapa                   | Descrição                                                              | Status |
| :---------------------- | :--------------------------------------------------------------------- | :----: |
| **1. Núcleo básico**    | Projeto único com domínio simples (`Sale`, `SaleItem`, `Program.cs`).  |   🟢   |
| **2. Separação lógica** | Organização em pastas `/Domain`, `/Application`, `/Web`.               |   ⏳   |
| **3. Projetos reais**   | Criação dos projetos Domain, Application, Infrastructure e WebApi.     |   ⏳   |
| **4. Testes e IoC**     | Adição de testes unitários, EF Core InMemory e injeção de dependência. |   ⏳   |

---

## 🧠 Stack inicial

- **.NET 8**
- **C# 12**
- **xUnit + FluentAssertions** (a partir da Etapa 4)

---

## 🧭 Filosofia

> “Construa o domínio antes da infraestrutura.”
>
> O código nasce do **negócio**, não do **framework**.

---

## 🪪 Autor

**Marcos Rabinowicz | Neshama Tech**  
[https://github.com/marcos-rabinowicz](https://github.com/marcos-rabinowicz)

---
