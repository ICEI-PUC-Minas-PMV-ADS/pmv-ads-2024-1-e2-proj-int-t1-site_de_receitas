# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-01 – Cadastrar Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001: O sistema deve permitir que o usuário se cadastre. |
|Registro de evidência | [Teste 1](https://drive.google.com/file/d/1Vs3ouv7H6yx2gXAk8Du1BXCTNSUjr0Ho/view?usp=sharing) e [Teste 2](https://drive.google.com/file/d/1W9hhcPPiycbWOIJnqJkcbgVIg3ao_WPh/view?usp=sharing) |
|Resultado | FALHA - Em um dos testes o usuário tentou acessar o cadastro de usuário através do LOGIN e ficou confuso. No outro tentou acessar a lista de usuários e apresentou erro. |
|Ação | Corrigir o erro da lista de usuários e implementar um botão que leve para o cadastro no login. |

| **Caso de Teste** 	| **CT-02 - Cadastro de receitas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002: O sistema deve permitir que o usuário cadastre novas receitas com o nome dessas receitas e seus respectivos ingredientes e modos de preparo. |
|Registro de evidência | [Teste 2](https://drive.google.com/file/d/1W9hhcPPiycbWOIJnqJkcbgVIg3ao_WPh/view?usp=sharing) |
|Resultado | FALHA - não gravou |
|Ação | Já foi detectado que é um problema na tabela de imagens, correções em andamento.|

| **Caso de Teste** 	| **CT-03 – Avaliar receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - O sistema deve permitir que usuários adicionem avaliações às receitas por meio de notas que variam de um número à outro (ex: 0 à 5). |
|Registro de evidência | - |
|Resultado | Impedimento de teste em ct2. |
|Ação | Correção de ct2 |

| **Caso de Teste** 	| **CT-04 – Pesquisar receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - O sistema deve permitir que o usuário pesquise por receitas cadastradas através de seus ingredientes ou nomes.n |
|Registro de evidência | www.teste.com.br/drive/ct-02 |
|Resultado | Não implementado  |
|Ação | Previsto para a próxima etapa. |

| **Caso de Teste** 	| **CT-05 – Edição de receitas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005: O sistema deve permitir que o usuário edite receitas já cadastradas. |
|Registro de evidência | - |
|Resultado | Impedimento de teste em ct2. |
|Ação | Correção de ct2 |

| **Caso de Teste** 	| **CT-06 – Edição de Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006: O sistema deve permitir que o usuário edite seus próprios dados |
|Registro de evidência | - |
|Resultado | Impedimento de teste em ct1.  |
|Ação | Correção de ct1. |

| **Caso de Teste** 	| **CT-06 – Edição de Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006: O sistema deve permitir que o usuário edite seus próprios dados |
|Registro de evidência | - |
|Resultado | Impedimento de teste em ct1. |
|Ação | Correção de ct1. |

| **Caso de Teste** 	| **CT-07 – Desfazer avaliação de receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-007: O sistema deve permitir que o usuário desfaça sua avaliação |
|Registro de evidência | - |
|Resultado | Impedimento de teste em ct2. |
|Ação | Correção de ct2 |

| **Caso de Teste** 	| **CT-08 – Exclusão de perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008: O sistema deve permitir que o usuário exclua seu perfil |
|Registro de evidência | - |
|Resultado | Impedimento de teste em ct1. |
|Ação | Correção de ct1. |

| **Caso de Teste** 	| **CT-09 - Lista de Receitas de autoria do Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-009: O sistema deve fornecer ao usuário uma lista com todas as receitas já cadastradas por ele |
|Registro de evidência | - |
|Resultado | Não implementado  |
|Ação | Previsto para a próxima etapa. |

| **Caso de Teste** 	| **CT-10 Exclusão** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-010: O sistema deve permitir que usuário exclua receitas por ele cadastradas |
|Registro de evidência | - |
|Resultado | Impedimento de teste em ct2. |
|Ação | Correção de ct2 |

| **Caso de Teste** 	| **CT-11 Arquitetura e Framework** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-002: O sistema deve ser desenvolvido utilizando a arquitetura MVC |
|	Requisito Associado 	| RNF-003: O sistema deve ser desenvolvido utilizando o framework ASP.NET Core MVC. |
|Registro de evidência | - |
|Resultado | CONFIRMADO. |
|Ação | |

| **Caso de Teste** 	| **CT-12 Privacidade de dados** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-001: O sistema não deve expor dados sensíveis do usuário |
|Registro de evidência | - |
|Resultado | Não implementado  |
|Ação | Previsto para a próxima etapa. |






## Avaliação

Os resultados dos testes indicam que há problemas em partes fundamentais do sistema, com correções já em andamento, e algumas melhorias de usabilidade a ser implementadas. Também mostram que as propostas de desenvolvimento estão sendo seguidas, mesmo que ainda em andamento.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
