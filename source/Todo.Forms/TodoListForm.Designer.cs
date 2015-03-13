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
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.newTodoListButton = new System.Windows.Forms.Button();
			this.newEntryButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 12);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(300, 450);
			this.treeView1.TabIndex = 0;
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
			// TodoListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 628);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.newEntryButton);
			this.Controls.Add(this.newTodoListButton);
			this.Controls.Add(this.treeView1);
			this.Name = "TodoListForm";
			this.Text = "TODO-Listen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button newTodoListButton;
		private System.Windows.Forms.Button newEntryButton;
		private System.Windows.Forms.Button deleteButton;
	}
}