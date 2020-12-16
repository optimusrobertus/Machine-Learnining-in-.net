using System;
using MyMLAppML.Model;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to analyse a sentence?");
            String varAnswer = Console.ReadLine();
            while (varAnswer.ToLower() == "yes")
            {
                Console.WriteLine("What sentence do you want to analyse?");
                String varSentence = Console.ReadLine();
                Console.WriteLine(varSentence);

                // Add input data
                var input = new ModelInput();
                input.SentimentText = varSentence;

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine($"Based on what I have learned, the analysis returns a toxic value of: {result.Prediction}");

                Console.WriteLine("Do you want to analyse another sentence?");
                varAnswer = Console.ReadLine();

            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }

}