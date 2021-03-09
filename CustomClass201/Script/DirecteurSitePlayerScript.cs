﻿using Synapse.Config;
using System.Collections.Generic;
using VT_Referance.Variable;

namespace CustomClass.PlayerScript
{
    public class DirecteurSiteScript : BasePlayerScript
    {
        protected override List<int> EnemysList => new List<int> { (int)Team.CHI, (int)Team.SCP };

        protected override List<int> FriendsList => new List<int> { (int)Team.MTF, (int)Team.RSC };

        protected override RoleType RoleType => RoleType.Scientist;

        protected override int RoleTeam => (int)Team.RSC;

        protected override int RoleId => (int)RoleID.DirecteurSite;

        protected override string RoleName => PluginClass.ConfigDirecteurSite.RoleName;

        protected override AbstractConfigSection Config => PluginClass.ConfigConcierge;
    }
}