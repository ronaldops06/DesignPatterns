# Patters Comportamentais
Os padrões de compostamento se concentram nos algoritmos e atribuições de responsabilidade entre os objetos.
Eles não descrevem apenas padrões de objetos ou de classes, mas também os padrões de comunicação entre os objetos.
Os padrões comportamentais de classes utilizam a herança para distribuir o comportamento entre classes, e os padrões de comportamento de objeto utilizam a composição de objetos em contrapartida a herança.
Alguns descrevem como grupos de objetos cooperam para a execução de uma tarefa que não poderia ser executada por um objeto sozinho.

## Chain Of Responsibility
Evita acoplar o rementente de uma solicitação ao seu receptor, dando a mais de um objeto a chance de manipular a solicitação. Encadeie os objetos de recebimento e passe a solicitação ao longo da cadeia até que um objeto a manipule.
### Classes e objetos que participam desse padrão:
- Manipulador:
	- Define uma interface para manipular as solicitações.
	- (Opcional) implementa o link sucessor.
- ConcreteHandler:
	- Lida com pedidos que é responsável por algo.
	- Pode acessar seu sucessor.
	- Se o ConcreteHandler puder manipular o pedido, ele faz isso; caso contrário, encaminha a solicitação ao seu sucessor.
- Cliente:
	- Inicia a solicitação para um objeto ConcreteHandler na cadeia.
	
## Command
Encapsula uma solicitação como um objeto, permitindo assim que você faça a parametrização de clientes com diferentes solicitações, enfileire ou registre solicitações, e dê suporte a operações que podem ser desfeitas.
### Classes e objetos que participam desse padrão:
- Command:
	- Declara uma interface para executar uma operação.
- ConcreteCommand
	- Define uma ligação entre um objeto Receiver e uma ação.
	- Implementa Execute invocado a(s) operação (ões) correspondente (s) no receptor.
- Client:
	- Cria um objeto ConcreteCommand e define seu receptor.
- Invoker:
	- Pede o comando para realizar o pedido.
- Receptor:
	- Sabe como executar as operações associadas a execução da solicitação.

## Interpreter
Uma maneira de incluir elementos de linguagem em um programa.
Dada uma linguagem, defina uma representação para sua gramática junto com um intérprete que use a representação para interpretar sentenças na linguagem.
### Classes e objetos que participam desse padrão:
- AbstractExpression:
	- Declara uma interface para executar uma operação.
- Terminal Expression:
	- Implementa uma operação Interpret associada a símbolos de terminal na gramática.
	- Uma instância é necessária para cada símbolo de terminal na sentença.
- Expressão:
	- Uma dessas classes é requerida para cada regra R::=R1R2...Rn na gramática;
	- Mantém váriáveis de instância do tipo AbstractExpression para cada um dos símbolos R1 e Rn.
	- Implementa uma operação Interpret para símbolos não###terminais na gramática. Interpret geralmente chama###se recursivamente nas vairáveis que representam R1 a Rn.
- Contexo:
	- Contém informações que são globais para o intérprete.
- Cliente:
	- Constrói (ou recebe) uma árvore de sintaxe abstrata representando uma frase específica na linguagem que a gramática define. A árvore abstrata é montada a partir de instâncias das classes NoTerminalExpression e TerminalExpression.
	- Invoca a operação Interpret.
	
## Iterator
Fornece uma maneira de acessar os elementos de um objeto agregado sequencialmente sem expor sua representação subjacente.
### Classes e objetos que participam desse padrão:
- Iterator:
	- Define uma interface para acessar e percorrer elementos.
- ConcreteIterator:
	- Implementa a interface do Iterador.
	- Mantém o controle da posição atual na travessia do agregado.
- Agregado:
	- Define uma interface para criar um objeto iterador.
- ConcreteAggregate:
	- Implementa a interface de criação do Iterador para retornar uma instância do ConcreteIterador adequado.

## Mediator
Define comunicação simplificada entre classes.
Defina um objeto que encapsule como um conjunto de objetos interage. O mediador promove um acoplamento flexível impedindo que os objetos se refiram explicitamente e permite que você varie sua interação de forma independente.
### Classes e objetos que participam desse padrão:
- Mediador:
	- Define uma interface para comunicação com objetos Colleague.
ConcreteMediator:
	- Implementa o comportamento cooperativo ao coordenador dos objetos do Colleague.
	- Conhece e mantém seus Colleagues.
- Classes de Colleague.
	- Cada classe de Colleague conhece seu objeto Mediator.
	- Cada Colleague comunica com o sue Mediator sempre que, de outra forma, teria comunicado com outro Colleague.

## Memento
Sem violar o encapsulamento, capture e externalise o estado interno de um objeto para que o objeto possa ser restaurado posteriormente para este estado.
### Classes e objetos que participam desse padrão:
- Memento:
	- Armazena o estado interno do objeto Originador. A Memento pode armazenar tanto ou tão pouco do estado interno do originador quanto necessário, a critério do autor.
	- Proteger contra o acesso por objetos que não sejam o originador. Mementos têm efetivamente duas interfaces. Zelador vê uma interface ampla, que permite acessar todos os dados necessários para se restaurar o estado anterior. Idealmente, apenas o originador que produz o Memento teria permissão para acessar o estado interno do Memento.
