﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAwayNight.Application.Features.CQRS.Commands.AdressCommands
{
    public class CreateAdressCommand
    {
        
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
