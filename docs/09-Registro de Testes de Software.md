# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-01 – Cadastrar Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001: O sistema deve permitir que o usuário se cadastre. |
|Registro de evidência | [Teste CT1](https://drive.google.com/file/d/1_yxnDxokRcgrswnuasG4gyYeeRaLp9Xp/view?usp=sharing) |
|Resultado | Bem sucedido. |
|Ação | - |

| **Caso de Teste** 	| **CT-02 - Cadastro de receitas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002: O sistema deve permitir que o usuário cadastre novas receitas com o nome dessas receitas e seus respectivos ingredientes e modos de preparo. |
|Registro de evidência | [Teste CT2](https://drive.google.com/file/d/1fKNcuwuhwat81pWiXd3GWsFgNFVBaopA/view?usp=sharing)|
|Resultado | Falha |
|Ação | Já foi detectado que é um problema no controller, correções em andamento.|

| **Caso de Teste** 	| **CT-03 – Avaliar receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - O sistema deve permitir que usuários adicionem avaliações às receitas por meio de notas que variam de um número à outro (ex: 0 à 5). |
|Registro de evidência | [Teste CT3](https://drive.google.com/file/d/1wXnZ-QTeZpkZ1fvjgCLQ5-PDyyZQ6b-d/view?usp=sharing) |
|Resultado | Falha. Não salvou e mostrou modo de preparo no lugar de nome da receita. |
|Ação | Correção da gravação das avaliações. |

| **Caso de Teste** 	| **CT-04 – Cadastrar Ingrediente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - O sistema deve permitir que o usuário cadastre novos ingredientes. |
|Registro de evidência | [Teste CT4](https://drive.google.com/file/d/1qqW30VFi9yea3hMa-QHDPd6AK_dnQtF8/view?usp=sharing) |
|Resultado | Bem sucedido. |
|Ação | - |

| **Caso de Teste** 	| **CT-05 – Edição de receitas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005: O sistema deve permitir que o usuário edite receitas já cadastradas. |
|Registro de evidência | [Teste CT5](https://drive.google.com/file/d/1rXWZrvyumtE18s-E8hz-gVyzGBrUiBHg/view?usp=sharing) |
|Resultado | Falha |
|Ação | Corrigir o controller do crud receita. |

| **Caso de Teste** 	| **CT-06 – Edição de Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006: O sistema deve permitir que o usuário edite seus próprios dados |
|Registro de evidência | [Teste CT6](https://drive.google.com/file/d/11q6xLA57Y50-4vsNkQcd0YVrDFHdqeIK/view?usp=sharing) |
|Resultado | Falha |
|Ação | Dar acesso ao usuário. |

| **Caso de Teste** 	| **CT-07 – Desfazer avaliação de receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-007: O sistema deve permitir que o usuário desfaça sua avaliação |
|Registro de evidência | [Teste CT7](https://drive.google.com/file/d/1JFqw_ItQDLTOD4lslct8ABtqvzm-So8y/view?usp=sharing) |
|Resultado | Impedimento de teste em ct3. |
|Ação | Correção de ct3 |

| **Caso de Teste** 	| **CT-08 – Exclusão de perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008: O sistema deve permitir que o usuário exclua seu perfil |
|Registro de evidência | [Teste CT8](https://drive.google.com/file/d/1c1llpBpA-CLsmxyctTzy1dpadTF98u_V/view?usp=sharing) |
|Resultado | Falha - sem acesso. |
|Ação | Dar acesso ao usuário. |

| **Caso de Teste** 	| **CT-09 - CT-09 - Edição de Ingredientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-009: O sistema deve permitir que o usuário edite ingredientes já cadastrados |
|Registro de evidência | [Teste CT9](https://drive.google.com/file/d/15HHzz3lK3N2x8w3PaJfw5lAtHt0f2AeG/view?usp=sharing) |
|Resultado | Bem Sucedido. |
|Ação | - |

| **Caso de Teste** 	| **CT-10 Exclusão de Ingredientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-010: O sistema deve permitir que usuário exclua ingredientes |
|Registro de evidência | [Teste CT10](https://drive.google.com/file/d/1E8eLh5sk6jottLobcBLTncP8DcoMc95o/view?usp=sharing) |
|Resultado | Bem Sucedido |
|Ação | - |

| **Caso de Teste** 	| **CT-11 Privacidade de dados** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-001: O sistema não deve expor dados sensíveis do usuário |
|Registro de evidência | Sem registro. |
|Resultado | Bem sucedido - o usuário logado ou não não pode ver os dados de outros usuários. |
|Ação | Deixar o usuário ver os próprios dados. |

| **Caso de Teste** 	| **CT-12 Arquitetura e Framework** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-002: O sistema deve ser desenvolvido utilizando a arquitetura MVC |
|Registro de evidência | Sem registro, análise de código. |
|Resultado | Bem Sucedido. |
|Ação | - |

| **Caso de Teste** 	| **CT-13 Framework de desenvolvimento** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-003: O sistema deve ser desenvolvido utilizando o framework ASP.NET Core MVC. |
|Registro de evidência | Sem registro, análise de código.  |
|Resultado | Bem Sucedido. |
|Ação | - |

| **Caso de Teste** 	| **CT-14 Sistema Multiusuário 1** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-004: O sistema deve ser capaz de lidar com vários usuários simultâneos sem sofrer degradações significativas no desempenho. |
|Registro de evidência | [Teste Multiusuário](https://drive.google.com/file/d/1jYpf1BUfRuUGK1Cfv8V4sgf346PFhe0Q/view?usp=sharing)  |
|Resultado | Bem sucedido. |
|Ação | - |

| **Caso de Teste** 	| **CT-15 Sistema Multiusuário 2** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-005: O sistema deve suportar múltiplos usuários simultaneamente. |
|Registro de evidência | [Teste Multiusuário](https://drive.google.com/file/d/1jYpf1BUfRuUGK1Cfv8V4sgf346PFhe0Q/view?usp=sharing) |
|Resultado | Bem sucedido. |
|Ação | - |

| **Caso de Teste** 	| **CT-16 Tempo de Resposta** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-006: O sistema não deve ter tempo médio de resposta superior a 5s. |
|Registro de evidência | [Teste Tempo de Resposta](https://drive.google.com/file/d/1h2VuJ8_k1a5RTphXgav56GhJSSuDivV4/view?usp=sharing) |
|Resultado | Bem sucedido |
|Ação | - |

| **Caso de Teste** 	| **CT-17 Clean Code** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RFN - 007: O sistema deve ser desenvolvido utilizando práticas recomendadas de clean code. |
|Registro de evidência | - |
|Resultado | - |
|Ação | - |

| **Caso de Teste** 	| **CT-18 Testar em diferentes navegadores** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-008 - O sistema deve ser executado nos navegadores Google Chrome, Opera e Edge. |
|Registro de evidência | [Teste Navegador](https://drive.google.com/file/d/1jYpf1BUfRuUGK1Cfv8V4sgf346PFhe0Q/view?usp=sharing)  |
|Resultado | Bem sucedido. |
|Ação | - |

| **Caso de Teste** 	| **CT-19 Permanência de conteúdo** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RFN - 010: O sistema deve continuar funcionando apresentando conteúdo já carregado em caso de queda de conexão ou instabilidade no banco de dados. |
|Registro de evidência | Sem registro. |
|Resultado | Bem sucedido. |
|Ação | - |





## Avaliação

Os resultados dos testes indicam que há problemas em partes fundamentais do sistema, com correções já em andamento, mas que em sua grande parte está funcionando e cumpre múltiplos requisitos.
<!--
> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
-->
