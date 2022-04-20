# Patters Estruturais
Se preocupam com a forma com a classe e o objetos são compostos para formarem etruturas maiores.
Os de classe usam herança para compor interface ou implementações, já os objetos descrevem maneiras de compor o objeto para obter novas funcionalidades.
A flexibilidade obtida pela composição de objetos provém da capacidade de mudar a composição em tempo de execução o que não é possível com a composição estática(herança de classes).

## Adapter
Este é um padrão particularmente útil para fazer bibliotecas de classes desenvolvidas independentemente trabalharem juntas.
Cria uma classe que faça uma adaptação.
Faz com que uma interface adaptada seja compatível com outra.
Pode ser Adapter de classe ou Adapter de objeto.

### Classes e objetos que participam desse padrão:
- Alvo:
  - Define a interface específica do domínio que o cliente usa.
- Adaptador:
  - Adapta a interface Adaptee à interface Target.
- Adaptee:
  - Define uma interface existente que precisa ser adaptada.
- Cliente:
  - Colabora com objetos em conformidade com a interface de destino.

## Bridge
Permite fornecer um substituto ou espaço reservado para outro objeto. Um proxy controla o acesso ao objeto original, permitindo que seja executado algo antes ou depois que a solicitação chega ao objeto original.
### Classes e objetos que participam desse padrão:
- Abstração:
  - É uma interface que define uma referência a um objeto do tipo Implementor.
- RefinadoAbstração:
  - Estende a interface definida pelo Abstraction.
- Implementor:
  - Define a interface para classes de implementação. Essa interface não precisa corresponder exatamente à interface do Abstraction, podendo ser totalmente diferentes. Normalmente, a interface de implementação fornece apenas operações primitivas, e a Abstraction define operações de nível superior com base nessas primitivas.
- ConcreteImplementor:
  - Implementa a interface do Implementor e define sua implement concreta.

## Composite
Permite compor objetos em estruturas de árvore para representar hierarquias de partes inteiras. Permiter que os clientes tratem objetos individuais e composições de objetos de maneira uniforme.
### Classes e objetos que participam desse padrão:
- Componente: Declara a interface para ojbetos na composição.
  - Implementa o comportamento padrão para a interface comum a todas as classes.
  - Declara uma interface para acessar e gerenciar seus componentes filhos.
- Folha: Representa objetos folha na composição. Uma folha não tem filhos.
  - Define o comportamento de objetos primitivos na composição.
- Composto: Define o comportamento de componentes tendo filhos.
  - Armazenda componentes filhos.
  - Implementa operações relacionadas a filhos na interface Component.
- Cliente:
  - Manipula objetos na composição por meio da interface Component.
	
## Decorator
Permite anexar responsabilidades adicionais a um objeto dinamicamente. Os decoradores fornecem uma alternativa flexível à subclasse para estender a funcionalidade.
### Classes e objetos que participam desse padrão:
- Componente:
  - Define a interface para objetos que podem ter responsabilidades adicionais a eles dinamicamente.
- ConcreteComponent:
  - Define um objeto ao qual responsabilidades adicionais podem ser anexadas.
- Decorador:
  - Mantém uma referência a um objeto Componente e define uma interface que está em conformidade com a interface do Componente.
- ConcreteDecorator:
  - Adiciona responsabilidades ao componente.
	
## Facade
Fornecer uma interface unificada para um conjunto de interfaces em um subsistema.
### Classes e objetos que participam desse padrão:
- Facade: 
  - Sabe quais classes do subsistema são responsáveis por uma solicitação.
  - Delega solicitações de clientes a objetos apropriados do subsistema.
- Classes do subsistema:
  - Implementar a funcionalidade do subsistema.
  - Manipular o trabalho atribuído pelo objeto facade.

## Flyweight
Um dos requisitos não-funcionais de grande importância é a performance (sistemas rápidos e com pouco consumo de memória).
Um bom caminho é reduzir objetos criados, já que o processo de instanciação pode ser relativamente custoso, pois o processo de construção também envolve gerenciamento de memória, ponteiros e contagens de referência.
O objetivo deste padrão é melhorar o desempenho de um procedimento compartilhando objetos com características parecidas.
O padrão provê parâmetros para serem aplicados em objetos já existentes, modificando suas propriedades conforme solicitado, ao invés da necessidade de sempre instanciá-los.
### Características de um objeto flyweight
- Intrínsecas:
  - Propriedades imutáveis, ou seja, que caracterizam o objeto compartilhado.
- Extrínsecas:
  - Propriedades variáveis que podem receber novos valores a cada acesso.

## Proxy
Fornece um substituto ou espaço reservado para outro objeto para controlar o acesso a ele.
### Classes e objetos que participam desse padrão:
- Proxy:
  - Mantém uma referência que permite ao proxy acessar o assunto real. Proxy pode se referir a um Assunto se as interfaces RealSubject e Subject forem as mesmas.
  - Fornece uma interface idêntica à do subject para que um proxy possa ser substituído pelo sujeito real.
  - Controla o acesso ao assunto real e pode ser responsável por criar e excluí-lo.
  - Responsabilidades que dependem do tipo de proxy:
  	- Proxies remotos: são responsáveis por codificar uma solicitação e seus argumentos e por enviar a solicitação codificada para o assunto real em um espaço de endereço diferente.
  	- Proxies virtuais: podem armazenar em cache informações adicionais sobre o assunto real, para que possam adiar o acesso a ele. Por exemplo, o ImageProxy da Motivation armazena a extenção das imagens reais.
  	- Proxies de proteção: verificam se o chamador tem as permissões de acesso necessárias para executar uma solicitação.
- Assunto:
  - Define a interface comum para RealSubject e Proxy para que um Proxy possa ser usado em qualquer lugar em que um RealSubject é esperado.
- RealSubject:
  - Define o objeto real que o proxy representa.
