﻿using System;
using System.Collections.Generic;

namespace Assignment.UserService.DatabaseModels
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
    }
}
