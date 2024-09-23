using System.Text.RegularExpressions;
namespace Fundamentos_de_C_Sharp.plateAuthenticator;


public class AuthenticatorPlate
{
    public string Plate { get; set; }
    public AuthenticatorPlate(string plate)
    {
        Plate = plate;
    }

    public bool Authenticator()
    {
        string pattern = @"^[a-zA-Z]{3}[0-9]{4}$";

        return Regex.IsMatch(Plate, pattern);
     
  
    }
}
