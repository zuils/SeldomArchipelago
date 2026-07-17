using System.ComponentModel;
using System.Runtime.Serialization;
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
        [OnDeserialized]
        internal void CheckItems(StreamingContext _)
        {
            name = name.Trim(' ', '\n', '\t');
            address = address.Trim(' ', '\n', '\t');
            password = password.Trim(' ', '\n', '\t');
        }
    }
    public enum ChatSetting
    {
        All,
        Grey,
        Filter,
        Disable
    }
}