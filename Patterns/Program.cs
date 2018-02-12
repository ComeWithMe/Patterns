using System;

namespace Patterns
{
    class Program
    {
        static void Main()
        {
            var k = new Observable();
            k.Add(new Observer());
            k.Add(new Observer());
            k.Add(new Observer());
            k.Add(new Observer());
            k.Notify();
        }
    }
}
