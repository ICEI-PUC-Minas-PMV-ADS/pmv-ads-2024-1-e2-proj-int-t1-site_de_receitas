# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="01-Documentação de Contexto.md"> Documentação de Contexto</a></span>

<!--Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto-->

Diante do contexto levantado, a proposta é uma plataforma projetada para atender às necessidades de diferentes usuários, proporcionando uma experiência culinária acessível e capaz de atender demandas customizáveis. Para isso, buscamos envolver um pequeno grupo de usuários em potencial dispostos a acompanhar o processo de design da solução.

Como características principais do que nossos usuários buscam, nos decidimos por priorizar:

- Os usuários demonstraram interesse em um sistema que os ajude a poupar tempo selecionando algo que atende seus objetivos, além de facilitar que se decidam entre as opções viáveis. Para isso, desenvolveremos em um sistema multifatorial de pesquisa que deve permitir ao usuário buscar receitas que se adequem às diversas formas que suas demandas podem se apresentar e agrupar. 

- Precisam que as receitas sejam facilmente adequadas para diferentes perfis de usuários. Portanto, pretendemos possibilitar diferentes formas de categorização que possam registrar tipos de demandas que uma receita atende, por exemplo: fácil preparo, rápido preparo, não exige forno, segura para celíacos, etc..

- Têm, também, interesse em um senso de comunidade e espaço interativo para compartilhamento e aprendizado de versões e avaliações das receitas. Pretendemos viabilizar o compartilhamento de receitas ou conexão de variações customizadas, com dicas de ingredientes alternativos e adaptações a diferentes gostos ou situações. 

A plataforma deve ser moldada com a prioridade máxima de garantir uma experiência centrada nas demandas do usuário, fornecendo uma experiência culinária diversificada, personalizada e acessível a diferentes estilos de vida, preferências e restrições alimentares. Para garantir o desenvolvimento de um produto que atenda nossos usuários, a intenção é validar nossos requisitos funcionais e propostas de desenvolvimento em um primeiro momento e posteriormente envolvê-los em etapas de testes de usabilidade da plataforma, sempre com um foco em adaptação ao feedback recebido.

------

## Personas

### Persona 1

- Nome: Ricardo

- Idade: 21

- Ocupação: Estudante universitário

- História: Ricardo passou grande parte de sua vida com idas ao hospital alegando estar passando mal e sentindo dores, principalmente após refeições. Após muitos exames, que duraram anos,durante sua vida universitária, descobriu tardiamente que é portador da doença de chron, doença auto-imune que causa inflamação intestinal e dificuldade na absorção de nutrientes. Desde então, passou a ter que adequar a sua dieta à sua condição médica, que impõe diversas restrições alimentares, e à sua vida universitária.

- Problemas/Frustrações: Não conseguir encontrar receitas diversificadas que se adequem à sua condição especial e que sejam práticas o suficiente para serem feitas em meio à sua vida ocupada de estudante, e não saber se ele pode experimentar determinadas receitas por desconhecer os ingredientes nelas envolvidos.

- Metas: Encontrar receitas diversificadas que encaixam em sua restrição alimentar e conhecer melhor os ingredientes que compõem cada receita.

### Persona 2

- Nome: Victoria

- Idade: 20

- Ocupação: Estudante e Atendente

- História: Victoria é uma jovem estudante universitária que trabalha como atendente em meio período para ajudar a custear seus estudos e despesas pessoais. Ela está no segundo ano de faculdade, estudando Engenharia de Software. 

- Problemas/Frustrações: Tem uma rotina agitada entre estudos, trabalho e vida social, o que torna difícil encontrar tempo para cozinhar refeições saudáveis e saborosas, gastando assim muito dinheiro para comer fora de casa.

- Metas: Encontrar receitas que se encaixem em sua agenda lotada e que sejam fáceis e rápidas de preparar.

### Persona 3

- Nome: Jaqueline
 
- Idade: 34
 
- Ocupação: servidora pública e mãe
 
- História: Jaqueline é uma técnica judiciária, trabalha 6h por dia e é mãe da Sofia de 3 anos e casada com o Eduardo. A família mora em uma capital de um estado situado na região sul do Brasil e tem uma rotina bem corrida, de levar a filha para a escola, ir trabalhar, ir para academia, pegar a filha na escola e à noite prefere fazer receitas práticas, porém saudáveis para cozinhar com seu marido. Prefere ingredientes naturais pois deseja acostumar o paladar da filha com sabores naturais e assim retardar ao máximo a introdução de produtos industrializados na dieta da criança.
 
