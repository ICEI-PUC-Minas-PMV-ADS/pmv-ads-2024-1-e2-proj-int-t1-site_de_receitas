# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:

## Plano de Testes dos Requisitos Funcionais
| **Caso de Teste** 	| **CT-01 - Cadastrar Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001: O sistema deve permitir que o usuário se cadastre. |
| Objetivo do Teste 	| Verificar a função de cadastrar usuários. |
| Passos 	| - Acessar a página de cadastro de usuário <br> - Adicionar nome de usuário, e-mail e confirmar senha       <br>  - Autenticar usuário cadastrado com e-mail e senha.
|Critério de Êxito | -  Será exibido na tela "O usuário foi cadastrado com sucesso". |
 
| **Caso de Teste** 	| **CT-02 - Cadastro de receitas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002: O sistema deve permitir que o usuário cadastre novas receitas com o nome dessas receitas e seus respectivos ingredientes e modos de preparo. |
| Objetivo do Teste 	| Verificar a função de cadastrar uma receita, ingredientes e seu modo de preparo. |
| Passos 	| - Ser um usuário cadastrado <br>- Acessar a tela de criação de receita <br>- Adicionar as informações: Nome da receita, Ingredientes, modo de preparo e tempo médio de preparo <br>- Salvar a receita <br>- Fazer uma busca pela receita criada. <br>  |
|Critério de Êxito |  A receita foi cadastrada com sucesso. |


| **Caso de Teste** 	| **CT-03 – Avaliar receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - O sistema deve permitir que usuários adicionem avaliações às receitas por meio de notas que variam de um número à outro (ex: 0 à 5). |
| Objetivo do Teste 	| Verificar se o usuário conseguirá atribuir uma nota a receita. |
| Passos 	| - Acessar a página de uma receita específica <br> - Adicionar uma avaliação com uma nota válida (Ruim, Bom, Ótimo) <br> - Verificar se a avaliação é exibida na receita <br> - Clicar em "Confirmar a nota" |
|Critério de Êxito | - A avaliação será exibida na tela. |
 
| **Caso de Teste** 	| **CT-04 – Cadastrar Ingrediente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 -  O sistema deve permitir que o usuário cadastre novos ingredientes.|
| Objetivo do Teste 	| Verificar a função de cadastro de ingredientes. |
| Passos 	| - Acessar a página de ingredientes <br> -  Acessar a opção de cadastrar novo<br> - Preencher os dados pedidos e salvar <br> - Verificar os ingredientes exibidos  |
|Critério de Êxito | - O ingrediente cadastrado deve passar a ter uma ID e ser exibido adequadamente. |

| **Caso de Teste** 	| **CT-05 – Edição de receitas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005: O sistema deve permitir que o usuário edite receitas já cadastradas. |
| Objetivo do Teste 	| Verificar a função de editar uma receita, ingredientes e seu modo de preparo. |
| Passos 	| - Ser um usuário cadastrado. <br> -  Acessar a tela de visulizar receita cadastradas. <br> - Alterar as informações: Nome da receita, Ingredientes, modo de preparo e tempo médio de preparo. <br> - Salvar a receita. <br> - Aceesar tela de receitas cadastradas. <br>  |
|Critério de Êxito | -  A receita foi editada com sucesso. |

| **Caso de Teste** 	| **CT-06 – Edição de Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006: O sistema deve permitir que o usuário edite seus  dados |
| Objetivo do Teste 	| Verificar a função de editar dados do usuário. |
| Passos 	| - Ser um usuário cadastrado. <br> -  Acessar a tela de usuários. <br> - Alterar as informações: nome, e-mail, senha e especificação culinaria. <br> - Salvar usuário. <br> - Aceesar tela de usuarios. <br>  |
|Critério de Êxito | -   Usuário foi editado com sucesso. |

| **Caso de Teste** 	| **CT-07 – Desfazer avaliação de receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-007: O sistema deve permitir que o usuário desfaça sua avaliação |
| Objetivo do Teste 	| Verificar a função de desfazer avaliação de uma receita. |
| Passos 	| - Acessar página de uma receita específica. <br> -  Verificar a existência da avaliação feita. <br> - Clicar no botão de desfazer avaliação. <br> - Verificar se a avaliação feita não existe mais. <br>  - Verificar a aparição de mensagem avisando que a avaliação foi desfeita com sucesso. <br> |
|Critério de Êxito | - A avaliação feita  não é mais apresentada, mesmo após revisitar a página da receita. |

| **Caso de Teste** 	| **CT-08 – Exclusão de perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008: O sistema deve permitir que o usuário exclua seu perfil |
| Objetivo do Teste 	| Verificar a funcionalidade de exclusão de perfil. |
| Passos 	| - Acessar página de perfil. <br> -  Clicar em "Excluir conta". <br> - Verificar existência de mensagem de aviso sobre o sucesso na exclusão. <br> - Verificar se houve o redirecionamento à tela de login. <br> -Verificar se, preenchendo o formulário com os dados da conta excluída, as credenciais não são reconhecidas. <br>|
|Critério de Êxito | - Credenciais de conta excluída não são mais reconhecidas pelo sistema. |

| **Caso de Teste** 	| **CT-09 - Edição de Ingredientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-009: O sistema deve permitir que o usuário edite ingredientes já cadastrados |
| Objetivo do Teste 	| Confirmar a edição de ingredientes|
| Passos 	| Usuário deve estar logado <br> - Navegar até: Ingredientes e editar um ingrediente |
| Critério de Êxito | O ingrediente deve passar a refletir as novas informações tanto em ingrediente quanto nas receitas onde está cadastrado |

