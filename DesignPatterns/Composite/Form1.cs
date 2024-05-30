namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompositeType<Category> categoryTree = new CompositeType<Category>()
            {
                Node = new Category() { Name = "Kategoriler" }
            };

            var elektronik = categoryTree.Add(new Category { Name = "Elektronik" });
            var bilgisayar = elektronik.Add(new Category { Name = "Bilgisayar" });
            var laptop = bilgisayar.Add(new Category { Name = "Lapop" });
            var desktop = bilgisayar.Add(new Category { Name = "Desktop" });
            var sesSistemi = elektronik.Add(new Category { Name = "Ses Sistemi" });

            CompositeType<Category>.Show(categoryTree, treeViewComposite);

        }
    }
}
