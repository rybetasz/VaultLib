﻿// This file is part of VaultLib by heyitsleo.
// 
// Created: 09/27/2019 @ 4:45 PM.

using VaultLib.Core.Data;
using VaultLib.Core.Types;
using VaultLib.Core.Types.Attrib.Gen;

namespace VaultLib.Support.Undercover.VLT.Attrib.Gen
{
    [VLTTypeInfo("Attrib::Gen::ClassRefSpec_car_damage_objects")]
    public class ClassRefSpec_car_damage_objects : ClassRefSpec_template
    {
        public ClassRefSpec_car_damage_objects(VltClass @class, VltClassField field, VltCollection collection) : base(@class, field, collection, "car_damage_objects")
        {
        }

        public ClassRefSpec_car_damage_objects(VltClass @class, VltClassField field) : base(@class, field, "car_damage_objects")
        {
        }
    }
}