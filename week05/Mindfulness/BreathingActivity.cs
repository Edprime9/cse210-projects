using System.IO.Compression;

namespace activity
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration) : base(name, description, duration)     
        {

        }
        public void Run()
        {
            DateTime n = DateTime.Now;
            //Console.WriteLine(n);
            DateTime q = n.AddSeconds(GetDuration());
            //Console.WriteLine(q);
            while (DateTime.Now<q)
            {
                Console.Write($"Breathe in...");
                ShowCountDown(5);
                Console.WriteLine();

                Console.Write($"Now Breathe out...");
                ShowCountDown(5);

                Console.WriteLine();
                Console.WriteLine();
            }
       
        }
    }
}