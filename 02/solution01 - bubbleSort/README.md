## Solução

Essa solução é provavelmente a mais básica quando trata-se de um problema de ordenação de arrays, em ordenação por troca. Seu funcionamento básico baseia-se na comparação de elementos adjacentes, ou seja, se dois elementos estão fora de ordem, troque-os e repita esse processo por todo o array, até que nenhum elemento precise ser trocado. Como funciona, em termos mais simples:

1 - Leia o array, da esquerda para a direita, a partir do elemento 0;
2 - Compare o atual elemento, com o próximo elemento. Se o atual for maior do que o próximo, significa que eles estão fora de ordem.
3 - Se os elementos estão fora de ordem, troque-os. O maior elemento passa a ser o "próximo elemento" e o menor passa a ser o "elemento atual".
4 - Repita esse processo até chegar ao final do array.
5 - Quando nenhuma troca pode ser feita, significa que o array está completamente ordenado.

**Problemas**
1 - É o algoritmo de ordenação ineficiente para conjuntos elevados de dados, dada sua complexidade de tempo.
2 - Da forma com que o algoritmo foi escrito, no melhor ou pior caso, a complexidade de tempo é a mesma. Portanto, não há nenhum beneficio em tratar conjuntos de dados pré-ordenados. Entretanto, é possivel "otimizar" para o melhor caso (onde tudo já está ordenado), simplesmente inserindo uma variável booleana no loop for mais "externo" e verificando se houve troca (Nesse caso, a complexidade de tempo para o melhor caso é O(n)).

## Complexidade

Tempo: O(n²), sendo n o tamanho do vetor de entrada, ou o vetor de números a serem ordenados.

Memória: O(1) constante, pois é um algoritmo de ordenação "in-place", ou seja, não requer memória adicional além do espaço ocupado pelo array original.
