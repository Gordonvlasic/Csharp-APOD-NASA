using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using SimpleAPI;
class Program
{
    HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        //instatiate a new Program, Then run the Task ConnectionStream().

        Program program = new Program();
        await program.ConnectionStream();
    }

    private async Task ConnectionStream()
    {
        //instatiate Json
        var json = string.Empty;


        //Start filestreamer and streamreader JSON data from the Config.json file. (stored in Debug)
        using (var fs = File.OpenRead("Config.json"))
        using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = await sr.ReadToEndAsync().ConfigureAwait(false);


        //Deserialize the targeted data (Config.json) file.
        var configJson = JsonConvert.DeserializeObject<Connection>(json);
        //set config to be a type of connection, and then setting variables == eachother.
        var config = new Connection
        {
            MainUrl = configJson.MainUrl,
            APIKey = configJson.APIKey,
            
        };

        
      
        //This is the final string, this combines the target URL and includes the API key.
        string TargetUrl = config.MainUrl+config.APIKey;


        //Gets the response of the client for the targeted url.
        string response = await client.GetStringAsync(TargetUrl);


        //Class of POCOS, therefore deserializing the object data into the POCO class of response (being the website we are connected to)
        POCOS pocos = JsonConvert.DeserializeObject<POCOS>(response);


        //Print out pocos, this will give us our Override ToString values.
        Console.WriteLine(pocos);


        //Keep program interface clear and open until user wants to exit.
        Console.ReadLine();


    }


}