- Originador:
	- Cria um Memento contendo um instantâneo de seu estado interno atual.
	- Usa o Memento para restaurar seu estado interno.
- Zelador:
	- É responsável pela guarda do Memento.
	- Nunca opera ou examina o conteúdo de um Memento.
	
## Observer
Defina uma dependência um###para###muitos entre objetos para que, quanto um objeto mudar de estado, todos os seus dependentes sejam notificados e atualizados automaticamente.
### Classes e objetos que participam desse padrão:
- Subject:
	- Conhece seus observadores. Qualquer número de objetos observadores pode observar um Subject.
	- Fornece uma interface para anexar e desanexar objetos Observer.
- ConcreteSubject:
	- Armazena o estado de interesse do ConcreteObserver.
	- Envia uma notificação a seus observadores quando seu estado muda.
- Observador:
	- Define uma interface de atualização para objetos que devem ser notificados de alterações em um Subject.
- ConcreteObserver:
	- Mantém uma referência a um objeto ConcreteSubject.
	- Implementa a interface de atualização do Observer para manter seu estado cosistente com o Subject.

## State
Altera o comportamento de um objeto quando seu estado se altera.
Permite que um objeto altere seu comportamento quando seu estado interno é alterado. O objeto aparecerá para mudar sua classe.
### Classes e objetos que participam desse padrão:
- Context:
	- Define a interface de interesse para os clientes.
	- Mantém uma instância de uma subclasse ConcreteState que define o estado atual.
- State:
	- Define uma interface para encapsular o comportamento associado a um estado particular do contexto.
- ConcreteState:
	- Cada subclasse implementa um comportamento associado a um estado de Contexto.

## Strategy
Define uma família de algoritmos, encapsule cada um deles e torne###os intercambiáveis. O Strategy permite que o algoritmo varie indepentemente dos clientes que o usam.
### Classes e objetos que participam desse padrão:
- Stratagy:
	- Declara uma interface comum a todos os algoritmos suportados. Contexto usa interface para chamar o algoritmo definido por um ConcreteStrategy.
- ConcreteStrategy:
	- Implementa o algoritmo usando a interface Strategy.
- Contexto:
	- Está configurado com um objeto ConcreteStrategy.
	- Mantém uma referência a um objeto Strategy.
	- Pode definir uma interface que permite a Strategy acessar seus dados.

## Template Method
Adia as etapas exatas de um algoritmo para uma subclasse.
Define o esqueleto de um algoritmo em uma operação, adiando algumas etapas para subclasses. Template Method permite que as subclasses redefinam certas etapas de um algoritmo sem alterar a estrutura do algoritmo.
### Classes e objetos que participam desse padrão:
- AbstractClass:
	- Define operações primitivas abstratas que subclasses concretas definem para implementar etapas de um algoritmo.
	- Implementa um método de modelo que define o esqueleto de um algoritmo. o método de modelo chama operações primitivas, bem como operações definidas no AbstractClass ou de outros objetos.
- ConcreteClass:
	- Implementa as operações primitivas de executar etapas específicas da subclasse de algoritmo.

## Visitor
Define uma nova operação para uma classe sem alteração.
Representa uma operação a ser executada nos elementos de uma estrutura de objetos. Visitor permite definir uma nova operação se alterar as classes dos elementos em que ela opera.
### Classes e objetos que participam desse padrão:
- Visitor:
	- Declara uma operação Visit para cada classe de ConcreteElement na estrutura do objeto. O nome e a assinatura da operação identificam a classe que envia a solicitação de visita ao visitante. Em seguida, o Visitor pode acessar os elementos diretamente por meio de sua interface específica.
- ConcreteVisitor:
	- Implementa cada operação declarada pelo Visitor. Cada operação implementa um fragmento do algoritmo definido para a classe ou objeto correspondente na estrutura. O ConcreteVisitor fornece o contexto para o algoritmo e armazenda seu estado local. Esse estado geralmente acumula resultados durante a travessia da estrutura.
- Element:
	- Define uma operação Accept que aceita um Visitor como um argumento.
- ConcreteElement:
	- Implementa uma operação de aceitação que leva um visitante como um argumento.
- ObjectStructure:
	- Pode aumentar seus elementos.
	- Pode fornecer uma interface do alto nível para permitir que o Visitor visite seus elementos.
	- Pode ser um Composite(padrão) ou uma coleção, como uma lista ou um conjunto.
	
# Injeção de dependência
## Injeção de dependência
Implementa o padrão Inversão de controle.
Devemos utilizar esse padrão quanto temos a necessidade de desenvolver sistemas em que o nível de acoplamento entre seus diferentes módulos precisem ser extremamente baixos.
Oferecer reusabilidade de componentes, uma vez que criamos componentes interdependentes, eles podem ser facilmente implmentados em sistemas diversos.
Facilita a manutenção de Sistemas, fazendo com que as manutenções em módulos não afetem o restante do sistema.
Cria códigos altamente "testáveis". Uma vez que temos códigos implementados seguindo esse Pattern, podemos testá###los mais facilmente utilizando os "mock tests".
Criar códigos mais legíveis, o que torna mais fácil a compreensão do sistema como um todo.
### Aonde é possível implementar:
- Construtor
- Gerrer and Setter
- Interface Implementation
- ServiceLocator