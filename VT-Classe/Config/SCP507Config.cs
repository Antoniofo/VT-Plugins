﻿using Synapse.Config;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace CustomClass.Config
{
    public class SCP507Config : AbstractConfigSection, IBaseConfig

    {
        [Description("The MapPoint where SCP507 should Spawn")]
        public SerializedMapPoint SpawnPoint = new SerializedMapPoint("HCZ_Room3ar", -1.792f, 1.330017f, -0.004005589f);

        [Description("The Amount of Health SCP507 has")]
        public int Health = 100;

        [Description("The Items SCP507 spawns with")]
        public List<SerializedItem> Items = new List<SerializedItem>() { new SerializedItem((int)ItemType.Medkit, 35, 0, 0, 0, Vector3.one) };

        [Description("The Chanche of which SCP507 spawns")]
        public int SpawnChance = 25;

        [Description("The Amount of Players Required in order to have the Chanche that SCP507 can spawn")]
        public int RequiredPlayers = 0;

        [Description("The name of the SCP507")]
        public string RoleName = "NONE";

        [Description("The Amount of Health SCP507 has")]
        public int ArtificialHealth = 0;

        [Description("The Amount of Health SCP507 has")]
        public int MaxArtificialHealth = 100;

        [Description("The Amount of Health SCP507 has")]
        public bool loseArtificialHealth = false;

        [Description("The Name Tag is visible or invisible")]
        public bool ShowTag = false;

        public SerializedMapPoint ConfigSpawnPoint => SpawnPoint;
        public int ConfigHealth => Health;
        public List<SerializedItem> ConfigItems => Items;
        public int ConfigSpawnChance => SpawnChance;
        public int ConfigRequiredPlayers => RequiredPlayers;
        public string ConfigRoleName => RoleName;
        public int ConfigArtificialHealth => ArtificialHealth;
        public int ConfigMaxArtificialHealth => MaxArtificialHealth;
        public bool ConfigloseArtificialHealth => loseArtificialHealth;
        public bool CongifShowTag => ShowTag;
    }
}
