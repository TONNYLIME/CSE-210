using System;

public class PromptGenerator
{
     public List<string> Prompts{get; set;}

       public PromptGenerator()
       {
         Prompts = new List<string>
         {
            "What was the best part of the day? ",
            "What experience did you have increase your faith? ",
            "Who was the most interesting person you interracted with? ",

        };
       }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(Prompts.count);
            return Prompts[index];
        }
        

        
}
    
