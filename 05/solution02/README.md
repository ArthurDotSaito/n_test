## Solução

Essa solução é similar à solução anterior, entretanto não faz uso de uma pilha auxiliar, e sim de uma chamada recursiva da função de remoção de elemento. Aqui, deve-se ter o cuidado de verificar o tamanho da pilha antes de efetuar qualquer operação, pois isso pode gerar uma chamada recursiva infinita.

De maneira similiar à solução01, verificamos se o elemento atual (do topo da pilha) é diferente do valor que queremos remover. Se for diferente, a função de remoção é recursivamente chamada. Ao encontrar o elemento a ser removido, a função simplesmente se move para a próxima condicional, reempilhando os elementos novamente.
