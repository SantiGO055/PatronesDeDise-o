// See https://aka.ms/new-console-template for more information

using PatronesDeDiseño.Singleton;

Console.WriteLine(Singleton.Instance.GetMessage());
Console.WriteLine(Singleton.Instance.SetMessage("pepito"));
Console.WriteLine(Singleton.Instance.GetMessage());
