﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.DTO.DTO
{
    public class ActionStatus
    {
        public int ID { get; set; }
        public int AssetActionID { get; set; }
        public int StatusID { get; set; }
        public bool IsActive { get; set; }
    }
}
