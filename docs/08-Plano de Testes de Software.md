# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:

## Plano de Testes dos Requisitos Funcionais

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
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
