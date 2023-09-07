## Solução

Essa solução foi pensada de forma a implementar princípios OO. O diagrama de classes básico do problema está representado na figura abaixo:

![UML](/03/solution01/assets/UML.png)

A classe abstrata GeometricFigure implementa as assinaturas dos métodos e propriedades necessárias nas classes derivadas. Todas as classes derivadas herdam essas propriedades e métodos, assim a herança é implemetada com ":GeometricFigure", entretanto podem adicionar ou substituir propriedades e métodos para atender funcionalidades específicas de cada figura.

Em cada classe de figura especifica, além de herdar as características da super classe, encapsulamos os atributos especificos que fazem sentido apenas para as figuras geometricas individuais (lado, raio) através do modificador de acesso privado. Além disso, cada figura possui seu próprio construtor e método para cálculo de área, que serão subsequentementes usados no método principal - Main.

Através da assinatura declarada na super classe, fazendo uso do método abstrato, possibilitamos que cada figura molde a ação de calcular área de acordo com sua caracteristíca especifica. Isso é possível devido à herança relativa à superclasse. Por fim, no método principal, fazemos a chamada polimórfica para cada figura.

O método principal implementa uma coleção do tipo Dicionário, instanciando cada uma das figuras com os valores especificos de seus atributos e armazendo-os como valores às chaves correspondentes - que podem ser nomeadas de qualquer forma. No loop, apenas retornamos o tipo e área de cada uma das figuras, acessando essas propriedades armazenadas como valores.
