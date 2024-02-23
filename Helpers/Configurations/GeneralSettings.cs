namespace clashofclans.server.Helpers.Configurations
{
    public class GeneralSettings
    {
        public ClashOfClansSettings ClashOfClansSettings{ get; set; }

        public string ObterToken()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json") // Este é o arquivo padrão
                .AddJsonFile("appsettings.development.json", optional: true) // Adiciona o arquivo development.json, se existir
                .Build();

            // Obtém o valor do token
            var token = configuration["ClashOfClans:Token"];

            return token ?? "Token not found";
        }
        public string GetAPIUrl()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json") // Este é o arquivo padrão
                .AddJsonFile("appsettings.development.json", optional: true) // Adiciona o arquivo development.json, se existir
                .Build();

            // Obtém o valor do token
            var url = configuration["ClashOfClans:APIUrl"];

            return url ?? "Token not found";
        }
    }

    public class ClashOfClansSettings
    {
        public string url { private get; set; }
        public string token { private get; set; }
    }
}
