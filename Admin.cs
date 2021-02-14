using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Restaurant
{
    public partial class Admin : Form
    {

        string filename;
        Item myit = new Item();
        int flag;
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LandingForm landing = new LandingForm();
            landing.Show();
            this.Close();
        }

        private void Importbutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog()) //{Filter = "(*.jpg)|(*.jpeg)|(*.png)", ValidateNames = true, Multiselect = false })
            {
                open.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                open.ValidateNames = true;
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filename = open.FileName;
                    itempictureBox.Image = Image.FromFile(filename);
                }
            }

        }

        private async void Savebutton_Click(object sender, EventArgs e)
        {
            if ((ItemNametextBox.TextLength > 0) && (ItemPricetextBox.TextLength > 0) && (CatIDcomboBox.SelectedIndex != -1) && (itempictureBox.Image != null)) {

                myit.ItemName = ItemNametextBox.Text;
                myit.ItemPrice = Convert.ToInt32(ItemPricetextBox.Text);
                myit.CatID = Convert.ToInt32(CatIDcomboBox.Text);
                myit.ItemImage = covertToBinary(itempictureBox.Image);
                clear();
                using (MyRestaurantDBEntities restEN = new MyRestaurantDBEntities())
                {
                    if (flag == 0)// Insert
                    {
                        restEN.Items.Add(myit);
                    }
                    else // Update
                    {
                        restEN.Entry(myit).State = System.Data.Entity.EntityState.Modified;
                        MessageBox.Show("Item updated");
                    }
                    await restEN.SaveChangesAsync();
                }
                //loaddb(); 
                loadDBbutton.Text = "Refresh database";
                Savebutton.Text = "Save";
                
            }
            else
                MessageBox.Show("Please fill all required text fields :)");
        }
        public byte[] covertToBinary( Image image)
        {
            
            using(MemoryStream ms = new MemoryStream())
            {
                    image.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
            }
        }

        private void mydataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (mydataGridView.CurrentRow.Index != -1)
                {
                    flag = 1;
                    int id = Convert.ToInt32(mydataGridView.CurrentRow.Cells["ItemID"].Value);
                    using (MyRestaurantDBEntities db = new MyRestaurantDBEntities())
                    {
                        myit = db.Items.Where(x => x.ItemID == id).FirstOrDefault();
                        ItemNametextBox.Text = myit.ItemName;
                        ItemPricetextBox.Text = (myit.ItemPrice).ToString();
                        CatIDcomboBox.Text = (myit.CatID).ToString();
                        try
                        {
                            itempictureBox.Image = convertToImage(myit.ItemImage);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("There is no image associated with this item", "Fatal reference error", MessageBoxButtons.OK);
                        }

                    }
                    Deletebutton.Enabled = true;
                    Savebutton.Text = "Update";
                }
               
            }
            catch (Exception)
            {
               
            }
                
        }
        public Image convertToImage(byte[] b)
        {
            using (MemoryStream ms = new MemoryStream(b))
            {
                return Image.FromStream(ms);
            }
        }

        
        public void clear()
        {
            itempictureBox.Image = null;
            ItemNametextBox.Clear();
            ItemPricetextBox.Clear();
            CatIDcomboBox.Text = "";
        }
        public void loaddb()
        {
            flag = 0;
            mydataGridView.Rows.Clear();
            mydataGridView.Refresh();
            clear();
            Savebutton.Text = "Save";
            try
            {
                using (MyRestaurantDBEntities RE = new MyRestaurantDBEntities())
                {
                    //mydataGridView.DataSource = RE.Items.ToList<Item>();
                    foreach (Item item in RE.Items)
                    {
                        mydataGridView.Rows.Add(item.ItemID.ToString(), item.ItemName, item.ItemPrice.ToString(), item.CatID.ToString(), convertToImage(item.ItemImage));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            flag = 0;
            clear();
            //loaddb();
        }

        private async void Deletebutton_Click(object sender, EventArgs e)
        {
            using (MyRestaurantDBEntities RE = new MyRestaurantDBEntities())
            {
                var entry = RE.Entry(myit);
                if(entry.State == System.Data.Entity.EntityState.Detached)
                {
                    RE.Items.Attach(myit);
                    RE.Items.Remove(myit);
                    await RE.SaveChangesAsync();
                    loadDBbutton.Text = "Refresh database";
                    clear();
                }
            }
        }

        private void loadDBbutton_Click(object sender, EventArgs e)
        {
            loaddb();
            loadDBbutton.Text = "Refresh Database";
        }

        private void SearchtextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(SearchtextBox, "Enter the name of the item you are searching");
        }

        private void SearchtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(SearchtextBox.TextLength > 0)
            {
                mydataGridView.Rows.Clear();
                string itemsearch = SearchtextBox.Text;
                mydataGridView.Columns[0].Name = "Item ID";
                mydataGridView.Columns[1].Name = "Item Name";
                mydataGridView.Columns[2].Name = "Item Price";
                mydataGridView.Columns[3].Name = "CatID";
                mydataGridView.Columns[4].Name = "Item Image";
                using (MyRestaurantDBEntities myrest = new MyRestaurantDBEntities())
                {
                    foreach(Item it in myrest.Items.Where<Item>(x => x.ItemName == itemsearch))
                    {
                        string searchid = it.ItemID.ToString();
                        string searchname = it.ItemName;
                        string searchprice = it.ItemPrice.ToString();
                        string searchcat = it.CatID.ToString();
                        Image searchimage = convertToImage(it.ItemImage);
                        mydataGridView.Rows.Add(searchid, searchname, searchprice, searchcat, searchimage);
                    }
                }
            }
        }
    }
}
