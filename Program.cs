using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
            foo.OnKeyPressed += (_, c) => Console.WriteLine($"\n{c}");

            foo.Run();
        }
    }

    public class Foo
    {
        public EventHandler<char> OnKeyPressed;
        public void Run()
        {
            char input = ' ';

            while (input != 'c')
            {
                input = Console.ReadKey().KeyChar;
                OnKeyPressed.Invoke(this, input);
            }
        }
    }
}
