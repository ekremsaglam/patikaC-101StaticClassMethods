using System;

namespace staticClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı : " + Employee.NumberOfWorker);
            Employee employee = new Employee("Ekrem","Sağlam","IT");
            Console.WriteLine("Çalışan sayısı : " + Employee.NumberOfWorker);
            Employee employee2 = new Employee("Mahmut","Sağlam","IT");
            Employee employee3 = new Employee("Mehmet","Sağlam","IT");
            Console.WriteLine("Çalışan sayısı : " + Employee.NumberOfWorker);

            Console.WriteLine(Islemler.topla(100,200));
            
        }//Main end
    }//class Program end

    class Employee
    {
        private static int numberOfWorker;
        public static int NumberOfWorker { get => numberOfWorker;}
        private string name;
        private string surname;
        private string department;

        static Employee(){
            numberOfWorker = 0;
        }

        public Employee(string department, string surname, string name)
        {
            this.Department = department;
            this.surname = surname;
            this.name = name;
            numberOfWorker++;
        }

        
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Department { get => department; set => department = value; }
    }//class Employee end

    static class Islemler{
        public static long topla (int number1,int number2){
            return number1+number2;
        }
    }
}
