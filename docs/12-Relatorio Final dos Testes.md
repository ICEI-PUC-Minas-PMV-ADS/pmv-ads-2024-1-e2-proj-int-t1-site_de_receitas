# Relatório Final dos Testes

## 1.Problema e Proposta de Solução
### 1.1.Problema
Contextualização:
Muitas pessoas enfrentam dificuldades em diversificar e preparar refeições diárias, especialmente aquelas com dietas restritas por motivos de saúde ou escolhas alimentares. A falta de conhecimento e de uma plataforma integrada para acesso a receitas diversificadas e práticas afeta tanto amadores quanto profissionais da culinária.
Impacto:
Esse problema resulta em alimentação monótona e inadequada, aumento do desperdício de alimentos e limitações para profissionais em oferecer serviços de qualidade e inovar.

### 1.2.Proposta de Solução
Solução Proposta:
Desenvolvimento de um site de receitas que oferece uma plataforma integrada para compartilhar e encontrar receitas de forma eficiente. Este site será uma ferramenta útil para amadores e profissionais da culinária.

Funcionalidades Chave:
- Busca por Receitas: Permite encontrar receitas com base em ingredientes, tipos de dieta e outros critérios.
- Sistema de Avaliação: Usuários podem avaliar receitas.
- Contribuição de Usuários: Espaço para submissão de receitas próprias.

Objetivos:
- Educação Alimentar: Promover conhecimento e experimentação na cozinha.
- Comodidade: Facilitar o acesso a receitas práticas.
- Troca de Informações: Criar uma comunidade ativa para compartilhamento de receitas e dicas.
- Redução do Desperdício: Educar sobre o aproveitamento integral dos alimentos.

## 2.Objetivos foram alcançados?
### 2.1.Objetivos Gerais
Descrição:
Os objetivos específicos do projeto incluem:
- Permitir o cadastro de usuários.
- Facilitar o cadastro de novas receitas com ingredientes e modo de preparo.
- Permitir avaliações detalhadas das receitas pelos usuários.
- Possibilitar o cadastro e gerenciamento de ingredientes.
- Implementar funcionalidade para edição de receitas cadastradas.
- Permitir aos usuários editar seus próprios dados de perfil.
- Oferecer a opção de desfazer avaliações de receitas.
- Permitir aos usuários excluir seus perfis.
- Implementar funcionalidade para edição de ingredientes cadastrados.

Avaliação:
|ID    | Status  | Detalhes | 
|------|-----------------------------------------|----|
|Cadastro de Usuários (RF-001)| Alcançado |  Os usuários podem se cadastrar na plataforma de maneira eficiente, permitindo acesso às funcionalidades principais.|  
|Cadastro de Receitas (RF-002)| Parcialmente Alcançado |  Houve relatos de falhas na funcionalidade de cadastro de receitas, especificamente no controller.| 
|Avaliações de Receitas (RF-003)| Parcialmente Alcançado |  Problemas foram identificados na gravação das avaliações, incluindo exibição incorreta de informações (como o modo de preparo no lugar do nome da receita).| 
|Cadastro de Ingredientes (RF-004)| Alcançado |   Os usuários podem cadastrar novos ingredientes conforme necessário, permitindo a personalização das receitas.| 
|Edição de Receitas (RF-005)| Parcialmente Alcançado |    Houve relatos de falhas na funcionalidade de edição de receitas, especificamente relacionadas ao controller.| 
|Edição de Usuário (RF-006)| Parcialmente Alcançado |    Os usuários enfrentaram problemas de acesso ao tentar editar seus próprios dados.| 
|Desfazer Avaliação de Receita (RF-007)| Parcialmente Alcançado |     Houve impedimento nos testes devido a problemas identificados na funcionalidade de avaliação de receitas.|
|Exclusão de Perfil (RF-008) | Parcialmente Alcançado | Usuários enfrentaram dificuldades ao tentar excluir seus perfis devido a problemas de acesso. |
|Edição de Ingredientes (RF-009) | Alcançado | Os usuários podem editar ingredientes já cadastrados. |

## 3.Os requisitos acordados estão funcionando? Em que nível eles foram atendidos?
### 3.1.Requisitos funcionais
|ID    | Descrição  | Status  | 
|------|-----------------------------------------|------|
| RF-001 | O sistema deve permitir que o usuário se cadastre | Completamente funcional |
| RF-002 | O sistema deve permitir que o usuário cadastre novas receitas com o nome dessas receitas e seus respectivos ingredientes e modos de preparo | Parcialmente funcional |
| RF-003 | O sistema deve permitir que usuários adicionem avaliações às receitas por meio de notas que variam entre Ruim, Bom e Ótimo | Parcialmente funcional |
| RF-004 | O sistema deve permitir que o usuário cadastre novos ingredientes | Completamente funcional |
| RF-005 | O sistema deve permitir que o usuário edite receitas já cadastradas | Parcialmente funcional |
| RF-006 | O sistema deve permitir que o usuário edite seus dados | Parcialmente funcional |
| RF-007 | O sistema deve permitir que o usuário desfaça sua avalição | Parcialmente funcional |
| RF-008 | O sistema deve permitir que o usuário exclua seu perfil | Parcialmente funcional |
| RF-009 | O sistema deve permitir que o usuário edite ingredientes já cadastrados | Completamente funcional |
| RF-010 | O sistema deve permitir que usuário exclua ingredientes | Completamente funcional |
| RF-011 | O sistema deve permitir que usuário modifique a avaliação feitas sobre determinada receita | Parcialmente funcional |

### 3.2.Requisitos não funcionais
|ID    | Descrição  | Status|
|------|-----------------------------------------|------|
| RNF-001 | O sistema não deve expor dados sensíveis do usuário | Completamente funcional |
| RNF-002 | O sistema deve ser desenvolvido utilizando a arquitetura MVC | Completamente funcional |
| RNF-003 | O sistema deve ser desenvolvido utilizando o framework ASP.NET Core MVC | Completamente funcional |
| RNF-004 | O sistema deve ser capaz de lidar com vários usuários simultâneos sem sofrer degradações significativas no desempenho | Parcialmente funcional |
| RNF-005 | O sistema deve suportar múltiplos usuários simultaneamente | Completamente funcional |
| RNF-006 | O sistema não deve ter tempo médio de resposta superior a 5s | Completamente funcional |
| RNF-007 | O sistema deve ser desenvolvido utilizando práticas recomendadas de clean code | Parcialmente funcional |
| RNF-008 | O sistema deve ser executado nos navegadores Google Chrome, Opera e Edge | Completamente funcional |
| RNF-009 | O sistema deve continuar funcionando apresentando conteúdo já carregado em caso de queda de conexão ou instabilidade no banco de dados | Parcialmente funcional |
| RNF-010 | O sistema deve ser responsivo. | Parcialmente funcional |
| RNF-011 | O sistema deve ser acessível pela internet. | Completamente funcional |
| RNF-012 | O sistema deverá informar ao usuário quando o mesmo estiver em manutenção e/ou fora do ar. | Não Atendido |
| RNF-013 | sistema deverá ter uma fácil usabilidade para o usuário. | Não Atendido |

## Quais os requisitos que não foram atendidos (sugestão de melhoria)



