using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebHookWF
{
    class Program
    {
        public static string ConfigFileName = "CFG.json";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Misc
    {
        public class Preset
        {
            public string token, webhook, channelId, userId, miscAvatar, miscName, miscText,
                embedImage, embedColor, embedDescription, authorIcon, authorUrl, authorText, footerIcon, footerText, name, embedName;
            public bool authorEnabled, embedEnabled, footerEnabled;
            public RadioBTNS radioButtonChecked, radioButton2Checked;
        }

        public class Presets
        {
            public List<Preset> presets = new List<Preset>();
        }

        public enum RadioBTNS
        {
            ChooseBTN,
            WebHookBTN,
            TokenBTN,
            UserIdBTN,
            ChannelIdBTN
        }
    }
}
