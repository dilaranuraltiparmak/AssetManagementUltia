﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.DTO.DTO
{
    public class Personel
    {
        public int ID { get; set; }
        public int MasterID { get; set; }
        public bool IsTeam { get; set; }
        public string Name { get; set; }
        public int CompanyID { get; set; }
        public bool IsActive { get; set; }
    }
}
