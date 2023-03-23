using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.DTO.DTO
{
    public class AssetInsert
    {
        public AssetDTO Asset { get; set; }
        public AssetType AssetType { get; set; }
        public BrandModel Brand { get; set; }
        public AssetOwner AssetOwner { get; set; }
        public Currency Currency { get; set; }






    }
}
