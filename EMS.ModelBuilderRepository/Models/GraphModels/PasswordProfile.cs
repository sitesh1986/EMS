﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.ModelBuilderRepository.Models.GraphModel
{
    public class PasswordProfile
    {
        public string password { get; set; }
        public bool forceChangePasswordNextLogin { get; set; }
    }
}