- Problemas/Frustrações: Apesar de não ter muito tempo disponível e também disposição em virtude da rotina agitada, não abre mão de incluir na alimentação uma dieta saudável, no entanto, as receitas que encontra na internet sempre exigem muitos ingredientes diferentes o que a leva ou desistir da receita ou procurar ingredientes alternativos que possua em casa.
 
- Metas: Ter acesso a um aplicativo ou site com receitas saudáveis de poucos ingredientes, ter também um espaço onde possa compartilhar as receitas que criou/modificou na sua busca por ingredientes alternativos às receitas tradicionais.

### Persona 4

- Nome: Carlos 

- Idade:  29 anos

- Ocupação: Desenvolvedor de Software

- História: Carlos aprendeu a cozinhar com a família, e sempre teve associações muito positivas ao tempo que passava ajudando quando mais novo e eventualmente preparando os próprios pratos para que experimentassem juntos. Quando se mudou para longe dos pais para estudar isso parou de ser algo que fazem juntos, mas nunca deixou de compartilhar receitas que encontra com eles, ou de tentar proporcionar que decidam juntos o que podem preparar quando se reúnem.

- Problemas/Frustrações: A paixão de Carlos por cozinhar é incompatível com sua rotina de trabalho corrida, e ele precisa encontrar novas receitas que possam servir bem a esse propósito. 
Carlos não tem muito contato direto com pessoas que compartilhem do seu gosto por cozinhar, e precisa também de novas formas de buscar receitas que possa fazer por diversão. 
Carlos preferiria ter uma solução online para catalogar e registrar suas receitas, de preferência uma que pudesse compartilhar facilmente com os pais. 
Carlos gostaria de poder disponibilizar suas próprias versões de receitas para o público, por valorizar fortemente a experiência colaborativa que isso pode proporcionar.

- Metas:  Carlos quer aprimorar suas habilidades culinárias e mantê-las em constante prática. Também quer compartilhar suas receitas e experiências com outros entusiastas ou até mesmo só propor pequenas mudanças que podem deixar pratos simples mais gostosos. Precisa, também, encontrar receitas práticas e deliciosas para o dia a dia, considerando sua agenda agitada como desenvolvedor.

### Persona 5

- Nome: Alexandro

- Idade: 28 anos

- Ocupação: Nutricionista

- História: Alexandro é um homem trans, mora na capital mineira onde divide apartamento com seu noivo Jonas. Alexandro sempre teve muito interesse pela alimentação e em como ela impacta na vida de cada um. Ele trabalha de forma online para uma ong que dá suporte a pessoas carentes.

- Problemas/Frustrações: Não encontrar com facilidade receitas diferentes utilizando o mesmo tipo de alimento de forma versátil e dificuldade em salvar receitas de forma centralizada em um lugar.

- Metas: Poder acessar diferentes receitas com o mesmo alimento com facilidade, ter agilidade em montar um cardápio com receitas saudáveis e variadas.

------

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| Ricardo, 21 anos, estudante universitário | Buscar eficientemente por receitas diversificadas | Encontrar receitas que se adequem às minhas restrições alimentares impostas por minha condição médica |
| Ricardo, 21 anos, estudante universitário | Conhecer os ingredientes envolvidos em algumas receitas famosas | Verificar se posso consumi-las sem que agravem os sintomas da minha doença |
| Victoria, 20 anos, estudante e atendente | Descobrir receitas rápidas, saborosas e saudáveis | Necessidade de Victoria cuidar de sua saúde e bem-estar, mesmo em meio à sua agenda lotada |
| Victoria, 20 anos, estudante e atendente | Encontrar receitas econômicas | Maneira rápida e fácil de encontrar receitas saudáveis e econômicas, para que possa preparar refeições nutritivas sem gastar muito tempo ou dinheiro |
| Jaqueline, 34 anos, servidora pública e mãe | Encontrar receitas saudáveis e práticas | Proporcionar uma alimentação saudável para a família, principalmente para filha de 3 anos para que ela se acostume desde cedo com os ingredientes naturais |
| Jaqueline, 34 anos, servidora pública e mãe | Um site ou aplicativo que possibilite comentários / interações | Compartilhar as suas experiências culinárias dando dicas de receitas que já testou anteriormente |
| Carlos, 29 anos, desenvolvedor de software e cozinheiro hobbysta | Poder filtrar receitas por nível de complexidade | Poder escolher opções práticas para o meu dia a dia corrido e mais elaboradas para me divertir nos fins de semana |
| Carlos, 29 anos, desenvolvedor de software e cozinheiro hobbysta | Poder transformar o meu hobby em uma experiência que interage com outros usuários | Poder transformar o meu hobby em uma experiência que interage com outros usuários |
| Alexandro, 28 anos, Nutricionista | Poder encontrar receitas utilizando o mesmo alimento | Entregar ao cliente um certa diversidade na alimentação |
| Alexandro, 28 anos, Nutricionista | Poder agrupar receitas de forma centralizada | Poder ver e utilizar as receitas de forma prática ao montar um cardápio |

