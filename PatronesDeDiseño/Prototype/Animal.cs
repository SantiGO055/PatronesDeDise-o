namespace PatronesDeDiseño.Prototype;

public class Animal : ICloneable
{
    public int Patas { get; set; }
    public string Nombre { get; set; }
    
    /// <summary>
    /// Clonacion superficial - Shallow:
    /// </summary>
    /// <returns>Objeto clonado con sus atributos</returns>
    public object Clone()
    {
        return MemberwiseClone();
    }
}