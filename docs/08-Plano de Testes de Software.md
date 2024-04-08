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
| Passos 	| - Acessar a página de cadastro de usuário - Adicionar nome de usuário, e-mail e confirmar senha         - Autenticar usuário cadastrado com e-mail e senha.
|Critério de Êxito | -  Será exibido na tela "O usuário foi cadastrado com sucesso". |
 
| **Caso de Teste** 	| **CT-02 - Cadastro de receitas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002: O sistema deve permitir que o usuário cadastre novas receitas com o nome dessas receitas e seus respectivos ingredientes e modos de preparo. |
| Objetivo do Teste 	| Verificar a função de cadastrar uma receita, ingredientes e seu modo de preparo. |
| Passos 	| - Ser um usuário cadastrado - Acessar a tela de criação de receita - Adicionar as informações: Nome da receita, Ingredientes, modo de preparo e tempo médio de preparo - Salvar a receita - Fazer uma busca pela receita criada. <br>  |
|Critério de Êxito |  A receita foi cadastrada com sucesso. |


| **Caso de Teste** 	| **CT-03 – Avaliar receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - O sistema deve permitir que usuários adicionem avaliações às receitas por meio de notas que variam de um número à outro (ex: 0 à 5). |
| Objetivo do Teste 	| Verificar se o usuário conseguirá atribuir uma nota a receita. |
| Passos 	| - Acessar a página de uma receita específica <br> - Adicionar uma avaliação com uma nota válida (entre 0 e 5) <br> - Verificar se a avaliação é exibida na receita <br> - Clicar em "Confirmar a nota" |
|Critério de Êxito | - A avaliação será exibida na tela. |
 
| **Caso de Teste** 	| **CT-04 – Pesquisar receita** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 -  O sistema deve permitir que o usuário pesquise por receitas cadastradas através de seus ingredientes ou nomes. |
| Objetivo do Teste 	| Verificar a função de busca por receitas ou ingredientes. |
| Passos 	| - Acessar a página de pesquisa de receitas <br> -  Inserir um nome de receita ou ingrediente na barra de pesquisa <br> - Verificar se as receitas relevantes são exibidas nos resultados da pesquisa <br>  |
|Critério de Êxito | - o nome da receita ou ingredientes digitados retornam as receitas salvas no banco de dados. |



## Plano de Testes dos Requisitos Não Funcionais
| **Caso de Teste** 	| **CT-05 - Sistema Multiusuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-005: O sistema deve suportar múltiplos usuários simultaneamente. |
| Objetivo do Teste 	| Verificar se a aplicaçãosuporta múltiplos usuários. |
| Passos 	| - Acessar a aplicação por 2 ou mais acessos simultaneamente. <br>        |
|Critério de Êxito | - A aplicação não caiu durante o teste. |

| **Caso de Teste** 	| **CT-06 - Tempo de Resposta** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-006: O sistema não deve ter tempo médio de resposta superior a 5s. |
| Objetivo do Teste 	| Verificar se a aplicação ultrapassa o tempo de resposta desejado. |
| Passos 	| - Acessar a aplicação - Realizar varias ações como: acessar o perfil, visualizar receita, pesquisar uma receita. |
|Critério de Êxito |  O tempo de Resposta não deve ser superior a 5s em cada pagina. |

| **Caso de Teste** 	| **CT-08 – Testar em diferentes navegadores** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-008 - O sistema deve ser executado nos navegadores Google Chrome, Opera e Edge. |
| Objetivo do Teste 	| verificar se o sistema executa corretamente nos navegadores Google Chrome, Opera e Edge. |
| Passos 	| - Acessar o sistema utilizando os navegadores Google Chrome, Opera e Edge <br> - Verificar se todas as funcionalidades estão disponíveis e funcionam corretamente em cada navegador <br>        |
|Critério de Êxito | - O sistema funciona em todos os navegadores testados. |

| **Caso de Teste** 	| **CT-09 – Avaliar a Expansividade** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RNF-009 - O sistema deve ser expansivo. |
| Objetivo do Teste 	| verificar a expansividade do sistema. |
| Passos 	| - Analisar a estrutura do sistema para verificar se é modular e permite a adição de novas funcionalidades sem alterar o código existente <br> - Testar a adição de novas funcionalidades e verificar se o sistema continua funcionando corretamente. |
|Critério de Êxito | - O sistema funciona corretamente mesmo após a adição de novas funcionalidades. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
