
using System.Net.WebSockets;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var aboutPage = new HomePage().GoToAboutPage();
            // var home = aboutPage.GoHome();
            // var home2 = home.GoHome();


            // var printer = new GenericPrinter();
            //printer.PrintType('f');

            var json = @"{""user"":""Sasha"", ""password"":""sup3rs3cr3t"", ""sm"" :[""li"",""fb"",""ig"",""tg""]}";
            var obj = Converter.StringToObject<UserDataModel>(json);
            var newJson = Converter.ObjToString(obj);
            var url = "https://swapi.dev/api/";
            var result = GetDataFromInternet(url);

            var page = GetDataFromInternet("http://google.com");
            File.WriteAllText("demo.html", page);
        }

        static string GetDataFromInternet(string url)
        {
            using HttpClient client = new HttpClient();
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri(url);
            var result = client.Send(request);
            result.EnsureSuccessStatusCode();
            return result.Content.ReadAsStringAsync().Result;
        }
    }

    public static class Converter
    {
        public static string ObjToString(object obj)
        {
            return System.Text.Json.JsonSerializer.Serialize(obj);
        }

        public static T StringToObject<T>(string value)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(value);
        }
    }

    public class UserDataModel
    {
        [JsonPropertyName("user")]
        public string User { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("sm")]
        public string[] Sm { get; set; }
    }


    public class GenericPrinter
    {
        public void PrintType<T>(T value)
        {
            System.Console.WriteLine(typeof(T));
        }
    }


    public class HomePage : Page
    {
        Button about = new Button();
        Link<HomePage> home = new Link<HomePage>();

        public AboutPage GoToAboutPage()
        {
            about.Click();
            return new AboutPage();
        }

        public HomePage GoHome()
        {
            return home.ClickAndGo();
        }
    }

    public class AboutPage : Page
    {
        Button home = new Button();

        public HomePage GoHome()
        {
            return home.ClickAndGo<HomePage>();
        }
    }

    public class Page
    {

    }

    public class Button()
    {
        public void Click()
        {
            System.Console.WriteLine("I am clicked ");
        }

        public T ClickAndGo<T>()
            where T : class, new()
        {
            Click();
            return new T();
        }
    }


    public class Link<TResult>()
            where TResult : class, new()
    {
        public void Click()
        {
            System.Console.WriteLine("I am clicked");
        }

        public TResult ClickAndGo()
        {
            Click();
            return new TResult();
        }
    }
}