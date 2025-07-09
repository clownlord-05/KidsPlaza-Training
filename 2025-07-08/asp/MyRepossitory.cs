namespace asp
{
    public class MyRepossitory : IRepository

    {
        private readonly ILogger<MyRepossitory> logger;

        public MyRepossitory(ILogger<MyRepossitory>logger)
        {
            this .logger = logger;
            logger.LogInformation("New MyRepossitory ");
        }

        public string GetById(string id)
        {
            return "ID: " + id;
        }

        public string GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
