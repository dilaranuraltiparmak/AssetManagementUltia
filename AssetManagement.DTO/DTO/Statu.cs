﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.DTO.DTO
{
    public class Statu
    {
        public int ID { get; set; }
        public int MasterID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
