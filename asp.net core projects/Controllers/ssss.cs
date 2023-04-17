using Microsoft.AspNetCore.Mvc;
namespace WebApplication6.Controllers;

[ApiController]
[Route("api/[controller],[action]")]

public class ReversController:ControllerBase
{
    
    [HttpGet]
    public string Reverse(string name )
    {

        char[] charArray = name.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
        
    }
    
  


}