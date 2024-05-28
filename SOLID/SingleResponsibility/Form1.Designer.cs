namespace SingleResponsibility
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
            textBoxProductName = new TextBox();
            textBoxPrice = new TextBox();
            buttonCreate = new Button();
            buttonChangeBackColor = new Button();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(42, 57);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(100, 23);
            textBoxProductName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(42, 86);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(100, 125);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Ürün Ekle";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonChangeBackColor
            // 
            buttonChangeBackColor.Location = new Point(166, 239);
            buttonChangeBackColor.Name = "buttonChangeBackColor";
            buttonChangeBackColor.Size = new Size(117, 23);
            buttonChangeBackColor.TabIndex = 3;
            buttonChangeBackColor.Text = "Renk değiştir";
            buttonChangeBackColor.UseVisualStyleBackColor = true;
            buttonChangeBackColor.Click += buttonChangeBackColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 274);
            Controls.Add(buttonChangeBackColor);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxProductName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductName;
        private TextBox textBoxPrice;
        private Button buttonCreate;
        private Button buttonChangeBackColor;
    }
}
