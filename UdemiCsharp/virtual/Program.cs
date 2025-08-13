using System;


namespace @virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            subClass subClass = new subClass();
            string value = subClass.getName("fattih", "çalişkan");
            Console.WriteLine(value);

            subClass.FirstName = "fattih";
            subClass.LastName = "çiloğlu";
            Console.WriteLine(subClass.FullName);
        }

        public abstract class baseClass
        {
            public abstract string getProduct(int id);
            public virtual string getName(string name,string surname)
            {
                return name + " " + surname;
            }

            private string _firstname;
            private string _lastname;

            public string FirstName
            {
                get => _firstname;
                set => _firstname = value;
            }
            public string LastName
            {
                get => _lastname;
                set => _lastname = value;
            }
            public virtual string FullName
            {
                get => _firstname +" " + _lastname;
            }
        }

        public class subClass : baseClass
        {
            public override string getProduct(int id)
            {
                throw new NotImplementedException();
            }

            public override string getName(string name, string surname)
            {
                return name.ToUpper()+" "+name.ToUpper();
            }

            public override string FullName => FirstName.ToUpper()+" "+LastName.ToUpper();
        }
    }

    internal class basesClass
    {
        public string Name { get; set; }
        public virtual string getName()
        {
            return Name;
        }
    }

    internal sealed class basestClass
    {

    }
    internal class childersClass:basesClass
    {
        public sealed override string getName()
        {
            return Name.ToUpper();
        }
    }

    internal class childersClass2 : basesClass
    {
       //getname   sealed ile işaretlendiği için kullanılamaz.
    }
}
