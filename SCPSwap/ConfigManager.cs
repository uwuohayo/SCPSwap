using System;

namespace SCPSwap
{
    public class ConfigManager
    {
        public static bool SCPSwap_enable;
        public static int SCPSwap_time;

        public static void registerCfg()
        {
            SCPSwap_enable = Plug.Config.GetBool("SCPSwap_enable", true, "on or off SCPSwap?");
            SCPSwap_time = Plug.Config.GetInt("SCPSwap_time", 60, "time from the start of the round in seconds after which it will be impossible to use scpswap");
        }
    }
}

