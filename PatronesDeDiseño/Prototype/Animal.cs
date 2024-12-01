namespace PatronesDeDiseño.Prototype;

public class Animal : ICloneable
{
    public int Patas { get; set; }
    public string Nombre { get; set; }
    
    //Clonacion superficial - shallow: Clona solo atributos de esta clase basicos no objetos complejos
    
    public object Clone()
    {
        return MemberwiseClone();
    }
}