| **Caso de Teste** 	| **CT-10 Exclusão de Ingredientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-010: O sistema deve permitir que usuário exclua ingredientes |
| Objetivo do Teste 	| Confirmar a exclusão de ingredientes |
| Passos 	| O usuário deve estar logado <br> - Navegar até: Ingredientes <br> - Selecionar ingrediente a ser excluída e clicar em excluir <br> - Confirmar que deseja excluir <br> - Navegar até: Ingredientes |
| Critério de Êxito | O ingrediente não deve mais constar na listagem após a exclusão |


------------------


## Plano de Testes dos Requisitos Não Funcionais

| **Caso de Teste** 	| **CT-01 Privacidade de dados** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-001: O sistema não deve expor dados sensíveis do usuário |
| Objetivo do Teste 	| Garantir a segurança dos dados sensíveis do usuário |
| Passos 	| O usuário pode ou não estar logado <br>- Navegar até uma receita<br>- Selecionar o autor<br>- Verificar os dados disponíveis sobre o autor        |
|Critério de Êxito | Apenas o nome de usuário do autor deve estar disponível para visualização |

| **Caso de Teste** 	| **CT-02- Arquitetura MVC** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-002: O sistema deve ser desenvolvido utilizando a arquitetura MVC |
| Objetivo do Teste 	| Verificar se a aplicação foi desenvolvida utilizando a arquitetura MVC |
| Passos 	| - Revisar código para verificar se todos os módulos correspondem à arquitetura MVC        |
|Critério de Êxito | Devem existir separações claras entre as camadas Model, View e Controller |

| **Caso de Teste** 	| **CT-03 - Framework de desenvolvimento** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-003: O sistema deve ser desenvolvido utilizando o framework ASP.NET Core MVC. |
| Objetivo do Teste 	| Verificar se a aplicação foi desenvolvida inteiramente com framework ASP.NET Core MVC. |
| Passos 	| - Revisar código para verificar se todos os módulos correspondem à arquitetura MVC e se utilizam do framework ASP.NET Core MVC. <br>        |
|Critério de Êxito | - Ausência de implementação de demais frameworks que não correspondem ao framework ASP.NET Core MVC. |

| **Caso de Teste** 	| **CT-04 - Sistema Multiusuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-004: O sistema deve ser capaz de lidar com vários usuários simultâneos sem sofrer degradações significativas no desempenho. |
| Objetivo do Teste 	| Verificar se a aplicação suporta múltiplos usuários sem diminuição significativa de desempenho. |
| Passos 	| - Acessar a aplicação por 2 ou mais acessos simultaneamente. <br>        |
|Critério de Êxito | - A aplicação não apresentou lentidão ou travamentos no carregamento das páginas e nas respostas às ações dos usuários durante o teste. |

| **Caso de Teste** 	| **CT-05 - Sistema Multiusuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-005: O sistema deve suportar múltiplos usuários simultaneamente. |
| Objetivo do Teste 	| Verificar se a aplicação suporta múltiplos usuários. |
| Passos 	| - Acessar a aplicação por 2 ou mais acessos simultaneamente. <br>        |
|Critério de Êxito | - A aplicação não caiu durante o teste. |

| **Caso de Teste** 	| **CT-06 - Tempo de Resposta** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-006: O sistema não deve ter tempo médio de resposta superior a 5s. |
| Objetivo do Teste 	| Verificar se a aplicação ultrapassa o tempo de resposta desejado. |
| Passos 	| - Acessar a aplicação <br>- Realizar varias ações como: acessar o perfil, visualizar receita, pesquisar uma receita. |
|Critério de Êxito |  O tempo de Resposta não deve ser superior a 5s em cada pagina. |

| **Caso de Teste** 	| **CT-07 - Clean Code** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RFN - 007: O sistema deve ser desenvolvido utilizando práticas recomendadas de clean code. |
| Objetivo do Teste 	| Garantir que o sistema desenvolvido siga práticas recomendadas de clean code. |
| Passos 	| - Analisar o código-fonte para identificar possíveis violações às práticas de clean code, como duplicação de código, funções muito longas, nomes de variáveis confusos, etc. |
|Critério de Êxito |  Ausência de violações graves de clean code. |

| **Caso de Teste** 	| **CT-08 – Testar em diferentes navegadores** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-008 - O sistema deve ser executado nos navegadores Google Chrome, Opera e Edge. |
| Objetivo do Teste 	| verificar se o sistema executa corretamente nos navegadores Google Chrome, Opera e Edge. |
| Passos 	| - Acessar o sistema utilizando os navegadores Google Chrome, Opera e Edge <br> - Verificar se todas as funcionalidades estão disponíveis e funcionam corretamente em cada navegador <br>        |
|Critério de Êxito | - O sistema funciona em todos os navegadores testados. |


| **Caso de Teste** 	| **CT-09 – Tempo de Resposta** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RFN - 010: O sistema deve continuar funcionando apresentando conteúdo já carregado em caso de queda de conexão ou instabilidade no banco de dados. |
| Objetivo do Teste 	| Verificar se a aplicação apresenta o conteúdo já carregado. |
| Passos 	| - Acessar a aplicação e conseguir visualizar telas anteriormentes acessadas. |
|Critério de Êxito | -  A aplicação conseguiu exibir as telas acessadas anteriormente durante o teste. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
