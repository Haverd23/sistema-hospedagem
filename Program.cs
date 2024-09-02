using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();
Suite suite = null; 
Reserva reserva = null; 
bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Pessoa");
    Console.WriteLine("2 - Cadastrar Suite ");
    Console.WriteLine("3 - Cadastrar Dias de Reserva");
    Console.WriteLine("4 - Quantidade de Hóspedes");
    Console.WriteLine("5 - Consultar Valor Total");
    Console.WriteLine("6 - Encerrar");


    switch (Console.ReadLine())
    {
        case "1":
            while(true){
            Console.Clear();
            Console.WriteLine("Digite seu Nome");
            string nomePessoa =(Console.ReadLine());
            Pessoa novoHospede = new Pessoa(nomePessoa);
            hospedes.Add(novoHospede);
            Console.WriteLine("Deseja acrescentar mais um hóspede? (S/N)");
            string acrescimo= Console.ReadLine().Trim().ToUpper();
            if(acrescimo !="S"){
                break; }
            }
            break;

        case "2":
            Console.Write("Digite o tipo da suite desejada:" );
            string suiteType = Console.ReadLine();
            suite = new Suite(tipoSuite: suiteType, capacidade: 2, valorDiaria: 30);
            break;
            

        case "3":
            while(true){
            int dias = 0;
            Console.Write("Digite quantos dias deseja reservar: "); 
            dias = Convert.ToInt32(Console.ReadLine());
            if (dias!=0){
            reserva = new Reserva(diasReservados:dias );
            if (suite != null){
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(new List<Pessoa>(hospedes));
            }}

            break;}
            break;
            

        case "4":
            if (reserva != null){   
            {try
            {Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");}
            catch (InvalidOperationException ex){
            Console.WriteLine(ex.Message); }
            }}
            else
            {Console.WriteLine("Nenhuma reserva foi realizada"); }
            break;
        
        case "5":
            if (reserva != null){   
            try
            {Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria()}");}
            catch (InvalidOperationException ex){
            Console.WriteLine(ex.Message); }
            }
            else
            {Console.WriteLine("Nenhuma reserva foi realizada, portanto não foi cobrado."); }
            break;

        case "6":
            menu =false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");