using System;

// АВТОР: Маркова Анастасия, 1521501 - 3Б


namespace апокалипсис
{
    // Class AntiWorld -- основной класс, из которого будут наследоваться класс Apocalipsis.
    public class AntiWorld
    {
        public virtual void deeletethisisworld()
        {
            Console.WriteLine("Hello World! Добро пожаловать в приложение, которое расскажет, как быстро тебя уничтожит человечество! \n\nЯ могу предложить тебе выбрать вариант развития событий, а потом расчитать, как быстро случится конец света.\n\n  Продолжим? (1 - да/ 0 - нет)");
            int otvet = Convert.ToInt32(Console.ReadLine());

            if (otvet > 0 && otvet < 2)
            {

                Console.WriteLine("\n\nокеей, значит продолжим. но уточню, что не стоит воспринимать меня всерьез, я просто озвучиваю мысли, не претендуя на их иситинность.");

            }
            else
            {
                System.Environment.FailFast("\n\n!!!!Приложение досрочно завершило свою работу!!!!");
            }

        }
    }

    // Apocalipsis -- наследуемый класс, из которого будет также наследоваться класс EndWorld.
    public class Apocalipsis : AntiWorld
    {
        public override void deeletethisisworld()
        {
            base.deeletethisisworld();
            Console.WriteLine("\n\nЧто же, вам предстоит давать ответы на дабавление происходящего в мире \n\nпо принципу 1 - включаем/0 - не включаем \n\nисходя из ваших ответов будут совершены подсчеты, насколько мир близок к концу.");

            Console.WriteLine("\nКоличество выбросов вырастает с каждым годом, минимум в два раза: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && a < 2)
            {
                a = 15;
            }
            else if (a > 1)
            {
                Console.WriteLine("оу, что-то пошло не так");
            }
            else
            {
                a = 0;
            }

            Console.WriteLine("\n\nВ мире постоянно идут войны:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b > 0 && b < 2)
            {
                b = 20;
            }
            else if (b > 1)
            {
                Console.WriteLine("оу, что-то пошло не так");
            }
            else
            {
                b = 0;
            }

            Console.WriteLine("\n\nВнутри стран происходят гражданские войны:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c > 0 && c < 2)
            {
                c = 5;
            }
            else if (c > 1)
            {
                Console.WriteLine("оу, что-то пошло не так");
            }
            else
            {
                c = 0;
            }

            Console.WriteLine("\n\nГлобальное потепление:");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d > 0 && d < 2)
            {
                d = 15;
            }
            else if (d > 1)
            {
                Console.WriteLine("оу, что-то пошло не так");
            }
            else
            {
                d = 0;
            }

            Console.WriteLine("\n\nСмена полюсов:");
            int e = Convert.ToInt32(Console.ReadLine());
            if (e > 0 && e < 2)
            {
                e = 20;
            }
            else if (e > 1)
            {
                Console.WriteLine("оу, что-то пошло не так");
            }
            else
            {
                e = 0;
            }

            Console.WriteLine("\n\nК планете подлетает метеорит:");
            int f = Convert.ToInt32(Console.ReadLine());
            if (f > 0 && f < 2)
            {
                f = 25;
            }
            else if (f > 1)
            {
                Console.WriteLine("оу, что-то пошло не так");
            }
            else
            {
                f = 0;
            }

            int w = a + b + c + d + e + f;

            if (w > 99)
            {

                Console.WriteLine("\n\nCлушайте, ну с таким набором я в шоке, что вы еще можете использовать компьютер и считать что-то.");
            }
            else if (w > 74 && w < 99)
            {
                Console.WriteLine("\n\nНе думаю, что у вас осталось много времени, чтобы тратить его на какие-то программки.");
            }
            else if (w > 49 && w < 75)
            {
                Console.WriteLine("\n\nНет, ну, шансы все исправить у вас еще есть, но советую попторопиться, если не хотите повторить судьбу динозавров.");
            }
            else if (w > 24 && w < 50)
            {
                Console.WriteLine("\n\nПару сотен лет в запасе еще есть, но такими темпами они могут быть борбой за выживание, стоит задуматься.");
            }
            else
            {
                Console.WriteLine("\n\nОтлично, у вас еще есть время на жизнь, проблемы есть конечно, но не такие значительные, все ок.");
            }

        }

        // EndWorld -- наследуемый из предыдущего класс, подсчитывающий сколько до конца света.   
        public class EndWorld : Apocalipsis
        {
            public override void deeletethisisworld()
            {

                Console.WriteLine("\nвообще, все это шутки конечно, но стоит порой задуматься над тем, как стремительно мы уничтожаем нашу планету, \n\nМарс вроде бы еще не готов для нашего переселения, поэтому надо быть осторжнее. ");
                Console.WriteLine(@"
а теперь посмотрите на котика, пока вы еще живы.)
                                                                                
⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⢰⣷⡄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⣠⣾⣿⣿⣷⣦⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⣠⣿⣿⣿⣿⣿⣿⣇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠛⠿⣿⣿⣿⣿⣿⣆⠄⠄⠄⠄⠄⣴⣿⣿⣆⠄⠄⠄
⠄⠄⠄⠄⠄⣰⣿⣿⣿⣿⣿⣿⣷⣄⠄⠄⠄⣿⣿⠛⠉⠄⠄⠄
⠄⠄⠄⠄⠄⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠄⠘⣿⡆⠄⠄⠄⠄
⠄⠄⠄⠄⠄⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠸⣿⡀⠄⠄⠄
⠄⠄⠄⠄⠄⠄⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠄⣿⡇⠄⠄⠄
⠄⠄⠄⠄⠄⠄⢸⣿⡟⣿⣿⣿⣿⣿⣿⣿⣿⡇⢀⣿⠇⠄⠄⠄
⠄⠄⠄⠄⠄⢀⣸⡿⢁⣘⣿⣿⣿⣿⣿⣿⣿⣇⣼⠋⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠻⠿⠓⠿⠿⠿⠿⠿⠿⠿⠿⠿⠛⠁⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄
              
");
            }
        }

        /// Program: used to execute the method.
        public class Program
        {
            private static void Main(string[] args)
            {
                AntiWorld a = new Apocalipsis();
                a.deeletethisisworld();
                Console.WriteLine("");
                Apocalipsis b = new EndWorld();
                b.deeletethisisworld();
                _ = Console.ReadKey();
            }
        }
    }
}