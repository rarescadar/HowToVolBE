﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToVol.Data.Entities
{
    public class UserInterest
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }

}
