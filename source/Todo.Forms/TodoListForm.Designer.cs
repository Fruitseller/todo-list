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
			this.todoListView = new System.Windows.Forms.TreeView();
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
			this.chooseContactsButton = new System.Windows.Forms.Button();
			this.choosenContactTitle = new System.Windows.Forms.Label();
			this.descriptionTitle = new System.Windows.Forms.Label();
			this.saveCheckBox = new System.Windows.Forms.CheckBox();
			this.choosenContactsBox = new System.Windows.Forms.RichTextBox();
			this.descriptionBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.priorityElement)).BeginInit();
			this.SuspendLayout();
			// 
			// todoListView
			// 
			this.todoListView.Location = new System.Drawing.Point(12, 12);
			this.todoListView.Name = "todoListView";
			this.todoListView.Size = new System.Drawing.Size(300, 450);
			this.todoListView.TabIndex = 0;
			// 
			// newTodoListButton
			// 
			this.newTodoListButton.Location = new System.Drawing.Point(13, 484);
			this.newTodoListButton.Name = "newTodoListButton";
			this.newTodoListButton.Size = new System.Drawing.Size(146, 40);
			this.newTodoListButton.TabIndex = 1;
			this.newTodoListButton.Text = "Neue TODO-Liste";
			this.newTodoListButton.UseVisualStyleBackColor = true;
			// 
			// newEntryButton
			// 
			this.newEntryButton.Location = new System.Drawing.Point(165, 484);
			this.newEntryButton.Name = "newEntryButton";
			this.newEntryButton.Size = new System.Drawing.Size(147, 40);
			this.newEntryButton.TabIndex = 2;
			this.newEntryButton.Text = "Neuer Eintrag";
			this.newEntryButton.UseVisualStyleBackColor = true;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(100, 530);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(121, 40);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.Text = "Löschen";
			this.deleteButton.UseVisualStyleBackColor = true;
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
			this.titleTextBox.Location = new System.Drawing.Point(434, 13);
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
			this.startDatePicker.Location = new System.Drawing.Point(434, 50);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.Size = new System.Drawing.Size(200, 20);
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
			this.endDatePicker.Location = new System.Drawing.Point(434, 88);
			this.endDatePicker.Name = "endDatePicker";
			this.endDatePicker.Size = new System.Drawing.Size(200, 20);
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
			this.priorityElement.Location = new System.Drawing.Point(434, 131);
			this.priorityElement.Name = "priorityElement";
			this.priorityElement.Size = new System.Drawing.Size(40, 20);
			this.priorityElement.TabIndex = 11;
			// 
			// chooseContactsButton
			// 
			this.chooseContactsButton.Location = new System.Drawing.Point(434, 176);
			this.chooseContactsButton.Name = "chooseContactsButton";
			this.chooseContactsButton.Size = new System.Drawing.Size(120, 23);
			this.chooseContactsButton.TabIndex = 12;
			this.chooseContactsButton.Text = "Kontakte auswählen";
			this.chooseContactsButton.UseVisualStyleBackColor = true;
			// 
			// choosenContactTitle
			// 
			this.choosenContactTitle.AutoSize = true;
			this.choosenContactTitle.Location = new System.Drawing.Point(319, 223);
			this.choosenContactTitle.Name = "choosenContactTitle";
			this.choosenContactTitle.Size = new System.Drawing.Size(101, 13);
			this.choosenContactTitle.TabIndex = 13;
			this.choosenContactTitle.Text = "betroffene Kontakte";
			// 
			// descriptionTitle
			// 
			this.descriptionTitle.AutoSize = true;
			this.descriptionTitle.Location = new System.Drawing.Point(319, 326);
			this.descriptionTitle.Name = "descriptionTitle";
			this.descriptionTitle.Size = new System.Drawing.Size(72, 13);
			this.descriptionTitle.TabIndex = 15;
			this.descriptionTitle.Text = "Beschreibung";
			// 
			// saveCheckBox
			// 
			this.saveCheckBox.AutoSize = true;
			this.saveCheckBox.Location = new System.Drawing.Point(434, 484);
			this.saveCheckBox.Name = "saveCheckBox";
			this.saveCheckBox.Size = new System.Drawing.Size(61, 17);
			this.saveCheckBox.TabIndex = 17;
			this.saveCheckBox.Text = "Erledigt";
			this.saveCheckBox.UseVisualStyleBackColor = true;
			// 
			// choosenContactsBox
			// 
			this.choosenContactsBox.Location = new System.Drawing.Point(434, 223);
			this.choosenContactsBox.Name = "choosenContactsBox";
			this.choosenContactsBox.Size = new System.Drawing.Size(200, 59);
			this.choosenContactsBox.TabIndex = 18;
			this.choosenContactsBox.Text = "";
			// 
			// descriptionBox
			// 
			this.descriptionBox.Location = new System.Drawing.Point(434, 326);
			this.descriptionBox.Name = "descriptionBox";
			this.descriptionBox.Size = new System.Drawing.Size(200, 136);
			this.descriptionBox.TabIndex = 19;
			this.descriptionBox.Text = "";
			// 
			// TodoListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 628);
			this.Controls.Add(this.descriptionBox);
			this.Controls.Add(this.choosenContactsBox);
			this.Controls.Add(this.saveCheckBox);
			this.Controls.Add(this.descriptionTitle);
			this.Controls.Add(this.choosenContactTitle);
			this.Controls.Add(this.chooseContactsButton);
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
			this.Controls.Add(this.todoListView);
			this.Name = "TodoListForm";
			this.Text = "TODO-Listen";
			((System.ComponentModel.ISupportInitialize)(this.priorityElement)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView todoListView;
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
		private System.Windows.Forms.Button chooseContactsButton;
		private System.Windows.Forms.Label choosenContactTitle;
		private System.Windows.Forms.Label descriptionTitle;
		private System.Windows.Forms.CheckBox saveCheckBox;
		private System.Windows.Forms.RichTextBox choosenContactsBox;
		private System.Windows.Forms.RichTextBox descriptionBox;
	}
}