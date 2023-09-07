## Solução

Essa solução trata a exceção ou cenário onde há mais do que um elemento igual à moda.

A solução em si é basicamente a mesma abordagem tratada na solução 01. A diferença é vista no momento onde percorremos o dicionário a fim de encontrar o valor que corresponde à moda. Na primeira solução, era um inteiro. Agora, trata-se de uma lista de inteiros. Para isso, fiz uso de uma lista e seus métodos Add e clear.

No segundo loop, ao verificar se o valor correspondente ao par chave valor é maior do que a contagem, faço a chamada de moda.Clear() para remover todos os elementos contidos na lista Moda, pois caso contrário, o novo valor seria simplesmente adicionado à lista, resultando em uma lista de valores de moda incorretos. Além disso, há uma segunda condição, verificando se o valor do par chave-valor é numéricamente igual à contagem. Se sim, adiciona-o à lista.

## Complexidade

Tempo: O(n), sendo n o tamanho do vetor de entrada, ou o vetor de números cuja moda desejo obter.

Memória: O(k), sendo k o número de elementos distintos no vetor, sendo que o pior caso é um vetor com elementos distintos, sendo k<=n.
