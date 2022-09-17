using System;

class Question
{
    int number1, number2, correct, userAnswer, userPoints = 0, counterCorrect = 0, counterIncorrect = 0;
    public void PrepareQuestion()
    {
        Random random1 = new Random();
        Random random2 = new Random();
        number1 = random1.Next(1, 100);
        number2 = random2.Next(1, 100);
        correct = number1 + number2;
    }

    public void ShowQuestion()
    {
        PrepareQuestion();
        Console.WriteLine("What is the sum of the numbers?");
        Console.Write($"{number1} + {number2} = ");
        userAnswer = Convert.ToInt32(Console.ReadLine());
        TextAnswer();
    }

    public void TextAnswer()
    {
        if (correct == userAnswer)
        {
            Console.WriteLine("Congratulations, you got it right!");
            userPoints += 5;
            counterCorrect++;
            RepeatedInf();
        }
        else
        {
            Console.WriteLine("Sorry, you got it wrong!");
            counterIncorrect++;
            RepeatedInf();

        }
    }

    public void RepeatedInf()
    {
        Console.WriteLine("Do you want to play again?(E/e)");
        string yourAnswerText = Console.ReadLine();
        if (yourAnswerText == "E" || yourAnswerText == "e")
        {
            Console.WriteLine("***********************************************************");
            ShowQuestion();
        }
        else
        {
            Console.WriteLine($"The Number of correct answers: {counterCorrect}");
            Console.WriteLine($"The number of incorrect answers: {counterIncorrect}");
            Console.WriteLine($"Your Score: {userPoints}");
        }
    }


}
