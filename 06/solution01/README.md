## Solução

Essa solução de inversão de matriz se baseia um pouco na ideia do bubble sort, onde em certa parte, troca-se elementos adjacentes.

1. Na função de inversão, primeiro é necessário obter as dimensões da matriz, para que seja possivel iterar através de seus elementos. Assim, uma forma de fazer isso é obter essa dimensão através do GetLength, que recupera o tamanho especifico de uma matriz multidimensional (No caso, passamos o argumento '0' justamente porque queremos o tamanho da primeira dimensão).

2. Iteramos através do número de **linhas i** da matriz, e criamos uma matriz auxiliar apenas para armazenar temporariamente o valor da diagonal principal [i,i] (poderia ser a secundária, tanto faz).

3. Substituimos a diagonal principal pelo elemento correspondente na diagonal secundária, ou seja, o elemento a(0,0) recebe o elemento a(0,2), o elemento a(1,1) recebe o próprio a(1,1), e o elemento a(2,2) recebe a(2,0).

## Complexidade

1. Tempo: Exclusivamente da solução e método de inverter a matriz, a complexidade de tempo é O(n), sendo n o tamanho da matriz.
2. Espaço: Exclusivamente da solução e método de inverter a matriz, a complexidade de espaço é O(1) constante, pois sob o ponto de vista das variáveis locais e modifica diretamente a matriz de entrada e portanto, não há alocação extra de memória.

_OBS_ A complexidade de tempo e espaço de todo o código é O(n²). Ambas são dominadas pelo processo de criação e leitura de matrizes, que possuem O(n²) como complexidade, dada sua natureza de iterar sobre linhas e colunas/criar matrizes adicionais.

## Demais partes do código

**1. Criar Matriz:**
Cria uma matriz quadrada, com números randomicos entre 0 e 10, através da classe Random, utilizada dentro dos loops responsáveis por gerar os elementos da matriz. Um arquivo txt será criado ou sobrescrito através do FileStream. O StreamWritter em conjunto com o método Write ditam as dimensões da matriz (nxn, nesse caso), e serão a primeira linha do arquivo. É importante fechar os objetos FileStream e StreamWritter para que os dados efetivamente saiam do buffer temporário e sejam escritos no arquivo.

**2. Ler Matriz:**
Abre o arquivo e lê a dimensão e valores da matriz e retorna a matriz como resultado. Usamos o FileMode.Open para acessar o arquivo em modo de leitura. Usamos o ReadLine.spli(' ') para ler a primeira linha do arquivo e retorna um array de strings que representam a dimensão da matriz. Como a matriz é quadrada, precisamos de uma de suas dimensões para determinar seu tamanho, possibilitando a iteração através de seus elementos. No loop, dividimos a linha por elementos e os armazenamos em um array, de modo que podemos acessa-los individualmente. No loop aninhado, armazenamos os valores da linha e coluna correspondentes na variável result.

**3. Exibir Matriz:**
Simplesmente obter o tamanho ou dimensão da matriz e itera por todos os seus elementos, imprimindo os valores no console, separando os elemetos de uma mesma linha por espaços , e quebra linhas para representar uma nova linha.
