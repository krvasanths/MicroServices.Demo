﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common1.Command
{
    class CreateUser : ICommand
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

    }
}
