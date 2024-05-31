using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form2 : Form, IObserver
    {
        private readonly ColorObservable colorObservable;

        public Form2(ColorObservable colorObservable)
        {
            InitializeComponent();
            this.colorObservable = colorObservable;
        }

        public void ChangeColor(Color color)
        {
            BackColor = color;
        }

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            colorObservable.Subscribe(this);
        }

        private void buttonUnsbuscribe_Click(object sender, EventArgs e)
        {
            colorObservable.Unsubscribe(this);
        }
    }
}
