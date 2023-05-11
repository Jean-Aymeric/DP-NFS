using DP_NFS.message;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(TextValidator.IsOk(new Message("Hello World!"))); // -> true

            Console.WriteLine(TextValidator.IsOk(new Message("Hello Caca!"))); // -> false
            Console.WriteLine(TextValidator.IsOk(new Message("Hello Prout!"))); // -> false
            Console.WriteLine(TextValidator.IsOk(new Message(""))); // -> false
            Console.WriteLine(TextValidator.IsOk(new Message("Hello World!!!"))); // -> false
            Console.WriteLine(TextValidator.IsOk(new Message("HELLO WORLD!"))); // -> false
        }
    }
}
