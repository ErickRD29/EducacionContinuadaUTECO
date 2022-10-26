namespace EducacionContinuadaUTECO.Models;

public class Publicaciones
{
    public int IdPublicacion { get; set; }
    public int IdTipo { get; set; }
    public int IdModalidad { get; set; }

    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Costo { get; set; }
    public string Cupo { get; set; }
    public string FechaPublicacion { get; set; }
    public string FechaInicio { get; set; }
    public string FechaExpiracion { get; set; }
    
}