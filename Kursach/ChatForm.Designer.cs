namespace Kursach
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxGroupIds = new System.Windows.Forms.ComboBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelgrid = new System.Windows.Forms.Label();
            this.textBoxChat = new System.Windows.Forms.RichTextBox();
            this.labelCurrentGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 457);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(199, 20);
            this.textBoxMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.Location = new System.Drawing.Point(12, 483);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(199, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxGroupIds
            // 
            this.comboBoxGroupIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupIds.FormattingEnabled = true;
            this.comboBoxGroupIds.Location = new System.Drawing.Point(12, 405);
            this.comboBoxGroupIds.Name = "comboBoxGroupIds";
            this.comboBoxGroupIds.Size = new System.Drawing.Size(199, 21);
            this.comboBoxGroupIds.TabIndex = 3;
            this.comboBoxGroupIds.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupIds_SelectedIndexChanged);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(9, 389);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(94, 13);
            this.labelSelect.TabIndex = 4;
            this.labelSelect.Text = "Выберите Группу";
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(9, 441);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(65, 13);
            this.labelMsg.TabIndex = 5;
            this.labelMsg.Text = "Сообщение";
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewGroup.Location = new System.Drawing.Point(12, 564);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(199, 23);
            this.buttonNewGroup.TabIndex = 6;
            this.buttonNewGroup.Text = "Создать";
            this.buttonNewGroup.UseVisualStyleBackColor = true;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(12, 538);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(199, 20);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelgrid
            // 
            this.labelgrid.AutoSize = true;
            this.labelgrid.Location = new System.Drawing.Point(12, 522);
            this.labelgrid.Name = "labelgrid";
            this.labelgrid.Size = new System.Drawing.Size(55, 13);
            this.labelgrid.TabIndex = 8;
            this.labelgrid.Text = "Id группы";
            // 
            // textBoxChat
            // 
            this.textBoxChat.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxChat.Location = new System.Drawing.Point(-1, 24);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ReadOnly = true;
            this.textBoxChat.Size = new System.Drawing.Size(229, 356);
            this.textBoxChat.TabIndex = 9;
            this.textBoxChat.Text = "";
            // 
            // labelCurrentGroup
            // 
            this.labelCurrentGroup.AutoSize = true;
            this.labelCurrentGroup.Location = new System.Drawing.Point(1, 6);
            this.labelCurrentGroup.Name = "labelCurrentGroup";
            this.labelCurrentGroup.Size = new System.Drawing.Size(95, 13);
            this.labelCurrentGroup.TabIndex = 10;
            this.labelCurrentGroup.Text = "Текущая группа: ";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 599);
            this.Controls.Add(this.labelCurrentGroup);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.labelgrid);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonNewGroup);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.comboBoxGroupIds);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чат";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxGroupIds;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button buttonNewGroup;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelgrid;
        private System.Windows.Forms.RichTextBox textBoxChat;
        private System.Windows.Forms.Label labelCurrentGroup;
    }
}