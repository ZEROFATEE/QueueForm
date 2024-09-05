namespace QueueForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            add = new Button();
            remove = new Button();
            Input = new TextBox();
            listofthings = new ListBox();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(53, 296);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 0;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            remove.Location = new Point(134, 296);
            remove.Name = "remove";
            remove.Size = new Size(75, 23);
            remove.TabIndex = 1;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // Input
            // 
            Input.Location = new Point(53, 118);
            Input.Name = "Input";
            Input.Size = new Size(100, 23);
            Input.TabIndex = 3;
            Input.TextChanged += Input_TextChanged;
            // 
            // listofthings
            // 
            listofthings.FormattingEnabled = true;
            listofthings.ItemHeight = 15;
            listofthings.Location = new Point(53, 158);
            listofthings.Name = "listofthings";
            listofthings.Size = new Size(197, 94);
            listofthings.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listofthings);
            Controls.Add(Input);
            Controls.Add(remove);
            Controls.Add(add);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private Button remove;
        private TextBox Input;
        private ListBox listofthings;
    }
}
