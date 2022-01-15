# DesafioPubFuture

Caso o sistema de problema ao executar por causa do BD, é necessario abrir o projeto no Visual Studio, selecionar o Database.mdf com dois clicks no seguinte caminho:
..\DesafioPubFuture\DesafioPubFuture\View\AppData\Database.mdf

**HOME**
   - Dentro da tela de Home, são chamadas quase todas as telas do sistema, tendo como unica execeção a tela de Transferencia.

**Cadastros**
   - As telas de cadastro são de uso simples, sendo necessario que em ambas as telas, todos os campos sejam preenchidos para que se possa fazer inclusões e alterações.
Tendo ao se abrir as telas somente os botões 'Salvar' e 'Excluir' habilitados, ao selecionar um item para edição na tabela, o botão de 'Editar' é habilitado e o de 
'Salvar' é desabilitado. Para poder se excluir um item da lista é necessario antes selecionar o item na lista e pressionar o botão excluir, que apresentara um mensagem 
de confirmação, que caso seja confirmada a exclusão, então o item será excluido e a tela irá se atualizar aotomaticamente para não mostrar o item nexcluido, o mesmo vale 
para inclusões e alterações.

**Listas com Filtro**
   - Ao entrar nas telas que possuem filtro, o usuario pode selecionar o tipo de filtragem o mesmo deseja, sendo possivel escolher entre filtro por tipo ou por periodo,
a tela ao ser aberta já fica selecionada com a opção de Tipo deixando desabilitados os campos do periodo, para o filtro de tipo é necessario selecionar no ComboBox 
o tipo a ser filtrado e após isto selecionar o botão filtrar. Caso sejá selecionada a opção de periodo, o ComboBox ira se desabilitar e habilitara os campos de data, 
que tem por padrão uma data pre-definida para eles, que caso o usuario queira pode fazer a alteração dos mesmo, sendo necessario tambem pressionar o botãop de filtrar.

**Lista de Contas**
   - Nesta tela será possivel somente visualizar quais são as telas cadastradas, sendo mostradas todas as informações das contas ao uuario.
  
**Listas de Totais**
   - Com uma pequena diferença da Lista de Contas, estas telas possuem em baixa da lista um Label que mostra o Total, das Contas, das Despesas ou das Receitas.
  
**Transferencia**
   - Para que se possa concluir uma transferencia deve-se informar no campo de valor um valor que seja inferior ao campo de saldo original, deve-se também selecionar no
ComboBox de conta de destina uma conta que seja direfente da conta de origem, após isto é necessario pressionar o botão transferir, o qual ira efetuar a transferencia 
e atualizar os valores nos campos de saldo das respectivas contas selecionadas.
