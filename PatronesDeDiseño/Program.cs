// See https://aka.ms/new-console-template for more information

using PatronesDeDiseño.Prototype;
using PatronesDeDiseño.Singleton;

#region Singleton
// Console.WriteLine(Singleton.Instance.GetMessage());
// Console.WriteLine(Singleton.Instance.SetMessage("pepito"));
// Console.WriteLine(Singleton.Instance.GetMessage());
#endregion

#region Prototype
Animal oAnimal = new Animal{ Nombre = "Oveja" , Patas = 4};
Animal oAnimalClonado = oAnimal.Clone() as Animal;
oAnimalClonado.Patas = 5;
Console.WriteLine(oAnimalClonado.Patas);
Console.WriteLine(oAnimal.Patas);
#endregion
