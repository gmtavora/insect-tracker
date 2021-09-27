﻿using System;
using System.Collections.Generic;
public class UserViewModel
{
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string ProfilePicture { get; set; }
    public DateTime DateSigned { get; set; }
    public IEnumerable<string> Roles { get; set; }
}