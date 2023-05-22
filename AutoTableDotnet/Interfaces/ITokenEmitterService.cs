namespace AutoTableDotnet.Interfaces;

public interface ITokenEmitterService
{
    string GenerateAuthToken(string userId);
}