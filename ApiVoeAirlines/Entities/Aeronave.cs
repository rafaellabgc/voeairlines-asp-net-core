namespace ApiVoeAirlines.Entities;

public class Aeronave {
    public int Id { get; set; }
    public string? Fabricante { get; set; }
    public string? Modelo { get; set; }
    public string? Codigo { get; set; }
    public int Tipo { get; set; }
}