
global using Microsoft.AspNetCore.Mvc;
global using OnCallDeveloperApi.Models;

namespace OnCallDeveloperApi
{ 
    public record GetOnCallDeveloperResponse(
    string Name, string Phone, string Email)
{

}

    public class GlobalUsings
    {
    }
}
