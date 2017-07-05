﻿using System.Collections.Generic;
using GTA;
using Newtonsoft.Json;

namespace GT_MP_vehicleInfo.Data
{
    public class VehicleData : IHashable, ILocalizable
    {

        public VehicleHash hash;
        public string name;
        public string displayName;
        public string localizedName;
        public string manufacturerName;
        public string localizedManufacturer;

        public bool convertible;
        public bool electric;
        public bool trailer;
        //public bool neon;
        
        public int vehicleClass;
        public string vehicleClassName;
        public string localizedVehicleClass;
        
        public Dictionary<int, ModTypeData> mods;
        public VehicleLiveries liveries;

        public void Hash()
        {
            this.hash = (VehicleHash) Game.GenerateHash(name);
        }

        public void Localize()
        {
            
        }
    }
}