using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Discord;
using Qurre;
using Qurre.API;
using Qurre.API.Events;
using Qurre.Events.Modules;
using Player = Qurre.API.Player;
using Round = Qurre.Events.Round;
using Server = Qurre.Events.Server;

namespace SCPSwap
{
    public class Plug : Plugin
    {
        public override string Developer => "ohayo!#5601";
        public override string Name => "SCPSwap";
        public override Version Version => new Version(1, 0, 0);
        public override int Priority => int.MinValue;
        public static DateTime whenStart;

        private Plug instance;
        public Plug getInstanse()
        {
            return instance;
        }

        public override void Enable()
        {
            instance = this;

            ConfigManager.registerCfg();

            if (ConfigManager.SCPSwap_enable == false)
            {
                Log.Error(" > the " + Name + " is disabled because you disabled it in the config");
                return;
            }

            Round.Start += onRoundStart;
            Server.SendingConsole += onConsoleSend;

            Log.Info(" " + Name + " enabled :)");
            Log.Info(" version: " + Version);
            Log.Info(" dev: " + Developer);
            Log.Info(" site: www.rootkovskiy.ovh");
        }

        public override void Disable()
        {
            instance = null;

            Round.Start -= onRoundStart;
            Server.SendingConsole -= onConsoleSend;

            Log.Info(" " + Name + " disabled :(");
            Log.Info(" version: " + Version);
            Log.Info(" dev: " + Developer);
            Log.Info(" site: www.rootkovskiy.ovh");
        }

        public void onRoundStart()
        {
            if (ConfigManager.SCPSwap_enableBroadcast)
            {
                List<Player> inRoundSCPs = (from p in Player.List where p.Team == Team.SCP select p).ToList<Player>();
                foreach (Player p in inRoundSCPs)
                {
                    p.Broadcast(ConfigManager.SCPSwap_Broadcast, ConfigManager.SCPSwap_timeBroadcast);
                }
            }
            whenStart = DateTime.Now;
        }

        public void onConsoleSend(SendingConsoleEvent ev)
        {
            if (ev.Name == ConfigManager.SCPSwap_command)
            {
                ev.Allowed = false;
                if ((DateTime.Now - whenStart).TotalSeconds < ConfigManager.SCPSwap_time)
                {
                    if (ev.Player.Team == Team.SCP)
                    {
                        List<Player> inRoundSCPs = (from p in Player.List where p.Team == Team.SCP select p).ToList<Player>();
                        switch (ev.Args[0])
                        {
                            case "info":
                                ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_argInfo, "green");
                                return;
                            case "173":
                                if (ev.Player.Role == RoleType.Scp173)
                                {
                                    ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyThatSCP, "red");
                                    return;
                                }
                                foreach(Player p in inRoundSCPs)
                                {
                                    if (p.Role == RoleType.Scp173)
                                    {
                                        ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyBusySCP, "red");
                                        return;
                                    }
                                }
                                ev.Player.Role = RoleType.Scp173;
                                ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_Successfully, "green");
                                return;
                            case "096":
                                if (ev.Player.Role == RoleType.Scp096)
                                {
                                    ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyThatSCP, "red");
                                    return;
                                }
                                foreach (Player p in inRoundSCPs)
                                {
                                    if (p.Role == RoleType.Scp096)
                                    {
                                        ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyBusySCP, "red");
                                        return;
                                    }
                                }
                                ev.Player.Role = RoleType.Scp096;
                                ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_Successfully, "green");
                                return;
                            case "079":
                                if (ev.Player.Role == RoleType.Scp079)
                                {
                                    ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyThatSCP, "red");
                                    return;
                                }
                                foreach (Player p in inRoundSCPs)
                                {
                                    if (p.Role == RoleType.Scp079)
                                    {
                                        ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyBusySCP, "red");
                                        return;
                                    }
                                }
                                ev.Player.Role = RoleType.Scp079;
                                ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_Successfully, "green");
                                return;
                            case "106":
                                if (ev.Player.Role == RoleType.Scp106)
                                {
                                    ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyThatSCP, "red");
                                    return;
                                }
                                foreach (Player p in inRoundSCPs)
                                {
                                    if (p.Role == RoleType.Scp106)
                                    {
                                        ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyBusySCP, "red");
                                        return;
                                    }
                                }
                                ev.Player.Role = RoleType.Scp106;
                                ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_Successfully, "green");
                                return;
                            case "049":
                                if (ev.Player.Role == RoleType.Scp049)
                                {
                                    ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyThatSCP, "red");
                                    return;
                                }
                                foreach (Player p in inRoundSCPs)
                                {
                                    if (p.Role == RoleType.Scp049)
                                    {
                                        ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyBusySCP, "red");
                                        return;
                                    }
                                }
                                ev.Player.Role = RoleType.Scp049;
                                ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_Successfully, "green");
                                return;
                            case "939":
                                if (ev.Player.Role == RoleType.Scp93953 || ev.Player.Role == RoleType.Scp93989)
                                {
                                    ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyThatSCP, "red");
                                    return;
                                }
                                foreach (Player p in inRoundSCPs)
                                {
                                    if (p.Role == RoleType.Scp93953 || p.Role == RoleType.Scp93989)
                                    {
                                        ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_alreadyBusySCP, "red");
                                        return;
                                    }
                                }
                                ev.Player.Role = RoleType.Scp93953;
                                ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_Successfully, "green");
                                return;
                            default:
                                ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_usage, "red");
                                return;
                        }
                    } else
                    {
                        ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_scpOnly, "red");
                        return;
                    }
                } else
                {
                    ev.Player.SendConsoleMessage(ConfigManager.SCPSwap_muchTime, "red");
                    return;
                }
            }
        }
    }
}

