using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.DTO.DTO
{
    public class AssetBarcode
    {
        public int ID { get; set; }
        public int AssetID { get; set; }
        public string Barcode { get; set; }
        public bool IsActive { get; set; }
    }
}
