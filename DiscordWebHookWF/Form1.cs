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
using Discord;
using Discord.Webhook;
using System.Threading;
using Discord.WebSocket;
using System.Net.Sockets;
using Discord.Rest;

namespace DiscordWebHookWF
{
    public partial class Form1 : Form
    /*
     * Добавить поддержку токенов, DM-каналов, и текстовых каналов.
     */
    {
        List<WebHook> hooks;
        List<Control> controls;

        public Form1()
        {
            InitializeComponent();

            //hooks = File.Exists("WebHookConfig.json") ? JsonConvert.DeserializeObject<WebHooks>(File.ReadAllText("WebHookConfig.json")) : new WebHooks();
        }

        DiscordSocketClient _client;

        async private void SendButton_Click(object sender, EventArgs e)
        {
            Embed embed = null;

            if (EmbedEnabled.Checked)
            {
                EmbedBuilder builder = new EmbedBuilder();
                builder.Title = EmbedNameTextBox.Text;
                builder.Description = DescriptionTextBox.Text;
                builder.Color = (Discord.Color?)colorDialog1.Color;
                builder.ImageUrl = ImageUrl.Text;

                if (AuthorEnabled.Checked)
                    builder.WithAuthor(new EmbedAuthorBuilder().WithIconUrl(AuthorIconUrlTextBox.Text).WithName(AuthorText.Text).WithUrl(AuthorUrlTextBox.Text));

                if (FooterEnabled.Checked)
                    builder.WithFooter(new EmbedFooterBuilder().WithIconUrl(FooterIconUrl.Text).WithText(FooterText.Text));

                embed = builder.Build();
            }

            if (InputWebHookRadioBtn.Checked)
            {
                DiscordWebhookClient webhookClient = new DiscordWebhookClient(InputWebHookTextBox.Text);
                await webhookClient.SendMessageAsync(text: TextTextBox.Text, username: NameTextBox.Text, avatarUrl: AvatarTextBox.Text, embeds: new Embed[] { embed });

                webhookClient.Dispose();
            } else if (ChooseWebHookRadioBtn.Checked)
            {
                DiscordWebhookClient webhookClient = new DiscordWebhookClient(hooks[WebHookComboBox.SelectedIndex]._WebHook);
                await webhookClient.SendMessageAsync(text: TextTextBox.Text, username: NameTextBox.Text, avatarUrl: AvatarTextBox.Text, embeds: new Embed[] { embed });

                webhookClient.Dispose();
            } else if (InputTokenRadioButton.Checked)
            {
                if (_client == null)
                {
                    _client = new DiscordSocketClient();
                    await _client.LoginAsync(0, TokenTextBox.Text); // TokenType.User = 0
                    await _client.StartAsync();

                    while (_client.ConnectionState != Discord.ConnectionState.Connected)
                    {
                        await Task.Delay(500);
                    }
                }

                if (GuildChannelRadioButton.Checked) // Guild Channel
                {
                    var channel = _client
                        .GetChannel(ulong.Parse(ChannelIdTextBox.Text));

                    await ((IMessageChannel)channel).SendMessageAsync(TextTextBox.Text, embed: embed);
                } else if (UserRadioButton.Checked) // User channel
                {
                    SocketUser user = _client
                        .GetUser(ulong.Parse(UserIdTextBox.Text));

                    await user.SendMessageAsync(TextTextBox.Text, embed: embed);
                }
            }
        }
        private void EmbedEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (EmbedEnabled.Checked == false)
            {
                foreach (Control control in EmbedGroupBox.Controls)
                {
                    control.Enabled = false;
                }

                AuthorGroupBox.Enabled = false;
                FooterGroupBox.Enabled = false;

                EmbedEnabled.Enabled = true;
            }
            else if (EmbedEnabled.Checked == true)
            {
                AuthorGroupBox.Enabled = true;
                FooterGroupBox.Enabled = true;

                foreach (Control control in EmbedGroupBox.Controls)
                {
                    control.Enabled = true;
                }
            }
        }
        private void ColorChangeBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                colorDialog1.Reset();

