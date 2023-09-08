## Solução

Essa solução de inversão de matriz simplesmente cria outra matriz a partir da matriz de entrada, e alimenta sua diagonal principal com a diagonal secundária da matriz de entrada e a diagonal principal com a secundária da matriz de entrada.
A diferença é que a primeira solução realiza operações na própria matriz de entrada e a solução 02 cria uma nova matriz, realiza as operações entre as duas matrizes (A matriz criada e a matriz de entrada) e a retorna. São abordagens muito similares, mas evidentenmente a segunda solução gera uma complexidade de memória adicional. A utilidade disso é possivelmente preservar os dados da matriz original, além de ser uma abordagem um pouco mais intuitiva.

## Complexidade

1. Tempo: Exclusivamente da solução e método de inverter a matriz, a complexidade de tempo é O(n), sendo n o tamanho da matriz.
2. Espaço: Exclusivamente da solução e método de inverter a matriz, a complexidade de espaço é O(n²) , pois criamos uma nova matriz n x n e a retornamos.

_OBS_ A complexidade de tempo e espaço de todo o código é O(n²). Ambas são dominadas pelo processo de criação e leitura de matrizes, que possuem O(n²) como complexidade.

## Outras partes do código

**1. Criar Matriz:**
Cria uma matriz quadrada, com números randomicos entre 0 e 10, através da classe Random, utilizada dentro dos loops responsáveis por gerar os elementos da matriz. Um arquivo txt será criado ou sobrescrito através do FileStream. O StreamWritter em conjunto com o método Write ditam as dimensões da matriz (nxn, nesse caso), e serão a primeira linha do arquivo. É importante fechar os objetos FileStream e StreamWritter para que os dados efetivamente saiam do buffer temporário e sejam escritos no arquivo.

**2. Ler Matriz:**
Abre o arquivo e lê a dimensão e valores da matriz e retorna a matriz como resultado. Usamos o FileMode.Open para acessar o arquivo em modo de leitura. Usamos o ReadLine.spli(' ') para ler a primeira linha do arquivo e retorna um array de strings que representam a dimensão da matriz. Como a matriz é quadrada, precisamos de uma de suas dimensões para determinar seu tamanho, possibilitando a iteração através de seus elementos. No loop, dividimos a linha por elementos e os armazenamos em um array, de modo que podemos acessa-los individualmente. No loop aninhado, armazenamos os valores da linha e coluna correspondentes na variável result.

**3. Exibir Matriz:**
Simplesmente obter o tamanho ou dimensão da matriz e itera por todos os seus elementos, imprimindo os valores no console, separando os elemetos de uma mesma linha por espaços , e quebra linhas para representar uma nova linha.
