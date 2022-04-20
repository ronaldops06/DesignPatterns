# Patters de criação
## Singleton
Seu objetivo é permitir uma única instanciação de objeto, reduzindo assim, a utilização de memória.
Define uma operação responsável por garantir o acesso a uma única instância.
Responsável por criar e manter sua própria instância única.

## Factory Method
É conhecido como construtor virtual. Tem como premissa a criação de uma fábrica de objetos em tempo de execução e deixar com que o objeto principal decida o tipo.
O Factory Method dispõe uma interface que irá criar um objeto, mas são as subclasses que irão descidir qual classe concreta instanciar.
Abstrações não devem depender de detalhes, detalhes são quem devem depender de abstrações.
Tenho objetos de vários tipos que podem ser instanciados, então não posso antecipar qual é o tipo de objeto.
Preciso delegar a responsabilidade para que as subclasses especifiquem os objetos que precisam ser criados.

## Abstract Factory
Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.
### Classes e objetos que participam desse padrão:
- AbstractFactory:
Declara uma interface para operações que criam produtos abstratos.
- ConcreteFactory:
Implementa as operações para criar objetos de produtos concretos.
- AbstractProdut:
Declara uma interface para um tipo de objeto de produto.
- Produto:
Usa interfaces declaradas pelas classes AbstractFactory e AbstractProduct.

## Builder
Separa a construção de um objeto complexo de sua representação para que o mesmo processo de construção possa criar diferentes representações.
### Classes e objetos que participam desse padrão:
- Construtor:
Especifica uma interface abstrata para criar partes de um objeto produto.
- ConcrecteBuilder:
Constrói e monta partes do produto implementando a interface do Construtor; Define e acompanha a representação que cria; e, fornece uma interface para recuperar o produto.
- Diretor:
Constrói um objeto usando a interface do construtor.
- Produto:
Representa o objeto complexo em construção.

## Prototype
Especifique o tipo de objetos a criar usando uma instância prototípica e crie novos objetos copiando esse protótipo.
### Classes e objetos que participam desse padrão:
- Protótipo:
Declara uma interface para ser clonada.
- Protótipo de Concreto:
Implementa uma operação para ser clonada.
- Cliente:
Cria um novo objeto pedindo a um protótipo para ser clonado.
