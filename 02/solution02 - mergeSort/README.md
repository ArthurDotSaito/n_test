## Solução

Essa solução é uma implementação do algoritmo de divisão e conquista MergeSort. Da forma implementada, esse mergeSort funciona de forma recursiva, cuja condição base é o array de entrada possuir tamanho menor ou igual a 1. De forma geral, o mergeSort possui duas etapas distintas: A divisão e a fusão. Na divisão, dividimos a lista recursivamente em sublistas de tamanho unitário. Na fusão, mesclamos essas sublistas em listas maiores, ordenando-as durante o processo.

1 - Verificar tamanho do array. Se maior do que 1, tomar sua metade e a partir disso, criar dois arrays denominados 'left' e 'right', para armazenar os valores da metade mais à esquerda do meio e mais à direita.

2 - Copiar os elementos do array original de entrada para 'left' e 'right'.

3 - Chamada recursiva da função MergeSort até que o array em questão, repetindo os passos 1 e 2, criando outros sub-arrays chamados 'left' e 'right'. Isso ocorre até que ambos os subarrays possuam tamanho 1.

4 - Os loops while fazem a ordenação do array/subarray através das estruturas de comparação e dos índices i,j,k onde i será o indice do array/subarray left, j será o indice do array/subarray
right e k será o índice/subíndice do array de entrada em questão.

5 - Repetir desde o passo 1, até que o array esteja ordenado.

**Problemas**
1 - É um algoritmo que requer memória adicional para armazenar todas as sublistas criadas durante sua execução.

## Complexidade

Tempo: O(N x logN), sendo bem consistente para qualquer tamanho de entrada n.

Memória: O(n) para um tamanho de entrada n, sendo necessário armazenar os n elementos do array de entrada.
