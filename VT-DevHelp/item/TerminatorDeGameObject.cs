﻿using Mirror;
using Synapse.Api.Enum;
using Synapse.Api.Events.SynapseEventArguments;
using Synapse.Api.Items;
using UnityEngine;
using VT_Referance.ItemScript;

namespace VTDevHelp
{
    internal class TerminatorDeGameObject : BaseWeaponScript
    {
        public override float Weight => 0.01f; 

        public override ushort Ammos => 100;

        public override AmmoType AmmoType => AmmoType.Ammo556x45;

        public override int ID => 300;

        public override ItemType ItemType => ItemType.GunCOM18;

        public override string Name => "TerminatorDeGameObject";

        public override int DamageAmmont => throw new System.NotImplementedException();

        // public override DamageTypes.DamageType DamageType => DamageTypes.Wall;

        // public override float ArmorPenetration => 0;

        // public override bool UseHitboxMultipliers => false;

        protected override void Shoot(PlayerShootEventArgs ev)
        {
            NetworkServer.UnSpawn(ev.Player.LookingAt);
            GameObject.Destroy(ev.Player.LookingAt);
        }
    }
}