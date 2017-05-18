using Common;
using ProtoBuf;
using System;
using System.IO.Pipes;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client");
			var pipe = new NamedPipeClientStream(".", "MyTest.Pipe", PipeDirection.InOut, PipeOptions.None);
			Console.WriteLine("Connecting");
			pipe.Connect();
			var person = Serializer.Deserialize<Person>(pipe);
			Console.WriteLine($"Person: {person.FirstName} {person.LastName}");
			Console.WriteLine("Done");

        }
    }
}