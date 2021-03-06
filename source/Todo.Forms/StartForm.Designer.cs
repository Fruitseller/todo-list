﻿namespace Todo.Forms
{
    partial class StartForm
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
			this.todoListButton = new System.Windows.Forms.Button();
			this.newContactButton = new System.Windows.Forms.Button();
			this.contactListButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// todoListButton
			// 
			this.todoListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.todoListButton.Location = new System.Drawing.Point(561, 44);
			this.todoListButton.Name = "todoListButton";
			this.todoListButton.Size = new System.Drawing.Size(100, 100);
			this.todoListButton.TabIndex = 0;
			this.todoListButton.Text = "TODO-Liste";
			this.todoListButton.UseVisualStyleBackColor = true;
			this.todoListButton.Click += new System.EventHandler(this.todoListButton_Click);
			// 
			// newContactButton
			// 
			this.newContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.newContactButton.Location = new System.Drawing.Point(691, 44);
			this.newContactButton.Name = "newContactButton";
			this.newContactButton.Size = new System.Drawing.Size(100, 45);
			this.newContactButton.TabIndex = 1;
			this.newContactButton.Text = "Neuer Kontakt";
			this.newContactButton.UseVisualStyleBackColor = true;
			this.newContactButton.Click += new System.EventHandler(this.newContactButton_Click);
			// 
			// contactListButton
			// 
			this.contactListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.contactListButton.Location = new System.Drawing.Point(691, 99);
			this.contactListButton.Name = "contactListButton";
			this.contactListButton.Size = new System.Drawing.Size(100, 45);
			this.contactListButton.TabIndex = 2;
			this.contactListButton.Text = "Kontakt-Liste";
			this.contactListButton.UseVisualStyleBackColor = true;
			this.contactListButton.Click += new System.EventHandler(this.contactListButton_Click);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Todo.Forms.Properties.Resources.BGStartForm;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(833, 561);
			this.Controls.Add(this.contactListButton);
			this.Controls.Add(this.newContactButton);
			this.Controls.Add(this.todoListButton);
			this.Name = "StartForm";
			this.Text = "Start";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onclose);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button todoListButton;
        private System.Windows.Forms.Button newContactButton;
        private System.Windows.Forms.Button contactListButton;
    }
}

