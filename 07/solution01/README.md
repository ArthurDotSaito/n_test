## Solução

Essa solução parte um pouco dos princípios de operações de convolução de matrizes. Em geral, quando falamos de redes neurais de convolução para reconhecimento de imagens, um único passe de convolução envolve três coisas:

1 - Um volume de entrada (Nesse caso, a imagem ou matriz original de zero e um);

2 - Aplicar um 'filtro' em cada posição do volume de entrada, onde esse filtro realiza operações de multipilicação elemento à elemento e soma todos eles;

3 - O resultado é uma unidade de convolução (Que também é uma matriz);

Para o problema em questão, estamos interessados no passe 1 e em 'metade' do passe 2(de forma adaptada), pois aqui só queremos aplicar o filtro e vericar a existencia ou não do padrão do filtro, comparando elemento à elemento. Na solução apresentada, iteramos sobre a matriz de entrada, respeitando os limites das dimensões de ambas as matrizes. Internamente, a chamada ao método 'VerificaPadrao' é o responsável por efetivamente retornar o resultado da comparação.

**Terminologias para o contexto do problema:**

- Matriz de entrada == 'Matriz A ou matriz grande onde queremos verificar o padrão'.
- Matriz padrão == 'Matriz B ou matriz pequena, cujo padrão queremos verificar existencia'.

**Funcionamento do método VerificaPadrao**: A ideia é: Dado x e y, sendo x e y coordenadas da matriz de entrada e posição inicial por onde essa comparação será iniciada, vamos comparar elemento à elemento a partir de x e y. Se em algum momento dentro da iteração, um elemento da matriz de entrada for diferente da matriz padrão, significa que a região da matriz de entrada não corresponde à matriz padrão. Portanto, essa região não é um padrão. Fazemos isso (N - n*) x (M -m) vezes, onde *M* é o número de linhas da matriz de entrada, *m* é o número da matriz padrão, *N* é o número de colunas da matriz de entrada, e *n* é o número de colunas da matriz padrão.*
