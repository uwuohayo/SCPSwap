using System;

namespace SCPSwap
{
    public class ConfigManager
    {
        public static bool SCPSwap_enable;
        public static int SCPSwap_time;

        public static String SCPSwap_command;

        public static bool SCPSwap_enableBroadcast;
        public static ushort SCPSwap_timeBroadcast;
        public static String SCPSwap_Broadcast;

        public static String SCPSwap_muchTime;
        public static String SCPSwap_scpOnly;
        public static String SCPSwap_usage;

        public static String SCPSwap_argInfo;
        public static String SCPSwap_alreadyThatSCP;
        public static String SCPSwap_alreadyBusySCP;
        public static String SCPSwap_Successfully;

        public static void registerCfg()
        {
            SCPSwap_enable = Plug.Config.GetBool("SCPSwap_enable", true, "on or off SCPSwap?");
            SCPSwap_time = Plug.Config.GetInt("SCPSwap_time", 60, "time from the start of the round in seconds after which it will be impossible to use scpswap");

            SCPSwap_command = Plug.Config.GetString("SCPSwap_command", "scpswap", "command to use scpswap");

            SCPSwap_enableBroadcast = Plug.Config.GetBool("SCPSwap_enableBroadcast", true, "on or off start broadcast with info about scpswap?");
            SCPSwap_timeBroadcast = Plug.Config.GetUShort("SCPSwap_timeBroadcast", 15, "time for broadcast");
            SCPSwap_Broadcast = Plug.Config.GetString("SCPSwap_Broadcast", "You can use command .scpswap at the round start!\nJust write it in Game Console", "broadcast info");

            SCPSwap_muchTime = Plug.Config.GetString("SCPSwap_muchTime", "This command can no longer be used", "message wnen the time to use the command has run out");
            SCPSwap_scpOnly = Plug.Config.GetString("SCPSwap_scpOnly", "This command can only be used by SCP", "message that is shown when a command is entered by a non scp player");
            SCPSwap_usage = Plug.Config.GetString("SCPSwap_usage", "Invalid usage: .scpswap [info|<SCP_NUM>]", "message when player send invalid usage");

            SCPSwap_argInfo = Plug.Config.GetString("SCPSwap_argInfo", "List of SCPs: 173, 096, 079, 106, 049, 939", "message when player send [.scpswap info]");
            SCPSwap_alreadyThatSCP = Plug.Config.GetString("SCPSwap_alreadyThatSCP", "You are already that SCP", "sent if the player has indicated the scp that he himself is");
            SCPSwap_alreadyBusySCP = Plug.Config.GetString("SCPSwap_alreadyBusySCP", "You can't become this SCP because it's already there", "sent when the player's chosen scp is busy");
            SCPSwap_Successfully = Plug.Config.GetString("SCPSwap_Successfully", "Successfully", "sent when the command succeeds");
        }
    }
}

