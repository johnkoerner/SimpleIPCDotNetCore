using Common;
using ProtoBuf;
using System;
using System.IO.Pipes;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Server");

			var pipe = new NamedPipeServerStream("MyTest.Pipe", PipeDirection.InOut);
			Console.WriteLine("Waiting for connection....");
			pipe.WaitForConnection();

			Console.WriteLine("Connected");

			Serializer.Serialize(pipe, new Person() { FirstName="Janey", LastName = "McJaneFace" });
			pipe.Disconnect();

        }
    }
}