using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp18
{
    class Staff
    {
        int serviceNumber;
        string name;
        string surname;
        string patronymic;
        DateTime bDay;
        string position;
        int salary;


        public Staff( string name, 
            string surname, string patronymic, DateTime bDay, string position, int salary)
        {
            serviceNumber++;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.bDay = bDay;
            this.position = position;
            this.salary = salary;
        }


        /// <summary>
        /// вводит данные сотрудников и сохнраняет в массив
        /// </summary>
        /// <param name="x">сколько сотрудников которых хотим записать в массив</param>
        /// <returns></returns>
        static public Staff[] ArrayStaff(int x)
        {
            Staff[] allStaff = new Staff[x];

            for (int i = 0; i < allStaff.Length;i++)
            {
                Console.Write("Введите имя сотрудника - ");
                string name = Convert.ToString(Console.ReadLine());

                Console.Write("Введите фамилию сотрудника - ");
                string surname = Convert.ToString(Console.ReadLine());

                Console.Write("Введите отчество сотрудника - ");
                string patronymic = Convert.ToString(Console.ReadLine());

                Console.Write("Введите дату рождения сотрудника - "); 
                DateTime bDay = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Введите должность сотрудника - ");
                string position = Convert.ToString(Console.ReadLine());

                Console.Write("Введите оклад сотрудника - ");
                int salary = Convert.ToInt32(Console.ReadLine());

                allStaff[i] = new Staff(name,surname,patronymic,bDay,position,salary);
            }
            return allStaff;
        }


        /// <summary>
        /// Выводит в консоль всех сотрудников
        /// </summary>
        /// <param name="a">массив где находятся все сотрудники</param>
        static public void PrintAllStaff(Staff[] a)
        {
            foreach(Staff el in a)
            {
                Console.WriteLine($"Табельный номер - {el.serviceNumber} " +
                    $"имя сотрудника - {el.name}\n" +
                    $"фамилия сотрудника - {el.surname}\n" +
                    $"отчество сотрудника - {el.patronymic}\n" +
                    $"дата рождения сотрудника - {el.bDay.ToString("d")}\n" +
                    $"должность сотрудника - {el.position}\n" +
                    $"оклад сотрудника - {el.salary}\n");
            }
        }

        /// <summary>
        /// выводит возраст каждого сотрудника
        /// </summary>
        /// <param name="a">массив где находятся все сотрудники</param>
        public static void AgeAllStaff(Staff[] a)
        {
            DateTime time2 = DateTime.Now;
            
            foreach(Staff el in a)
            {
                int year = time2.Year - el.bDay.Year;
                int month = Math.Abs(time2.Month - el.bDay.Month);

                if (time2.Month - el.bDay.Month < 0) year--;
               
                Console.WriteLine($"Сотруднику {el.name} - {year} лет");
            }
        }

    }

}
