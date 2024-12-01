namespace PatronesDeDiseño.Singleton;

public class Singleton
{
    private static Singleton? _instance;
    private string _message = "Hola mundo";
    public static Singleton Instance => _instance ??= new Singleton();
    public string GetMessage() => _message;
    public string SetMessage(string message) => _message = message;
}