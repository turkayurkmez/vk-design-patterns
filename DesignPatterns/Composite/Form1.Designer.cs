namespace Composite
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
            TreeNode treeNode7 = new TreeNode("Laptop");
            TreeNode treeNode8 = new TreeNode("Bilgisayar", new TreeNode[] { treeNode7 });
            TreeNode treeNode9 = new TreeNode("5 + 1 ");
            TreeNode treeNode10 = new TreeNode("Bluetooth");
            TreeNode treeNode11 = new TreeNode("Ses sistemi", new TreeNode[] { treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("Kategori", new TreeNode[] { treeNode8, treeNode11 });
            treeView1 = new TreeView();
            treeViewComposite = new TreeView();
            button1 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(27, 103);
            treeView1.Name = "treeView1";
            treeNode7.Name = "Node3";
            treeNode7.Text = "Laptop";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Bilgisayar";
            treeNode9.Name = "Node4";
            treeNode9.Text = "5 + 1 ";
            treeNode10.Name = "Node5";
            treeNode10.Text = "Bluetooth";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Ses sistemi";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Kategori";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode12 });
            treeView1.Size = new Size(193, 172);
            treeView1.TabIndex = 0;
            // 
            // treeViewComposite
            // 
            treeViewComposite.Location = new Point(296, 103);
            treeViewComposite.Name = "treeViewComposite";
            treeViewComposite.Size = new Size(160, 172);
            treeViewComposite.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(316, 285);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(button1);
            Controls.Add(treeViewComposite);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private TreeView treeViewComposite;
        private Button button1;
    }
}
