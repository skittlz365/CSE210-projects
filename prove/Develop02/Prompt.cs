/*
This is the prompt class. It generates a random prompt
from a list that is then presented to the user.
*/
class Prompt
{
    public string _npPrompt = "";

    public string GeneratePrompt()
    {
        List<string> prompts = ["What was one thing you wish you had done differently today?", "What is the best thing you ate today?",
        "What was the most interesting conversation you had today?", "What good deed did you do today?",
        "What is the coolest thing you learned today?", "What is something you improved on today?"];
        
        int npRandomIndex = Random.Shared.Next(prompts.Count);

        string choice = prompts[npRandomIndex];
        return choice;
    }
}