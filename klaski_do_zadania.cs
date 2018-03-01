

    //file Head.cs 
    public class Head
    {
        private string _behaviorCommand;

        public Head(string command)
        {
            if (ValidCommand(command))
                _behaviorCommand = command;
            else _behaviorCommand = "SLEEP";
        }

        private bool ValidCommand(string command)
        {
            bool result = false; if (!string.IsNullOrEmpty(command))
            {
                if (command == "SLEEP")
                    result = true;
                else if (command == "SAD")
                    result = true;
                else if (command == "HAPPY")
                    result = true;
            }
            return result;
        }

        internal void CallBehavior()
        {
            if (_behaviorCommand == "SLEEP")
            {
                Console.Clear();
                Console.WriteLine("_________________");
                Console.WriteLine("|               |");
                Console.WriteLine("|   --     --   |");
                Console.WriteLine("|               |");
                Console.WriteLine("|      *        |");
                Console.WriteLine("|               |");
                Console.WriteLine("|   --------    |");
                Console.WriteLine("|_______________|");
            }
            else if (_behaviorCommand == "SAD")
            {
                Console.Clear();
                Console.WriteLine("_________________");
                Console.WriteLine("|               |");
                Console.WriteLine("|    <>   <>    |");
                Console.WriteLine("|               |");
                Console.WriteLine("|       *       |");
                Console.WriteLine("|               |");
                Console.WriteLine("|    --------   |");
                Console.WriteLine("|_______________|");
            }
            else if (_behaviorCommand == "HAPPY")
            {
                Console.Clear();
                Console.WriteLine("_________________");
                Console.WriteLine("|               |");
                Console.WriteLine("|    O     O    |");
                Console.WriteLine("|               |");
                Console.WriteLine("|       *       |");
                Console.WriteLine("|               |");
                Console.WriteLine("| \\_______/    |");
                Console.WriteLine("|_______________|");
            }
            else
                Console.WriteLine("ooo nie wiem co zrobić...");
        }
    }
    
    //file RobotController.cs 
    public class RobotController
    {
        public void Sleep()
        {
            Head head = new Head("SLEEP");
            head.CallBehavior();
        }
        public void Sad()
        {
            Head head = new Head("SAD");
            head.CallBehavior();
        }
        public void Happy()
        {
            Head head = new Head("HAPPY");
            head.CallBehavior();
        }
    }

    //file Program.cs 
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var robotOla = new RobotController();
            robotOla.Sad();
            Thread.Sleep(2000);
            robotOla.Happy();
            Thread.Sleep(2000);
            robotOla.Sleep();
            Thread.Sleep(2000);
        }
    }


