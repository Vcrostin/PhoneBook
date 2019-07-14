using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBookBL.model;

namespace PhoneBook
{
    public partial class AdditonForm : Form
    {
        public AdditonForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CollectionsNumber collectionsNumber = new CollectionsNumber();
            collectionsNumber.AddPeople(new NumberData(collectionsNumber.NumberDatas.Count, PhoneName.Text, PhoneNumber.Text));
            this.Close();
        }
    }
}
