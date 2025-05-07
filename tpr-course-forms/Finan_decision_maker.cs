using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TPR_Kursovaia_Forms
{
    internal class Finan_decision_maker
    {
        bool Is_simulating = true; //смотря что у нас сначала
        public bool output_checker = true;
        public string plan_text;
        Main_Form main_form;

        public Finan_decision_maker(Main_Form form)
        {
            main_form = form; //присваиваем наш main_form
        }
        public void Output(Finan_profile profile, int month_when)
        {
            // Вывод текущего состояния
            foreach (var goal in profile.Goals)
            {
                goal.Month_when = $"Месяц {month_when}"; //присваиваем месяц в который мы это выводим
                plan_text = $"\n{goal.Month_when} | {goal.Name}: р/мес: {Math.Round(goal.Monthly_saving)}," +
                   $" будет накоплено {Math.Round(goal.Current_saved)} / {goal.Target_amount} руб.";
                main_form.plan_text_m += plan_text;
                //добавляем в список для grid_plan нашу цель, в которой есть все нужные поля
                main_form.grid_data.Add(goal.DeepCopy());
            }
        }
        public void Update_goals(Finan_profile profile, int month_when = -5) //каждый месяц делаем этот метод. Тоесть если прошло 5 месяцев, то мы сделали этот метод 5 раз
        { //этот метод пронесём по циклу месяцев
            foreach (var goal in profile.Goals.Where(g => !g.Is_completed))
            {
                decimal remaining = goal.Target_amount - goal.Current_saved;

                if (goal.Monthly_saving > remaining)
                {
                    decimal surplus = goal.Monthly_saving - remaining;
                    goal.Monthly_saving = remaining; // Корректируем только текущую цель
                                                     //Console.WriteLine($"{goal.Name}, {goal.Monthly_saving}");
                    Give_surplus(profile, surplus, goal); // Не на все распределяем излишек, а только на оставшееся
                                                          //передаём goal, у которого поменялись деньги
                }

                goal.Current_saved += goal.Monthly_saving;
                goal.Is_completed = goal.Current_saved >= goal.Target_amount;
            }

            if (!Is_simulating) //если НЕ симулируем, то делаем действия
            {
                foreach (var goal in profile.Goals_grid)
                {
                    Console.WriteLine(goal.Target_months);
                }
                // Собираем завершённые цели
                var completedGoals = profile.Goals.Where(g => g.Is_completed).ToList();

                if (completedGoals.Any()) //если есть завершённые
                {
                    Output(profile, month_when); //ещё раз выводим сколько надо в последнем месяце не них
                    output_checker = false; //потому что уже вывели то что надо
                    decimal new_free_money = completedGoals.Sum(g => g.Monthly_saving);
                    profile.Goals.RemoveAll(g => g.Is_completed);
                    Set_monthly_saves(profile, profile.Free_money); //просто заново всё перераспределяем, тк количество целей изменилось
                    //это какбы перерасчитали для велосипеда, а эта инфа уже для следующего месяца. Надо не в цикле это делать
                }
            }
        }
        private void Give_surplus(Finan_profile profile, decimal surplus, Finan_goal old_goal)
        {
            var active_goals = profile.Goals.Where(g => !g.Is_completed && g.Current_saved < g.Target_amount && g != old_goal && g.Monthly_saving < g.Target_amount - g.Current_saved).ToList();

            if (!active_goals.Any()) return;

            decimal total_score = active_goals.Sum(g => g.Score); //сколько в сумме баллов
            foreach (var goal in active_goals)
            {
                goal.Monthly_saving += surplus * (goal.Score / total_score);
                //plan_text = $"\nПередано {Math.Round(surplus * (goal.Score / total_score))} руб. от '{old_goal.Name}' для '{goal.Name}'";
                //main_form.Set_plan_text(plan_text); //добавляем строчку в наш остновной текст
            }
        }

        public void Set_monthly_saves(Finan_profile profile, decimal new_free_money) //когда какая-то цель куплена, freeMoney увеличиваются и заново расчитывается этот метод
        { //этот метод происходит в начале и когда удаляются цели
            decimal total_score = profile.Goals.Sum(g => g.Score); //сколько в сумме баллов

            foreach (var goal in profile.Goals)
            {
                goal.Share_of_weight = Math.Round(goal.Score / total_score, 2, MidpointRounding.AwayFromZero);
                goal.Monthly_saving = new_free_money * goal.Share_of_weight;
            }
            // Проверяем, не превышает ли Monthly_saving remaining, и перераспределяем излишки
            bool needsRedistribution;
            do
            {
                needsRedistribution = false;
                foreach (var goal in profile.Goals)
                {
                    decimal remaining = goal.Target_amount - goal.Current_saved;
                    if (goal.Monthly_saving > remaining)
                    {
                        decimal surplus = goal.Monthly_saving - remaining;
                        goal.Monthly_saving = remaining;
                        Give_surplus(profile, surplus, goal);
                        needsRedistribution = true; // После перераспределения нужно проверить остальные цели
                    }
                }
            } while (needsRedistribution);
        }
        public void How_many_months(Finan_profile profile) //для того, чтобы сразу написать сколько месяцев потребуется для того, чтобы что-то купить
        {
            // Создаем копию профиля для симуляции
            var simulationProfile = profile.DeepClone();

            int month = 0;
            while (simulationProfile.Goals.Any() && month < 300) // Макс 5 лет
            {
                month++;
                Update_goals(simulationProfile);

                // Выводим только завершённые цели
                foreach (var goal in simulationProfile.Goals.Where(g => g.Is_completed))
                {
                    //Console.WriteLine($"- {goal.Name}: {month} месяцев осталось для покупки");
                    //у целей добавить поле Months
                    goal.Target_months = month; //тут надо присваивать не клону profile
                    //Console.WriteLine(goal.Target_months);
                    simulationProfile.Goals_grid.Add(goal); //добавляем в клона цель
                }
                simulationProfile.Goals.RemoveAll(g => g.Is_completed); //удаляем все цели, которые завершились
                //ещё раз перераспределяем деньги
                Set_monthly_saves(simulationProfile, simulationProfile.Free_money);
            }
            Is_simulating = false; //закончили симуляцию
            //передать инфу из симуляции основному профилю
            foreach (var goal_s in simulationProfile.Goals_grid)
            {
                foreach (var goal in profile.Goals_grid)
                {
                    if (goal.Name == goal_s.Name)
                    {
                        goal.Target_months = goal_s.Target_months;
                    }
                }
            }
        }
        public void Counts_score(Finan_profile prof) //тут только score пересчитываем, метод используется ТОЛЬКО при ДОБАВЛЕНИИ цели
        {
            //считаем score и share_of_weight для всех goal
            foreach (var goal in prof.Goals)
            {
                goal.Score = goal.Urgency * prof.W_Urgency + goal.Importance * prof.W_Importance + goal.Emotion * prof.W_Emotion; //получили какой-то балл
            }
        }
    }
}
