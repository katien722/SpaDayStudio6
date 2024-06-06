using Microsoft.AspNetCore.Mvc;

namespace SpaDayStudio6;

public class UserController : Controller
{
 [HttpGet("/user/add")]
 public IActionResult Add()
 {
    return View("Add");
 }

[HttpPost("/user/add")]   

 public IActionResult SubmitAddUserForm(User newUser, string verify) 
 {
   if(verify==newUser.Password)
   {
    ViewBag.name=newUser.Username;
    return View("Index");

   }   
   else
   {
      return View("Add");      
            // add form submission handling code here
   }
}
}
