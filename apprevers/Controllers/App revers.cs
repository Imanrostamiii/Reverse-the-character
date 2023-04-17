using Microsoft.AspNetCore.Mvc;

namespace App_Revers.Controllers;
[ApiController]
[Route("api/[controller],[action]")]
public class App_revers:ControllerBase
{
   [HttpGet]
   public string Reverse(string name )
   {
   
       char[] charArray = name.ToCharArray();
       Array.Reverse(charArray);
       return new string(charArray);
           
   }
}
