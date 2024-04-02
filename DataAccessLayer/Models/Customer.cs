﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
