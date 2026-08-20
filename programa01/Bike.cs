namespace programa01
{
    class Bike
    {
        //DECLARAÇÕES
        public string? Modelo { get; set; }
        //public: metodo de acesso
        public double Bateria { get; set; }

        public double PesoCiclista { get; set; }

        public int RecargaMes { get; set; }

        //MÉTODOS (AÇÔES)
        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15.0;
            bool peso = PesoCiclista > 90.0;
            //se o peso do ciclista for maior que 90 kg reduz a autonomia
            //para 15%, se não, autonomia normal
            return peso ? (autonomiaBase * 0.05) : autonomiaBase;

        }
        public double CalcularConsumoMensal()
        {
            double cargaPorkm = Bateria / 1000.0;
            return cargaPorkm = RecargaMes;
        }

        public double CalcularCustoMensal()
        {
            const double PRECO = 0.80;
            return CalcularConsumoMensal() * PRECO;
        }

        public bool BikeEconomica()
        {
            return (CalcularCustoMensal() < 15.00) || (CalcularAutonomia() > 40);
        }

        
        
    }
}
