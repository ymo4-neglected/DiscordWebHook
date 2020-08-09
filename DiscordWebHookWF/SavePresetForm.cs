using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DiscordWebHookWF
{
    public partial class SavePresetForm : Form
    {
        public Form1 form;

        public SavePresetForm(Form1 _form)
        {
            InitializeComponent();

            form = _form;
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var newPreset = new Misc.Preset
            {
                token = form.TokenTextBox.Text,
                webhook = form.InputWebHookTextBox.Text,
                userId = form.UserIdTextBox.Text,
                channelId = form.ChannelIdTextBox.Text,
                authorEnabled = form.AuthorEnabled.Checked,
                embedEnabled = form.EmbedEnabled.Checked,
                footerEnabled = form.FooterEnabled.Checked,
                authorIcon = form.AuthorIconUrlTextBox.Text,
                footerIcon = form.FooterIconUrl.Text,
                authorText = form.AuthorText.Text,
                authorUrl = form.AuthorUrlTextBox.Text,
                footerText = form.FooterText.Text,
                miscText = form.TextTextBox.Text,
                miscName = form.NameTextBox.Text,
                miscAvatar = form.AvatarTextBox.Text,
                embedDescription = form.DescriptionTextBox.Text,
                embedImage = form.ImageUrl.Text,
                embedColor = form.colorDialog1.Color.ToArgb().ToString(),
                embedName = form.EmbedNameTextBox.Text,
                name = this.PresetNameTextBox.Text
            };

            if (form.InputWebHookRadioBtn.Checked)
                newPreset.radioButtonChecked = Misc.RadioBTNS.WebHookBTN;
            else if (form.InputTokenRadioButton.Checked)
                newPreset.radioButtonChecked = Misc.RadioBTNS.TokenBTN;
            else if (form.ChooseWebHookRadioBtn.Checked)
                newPreset.radioButtonChecked = Misc.RadioBTNS.ChooseBTN;

            if (form.UserRadioButton.Checked)
                newPreset.radioButton2Checked = Misc.RadioBTNS.UserIdBTN;
            else if (form.GuildChannelRadioButton.Checked)
                newPreset.radioButton2Checked = Misc.RadioBTNS.ChannelIdBTN;
            
            this.form.presets.Add(newPreset);

            var newJson = JsonConvert.SerializeObject(new Misc.Presets { presets=this.form.presets });
            File.WriteAllText(Program.ConfigFileName, newJson);

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
    }
}
