## SOLUÇÃO

O exemplo trás um exemplo extremamente simples de relacionamento N:N entre pacientes e médicos, com a hipótese de que um paciente pode ser tratado por vários médicos, e um médico pode tratar vários pacientes. O básico de qualquer relacionamento N:N em SQL é possuir uma tabela 'intermediária' ou 'pivô', que contém as chaves estrangeiras de ambas as tabelas entidades que se relacionam.

É importante manter/criar índices em todas as informações chave que podem ser usadas para consulta. Além das chaves primárias, no exemplo, a ideia foi manter indices nos campos de nome, pensando que gostaríamos de fazer pesquisas através dos nomes e retornar algum tipo de informação e também nos campos de onde gostariamos de fazer operações de junção - JOINS. Nesse caso, utilizamos o tipo mais comum de índices, baseado em árvores balanceadas, pois **costuma** ser eficiente para quase qualquer caso de uso devido à sua complexidade de tempo de pior caso (em geral) O(logN) e por manter ordenaçao de dados.

**Exemplo de relacionamento:**

<div align='center'>

![exemplo](./assets/example.png)

</div>
