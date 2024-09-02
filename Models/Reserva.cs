namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } 
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {  
           bool validarCapacidade = Suite.Capacidade >= hospedes.Count();
            
            if (validarCapacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new InvalidOperationException("Quantidade de hóspedes ultrapassa os limites da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
       
        return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {

            
            decimal valor = DiasReservados* Suite.ValorDiaria;
            return valor = DiasReservados >=10 ? valor - valor/10: valor;
           
        }
    }
}