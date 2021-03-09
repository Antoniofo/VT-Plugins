﻿using Synapse;
using Synapse.Api.Events.SynapseEventArguments;
using Synapse.Config;
using System;
using System.Collections.Generic;
using VT_Referance.Variable;

namespace CustomClass.PlayerScript
{
    public class NTFExpertReconfinementScript : BasePlayerScript
    {
        protected override List<int> EnemysList => new List<int> { (int)Team.CHI, (int)Team.SCP };

        protected override List<int> FriendsList => new List<int> { (int)Team.MTF, (int)Team.RSC };

        protected override RoleType RoleType => RoleType.NtfLieutenant;

        protected override int RoleTeam => (int)Team.MTF;

        protected override int RoleId => (int)RoleID.NTFExpertReconfinement;

        protected override string RoleName => PluginClass.ConfigNTFExpertReconfinement.RoleName;

        protected override AbstractConfigSection Config => PluginClass.ConfigNTFExpertReconfinement;

        protected override void Event()
        {
            Server.Get.Events.Scp.Scp096.Scp096AddTargetEvent += OnTarget;
            Server.Get.Events.Player.PlayerDamageEvent += OnDamage;
        }

        private void OnDamage(PlayerDamageEventArgs ev)
        {
            if (ev.Killer == Player && ev.Victim.RoleID == (int)RoleType.Scp096)
                ev.Victim.Scp096Controller.AddTarget(Player);
        }

        private void OnTarget(Scp096AddTargetEventArgument ev)
        {
            if (ev.Player == Player)
                ev.Allow = false;
        }
    }
}