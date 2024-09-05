namespace online_edu.WebUI.Helpers
{
    public static class HttpClientInstance
    {
        public static HttpClient CreateClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress= new Uri("https://localhost:7291/api/");
            return httpClient;
        }
    }
}