------

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir que o usuário se cadastre | Alta | 
|RF-002| O sistema deve permitir que o usuário cadastre novas receitas com o nome dessas receitas e seus respectivos ingredientes e modos de preparo | Alta |
|RF-003| O sistema deve permitir que usuários adicionem avaliações às receitas por meio de notas que variam de um número à outro (ex: 0 à 5) | Alta |
|RF-004| O sistema deve permitir que o usuário pesquise por receitas cadastradas através de seus ingredientes ou nomes | Alta |
|RF-005| O sistema deve permitir que o usuário edite receitas já cadastradas | Alta |
|RF-006| O sistema deve permitir que o usuário edite seus próprios dados | Alta |
|RF-007| O sistema deve permitir que o usuário desfaça sua avalição | Alta |
|RF-008| O sistema deve permitir que o usuário exclua seu perfil | Alta |
|RF-009| O sistema deve fornecer ao usuário uma lista com todas as receitas já cadastradas por ele | Alta |
|RF-010| O sistema deve permitir que usuário exclua receitas por ele cadastradas | Alta |
|RF-011| O sistema deve permitir que usuário modifique a avaliação que ele fez anteriormente sobre determinada receita | Média |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema não deve expor dados sensíveis do usuário | ALTA | 
|RNF-002| O sistema deve ser desenvolvido utilizando a arquitetura MVC |Alta |
|RNF-003| O sistema deve ser desenvolvido utilizando o framework ASP.NET Core MVC |Alta
|RNF-004| O sistema deve ser capaz de lidar com vários usuários simultâneos sem sofrer degradações significativas no desempenho | Média
|RNF-005| O sistema deve suportar múltiplos usuários simultaneamente | Alta |
|RNF-006| O sistema não deve ter tempo médio de resposta superior a 5s | Média |
|RNF-007| O sistema deve ser desenvolvido utilizando práticas recomendadas de clean code | Média |
|RNF-008| O sistema deve ser executado nos navegadores Google Chrome, Opera e Edge | Média
|RNF-009| O sistema deve ser expansivo | Média |
|RNF-010| O sistema deve continuar funcionando apresentando conteúdo já carregado em caso de queda de conexão ou instabilidade no banco de dados | Média |

------

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             | Tipo |
|--|-------------------------------------------------------| ---- |
|01| Orçamentária: Estima-se em aproximadamente R$120.000,00 os custos do desenvolvimento do projeto incluindo as despesas com pesquisa, design, codificação, testes, armazenamento na nuvem e marketing. |Gestão|
|02| Prazo: a equipe tem um prazo total de 4 meses para a conclusão do desenvolvimento da aplicação e o seu lançamento |Gestão|
|03| Falta de experiência no tema específico do projeto: pouca experiência da equipe em termos de dotes culinários e conhecimento incipiente em relação a banco de dados |Gestão|
|04| Público-alvo diverso: a necessidade de atender a diversos perfis de usuários poderá ser um dificultador do processo uma vez que a aplicação precisa apresentar conteúdo muito abrangente |Negócio|
|05| Concorrência: a grande quantidade de sites de receitas exigirá uma diferenciação importante para que a aplicação a ser desenvolvida se destaque |Negócio|
|06| Modelo de monetização: Para a sustentabilidade do negócio, o aplicativo deverá ter a modalidade de usuário premium com cobrança de assinatura e a busca por parceiros anunciantes, tais como indústrias alimentícias e de eletrodomésticos |Negócio|

------

## Diagrama de Casos de Uso
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-site_de_receitas/blob/main/docs/img/Diagrama%20caso%20de%20uso.png?raw=true" alt="Diagrama de Casos de Uso">

