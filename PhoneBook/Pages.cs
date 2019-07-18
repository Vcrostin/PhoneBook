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

        private static int ND;

        private CollectionsNumber collectionsNumber = new CollectionsNumber();
        private void CreatePanelList()
        {
            if(collectionsNumber.NumberDatas.Count > 0)
            {
                Panel[] panels = new Panel[collectionsNumber.NumberDatas.Count];
                int i = 0;
                foreach(var nd in collectionsNumber.NumberDatas)
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
                        NumberData ItemToRemove = ReturnCurrentPanel(collectionsNumber, nd.ID);
                        collectionsNumber.RemovePeople(ItemToRemove);
                        int index = 0;
                        foreach(var s in collectionsNumber.NumberDatas)
                        {
                            s.ID = index;
                            index++;
                        }
                        collectionsNumber.SaveData();
                    };
                    panels[i].Controls.Add(Remove);

                    Label ContactsName = new Label()
                    {
                        Size = new Size(192, 18),
                        Location = new Point(17, 14),
                        Name = "ContactName" + i,
                        Text = nd.FirstName
                    };
                    panels[i].Controls.Add(ContactsName);

                    Label ContactsNumber = new Label()
                    {
                        Size = ContactsName.Size,
                        Location = new Point(ContactsName.Left, 51),
                        Name = "ContactNumber" + i,
                        Text = nd.Number[0]
                    };
                    panels[i].Controls.Add(ContactsNumber);
                    panels[i].MouseClick += (a, b) =>
                    {
                        NumberData ChosenItem = ReturnCurrentPanel(collectionsNumber, nd.ID);
                        ND = nd.ID;
                        SetRightPanel(ChosenItem);
                    };
                    PanelLeft.Controls.Add(panels[i]);
                    i++;
                }
            }
        }

        private void SetRightPanel(NumberData ChosenItem)
        {
            ComboBoxNumber.Items.Clear();
            if (ChosenItem.FirstName != null)
            {
                FirstNameTextBox.Text = ChosenItem.FirstName;
            }
            if (ChosenItem.SecondName != null)
            {
                SecondNameTextBox.Text = ChosenItem.SecondName;
            }
            else
            {
                SecondNameTextBox.Text = "Фамилия";
            }
            if (ChosenItem.Patronynic != null)
            {
                PatronymicTextBox.Text = ChosenItem.Patronynic;
            }
            else
            {
                PatronymicTextBox.Text = "Отчество";
            }
            if (ChosenItem.Birthday != null)
            {
                BirthMark.Text = ChosenItem.Birthday.ToShortDateString();
            }
            foreach(var n in ChosenItem.Number)
            {
                ComboBoxNumber.Items.Add(n);
            }
            Bitmap bitmap;
            if (ChosenItem.ImageLink != null)
            {
                bitmap = new Bitmap(ChosenItem.ImageLink);
            }
            else
            {
                bitmap = Properties.Resources.unnamed;
            }
            pictureBox1.Image = bitmap;
            ErrorText.Text = "";
        }

        private static NumberData ReturnCurrentPanel(CollectionsNumber collectionsNumber, int id)
        {
            return collectionsNumber.NumberDatas.FirstOrDefault(u => u.ID == id);
        }

        private void AddNumberToChosePeople_MouseClick(object sender, MouseEventArgs e)
        {
            if (AddNumberTextBox.TextLength > 0)
            {
                ComboBoxNumber.Items.Add(AddNumberTextBox.Text);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var nd = ReturnCurrentPanel(collectionsNumber, ND);
            nd.FirstName = FirstNameTextBox.Text;
            nd.SecondName = SecondNameTextBox.Text;
            nd.Patronynic = PatronymicTextBox.Text;
            nd.Birthday = DateTime.Parse(BirthMark.Text);
            nd.Number = ComboBoxNumber.Items.Cast<string>().ToList();
            collectionsNumber.SaveData();
            collectionsNumber.UpdateData();
        }

        private void OpenFileDialogForAddImage_FileOk(object sender, CancelEventArgs e)
        {
            var nd = ReturnCurrentPanel(collectionsNumber, ND);
            try
            {
                Bitmap image = new Bitmap(OpenFileDialogForAddImage.FileName);
                pictureBox1.Image = image;
                nd.ImageLink = OpenFileDialogForAddImage.FileName;
            }
            catch (ArgumentException)
            {
                ErrorText.Text = "Вы указали недопустимый файл";
            }
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            ErrorText.Text = "";
            OpenFileDialogForAddImage.ShowDialog();
        }

        private void ErrorText_Click(object sender, EventArgs e)
        {
            ErrorText.Text = "";
        }

        private void PanelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
