﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs.Application.Features.Technologies.Dtos
{
    public class CreateTechnologyDto
    {
        public int  Id { get; set; }

        public string Name { get; set; }
        public string ProgrammingLanguageName { get; set; }
        
    }
}
