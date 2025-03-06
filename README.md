# CRMZapex

## 1. Introdução
O **CRMZapex** é um sistema de gerenciamento de relacionamento com o cliente (CRM) desenvolvido em **C# (.NET Framework 4.8)** utilizando **Windows Forms** e banco de dados **MySQL**.  

O objetivo do CRMZapex é facilitar a gestão de clientes, vendas e atendimentos, oferecendo uma interface intuitiva e funcionalidades eficientes para otimizar processos empresariais.

---

## 2. Tecnologias Utilizadas
- **Linguagem:** C# (.NET Framework 4.8)
- **Interface:** Windows Forms
- **Banco de Dados:** MySQL
- **ORM:** [Caso esteja utilizando, como Dapper, Entity Framework]
- **Arquitetura:** MVC / Camadas
- **Outras Dependências:** 
  - Oracle Managed Data Access (para integração com Oracle)
  - Web Service dos Correios (para cálculo de frete)

---

## 3. Instalação e Configuração

### **Requisitos**
- Windows 10 ou superior
- .NET Framework 4.8 instalado
- MySQL Server instalado e configurado
- Visual Studio (recomendado)
- Pacotes NuGet utilizados no projeto

### **Passos para Configuração**
1. **Clonar o Repositório**
   ```sh
   git clone https://github.com/afsilva3021/crmzapex.git
   cd crmzapex

2. Configurar o Banco de Dados

Criar um banco no MySQL chamado crmzapex

Executar o script banco/database.sql disponível no projeto



3. Configurar a String de Conexão
No arquivo App.config, configure a string de conexão com seu banco MySQL:

<connectionStrings>
    <add name="MySqlConnection" 
         connectionString="Server=localhost;Database=crmzapex;User Id=root;Password=suasenha;"
         providerName="MySql.Data.MySqlClient" />
</connectionStrings>


4. Executar o Projeto

Abra o projeto no Visual Studio

Compile e execute (Ctrl + F5)





---

4. Estrutura do Projeto

/CRMZapex
│── /Connected Services (Integrações com Web Services)
│── /Controller (Lógica do sistema)
│── /Icons (Ícones do sistema)
│── /Image (Imagens utilizadas)
│── /MySql (Consultas e scripts SQL)
│── /ProjetoMars (Diretório principal do projeto)
│── /Properties (Configurações do projeto)
│── /Resources (Recursos adicionais)
│── /Views (Interfaces gráficas do Windows Forms)
│── /banco (Scripts do banco de dados)
│── Program.cs (Ponto de entrada da aplicação)
│── App.config (Configurações do aplicativo)
│── ProjetoMars.sln (Solução do Visual Studio)
│── packages.config (Pacotes NuGet utilizados)


---

5. Funcionalidades

Gerenciamento de Clientes (Cadastro, edição, exclusão)

Gestão de Vendas (Registro, listagem, pesquisa)

Relatórios (Geração de relatórios em PDF, gráficos)

Autenticação de Usuários (Login, logout, permissões)

Integração com Web Services (Correios para cálculo de frete)

Banco de Dados MySQL (Armazenamento e consultas eficientes)



---

6. Banco de Dados

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

7. Guia para Desenvolvedores

Como Contribuir

1. Faça um fork do repositório


2. Crie uma branch com sua feature:

git checkout -b minha-feature


3. Faça commit das alterações:

git commit -m "Adiciona nova funcionalidade"


4. Envie para o repositório remoto:

git push origin minha-feature


5. Abra um Pull Request




---

8. Melhorias Futuras

Implementação de autenticação JWT

Integração com API de pagamentos

Melhorias na interface gráfica

Suporte a múltiplos idiomas



---

9. Licença

Este projeto é de código aberto e está sob a licença MIT.

📌 Criado por afsilva3021
📅 Última atualização: [Data Atual]

---

Agora vou gerar o arquivo `README.md` para download.

