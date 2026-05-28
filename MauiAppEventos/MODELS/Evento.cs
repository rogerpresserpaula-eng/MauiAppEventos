namespace MauiAppEventos.MODELS
{
    public class Evento
    {
        // Dados do evento
        public string NomeEvento { get; set; }

        public string LocalEvento { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFinal { get; set; }

        public int NumeroParticipantes { get; set; }

        public double CustoPorParticipante { get; set; }


        // Diferença entre datas usando TimeSpan
        public TimeSpan DuracaoEvento
        {
            get
            {
                return DataFinal - DataInicio;
            }
        }


        // Total de dias
        public int TotalDias
        {
            get
            {
                return DuracaoEvento.Days;
            }
        }


        // Valor total do evento
        public double ValorTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}
