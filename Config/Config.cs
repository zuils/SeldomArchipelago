using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace SeldomArchipelago.Config
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("Common")]

        [Label("Name")]
        [DefaultValue("")]
        public string name;

        [Label("Port")]
        [Range(0, 65535)]
        [DefaultValue(38281)]
        public int port;

        [Header("Advanced")]

        [Label("Server Address")]
        [DefaultValue("archipelago.gg")]
        public string address;

        [Label("Password")]
        [DefaultValue("")]
        public string password;
        [Header("Chat")]

        [Label("Color AP Text")]
        [DefaultValue(true)]
        public bool colorText;

        [Label("Adjust Filter")]
        [Dropdown]
        public ChatSetting chatSettings;

        [Header("Miscellaneous")]

        [DefaultValue(false)]
        public bool hardmodeAsItem;
    }
    public enum ChatSetting
    {
        All,
        Grey,
        Filter,
        Disable
    }
}