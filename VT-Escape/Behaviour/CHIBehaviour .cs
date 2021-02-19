﻿using Mirror;
using Synapse.Api;
using System.Linq;
using UnityEngine;

namespace VTEscape
{
    public class CHIEscape : NetworkBehaviour
    {
        private Player player;
        public bool Enabled = true;
        private float _timer;
        private Vector3 _Escape = new Vector3(-56.2f, 988.9f, -49.6f);

        private void Awake()
        {
            player = gameObject.GetPlayer();
        }

        private void Update()
        {
            _timer += Time.deltaTime;

            if (Enabled && _timer > 1f)
            {
                if (Vector3.Distance(base.transform.position, _Escape) < 1)
                {
                    var configEscape = Plugin.Config.EscapeList.FirstOrDefault(p => player.RoleID == (int)p.Role
                        && EscapeEnum.CHI == p.Escape && player.Cuffer == p.Handcuffed);
                    if (configEscape != null)
                    {
                        if (configEscape.StartWarHead == true)
                            Method.WarHeadEscape(3);
                        if (configEscape.EscapeMessage != null)
                            Map.Get.Cassie(configEscape.EscapeMessage, false);
                        player.Inventory.Clear();
                        player.RoleID = (int)configEscape.NewRole;
                        return;
                    }
                    configEscape = Plugin.Config.EscapeList.FirstOrDefault(p => player.TeamID == (int)p.Team
                        && EscapeEnum.CHI == p.Escape && player.Cuffer == p.Handcuffed);
                    if (configEscape != null)
                    {
                        if (configEscape.StartWarHead == true)
                            Method.WarHeadEscape(3);
                        if (configEscape.EscapeMessage != null)
                            Map.Get.Cassie(configEscape.EscapeMessage, false);
                        player.Inventory.Clear();
                        player.RoleID = (int)configEscape.NewRole;
                        return;
                    }
                    player.Inventory.Clear();
                    player.RoleID = (int)RoleType.Spectator;
                }

            }

            if (_timer > 1f)
                _timer = 0f;
        }
        public void Destroy()
        {
            Enabled = false;
            DestroyImmediate(this, true);
        }
    }
}

