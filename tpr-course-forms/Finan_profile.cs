using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_Kursovaia_Forms
{
   public class Finan_profile
    {
        public decimal Monthly_income { get; set; } //Доход
        public decimal Monthly_expenses { get; set; }  //Обязательные траты
        public decimal Free_money => Monthly_income - Monthly_expenses; //Свободные деньги
        public List<Finan_goal> Goals { get; set; } = new List<Finan_goal>();
        public List<Finan_goal> Goals_grid { get; set; } = new List<Finan_goal>();

        //тут зададим для профиля его вес для каждого критерия
        public decimal W_Urgency { get; set; } = 5.0M;    // Вес срочности (например, 0.5)
        public decimal W_Importance { get; set; } = 3.0M;  // Вес важности (0.3)
        public decimal W_Emotion { get; set; } = 2.0M;  // Вес эмоциональной ценности (0.2)

        public bool New_goal_from_main { get; set; } = false;

        public Finan_profile DeepClone() //создаём клона
        {
            return new Finan_profile
            {
                Monthly_income = this.Monthly_income,
                Monthly_expenses = this.Monthly_expenses,
                Goals = this.Goals.Select(g => new Finan_goal // Клонируем каждую цель
                {
                    Name = g.Name,
                    Target_amount = g.Target_amount,
                    Current_saved = g.Current_saved,
                    Monthly_saving = g.Monthly_saving,
                    Share_of_weight = g.Share_of_weight,
                    Score = g.Score,
                    Is_completed = g.Is_completed,
                    Target_months = g.Target_months
                }).ToList()
            };
        }
    }
}
