## Solução

Essa solução baseia-se no uso de um Dicionário, que em C# é definida no namespace System.Collections.Generic.
Minha primeira ideia foi usar um hashTable, mas optei por um dicionário, devido à possibilidade de manter uma tipagem mais forte definida, haja vista que o enunciado explicitamente trata o problema apenas com números inteiros. Além disso, usar as propriedades definidas na classe dicionário (Count, Value, Key) facilitam a resolução do problema.

Assim, o primeiro loop é basicamente para preencher esse dicionário. Para cada elemento definido no vetor de números inteiros cuja moda eu desejo obter, o loop verifica se o número já existe como uma chave do dicionário. Se não existir, adiciono essa entrada como uma chave, passando o valor como 1. Se existir, simplesmente incremento o valor associado à chave. Fazendo uso desse tipo de estrutura, garanto unicidade de chaves, o que resume o problema a partir de agora, em encontrar o maior valor dentre os pares chave-valor do dicionário.

os segundo loop forEach retorna a moda. Itero sobre cada par chave-valor, comparando o valor, com o valor máximo da contagem encontrada até então (por padrão, definida como zero na primeira iteração). Se o valor, do par chave valor, for maior do que a contagem, então a moda é atualizada como sendo a chave correspondente à esse valor, e atualiza a contagem máxima (maxCount) para o valor correspondente à chave. Logo, ao final do loop, o elemento com maior número de repetições estará armazenado na variável moda e será retornado como saida da função.

**Problema**: Se existirem dois numeros com mesmo número de repetições, a função retorna apenas um deles, sendo esse valor aquele que primeiro foi alocado na memória da variável "moda". Esse problema pode ser resolvido de uma forma alternativa, explorada na solução 02.

## Complexidade

Tempo: O(n), sendo n o tamanho do vetor de entrada, ou o vetor de números cuja moda desejo obter.

Memória: O(k), sendo k o número de elementos distintos no vetor, sendo que o pior caso é um vetor com elementos distintos, sendo k<=n.
