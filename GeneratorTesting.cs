namespace ImageGenerator
{
    public static class GeneratorTesting
    {
        public static string PositiveReaction()
        {
            string message = "The image was successfully generated!";
            return message;
        }
        public static string NegativeReaction()
        {
            string message = "Image creation error, you didn't use any blocks!";
            return message;
        }
    }
}
