﻿using System.Collections.Generic;
public class UserViewModel
{
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public IEnumerable<string> Roles { get; set; }
}