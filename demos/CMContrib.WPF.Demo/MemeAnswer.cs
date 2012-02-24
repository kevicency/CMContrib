namespace Caliburn.Micro.Contrib.Demo
{
    public class MemeAnswer
    {
        public string Meme { get; set; }
        public string Description { get; set; }

        public MemeAnswer()
        {}

        public MemeAnswer(string answer, string description)
        {
            Meme = answer;
            Description = description;
        }
    }
}