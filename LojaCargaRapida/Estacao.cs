
namespace LojaCargaRapida
{
     class Estacao
    {
        //PROPRIEDADES()
        public string Motorista { get; set; }

        public double CapacidadeKm { get; set; }

        public double PorcentagemAtual { get; set; }

        public double PotenciaKm { get; set; }


        //metodo

        public double CalcularKWNecessarios()
        {
            double PorcentagemFaltante = (100.00 - PorcentagemAtual) / 100.00;
            return CapacidadeKm * PorcentagemFaltante;
        }

        //

        public double CalcularTempoHoras()
        {
            return CalcularKWNecessarios() / PotenciaKm;

        }

        //
        public double CalcularValor()
        {
            const double PRECO_POR_KWN = 2.50;
            return CalcularKWNecessarios() * PRECO_POR_KWN;

        }

        // 
        public bool CarregamentoRapido()
        {
            return (PotenciaKm >= 50.0) && (CalcularTempoHoras() < 1.0);
        }


    }
}
