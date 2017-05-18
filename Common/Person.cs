using ProtoBuf;
using System;

namespace Common
{
	[ProtoContract]
    public class Person
    {
		[ProtoMember(1)]
		public string FirstName { get; set; }

		[ProtoMember(2)]
		public string LastName { get; set; }
    }
}
