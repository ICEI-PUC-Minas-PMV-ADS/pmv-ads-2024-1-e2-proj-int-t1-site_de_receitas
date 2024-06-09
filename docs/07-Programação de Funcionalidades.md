# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.



|ID    | Descrição do Requisito  | Artefato(s) Produzido(s) | Acesso à Funcionalidade |
|------|-----------------------------------------|----|---|
|RF-001| O sistema deve permitir que o usuário se cadastre |  Create.cshtml; PerfilUsuariosController.cs; PerfilUsuario.cs | [Cadastro de Usuário](https://sitereceitasadse2.azurewebsites.net/PerfilUsuarios/Create)  |  
|RF-002| O sistema deve permitir que o usuário cadastre novas receitas com o nome dessas receitas e seus respectivos ingredientes e modos de preparo |  Receitas/Create.cshtml; Receita.cs; ReceitasController.cs   | [Cadastro de Receita](https://sitereceitasadse2.azurewebsites.net/Receitas/Create)  |  
|RF-003| O sistema deve permitir que usuários adicionem avaliações às receitas por meio de notas que variam de um número à outro (ex: 0 à 5) |  Avaliacoes/Create.cshtml; Avalicao.cs AvaliacoesController.cs; ReceitasController.cs; Receitas/Create.cshtml | [Cadastro de Avaliações](https://sitereceitasadse2.azurewebsites.net/Avaliacoes/Create)  |  
|RF-004| O sistema deve permitir que o usuário cadastre novos ingredientes | IngredientesController.cs; Ingrediente.cs;  Ingredientes/Index.cshtml | [Ingredientes](https://sitereceitasadse2.azurewebsites.net/Ingredientes/Create)  |  
|RF-005| O sistema deve permitir que o usuário edite receitas já cadastradas | Receitas/Edit.cshtml; ReceitasController.cs; Receita.cs;  | [Edição Receitas](https://sitereceitasadse2.azurewebsites.net/Receitas)  |  
|RF-006| O sistema deve permitir que o usuário edite seus dados | PerfilUsuarios/Edit.cshtml; PerfilUsuario.cs; PerfilUsuariosController.cs | [Edição de Usuário](https://sitereceitasadse2.azurewebsites.net/PerfilUsuarios)  |  
|RF-007| O sistema deve permitir que o usuário desfaça sua avalição |  AvaliacaoController.cs; Avaliacoes/Delete.cshtml; Avaliacao.cs  | [Deletar Avaliação](https://sitereceitasadse2.azurewebsites.net/Avaliacoes)  |  
|RF-008| O sistema deve permitir que o usuário exclua seu perfil |  PerfilUsuario/Delete.cshtml; PerfilUsuariosController.cs; PerfilUsuario.cs | [Deletar de Usuário](https://sitereceitasadse2.azurewebsites.net/PerfilUsuarios)  |  
|RF-009| O sistema deve permitir que o usuário edite ingredientes já cadastrados |  Ingredientes/Edit.cshtml; IngredientesController.cs; Ingrediente.cs;   | [Editar Ingredientes](https://sitereceitasadse2.azurewebsites.net/Ingredientes)  |  
|RF-010| O sistema deve permitir que usuário exclua ingredientes |  IngredientesController.cs; Ingrediente.cs; Ingredientes/Delete.cshtml | [Deletar Ingredientes](https://sitereceitasadse2.azurewebsites.net/Ingredientes)  |  
|RF-011| O sistema deve permitir que usuário modifique a avaliação que ele fez anteriormente sobre determinada receita |  Avalicaoes/Edit.cshtml;  AvaliacaoController.cs; Avaliacao.cs | [Editar Avaliação](https://sitereceitasadse2.azurewebsites.net/Avaliacoes)  |  


# Instruções de acesso

[Site de Receitas](https://sitereceitasadse2.azurewebsites.net/)  |  

É possível criar um usuários de teste. Já está disponível o usuário: teste@user.com pw: 123

---
<!--
> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
->
