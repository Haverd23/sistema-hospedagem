# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

## Como Usar
Cadastrar Pessoa:
Adicione uma ou mais pessoas que serão os hóspedes.

Cadastrar Suite:
Informe o tipo da suíte desejada.

Cadastrar Dias de Reserva:
Informe o número de dias para a reserva. Esta etapa vincula os hóspedes e a suíte com a reserva.

Quantidade de Hóspedes:
Após cadastrar os hóspedes, a suíte e os dias de reserva, você pode verificar a quantidade total de hóspedes cadastrados na reserva.

Consultar Valor Total:
Após a reserva ser configurada, você pode consultar o valor total da diária, incluindo possíveis descontos aplicados.

Encerrar:
Encerre o programa quando terminar suas operações.

## Observações
Ordem das Operações: É necessário seguir a ordem correta das etapas: primeiro, cadastrar as pessoas; depois, cadastrar a suíte; e, por último, cadastrar os dias da reserva. Somente após essas etapas, as opções 4 e 5 funcionarão corretamente.

Configuração Padrão da Suíte: A suíte já vem configurada com uma capacidade máxima padrão para 2 hóspedes e uma diária de R$30,00. Caso precise alterar esses valores, ajuste a configuração conforme necessário.

Validação de Dados: Certifique-se de que a suíte tenha capacidade suficiente para o número de hóspedes e que os dias da reserva sejam informados corretamente.


![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

