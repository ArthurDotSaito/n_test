## Solução

Pensando no conceito de pilhas, onde aplica-se o conceito de LIFO - Last in, First Out, remover um elemento que não seja o último a ser adicionado é uma operação que requer um método não nativo, em qualquer linguagem de programação. Existem algumas formas de fazer isso, a solução 01 apresenta uma forma de fazer utilizando um conceito de pilha auxiliar.

Da forma com que o algoritmo foi escrito (E devido ao enunciado não explicitar qual o tipo de dado com que estamos trabalhando) a pilha implementada aceita qualquer tipo primitivo, mas o trata como um simples objeto.

O método para remover um elemento qualquer da pilha faz uso de uma pilha auxiliar (De forma semelhante à um buble sort, onde precisamos de um array auxiliar ou temporário) que é usado para armazenar temporariamente os valores que não devem ser removidos. No primeiro loop, a estrutura de controle condicional faz essa comparação entre o valor atual e aquele que deve ser removido e, caso não sejam iguais, empilha o elemento atual na pilha auxiliar, o que mantém os elementos na ordem original, com exceção do valor a ser removido. O valor a ser removido é basicamente "ignorado", pois ele é removido da pilha original, e não é alocado na pilha auxiliar.

Nesse momento, a pilha original está vazia e a auxiliar, preenchida com os elementos que não foram removidos.

No segundo loop, a função desempilha os elementos da pilha auxiliar de volta à pilha original, restaurando a ordem original dos elementos.
