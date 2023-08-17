Clean Architecture
=================

# Introdução
Projeto de estudo sobre Clean Architecture com .NET Core 5.0. Criando uma loja virtual com as entidades produtos e categoria.
A Clean Architecture refere-se à organização do projeto de forma que seja fácil de entender e fácil de mudar conforme o projeto cresce.
E o segredo de construir um projeto/sistema de grandes dimensões é:
- separar os arquivos ou classes em componentes que podem mudar independentemente de outros componentes.
De maneira mais simplista podemos mostrar o sistema como 2 camadas uma de infraestrutura e outra de dominio.

![alt text](https://www.macoratti.net/20/10/aspnc_arqclean11.png)

A camada de dominio tem toda a nossa regra de negócio, já a de infraestrutura pode contem Interface do usuário, acesso a banco de dados e outras funções. Essa separação é porque o dominio tem menor probabilidade de ter alteração. Já a infraestrutura passa por alterações por diversos motivos.

# Camadas
Na imagem a abaixo vamos descrever melhor as camadas. Dividimos a camada de dominio em Entites e Use Cases
![alt text](https://www.macoratti.net/20/10/aspnc_arqclean12.jpg)

## Entities
Representam um conjunto de regras de negócio relacionadas que são críticas para que a aplicação funcione corretamente para o seu propósito.

O que é importante destacar aqui é que as entidades não conhecem nada sobre as demais camadas. Elas não possuem nenhuma dependência, ou seja, elas não usam os nomes de nenhuma outra classe ou componente que estejam nas camadas externas.
## Use cases
Os casos de uso são as regras de negócios para um aplicativo específico. Eles dizem como automatizar o sistema e isso determina o comportamento do aplicativo.

Os casos de uso interagem e dependem das entidades, mas não sabem nada sobre as camadas mais distantes. Eles não se importam se é uma página web ou um aplicativo para Celular. Eles não se importam se os dados estão armazenados na nuvem ou em um banco de dados SQL Server ou SQLite local.

Essa camada define interfaces ou possuem classes abstratas que as camadas externas podem usar.

## Adapters
Os adaptadores, também chamados de adaptadores de interface, são os tradutores entre o domínio e a infraestrutura. Eles pegam dados de entrada da Interface com o usuário - UI, e os ajustam em um formato que seja conveniente para os casos de uso e entidades.

Em seguida, eles pegam a saída dos casos de uso e entidades e a ajustam em um formato que seja conveniente para exibir na interface com o usuário ou salvar em um banco de dados.

## Infrastructure
Essa camada é para onde vão todos os componentes de  entrada e saída ou I/O, a interface com o usuário - IU, o banco de dados, os frameworks, os dispositivos, etc.

É a camada mais volátil visto que as coisas nesta camada podem mudar, e, por isso, elas são mantidas o mais longe possível das camadas de domínio mais estáveis.

Como eles são mantidos separados, é relativamente fácil fazer alterações ou trocar um componente por outro.

# SOLID
Vamos iniciar com os princípios SOLID que são princípios de nível de classe, mas têm contrapartes semelhantes que se aplicam a componentes (grupos de classes relacionadas).

- The Single Responsibility Principle

  Principio da Responsabilidade Única, ou seja, uma classe deve ter um, e somente um, motivo para mudar;
 
- The Open Closed Principle

  Princípio Aberto-Fechado, você deve ser capaz de estender um comportamento de uma classe, sem ter que modificá-la;
 
- The Liskov Substitution Principle

  Princípio da Substituição de Liskov, as classes derivadas devem poder substituir suas classes bases;
 
- The Interface Segregation Principle

  Princípio da Segregação da Interface, muitas interfaces específicas são melhores do que uma interface geral;
 
- The Dependency Inversion Principle

  Princípio da inversão da dependência, Dependa de uma abstração e não de uma implementação.
