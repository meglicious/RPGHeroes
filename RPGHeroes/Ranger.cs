using System;
namespace Application
{
	public class Ranger
	{
        int Level;
        string Name;
        [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        public sealed class MyAttribute : Attribute
        {
            readonly string positionalString;
            public string PositionalString
            {
                get
                {
                    return positionalString;
                }
            }

            public int NamedInt { get; set; }

            public MyAttribute(string positionalString)
            {
                this.positionalString = positionalString;

                // TODO: Implement code here

                throw new NotImplementedException();
            }
        }
        public class Attribute
        {

        }
        public Ranger()
		{
		}
	}
}

