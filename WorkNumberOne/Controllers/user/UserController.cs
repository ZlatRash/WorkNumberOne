using Microsoft.AspNetCore.Mvc;
using WorkNumberOne.Models.data.context;
using WorkNumberOne.Models.data.user;

namespace WorkNumberOne.Controllers.user;

public class UserController : Controller
{
    private readonly UserContext _userContext;

    public UserController(UserContext userContext)
    {
        _userContext = userContext;
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userContext.Users.ToList();
        return View(users);
    }
    
    [HttpPost]
    public IActionResult Add(User user)
    {
        var userToAdd = new User
        {
            Id = user.Id,
            Name = user.Name,
            Surname = user.Surname,
            Age = user.Age    ,
            Married = user.Married,
            Gender = user.Gender
        };
        _userContext.Users.Add(userToAdd);
        _userContext.SaveChanges();

        return Redirect("/User/GetAll");
    }

    [HttpPost]
    public IActionResult Delete(long id)
    {
        var user = _userContext.Users.FirstOrDefault(user => user.Id == id);
        if (user == null) return Redirect("/User/GetAll");
        _userContext.Users.Remove(user);
        _userContext.SaveChanges();
        
        return Redirect("/User/GetAll");
    }
}