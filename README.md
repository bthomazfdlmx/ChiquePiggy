# Processo Seletivo Programador .Net Junior

# Escopo

A Loja de roupas ChiquePiggy deseja oferecer vantagens para os seus clientes, com isso, resolveram criar um programa de fidelidade para o negócio, onde para cada real que o cliente gastar na loja ele ganhará um ponto no programa de fidelidade
Quando o cliente chegar aos 100 pontos ou mais, a ChiquePiggy irá oferecer uma camisa de graça para o cliente, se ele aceitar será retirado 100 pontos do seu saldo no programa de fidelidade.
Para automatizar esse processo a ChiquePiggy precisará que você crie um sistema para o operador do caixa.

# Requisidos do sistema

- 1) O Sistema deve conter uma interface visual, onde o operador do caixa colocará o ID do cliente e o valor total da compra do cliente. Onde o ID do cliente deve ser um número inteiro, clientes com IDs que não contenham na base em memória será necessário avisar o operador do caixa que é a primeira compra do cliente;
- 2) O Sistema deve pontuar o cliente pelo valor total da compra que ele realizou, quando há centavos envolvidos o sistema deve arredondar a pontuação, conforme exemplo abaixo:
  -    Uma compra de R$50,49 deve ser considerado como 51 pontos.
- 3) O Sistema deve pontuar o cliente com pontuação dobrada em toda segunda-feira e terça-feira;
- 4) O Sistema deve avisar o operador do caixa, quando o cliente tiver 100 pontos ou mais;
- 5) O Sistema deve conter um botão para o operador dar baixa na pontuação do cliente, quando o mesmo aceitar a camisa de graça oferecida pela ChiquePiggy.

# Parte escrita

Para validar conceitos básicos de banco de dados, você deverá montar um script do banco de dados do sistema acima para rodar em SqlServer, onde deve coter as informações do cliente e o histórico de pontuação realizadas. As seguintes informações são necessárias para o projeto:
- Uma tabela de cliente que deve conter pelo menos o ID e nome do cliente;
- Uma tabela de histórico, onde ligue o cliente da tabela acima e suas transações como: Valor da compra, data da transação e pontos ganhos na compra ou pontos debitados pelo aceito do requesito "v".

Montar um script que dado um ID de cliente retorne todas as pontuações dele. Esse relatório deve conter pelo menos o nome do cliente e as informações da tabela de histórico.
Montar um script que agrupe todas as transações de um cliente por data, sendo o formato das datas dia/mês/ano

Você deve deixar os scripts dentro do projeto ChiquePiggy.Database

# Observações

Coloque
A base do projeto pode ser modificada por você, deixamos ela montada para dar o start para qualquer pessoa.
A class library de caching está feita para você armazenar os dados do sistema, caso você não queira depender de uma biblioteca externa/Sessão para isso.

Boa sorte!
