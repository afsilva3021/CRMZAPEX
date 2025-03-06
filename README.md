# CRMZapex - Documentação

## 1. Introdução
O **CRMZapex** é um sistema de gestão desenvolvido em **.NET Framework 4.8** com **Windows Forms** e banco de dados **MySQL**.  
Ele foi projetado para facilitar o gerenciamento de [clientes, vendas, atendimentos, etc.], oferecendo uma interface intuitiva e eficiente.

### Tecnologias Utilizadas
- **Linguagem**: C# (.NET Framework 4.8)
- **Interface**: Windows Forms
- **Banco de Dados**: MySQL
- **ORM**: [Caso esteja utilizando, como Dapper, Entity Framework]
- **Arquitetura**: MVC / Camadas [Caso tenha um padrão específico]
- **Outras Dependências**: [Especificar pacotes NuGet ou bibliotecas usadas]

---

## 2. Instalação e Configuração

### **Requisitos**
- Windows 10 ou superior
- .NET Framework 4.8 instalado
- MySQL Server instalado e configurado
- Visual Studio (recomendado)

### **Passos para Configuração**
1. **Clonar o Repositório**
   ```sh
   git clone https://github.com/seu-usuario/crmzapex.git
   cd crmzapex

2. Configurar o Banco de Dados

Criar um banco no MySQL chamado crmzapex

Executar o script database.sql disponível no projeto



3. Configurar a String de Conexão
No arquivo App.config, configure a string de conexão com seu banco MySQL:

<connectionStrings>
    <add name="MySqlConnection" 
         connectionString="Server=localhost;Database=crmzapex;User Id=root;Password=suasenha;"
         providerName="MySql.Data.MySqlClient" />
</connectionStrings>


4. Executar o Projeto

Abra o projeto no Visual Studio

Compilar e executar (Ctrl + F5)





---

3. Arquitetura do Sistema

O sistema segue a estrutura de camadas:

/CRMZapex
│── /App
│── /Models
│── /Views
│── /Controllers
│── /Database
│── Program.cs
│── App.config

Models: Representam as entidades do banco de dados.

Views: Formulários do Windows Forms.

Controllers: Lógica de negócios e conexão entre View e Model.

Database: Scripts SQL e classes de acesso ao banco.



---

4. Funcionalidades

Gerenciamento de Clientes (Cadastro, edição, exclusão)

Gestão de Vendas (Registrar, listar, pesquisar)

Relatórios (Gerar PDF, gráficos de desempenho)

Autenticação de Usuários (Login, logout)



---

5. Banco de Dados

Modelo de dados do CRMZapex:

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    email VARCHAR(100) UNIQUE,
    senha VARCHAR(255)
);

CREATE TABLE clientes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    telefone VARCHAR(15),
    email VARCHAR(100),
    endereco TEXT
);


---

6. API e Integrações (se houver)

Caso o CRMZapex se integre com APIs externas, descreva aqui.


---

7. Guia para Desenvolvedores

Como Contribuir

Faça um fork do repositório

Crie uma branch com sua feature:

git checkout -b minha-feature

Faça commit das alterações:

git commit -m "Adiciona nova funcionalidade"

Envie para o repositório remoto:

git push origin minha-feature

Abra um Pull Request



---

8. Possíveis Melhorias e Considerações Finais

Melhorias Futuras

Implementação de autenticação JWT

Integração com API de pagamentos

Melhorias na interface do usuário


Conclusão

O CRMZapex é um projeto em constante evolução. Sugestões e contribuições são bem-vindas!


---

📌 Criado por [Alex Felix França da silva]
📅 Última atualização: [09/10/2023]
