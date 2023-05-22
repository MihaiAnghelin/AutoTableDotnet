namespace AutoTableDotnet.DTOs;

public class ServiceResultDTO
{
    public object Data { get; set; } = null!;
    public string Error { get; set; } = string.Empty;
    public int StatusCode { get; set; }
}