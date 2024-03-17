using MachineLearningTest;

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = Console.ReadLine()
};

var result = SentimentModel.Predict(sampleData);


var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
