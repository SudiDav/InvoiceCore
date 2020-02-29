using Invoice.Core.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace Invoice.Core.Entity
{
    public class DailyExpenses : BaseModel 
    {
        public int Id { get; set; }
        [Display(Name = "Nom")]
        public string Name { get; set; }
        [Display(Name = "Taux de Change")]
        public double ExchangeRate { get; set; }
        [Display(Name = "Montant en Francs Congolais (FC)")]
        public double MoneyInFc { get; set; }
        [Display(Name = "Montant en Dollars Americain ($)")]
        public double MoneyInUsd { get; set; }
        [Display(Name ="Type d'Operation")]
        public string TypeOfOperation { get; set; }
        public string Description { get; set; }
    }
}