            ColorLabel.ForeColor = colorDialog1.Color;
        }
        private void AuthorEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (AuthorEnabled.Checked == false)
            {
                foreach (Control control2 in AuthorGroupBox.Controls)
                {
                    control2.Enabled = false;
                }

                AuthorEnabled.Enabled = true;
            }
            else if (AuthorEnabled.Checked == true)
            {
                foreach (Control control1 in AuthorGroupBox.Controls)
                {
                    control1.Enabled = true;
                }
            }
        }
        private void FooterEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (FooterEnabled.Checked == false)
            {
                foreach (Control control2 in FooterGroupBox.Controls)
                {
                    control2.Enabled = false;
                }

                FooterEnabled.Enabled = true;
            }
            else if (FooterEnabled.Checked == true)
            {
                foreach (Control control2 in FooterGroupBox.Controls)
                {
                    control2.Enabled = true;
                }
            }
        }
        private void SaveSettingsToConfigButton_Click(object sender, EventArgs e)
        {
            new SavePresetForm().ShowDialog();
        }
        private void ChooseStatusAllControls(List<Control> _controls, bool status)
        {
            foreach (Control control in _controls)
                control.Enabled = status;
        }
        private void ChooseWebHookRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChooseWebHookRadioBtn.Checked)
            {
                ChooseStatusAllControls(controls, false);
                WebHookComboBox.Enabled = true;
                PresetComboBox.Enabled = true;
            }
        }
        private void FromClosing(object sender, FormClosingEventArgs e)
        {
            //File.WriteAllText("WebHookConfig.json", JsonConvert.SerializeObject(hooks));
        }
        private void InputTokenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InputTokenRadioButton.Checked)
            {
                ChooseStatusAllControls(controls, false);
                TokenTextBox.Enabled = true;
                this.DmGuildPanel.Enabled = true;

                this.GuildChannelRadioButton_CheckedChanged(this, new EventArgs());
                this.UserRadioButton_CheckedChanged(this, new EventArgs());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            controls = this.Controls.OfType<TextBox>().ToList<Control>();
            controls.Add(WebHookComboBox);
            controls.Add(PresetComboBox);
            controls.Add(DmGuildPanel);

            this.EmbedEnabled_CheckedChanged(this, new EventArgs());
            this.FooterEnabled_CheckedChanged(this, new EventArgs());
            this.AuthorEnabled_CheckedChanged(this, new EventArgs());

            this.ChooseWebHookRadioBtn_CheckedChanged(this, new EventArgs());
            this.InputTokenRadioButton_CheckedChanged(this, new EventArgs());
            this.InputWebHookRadioBtn_CheckedChanged(this, new EventArgs());
        }
        private void InputWebHookRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (InputWebHookRadioBtn.Checked)
            {
                ChooseStatusAllControls(controls, false);
                InputWebHookTextBox.Enabled = true;
            }
        }
        private void GuildChannelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GuildChannelRadioButton.Checked)
            {
                ChannelIdTextBox.Enabled = true;

                UserIdTextBox.Enabled = false;
            }
        }
        private void UserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UserRadioButton.Checked)
            {
                ChannelIdTextBox.Enabled = false;

                UserIdTextBox.Enabled = true;
            }
        }
    }

    public class Preset
    {
        public string WebHookName, AvatarUrl, Text, AuthorIconUrl, AuthorUrl, AuthorText, EmbedName, EmbedDescription, FooterIconUrl, FooterText, EmbedImageUrl;
        public bool FooterEnabled, EmbedEnabled, AuthorEnabled;
        public System.Drawing.Color color;
    }

    public class WebHook
    {
        public string _WebHook;
        public List<Preset> presets;
    }
}
