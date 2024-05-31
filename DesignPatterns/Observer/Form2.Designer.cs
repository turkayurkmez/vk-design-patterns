namespace Observer
{
    partial class Form2
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
            buttonSubscribe = new Button();
            buttonUnsbuscribe = new Button();
            SuspendLayout();
            // 
            // buttonSubscribe
            // 
            buttonSubscribe.Location = new Point(60, 111);
            buttonSubscribe.Name = "buttonSubscribe";
            buttonSubscribe.Size = new Size(105, 23);
            buttonSubscribe.TabIndex = 0;
            buttonSubscribe.Text = "Abone ol";
            buttonSubscribe.UseVisualStyleBackColor = true;
            buttonSubscribe.Click += buttonSubscribe_Click;
            // 
            // buttonUnsbuscribe
            // 
            buttonUnsbuscribe.Location = new Point(60, 140);
            buttonUnsbuscribe.Name = "buttonUnsbuscribe";
            buttonUnsbuscribe.Size = new Size(105, 23);
            buttonUnsbuscribe.TabIndex = 1;
            buttonUnsbuscribe.Text = "Abonelikten çık";
            buttonUnsbuscribe.UseVisualStyleBackColor = true;
            buttonUnsbuscribe.Click += buttonUnsbuscribe_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 251);
            Controls.Add(buttonUnsbuscribe);
            Controls.Add(buttonSubscribe);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSubscribe;
        private Button buttonUnsbuscribe;
    }
}