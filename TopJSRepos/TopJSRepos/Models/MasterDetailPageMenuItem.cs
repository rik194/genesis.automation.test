﻿using System;
using System.Collections.Generic;
using System.Linq;
using TopJSRepos.Views;

namespace TopJSRepos.Models
{

    public class MasterDetailPageMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}