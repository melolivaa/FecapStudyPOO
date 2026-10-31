# FecapStudy

**Plataforma de Apoio ao Estudo**

Projeto desenvolvido como parte das atividades acadêmicas da FECAP, com foco em Programação Orientada a Objetos (POO) e no desenvolvimento de uma plataforma para acompanhamento e organização dos estudos.

## Sobre o projeto: 

O FecapStudy é uma plataforma pensada para auxiliar discentes na organização da rotina acadêmica, permitindo acompanhar sessões de estudo, registrar metas e monitorar o desempenho por meio de pontos de experiência (XP).

O sistema também busca aproximar responsáveis do acompanhamento das metas dos discentes e oferecer aos administradores ferramentas para estruturar disciplinas e acompanhar o engajamento geral.

## Perfis de usuário:

- **Discente:** registra sessões de estudo, acompanha seu histórico e acumula XP.
- **Responsável:** acompanha o cumprimento das metas de estudo.
- **Administrador:** organiza disciplinas e acompanha o engajamento da plataforma.

## Funcionalidades:

- Cadastro e gerenciamento de usuários.
- Organização de disciplinas.
- Registro de sessões de estudo.
- Modalidades de estudo: Pomodoro, exercícios e leitura.
- Cálculo e acompanhamento de XP.
- Histórico de atividades do discente.
- Criação e acompanhamento de metas de estudo.
- Sistema de notificações por diferentes canais.
- Exportação de dados no formato JSON.
- Integração com banco de dados MySQL.

## Conceitos de Programação Orientada a Objetos:

Durante o desenvolvimento, são aplicados os seguintes conceitos:

- Classes e objetos.
- Encapsulamento.
- Herança.
- Abstração e classes abstratas.
- Polimorfismo dinâmico (sobrescrita).
- Polimorfismo estático (sobrecarga).
- Interfaces.
- Relacionamentos entre classes.
- Serialização de dados em JSON.

## Tecnologias utilizadas:

- **C#:** desenvolvimento das classes de domínio e do backend.
- **MySQL:** armazenamento dos dados.
- **Interface gráfica:** interação dos usuários com a plataforma.
- **API local:** comunicação entre a interface e o banco de dados.
- **Git e GitHub:** versionamento e organização do projeto.

## Arquitetura do projeto:

O sistema é organizado em três partes principais:

1. **Interface gráfica:** permite que os usuários interajam com as funcionalidades da plataforma.
2. **Backend em C#:** processa as requisições e executa as regras de negócio.
3. **Banco de dados MySQL:** armazena as informações do sistema.

## Como executar:

1. Clone este repositório.
2. Abra o projeto no Visual Studio.
3. Configure o ambiente conforme as instruções da atividade.
4. Inicie o backend local utilizando `iniciar_backend.bat`.
5. Execute a aplicação e teste as funcionalidades disponíveis.

> O backend fornecido para a atividade está localizado na pasta `Aula_09_Exercicios_Projeto_PI/Backend/`.

## Objetivo acadêmico:

O FecapStudy tem como objetivo consolidar os conhecimentos de Programação Orientada a Objetos por meio de um projeto prático e incremental, conectando conceitos de desenvolvimento de software a uma necessidade real do ambiente acadêmico.
