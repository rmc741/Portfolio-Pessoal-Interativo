# PortfolioPessoal

This project was generated using [Angular CLI](https://github.com/angular/angular-cli) version 19.2.1.

## Development server

To start a local development server, run:

```bash
ng serve
```

Once the server is running, open your browser and navigate to `http://localhost:4200/`. The application will automatically reload whenever you modify any of the source files.

## Code scaffolding

Angular CLI includes powerful code scaffolding tools. To generate a new component, run:

```bash
ng generate component component-name
```

For a complete list of available schematics (such as `components`, `directives`, or `pipes`), run:

```bash
ng generate --help
```

## Building

To build the project run:

```bash
ng build
```

This will compile your project and store the build artifacts in the `dist/` directory. By default, the production build optimizes your application for performance and speed.

## Running unit tests

To execute unit tests with the [Karma](https://karma-runner.github.io) test runner, use the following command:

```bash
ng test
```

## Running end-to-end tests

For end-to-end (e2e) testing, run:

```bash
ng e2e
```

Angular CLI does not come with an end-to-end testing framework by default. You can choose one that suits your needs.

## Additional Resources

For more information on using the Angular CLI, including detailed command references, visit the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.


# ✅ Checklist para o Projeto Angular (Landing Page + Blog)

## 📌 Estrutura Inicial do Projeto
- [X] Instalar o Angular CLI: `npm install -g @angular/cli`
- [X] Criar o projeto: `ng new meu-portfolio`
- [X] Configurar roteamento no Angular: `ng generate module app-routing`
- [ ] Criar os componentes principais:
  - [X] `HomeComponent`
  - [X] `SobreComponent`
  - [X] `ContatoComponent`
  - [ ] `BlogComponent`
  - [ ] `PostagemComponent`
- [ ] Criar os serviços:
  - [ ] `PostService` (para gerenciar postagens)
  - [ ] `AuthService` (para autenticação, se necessário)
- [ ] Configurar Angular Material ou Bootstrap para UI (opcional)

## 🌍 Roteamento e Navegação
- [ ] Configurar rotas no `app-routing.module.ts`
- [ ] Criar rotas dinâmicas para postagens individuais
- [ ] Implementar Lazy Loading para otimizar a aplicação
- [ ] Configurar guards para rotas protegidas (se necessário)

## 🔗 API e Back-End
- [ ] Configurar `HttpClientModule`
- [ ] Criar serviço para consumir API REST
- [ ] Implementar chamadas HTTP (`GET`, `POST`, `PUT`, `DELETE`)
- [ ] Testar chamadas à API com Postman ou Insomnia

## 🔐 Autenticação e Autorização
- [ ] Criar sistema de login com JWT (opcional)
- [ ] Armazenar token no `localStorage` ou cookies
- [ ] Criar guardas de rota (`AuthGuard`)

## 📄 Postagens e Comentários
- [ ] Criar modelo de `Post`
- [ ] Criar formulário para criação de postagens
- [ ] Criar sistema de comentários
- [ ] Implementar validação nos formulários

## 🎨 Estilização e Responsividade
- [ ] Utilizar SCSS, TailwindCSS ou Bootstrap
- [ ] Aplicar Flexbox e Grid Layout
- [ ] Criar tema responsivo para mobile e desktop
- [ ] Implementar Dark Mode (opcional)

## 📢 SEO e Performance
- [ ] Adicionar `Title` e `Meta` dinâmicos
- [ ] Implementar `Angular Universal` para SSR (opcional)
- [ ] Melhorar tempo de carregamento com Lazy Loading

## 🚀 Deploy
- [ ] Gerar build otimizado: `ng build --configuration=production`
- [ ] Configurar hospedagem na AWS S3, Firebase Hosting ou Vercel
- [ ] Configurar domínio personalizado e HTTPS

---
