using System;

public class ReflectingActivity
{
    public List<string>_prompts;
    public List<string>_questions;
    public ReflectingActivity()
    {

    }
    public void Run()
    {

    }
     public string GetRandomPrompt()
    {
        return $"{_prompts}";
    }
     public string  GetRandomQuestion()
    {
        return $"{_questions}";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{_prompts}");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"{_questions}");
    }


}   