# Banco-de-Dados2

## Tutorial para criar um projeto no Visual Studio

- Criar novo projeto na pasta (BancoDeDados2)
- Aplicativo Web do ASP.NET (Core MVC)
- Local (cola a pasta do caminho)
- Nome do projeto (AulaEntityFramework)
- Nome do servidor para conectar "(localdb)\MSSQLLocalDB" SQL Server Express
- Para criar a migration "dotnet ef migrations add Initial"
- Comando para atualizar a migration "dotnet ef database update"
- Comando para remover a ultima migration "dotnet ef migrations remove"
- Aplicar migrations e atualiza BD "dotnet ef database update"
- Novo item com scaffold na model
- ctrl + shift + b = builda o sistema
- ctrl + f5 = rodar sem debugger

## Buscar conhecimento 

- MVVM - Model View View Model

## Tema 

Cria um projeto com categoria e item, 1 categoria pode ter varios items
- Modelo - Categoria 1 : N Item (Carro, Banda, Time) etc...
- ORM - Conexão
- Criar migrations - Atualizar BD
- Controllers / Views (Scaffold)
- Git (Atualizar repositorio)

## Lembrete

- Prova 20/09 
- Fazer o projeto do campeonato / pontos corridos / 
- Aula 13/09 n para n

# Atividade 

Uma instituição precisa criar uma plataforma de banco de dados para armazenar e registrar os resultados e participações dos times e atletas em competições dos mais diversos generos/modalidades, as modalidades pode ocorrer por equipe ou individuais.
Os torneios deverão poder acontecer por grupos/chaveamentos com classificatórias, oitavas, quartas, semi e finais ou diretamentes ou diretamente por pontos corridos.
Deverão ser registrados os resultados de cada partida bem como a pontuação das equipes somando-se 3pts por vitoria e 1pt por empate.
Permitindo ordenar por pontuação os grupos e monstar as fases eliminatórias.

Elaborar um modelo de estrutura Entidade-Relacional para um banco de dados que atenda as modalidades pode ocorrer.

Instituição 
registrar os resultados - score
resultados - endGame? / wins 
participacoes dos times e atletas em competições dos mais diversos generos- teams / players / genre
Os torneio deverão poder acontecer por grupo/chaveamentos com classificatórias 


