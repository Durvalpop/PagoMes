using PagoMes.Entities.Enums;
using System.Collections.Generic;
namespace PagoMes.Entities
{
    //Trabalhador
    class Worker
    {
        public string Name { get; set; }        //nome
        public WorkerLevel Level { get; set; }  //level_experiencia
        public double BaseSalary { get; set; }  //salario_Base
        public Department Department { get; set; }      //seu departamento
        public List<HourContract> Contracts { get; set; } = 
                new List<HourContract>();               // seus contratos bonus

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        //add
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        //remove
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //Calculo final__base salario + horas trabalhadas do dia
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
