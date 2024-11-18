# 🖥️ Portfólio Pessoal Interativo

Um projeto de portfólio com funcionalidades modernas para gerenciamento de projetos e interação com usuários.

---

## 🚀 Funcionalidades

1. **Autenticação e Autorização**
   - Usuários podem criar contas e fazer login.
   - Perfis:
     - **Administrador**: Acesso completo para gerenciar projetos.
     - **Usuário Comum**: Pode visualizar projetos e comentar.
   - Segurança:
     - Controle de sessões com **JWT**.
     - Validação de ações humanas usando **reCAPTCHA v3**.

2. **Gestão de Projetos** (Administrador)
   - CRUD completo: Criar, Ler, Atualizar e Excluir.
   - Editor de texto rico para descrição de projetos (ex.: **Quill.js**).

3. **Comentários**
   - Usuários podem comentar nos projetos.
   - Filtros para evitar spam e garantir segurança.

4. **Exibição de Projetos**
   - **Página Inicial**: Lista dinâmica de projetos com filtros (ex.: categorias, tecnologias).
   - **Página Detalhada**:
     - Informações completas do projeto.
     - Sessão de comentários.
     - Links para repositórios (ex.: GitHub) ou demonstrações.

5. **Responsividade e Acessibilidade**
   - Interface otimizada para dispositivos móveis.
   - Seguindo os padrões de acessibilidade (WCAG).

---

## 🛠️ Tecnologias Utilizadas

### Back-end:
- **C# .NET Core**
- **Entity Framework Core** (ORM)
- **AutoMapper** (conversão de entidades em DTOs)

### Front-end:
- **React.js**
- Gerenciamento de estado: **Redux** ou **Context API**
- Frameworks de design: **Material-UI** ou **Tailwind CSS**

### Banco de Dados:
- **PostgreSQL**
  - Otimizado com índices para melhorar desempenho em filtros.

### Hospedagem:
- **AWS**:
  - API: **AWS Elastic Beanstalk** ou **AWS Lambda** (serverless)
  - Banco: **Amazon RDS**
  - Front-end: **Amazon S3 + CloudFront** (hospedagem estática)

---

## 🛡️ Melhorias Extras

- **Logs e Monitoramento**:
  - **Serilog** para logs no back-end.
  - Monitoramento via **AWS CloudWatch**.
  
- **Testes Automatizados**:
  - Back-end: **xUnit** ou **NUnit**.
  - Front-end: **Jest** e **React Testing Library**.

- **CI/CD**:
  - Pipelines com **GitHub Actions** ou **AWS CodePipeline**.

---

## 🗂️ Estrutura do Projeto

1. **Back-end**: API RESTful desenvolvida em C# .NET.
2. **Front-end**: Aplicação React com integração via API.
3. **Banco de Dados**: Estruturado e gerenciado no PostgreSQL.
4. **CI/CD**: Automação de build, testes e deploy.

---

## 🗓️ Etapas de Desenvolvimento

1. Planejar o **design do banco de dados**.
2. Implementar a API no back-end.
3. Desenvolver o front-end com integração incremental (por funcionalidades).
4. Configurar o ambiente na **AWS** e implementar o **CI/CD**.
5. Testar e refinar o sistema antes do lançamento.

---

## 📚 Como Executar o Projeto

### Pré-requisitos:
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [PostgreSQL](https://www.postgresql.org/download/)
- Conta na **AWS** (para hospedagem).

### Passos:
1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
