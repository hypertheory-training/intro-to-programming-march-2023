global using OnCallDeveloperApi.Models;
global using Microsoft.AspNetCore.Mvc;


namespace OnCallDeveloperApi.Models;

public  record GetOnCallDeveloperResponse(
string Name, string Phone, string Email)
{

}
