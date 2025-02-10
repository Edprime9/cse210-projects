namespace activity
{
    public class ListingActivity : Activity
    {
        //private int _count;
        private List<string> _prompts;
        private List<string> MyUserList =[];
        public void Run()
        {
           
            Console.WriteLine($"Number of listed items {MyUserList.Count()}");
        }
        public string GetRandomPrompt()
        {
            _prompts=["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(_prompts.Count());
            
            return _prompts[number];
        }

        public List<string> GetListFromUser()
        {  
            
           string input = Console.ReadLine();
           MyUserList.Add(input);

                    
                
            return MyUserList;
                    
        }
    }
}