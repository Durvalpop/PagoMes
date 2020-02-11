using System;

namespace PagoMes.Entities
{
    //Horas_Contratadas
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }
        
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        //Calculo final_horas_
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
