namespace activity
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
        {
            _prompts=["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];

            _questions=["Why was this experience meaningful to you? ","Have you ever done anything like this before? ","How did you get started?","How did you feel when it was complete? ","What made this time different than other times when you were not as successful? ","What is your favorite thing about this experience? ","What could you learn from this experience that applies to other situations? ","What did you learn about yourself through this experience? ","How can you keep this experience in mind in the future? "];
        }
        public void Run()
        {
            DateTime n = DateTime.Now;
            //Console.WriteLine(n);
            DateTime q = n.AddSeconds(GetDuration());
            //Console.WriteLine(q);
            while (DateTime.Now<q)
            {
                Console.WriteLine(GetRandomQuestion());
                Thread.Sleep(6);
            }
        }

        public string GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(_prompts.Count());
            
            return _prompts[number];
        }
        public string GetRandomQuestion()
        {   
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(_questions.Count());
            
            return _questions[number];     
        }

        public void DisplayPrompt()
        {
            Console.WriteLine(GetRandomPrompt());
        }
        public void DisplayQuestions()
        {
           

           DateTime n = DateTime.Now;
            //Console.WriteLine(n);
            DateTime q = n.AddSeconds(GetDuration());
            //Console.WriteLine(q);
            while (DateTime.Now<q)
            {
                Console.Write(GetRandomQuestion());
                ShowSpinner(7);
                
                Console.WriteLine();
                Console.WriteLine();
                
            }
        }
    }
}