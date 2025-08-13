using System;


namespace @event
{
    public delegate void speedDelegate(int speedValue);
    internal class car
    {
        //public event speedDelegate speedEvent;
        public event Action<int> speedEvent;

        private int _speed;

        public string Model { get; set;}

        public int Speed 
        { 
            get => _speed;
            set
            {
                if (value > 80 && speedEvent != null)
                {
                    speedEvent(value);  //event fırlatıldığı an
                }
                else
                {
                    _speed = value;
                }
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            car c = new car();
            c.Model = "Renault";
            c.speedEvent +=  (speedValue) => { Console.WriteLine("araba hız limitini aştı."); };
            //c.speedEvent += C_speedEvent;
            for (int i = 50; i<100; i+=5)
            {
                System.Threading.Thread.Sleep(300);

                c.Speed = i;

                Console.WriteLine("araç hızlanıyor. araç hızı:"+i);
            }
        }

        //private static void C_speedEvent(int speedValue)
        //{
        //    Console.WriteLine("Araba hızını aştı::: anlık hız durumu: "+speedValue);
        //}
    }
}
