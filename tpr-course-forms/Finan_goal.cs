using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_Kursovaia_Forms
{
    public class Finan_goal
    {
        //это вводит пользователь
        public string Month_when { get; set; }
        public string Name { get; set; }    //Название цели
        public decimal Target_amount { get; set; }   // Сумма, которую нужно накопить
        public int Urgency { get; set; }       // 1-10 СРОЧНОСТЬ
        public int Importance { get; set; }     // 1-10 ВАЖНОСТЬ
        public int Emotion { get; set; }       // 1-10 ЭМОЦИОНАЛЬНАЯ ЦЕННОСТЬ

        //это только в программе находиться
        public decimal Monthly_saving { get; set; }  //Сколько откладываем в месяц
        public decimal Current_saved { get; set; } = 0m;   // Уже накоплено
        public decimal Target_months { get; set; } = 1000;   //через сколько купим ТОЧНО

        public bool Is_completed { get; set; } //проверка накопили ли достаточно денег

        //для метода весов
        public decimal Share_of_weight { get; set; } //Делим это число на total_score(сумма баллов всех goal в profile
        public decimal Score { get; set; } //балл от критерии * вес критериев
        //public decimal Min_monthly_percent { get; set; } // Минимальный процент от свободных средств
        //ДАТА начала копления на этот предмет. Чтобы в будущем реализовать то, что мы можем зайти через месяц и нам должны показать сколько осталось и мы запомнили сколько уже накопили
        public Finan_goal DeepCopy()
        {
            return new Finan_goal
            {
                Month_when = this.Month_when,
                Name = this.Name,
                Monthly_saving = this.Monthly_saving,
                Current_saved = this.Current_saved,
                Target_amount = this.Target_amount
                // скопируйте все нужные свойства
            };
        }
    }
}
