namespace usingStatementpractice;

internal class Program {
    static void Main(string[] args) {

        List<string> strings = new List<string>();

        strings.Add("Pink");
        strings.Add("Red");
        strings.Add("Magenta");
        strings.Add("Purple");
        strings.Add("Black");
        {

            var answer = 0;

            Console.Write("Type in a color ");
            var color = Console.ReadLine();
            if(strings.Contains(color)) {
                Console.Write("Color already exisits!");
            } else {
                strings.Add(color);
                Console.WriteLine("Added...");
            }
                foreach(string str in strings) {

                    Console.Write($"{str} ");
                }
            }
            
        }
    }








