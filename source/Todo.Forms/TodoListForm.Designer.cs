namespace Todo.Forms
{
    partial class TodoListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoListForm));
            this.todoListTreeView = new System.Windows.Forms.TreeView();
            this.newTodoListButton = new System.Windows.Forms.Button();
            this.newEntryButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.startDateTitle = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTitle = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityElement = new System.Windows.Forms.NumericUpDown();
            this.choosenContactTitle = new System.Windows.Forms.Label();
            this.descriptionTitle = new System.Windows.Forms.Label();
            this.doneCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.AssignedContactsListbox = new System.Windows.Forms.ListBox();
            this.right_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.priorityElement)).BeginInit();
            this.SuspendLayout();
            // 
            // todoListTreeView
            // 
            this.todoListTreeView.ImageIndex = 0;
            this.todoListTreeView.ImageList = this.imageList2;
            this.todoListTreeView.Location = new System.Drawing.Point(13, 13);
            this.todoListTreeView.Name = "todoListTreeView";
            this.todoListTreeView.SelectedImageIndex = 0;
            this.todoListTreeView.Size = new System.Drawing.Size(299, 465);
            this.todoListTreeView.TabIndex = 0;
            this.todoListTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.After_Edit);
            this.todoListTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.After_Select);
            // 
            // newTodoListButton
            // 
            this.newTodoListButton.Location = new System.Drawing.Point(13, 484);
            this.newTodoListButton.Name = "newTodoListButton";
            this.newTodoListButton.Size = new System.Drawing.Size(121, 40);
            this.newTodoListButton.TabIndex = 1;
            this.newTodoListButton.Text = "Neuen Todozweig anhängen";
            this.newTodoListButton.UseVisualStyleBackColor = true;
            this.newTodoListButton.Click += new System.EventHandler(this.newTodoListButton_Click);
            // 
            // newEntryButton
            // 
            this.newEntryButton.Location = new System.Drawing.Point(491, 509);
            this.newEntryButton.Name = "newEntryButton";
            this.newEntryButton.Size = new System.Drawing.Size(147, 40);
            this.newEntryButton.TabIndex = 2;
            this.newEntryButton.Text = "Neuen Termin speichern";
            this.newEntryButton.UseVisualStyleBackColor = true;
            this.newEntryButton.Click += new System.EventHandler(this.newEntryButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(191, 484);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Element Löschen";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(319, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Titel";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(405, 13);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 5;
            // 
            // startDateTitle
            // 
            this.startDateTitle.AutoSize = true;
            this.startDateTitle.Location = new System.Drawing.Point(319, 50);
            this.startDateTitle.Name = "startDateTitle";
            this.startDateTitle.Size = new System.Drawing.Size(58, 13);
            this.startDateTitle.TabIndex = 6;
            this.startDateTitle.Text = "Startdatum";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(405, 50);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(142, 20);
            this.startDatePicker.TabIndex = 7;
            // 
            // endDateTitle
            // 
            this.endDateTitle.AutoSize = true;
            this.endDateTitle.Location = new System.Drawing.Point(319, 88);
            this.endDateTitle.Name = "endDateTitle";
            this.endDateTitle.Size = new System.Drawing.Size(55, 13);
            this.endDateTitle.TabIndex = 8;
            this.endDateTitle.Text = "Enddatum";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(405, 88);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(142, 20);
            this.endDatePicker.TabIndex = 9;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(319, 131);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(42, 13);
            this.priorityLabel.TabIndex = 10;
            this.priorityLabel.Text = "Priorität";
            // 
            // priorityElement
            // 
            this.priorityElement.Location = new System.Drawing.Point(405, 131);
            this.priorityElement.Name = "priorityElement";
            this.priorityElement.Size = new System.Drawing.Size(40, 20);
            this.priorityElement.TabIndex = 11;
            // 
            // choosenContactTitle
            // 
            this.choosenContactTitle.AutoSize = true;
            this.choosenContactTitle.Location = new System.Drawing.Point(402, 167);
            this.choosenContactTitle.Name = "choosenContactTitle";
            this.choosenContactTitle.Size = new System.Drawing.Size(50, 13);
            this.choosenContactTitle.TabIndex = 13;
            this.choosenContactTitle.Text = "Kontakte";
            // 
            // descriptionTitle
            // 
            this.descriptionTitle.AutoSize = true;
            this.descriptionTitle.Location = new System.Drawing.Point(318, 367);
            this.descriptionTitle.Name = "descriptionTitle";
            this.descriptionTitle.Size = new System.Drawing.Size(72, 13);
            this.descriptionTitle.TabIndex = 15;
            this.descriptionTitle.Text = "Beschreibung";
            // 
            // doneCheckBox
            // 
            this.doneCheckBox.AutoSize = true;
            this.doneCheckBox.Location = new System.Drawing.Point(405, 509);
            this.doneCheckBox.Name = "doneCheckBox";
            this.doneCheckBox.Size = new System.Drawing.Size(61, 17);
            this.doneCheckBox.TabIndex = 17;
            this.doneCheckBox.Text = "Erledigt";
            this.doneCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(405, 367);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(233, 136);
            this.descriptionBox.TabIndex = 19;
            this.descriptionBox.Text = "";
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(405, 183);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(100, 147);
            this.ContactsListBox.TabIndex = 20;
            // 
            // AssignedContactsListbox
            // 
            this.AssignedContactsListbox.FormattingEnabled = true;
            this.AssignedContactsListbox.Location = new System.Drawing.Point(538, 183);
            this.AssignedContactsListbox.Name = "AssignedContactsListbox";
            this.AssignedContactsListbox.Size = new System.Drawing.Size(100, 147);
            this.AssignedContactsListbox.TabIndex = 21;
            // 
            // right_button
            // 
            this.right_button.Location = new System.Drawing.Point(511, 211);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(21, 23);
            this.right_button.TabIndex = 22;
            this.right_button.Text = ">";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // left_button
            // 
            this.left_button.Location = new System.Drawing.Point(511, 269);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(21, 23);
            this.left_button.TabIndex = 23;
            this.left_button.Text = "<";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Zugwiesen";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "calendar.png");
            this.imageList2.Images.SetKeyName(1, "clipboard45.png");
            this.imageList2.Images.SetKeyName(2, "communities.png");
            // 
            // TodoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.AssignedContactsListbox);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.doneCheckBox);
            this.Controls.Add(this.descriptionTitle);
            this.Controls.Add(this.choosenContactTitle);
            this.Controls.Add(this.priorityElement);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.endDateTitle);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.startDateTitle);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newEntryButton);
            this.Controls.Add(this.newTodoListButton);
            this.Controls.Add(this.todoListTreeView);
            this.Name = "TodoListForm";
            this.Text = "TODO-Listen";
            ((System.ComponentModel.ISupportInitialize)(this.priorityElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView todoListTreeView;
        private System.Windows.Forms.Button newTodoListButton;
        private System.Windows.Forms.Button newEntryButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label startDateTitle;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endDateTitle;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.NumericUpDown priorityElement;
        private System.Windows.Forms.Label choosenContactTitle;
        private System.Windows.Forms.Label descriptionTitle;
        private System.Windows.Forms.CheckBox doneCheckBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.ListBox AssignedContactsListbox;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}