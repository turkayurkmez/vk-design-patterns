namespace SingleResponsibility
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        /*
        * SRP: Uygulamadaki her nesnenin yalnızca bir sorumluluğu olmalı.
        *    İhlal: Bir nesnede operasyonel değişiklik (metodun çalışma biçimi veya yeni metot eklemek) yapmak için birden fazla sebebiniz varsa prensibi ihlal ediyorsunuz demektir.
        *    
        *    Form1 insan olsaydı, uygulamadaki sorumluluğunu nasıl açıklardı?
        *    Fonksiyona senin yerin burası mı diye sorun
        */
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var productName = textBoxProductName.Text;
            var price = decimal.Parse(textBoxPrice.Text);

            ProductService productService = new ProductService();
            MailService mailService = new MailService();

            productService.CreateProduct(productName, price);
            mailService.SendNotifyMail("test@test.com");
        }




        private void buttonChangeBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = dialog.Color;
            }
        }
    }
}
