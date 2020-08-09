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
using Newtonsoft.Json;

namespace DiscordWebHookWF
{
	public partial class Form1 : Form
	/*
	 * Добавить поддержку токенов, DM-каналов, и текстовых каналов.
	 */
	{
		public List<Misc.Preset> presets;
		List<Control> controls;

		private void reloadComboBox()
		{
			this.WebHookComboBox.Items.Clear();

			for (int i = 0; i < presets.Count; i++)
			{
				if (presets[i].name == null)
				{
					presets.RemoveAt(i);
					continue;
				}

				this.WebHookComboBox.Items.Add(presets[i].name);
			}
		}

		public Form1()
		{
			InitializeComponent();

			var _presets = File.Exists(Program.ConfigFileName) ? JsonConvert.DeserializeObject<Misc.Presets>(File.ReadAllText(Program.ConfigFileName)) : new Misc.Presets();

			if (presets != null)
            {
				presets = _presets.presets;
            } else if (presets == null)
            {
				presets = new List<Misc.Preset>();
            }

			reloadComboBox();
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
				//DiscordWebhookClient webhookClient = new DiscordWebhookClient(hooks[WebHookComboBox.SelectedIndex]._WebHook);
				//await webhookClient.SendMessageAsync(text: TextTextBox.Text, username: NameTextBox.Text, avatarUrl: AvatarTextBox.Text, embeds: new Embed[] { embed });

				//webhookClient.Dispose();

				MessageBox.Show("Нажмите кнопку \"Выбрать\"");
			} else if (InputTokenRadioButton.Checked)
			{
				if (_client == null) // Если сменить токен после отправки, отправлять будет всё-равно на прошлый токен
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
			new SavePresetForm(this).ShowDialog();

			reloadComboBox();
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
				DeleteThisPresetButton.Enabled = true;
				SelectButton.Enabled = true;
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
			controls.Add(SelectButton);
			controls.Add(DeleteThisPresetButton);

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
		private void SelectButton_Click(object sender, EventArgs e)
		{
			//try
			//{
			this.EmbedEnabled.Checked = presets[WebHookComboBox.SelectedIndex].embedEnabled;
			this.AuthorEnabled.Checked = presets[WebHookComboBox.SelectedIndex].authorEnabled;
			this.FooterEnabled.Checked = presets[WebHookComboBox.SelectedIndex].footerEnabled;
			//((RadioButton)this.controls.Where(control => control.Name.Contains(presets[WebHookComboBox.SelectedIndex].radioButtonChecked)).ToList()[0]).Checked = true;
			//((RadioButton)this.controls.Where(control => control.Name.Contains(presets[WebHookComboBox.SelectedIndex].radioButton2Checked)).ToList()[0]).Checked = true;
				
			if (presets[WebHookComboBox.SelectedIndex].radioButton2Checked == Misc.RadioBTNS.ChannelIdBTN)
			{
				this.GuildChannelRadioButton.Checked = true;
			} else if (presets[WebHookComboBox.SelectedIndex].radioButton2Checked == Misc.RadioBTNS.UserIdBTN)
            {
				this.UserRadioButton.Checked = true;
            }

			if (presets[WebHookComboBox.SelectedIndex].radioButtonChecked == Misc.RadioBTNS.WebHookBTN)
            {
				this.InputWebHookRadioBtn.Checked = true;
            } else if (presets[WebHookComboBox.SelectedIndex].radioButtonChecked == Misc.RadioBTNS.TokenBTN)
            {
				this.InputTokenRadioButton.Checked = true;
            } else if (presets[WebHookComboBox.SelectedIndex].radioButtonChecked == Misc.RadioBTNS.ChooseBTN)
            {
				this.ChooseWebHookRadioBtn.Checked = true;
            }
			
			this.InputWebHookTextBox.Text = presets[WebHookComboBox.SelectedIndex].webhook;
			this.TokenTextBox.Text = presets[WebHookComboBox.SelectedIndex].token;
			this.ChannelIdTextBox.Text = presets[WebHookComboBox.SelectedIndex].channelId;
			this.UserIdTextBox.Text = presets[WebHookComboBox.SelectedIndex].userId;
			this.AuthorIconUrlTextBox.Text = presets[WebHookComboBox.SelectedIndex].authorIcon;
			this.AuthorUrlTextBox.Text = presets[WebHookComboBox.SelectedIndex].authorUrl;
			this.AuthorText.Text = presets[WebHookComboBox.SelectedIndex].authorText;
			this.NameTextBox.Text = presets[WebHookComboBox.SelectedIndex].miscName;
			this.AvatarTextBox.Text = presets[WebHookComboBox.SelectedIndex].miscAvatar;
			this.TextTextBox.Text = presets[WebHookComboBox.SelectedIndex].miscText;
			this.FooterIconUrl.Text = presets[WebHookComboBox.SelectedIndex].footerIcon;
			this.FooterText.Text = presets[WebHookComboBox.SelectedIndex].footerText;
			this.EmbedNameTextBox.Text = presets[WebHookComboBox.SelectedIndex].embedName;
			this.colorDialog1.Color = System.Drawing.Color.FromArgb(int.Parse(presets[WebHookComboBox.SelectedIndex].embedColor));
			this.DescriptionTextBox.Text = presets[WebHookComboBox.SelectedIndex].embedDescription;
			this.ImageUrl.Text = presets[WebHookComboBox.SelectedIndex].embedImage;

			this.WebHookComboBox.Text = null;
			//} catch { }
		}
		private void tokenChanged(object sender, EventArgs e)
		{
			_client = null;
		}
		private void DeleteThisPresetButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.presets.RemoveAt(this.WebHookComboBox.SelectedIndex);

				var newJson = JsonConvert.SerializeObject(new Misc.Presets { presets = this.presets });
				File.WriteAllText(Program.ConfigFileName, newJson);

				this.WebHookComboBox.Text = null;

				reloadComboBox();
			} catch { }
		}
	}
}
