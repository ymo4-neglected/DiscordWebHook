namespace DiscordWebHookWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.EmbedGroupBox = new System.Windows.Forms.GroupBox();
            this.EmbedNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ColorChangeBtn = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ImageUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmbedEnabled = new System.Windows.Forms.CheckBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ChooseWebHookRadioBtn = new System.Windows.Forms.RadioButton();
            this.InputWebHookRadioBtn = new System.Windows.Forms.RadioButton();
            this.InputWebHookTextBox = new System.Windows.Forms.TextBox();
            this.WebHookComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AvatarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AuthorGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthorUrlTextBox = new System.Windows.Forms.TextBox();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.AuthorIconUrlTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AuthorEnabled = new System.Windows.Forms.CheckBox();
            this.FooterGroupBox = new System.Windows.Forms.GroupBox();
            this.FooterEnabled = new System.Windows.Forms.CheckBox();
            this.FooterText = new System.Windows.Forms.TextBox();
            this.FooterIconUrl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SavePresetToConfigButton = new System.Windows.Forms.Button();
            this.PresetComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InputTokenRadioButton = new System.Windows.Forms.RadioButton();
            this.ChannelIdTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TokenTextBox = new System.Windows.Forms.TextBox();
            this.GuildChannelRadioButton = new System.Windows.Forms.RadioButton();
            this.DmGuildPanel = new System.Windows.Forms.Panel();
            this.UserRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.DeleteThisPresetButton = new System.Windows.Forms.Button();
            this.EmbedGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AuthorGroupBox.SuspendLayout();
            this.FooterGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DmGuildPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 562);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(735, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send!";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // EmbedGroupBox
            // 
            this.EmbedGroupBox.Controls.Add(this.EmbedNameTextBox);
            this.EmbedGroupBox.Controls.Add(this.label7);
            this.EmbedGroupBox.Controls.Add(this.ColorChangeBtn);
            this.EmbedGroupBox.Controls.Add(this.ColorLabel);
            this.EmbedGroupBox.Controls.Add(this.ImageUrl);
            this.EmbedGroupBox.Controls.Add(this.label4);
            this.EmbedGroupBox.Controls.Add(this.label3);
            this.EmbedGroupBox.Controls.Add(this.EmbedEnabled);
            this.EmbedGroupBox.Controls.Add(this.DescriptionTextBox);
            this.EmbedGroupBox.Location = new System.Drawing.Point(12, 266);
            this.EmbedGroupBox.Name = "EmbedGroupBox";
            this.EmbedGroupBox.Size = new System.Drawing.Size(735, 290);
            this.EmbedGroupBox.TabIndex = 1;
            this.EmbedGroupBox.TabStop = false;
            this.EmbedGroupBox.Text = "Embed";
            // 
            // EmbedNameTextBox
            // 
            this.EmbedNameTextBox.Location = new System.Drawing.Point(401, 16);
            this.EmbedNameTextBox.Name = "EmbedNameTextBox";
            this.EmbedNameTextBox.Size = new System.Drawing.Size(328, 20);
            this.EmbedNameTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(287, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Embed name:";
            // 
            // ColorChangeBtn
            // 
            this.ColorChangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorChangeBtn.Location = new System.Drawing.Point(62, 38);
            this.ColorChangeBtn.Name = "ColorChangeBtn";
            this.ColorChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ColorChangeBtn.TabIndex = 13;
            this.ColorChangeBtn.Text = "Выбрать";
            this.ColorChangeBtn.UseVisualStyleBackColor = true;
            this.ColorChangeBtn.Click += new System.EventHandler(this.ColorChangeBtn_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(6, 40);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(50, 20);
            this.ColorLabel.TabIndex = 12;
            this.ColorLabel.Text = "Color:";
            // 
            // ImageUrl
            // 
            this.ImageUrl.Location = new System.Drawing.Point(74, 264);
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.Size = new System.Drawing.Size(655, 20);
            this.ImageUrl.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Image: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(292, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // EmbedEnabled
            // 
            this.EmbedEnabled.AutoSize = true;
            this.EmbedEnabled.Location = new System.Drawing.Point(6, 18);
            this.EmbedEnabled.Name = "EmbedEnabled";
            this.EmbedEnabled.Size = new System.Drawing.Size(65, 17);
            this.EmbedEnabled.TabIndex = 0;
            this.EmbedEnabled.Text = "Enabled";
            this.EmbedEnabled.UseVisualStyleBackColor = true;
            this.EmbedEnabled.CheckedChanged += new System.EventHandler(this.EmbedEnabled_CheckedChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(6, 63);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(723, 195);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // ChooseWebHookRadioBtn
            // 
            this.ChooseWebHookRadioBtn.AutoSize = true;
            this.ChooseWebHookRadioBtn.Checked = true;
            this.ChooseWebHookRadioBtn.Location = new System.Drawing.Point(6, 3);
            this.ChooseWebHookRadioBtn.Name = "ChooseWebHookRadioBtn";
            this.ChooseWebHookRadioBtn.Size = new System.Drawing.Size(142, 17);
            this.ChooseWebHookRadioBtn.TabIndex = 2;
            this.ChooseWebHookRadioBtn.TabStop = true;
            this.ChooseWebHookRadioBtn.Text = "Choose token/webHook";
            this.ChooseWebHookRadioBtn.UseVisualStyleBackColor = true;
            this.ChooseWebHookRadioBtn.CheckedChanged += new System.EventHandler(this.ChooseWebHookRadioBtn_CheckedChanged);
            // 
            // InputWebHookRadioBtn
            // 
            this.InputWebHookRadioBtn.AutoSize = true;
            this.InputWebHookRadioBtn.Location = new System.Drawing.Point(6, 26);
            this.InputWebHookRadioBtn.Name = "InputWebHookRadioBtn";
            this.InputWebHookRadioBtn.Size = new System.Drawing.Size(111, 17);
            this.InputWebHookRadioBtn.TabIndex = 3;
            this.InputWebHookRadioBtn.Text = "Написать вебхук";
            this.InputWebHookRadioBtn.UseVisualStyleBackColor = true;
            this.InputWebHookRadioBtn.CheckedChanged += new System.EventHandler(this.InputWebHookRadioBtn_CheckedChanged);
            // 
            // InputWebHookTextBox
            // 
            this.InputWebHookTextBox.Location = new System.Drawing.Point(163, 34);
            this.InputWebHookTextBox.Name = "InputWebHookTextBox";
            this.InputWebHookTextBox.Size = new System.Drawing.Size(578, 20);
            this.InputWebHookTextBox.TabIndex = 4;
            // 
            // WebHookComboBox
            // 
            this.WebHookComboBox.FormattingEnabled = true;
            this.WebHookComboBox.Location = new System.Drawing.Point(163, 11);
            this.WebHookComboBox.Name = "WebHookComboBox";
            this.WebHookComboBox.Size = new System.Drawing.Size(369, 21);
            this.WebHookComboBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AvatarTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Text: ";
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(79, 71);
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.Size = new System.Drawing.Size(650, 20);
            this.TextTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Avatar: ";
            // 
            // AvatarTextBox
            // 
            this.AvatarTextBox.Location = new System.Drawing.Point(79, 45);
            this.AvatarTextBox.Name = "AvatarTextBox";
            this.AvatarTextBox.Size = new System.Drawing.Size(650, 20);
            this.AvatarTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name: ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(79, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(650, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // AuthorGroupBox
            // 
            this.AuthorGroupBox.Controls.Add(this.AuthorUrlTextBox);
            this.AuthorGroupBox.Controls.Add(this.AuthorText);
            this.AuthorGroupBox.Controls.Add(this.AuthorIconUrlTextBox);
            this.AuthorGroupBox.Controls.Add(this.label10);
            this.AuthorGroupBox.Controls.Add(this.label9);
            this.AuthorGroupBox.Controls.Add(this.label8);
            this.AuthorGroupBox.Controls.Add(this.AuthorEnabled);
            this.AuthorGroupBox.Location = new System.Drawing.Point(753, 11);
            this.AuthorGroupBox.Name = "AuthorGroupBox";
            this.AuthorGroupBox.Size = new System.Drawing.Size(492, 217);
            this.AuthorGroupBox.TabIndex = 8;
            this.AuthorGroupBox.TabStop = false;
            this.AuthorGroupBox.Text = "Author";
            // 
            // AuthorUrlTextBox
            // 
            this.AuthorUrlTextBox.Location = new System.Drawing.Point(107, 174);
            this.AuthorUrlTextBox.Name = "AuthorUrlTextBox";
            this.AuthorUrlTextBox.Size = new System.Drawing.Size(379, 20);
            this.AuthorUrlTextBox.TabIndex = 7;
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(107, 194);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(379, 20);
            this.AuthorText.TabIndex = 6;
            // 
            // AuthorIconUrlTextBox
            // 
            this.AuthorIconUrlTextBox.Location = new System.Drawing.Point(107, 154);
            this.AuthorIconUrlTextBox.Name = "AuthorIconUrlTextBox";
            this.AuthorIconUrlTextBox.Size = new System.Drawing.Size(379, 20);
            this.AuthorIconUrlTextBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "URL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Text:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Icon URL:";
            // 
            // AuthorEnabled
            // 
            this.AuthorEnabled.AutoSize = true;
            this.AuthorEnabled.Location = new System.Drawing.Point(6, 19);
            this.AuthorEnabled.Name = "AuthorEnabled";
            this.AuthorEnabled.Size = new System.Drawing.Size(65, 17);
            this.AuthorEnabled.TabIndex = 1;
            this.AuthorEnabled.Text = "Enabled";
            this.AuthorEnabled.UseVisualStyleBackColor = true;
            this.AuthorEnabled.CheckedChanged += new System.EventHandler(this.AuthorEnabled_CheckedChanged);
            // 
            // FooterGroupBox
            // 
            this.FooterGroupBox.Controls.Add(this.FooterEnabled);
            this.FooterGroupBox.Controls.Add(this.FooterText);
            this.FooterGroupBox.Controls.Add(this.FooterIconUrl);
            this.FooterGroupBox.Controls.Add(this.label13);
            this.FooterGroupBox.Controls.Add(this.label12);
            this.FooterGroupBox.Location = new System.Drawing.Point(753, 234);
            this.FooterGroupBox.Name = "FooterGroupBox";
            this.FooterGroupBox.Size = new System.Drawing.Size(492, 322);
            this.FooterGroupBox.TabIndex = 2;
            this.FooterGroupBox.TabStop = false;
            this.FooterGroupBox.Text = "Footer";
            // 
            // FooterEnabled
            // 
            this.FooterEnabled.AutoSize = true;
            this.FooterEnabled.Location = new System.Drawing.Point(6, 19);
            this.FooterEnabled.Name = "FooterEnabled";
            this.FooterEnabled.Size = new System.Drawing.Size(65, 17);
            this.FooterEnabled.TabIndex = 0;
            this.FooterEnabled.Text = "Enabled";
            this.FooterEnabled.UseVisualStyleBackColor = true;
            this.FooterEnabled.CheckedChanged += new System.EventHandler(this.FooterEnabled_CheckedChanged);
            // 
            // FooterText
            // 
            this.FooterText.Location = new System.Drawing.Point(107, 296);
            this.FooterText.Name = "FooterText";
            this.FooterText.Size = new System.Drawing.Size(379, 20);
            this.FooterText.TabIndex = 12;
            // 
            // FooterIconUrl
            // 
            this.FooterIconUrl.Location = new System.Drawing.Point(107, 276);
            this.FooterIconUrl.Name = "FooterIconUrl";
            this.FooterIconUrl.Size = new System.Drawing.Size(379, 20);
            this.FooterIconUrl.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Icon URL:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Text:";
            // 
            // SavePresetToConfigButton
            // 
            this.SavePresetToConfigButton.Location = new System.Drawing.Point(753, 562);
            this.SavePresetToConfigButton.Name = "SavePresetToConfigButton";
            this.SavePresetToConfigButton.Size = new System.Drawing.Size(492, 23);
            this.SavePresetToConfigButton.TabIndex = 9;
            this.SavePresetToConfigButton.Text = "Save preset to config";
            this.SavePresetToConfigButton.UseVisualStyleBackColor = true;
            this.SavePresetToConfigButton.Click += new System.EventHandler(this.SaveSettingsToConfigButton_Click);
            // 
            // PresetComboBox
            // 
            this.PresetComboBox.FormattingEnabled = true;
            this.PresetComboBox.Location = new System.Drawing.Point(167, 147);
            this.PresetComboBox.Name = "PresetComboBox";
            this.PresetComboBox.Size = new System.Drawing.Size(574, 21);
            this.PresetComboBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.74F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Choose preset: ";
            // 
            // InputTokenRadioButton
            // 
            this.InputTokenRadioButton.AutoSize = true;
            this.InputTokenRadioButton.Location = new System.Drawing.Point(6, 49);
            this.InputTokenRadioButton.Name = "InputTokenRadioButton";
            this.InputTokenRadioButton.Size = new System.Drawing.Size(79, 17);
            this.InputTokenRadioButton.TabIndex = 12;
            this.InputTokenRadioButton.Text = "Input token";
            this.InputTokenRadioButton.UseVisualStyleBackColor = true;
            this.InputTokenRadioButton.CheckedChanged += new System.EventHandler(this.InputTokenRadioButton_CheckedChanged);
            // 
            // ChannelIdTextBox
            // 
            this.ChannelIdTextBox.Location = new System.Drawing.Point(196, 86);
            this.ChannelIdTextBox.Name = "ChannelIdTextBox";
            this.ChannelIdTextBox.Size = new System.Drawing.Size(545, 20);
            this.ChannelIdTextBox.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(130, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Channel id:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChooseWebHookRadioBtn);
            this.panel1.Controls.Add(this.InputWebHookRadioBtn);
            this.panel1.Controls.Add(this.InputTokenRadioButton);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 69);
            this.panel1.TabIndex = 21;
            // 
            // TokenTextBox
            // 
            this.TokenTextBox.Location = new System.Drawing.Point(163, 57);
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.Size = new System.Drawing.Size(578, 20);
            this.TokenTextBox.TabIndex = 22;
            this.TokenTextBox.TextChanged += new System.EventHandler(this.tokenChanged);
            // 
            // GuildChannelRadioButton
            // 
            this.GuildChannelRadioButton.AutoSize = true;
            this.GuildChannelRadioButton.Checked = true;
            this.GuildChannelRadioButton.Location = new System.Drawing.Point(3, 3);
            this.GuildChannelRadioButton.Name = "GuildChannelRadioButton";
            this.GuildChannelRadioButton.Size = new System.Drawing.Size(112, 17);
            this.GuildChannelRadioButton.TabIndex = 24;
            this.GuildChannelRadioButton.TabStop = true;
            this.GuildChannelRadioButton.Text = "Guild\\DM channel";
            this.GuildChannelRadioButton.UseVisualStyleBackColor = true;
            this.GuildChannelRadioButton.CheckedChanged += new System.EventHandler(this.GuildChannelRadioButton_CheckedChanged);
            // 
            // DmGuildPanel
            // 
            this.DmGuildPanel.Controls.Add(this.GuildChannelRadioButton);
            this.DmGuildPanel.Controls.Add(this.UserRadioButton);
            this.DmGuildPanel.Location = new System.Drawing.Point(12, 83);
            this.DmGuildPanel.Name = "DmGuildPanel";
            this.DmGuildPanel.Size = new System.Drawing.Size(114, 45);
            this.DmGuildPanel.TabIndex = 26;
            // 
            // UserRadioButton
            // 
            this.UserRadioButton.AutoSize = true;
            this.UserRadioButton.Location = new System.Drawing.Point(3, 24);
            this.UserRadioButton.Name = "UserRadioButton";
            this.UserRadioButton.Size = new System.Drawing.Size(47, 17);
            this.UserRadioButton.TabIndex = 25;
            this.UserRadioButton.Text = "User";
            this.UserRadioButton.UseVisualStyleBackColor = true;
            this.UserRadioButton.CheckedChanged += new System.EventHandler(this.UserRadioButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "User Id:";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(196, 108);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(545, 20);
            this.UserIdTextBox.TabIndex = 27;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(647, 9);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(95, 23);
            this.SelectButton.TabIndex = 29;
            this.SelectButton.Text = "Выбрать";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // DeleteThisPresetButton
            // 
            this.DeleteThisPresetButton.Location = new System.Drawing.Point(538, 9);
            this.DeleteThisPresetButton.Name = "DeleteThisPresetButton";
            this.DeleteThisPresetButton.Size = new System.Drawing.Size(103, 23);
            this.DeleteThisPresetButton.TabIndex = 30;
            this.DeleteThisPresetButton.Text = "Delete this preset";
            this.DeleteThisPresetButton.UseVisualStyleBackColor = true;
            this.DeleteThisPresetButton.Click += new System.EventHandler(this.DeleteThisPresetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 589);
            this.Controls.Add(this.DeleteThisPresetButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.TokenTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ChannelIdTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PresetComboBox);
            this.Controls.Add(this.SavePresetToConfigButton);
            this.Controls.Add(this.FooterGroupBox);
            this.Controls.Add(this.AuthorGroupBox);
            this.Controls.Add(this.EmbedGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WebHookComboBox);
            this.Controls.Add(this.InputWebHookTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DmGuildPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EmbedGroupBox.ResumeLayout(false);
            this.EmbedGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AuthorGroupBox.ResumeLayout(false);
            this.AuthorGroupBox.PerformLayout();
            this.FooterGroupBox.ResumeLayout(false);
            this.FooterGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DmGuildPanel.ResumeLayout(false);
            this.DmGuildPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button SendButton;
        public System.Windows.Forms.GroupBox EmbedGroupBox;
        public System.Windows.Forms.CheckBox EmbedEnabled;
        public System.Windows.Forms.RadioButton ChooseWebHookRadioBtn;
        public System.Windows.Forms.RadioButton InputWebHookRadioBtn;
        public System.Windows.Forms.TextBox InputWebHookTextBox;
        public System.Windows.Forms.ComboBox WebHookComboBox;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox DescriptionTextBox;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.GroupBox AuthorGroupBox;
        public System.Windows.Forms.Button ColorChangeBtn;
        public System.Windows.Forms.Label ColorLabel;
        public System.Windows.Forms.TextBox ImageUrl;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox AuthorEnabled;
        public System.Windows.Forms.GroupBox FooterGroupBox;
        public System.Windows.Forms.CheckBox FooterEnabled;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button SavePresetToConfigButton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox AvatarTextBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TextTextBox;
        public System.Windows.Forms.TextBox EmbedNameTextBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox AuthorUrlTextBox;
        public System.Windows.Forms.TextBox AuthorText;
        public System.Windows.Forms.TextBox AuthorIconUrlTextBox;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox FooterText;
        public System.Windows.Forms.TextBox FooterIconUrl;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox PresetComboBox;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.RadioButton InputTokenRadioButton;
        public System.Windows.Forms.TextBox ChannelIdTextBox;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TokenTextBox;
        public System.Windows.Forms.RadioButton GuildChannelRadioButton;
        public System.Windows.Forms.Panel DmGuildPanel;
        public System.Windows.Forms.RadioButton UserRadioButton;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox UserIdTextBox;
        public System.Windows.Forms.Button SelectButton;
        public System.Windows.Forms.Button DeleteThisPresetButton;
    }
}

