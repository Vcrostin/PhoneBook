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
    public partial class Pages : Form
    {
        public Pages()
        {
            InitializeComponent();
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Pages_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {
            AdditonForm additonForm = new AdditonForm();
            additonForm.ShowDialog();
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            RemoveAllAddPanel();
            CreatePanelList();
        }

        private void RemoveAllAddPanel()
        {
            for (int i = 0; i < new CollectionsNumber().NumberDatas.Count + k; i++)
            {
                PanelLeft.Controls.RemoveByKey("panels" + i);
            }
        }

        public static int k = 0;

        private void CreatePanelList()
        {
            if(new CollectionsNumber().NumberDatas.Count > 0)
            {
                Panel[] panels = new Panel[new CollectionsNumber().NumberDatas.Count];
                int i = 0;
                foreach(var nd in new CollectionsNumber().NumberDatas)
                {
                    panels[i] = new Panel()
                    {
                        Name = "panels" + i,
                        Size = new Size(325, 88),
                        BorderStyle = BorderStyle.Fixed3D,
                        BackColor = Color.White
                    };
                    if (i == 0)
                    {
                        panels[i].Location = new Point(13, 30);
                    }
                    else
                    {
                        panels[i].Location = new Point(13, panels[i - 1].Bottom+20);
                    }

                    Button Remove = new Button()
                    {
                        Size = new Size(59, 23),
                        Location = new Point(248, 51),
                        Name = "Remove" + i,
                        Text = "Remove"
                    };
                    NumberData numberData = nd;
                    Remove.Click += (a, b) =>
                    {
                        k++;
                        CollectionsNumber collectionsNumber = new CollectionsNumber();
                        var ItemToRemove = collectionsNumber.NumberDatas.FirstOrDefault(u => u.Name == nd.Name && u.Number == nd.Number);
                        collectionsNumber.RemovePeople(ItemToRemove);
                    };
                    panels[i].Controls.Add(Remove);

                    Label ContactsName = new Label()
                    {
                        Size = new Size(192, 18),
                        Location = new Point(17, 14),
                        Name = "ContactName" + i,
                        Text = nd.Name
                    };
                    panels[i].Controls.Add(ContactsName);

                    Label ContactsNumber = new Label()
                    {
                        Size = ContactsName.Size,
                        Location = new Point(ContactsName.Left, 51),
                        Name = "ContactNumber" + i,
                        Text = nd.Number
                    };
                    panels[i].Controls.Add(ContactsNumber);
                    PanelLeft.Controls.Add(panels[i]);
                    i++;
                }
            }
        }
    }
}
