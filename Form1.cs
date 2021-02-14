using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.OData.Edm;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        Item myit = new Item();
        Order myorder = new Order();
        
        Service myservices = new Service();
        DateTime date;int tabnum;
        string name; int units; int unitprice; int finalpric; int grdtotal = 0; Image im; int id;
        public Form1()
        {
            InitializeComponent();
        }
        // Close this window event
        private void ClosePB_Click(object sender, EventArgs e)
        {
            LandingForm landing = new LandingForm();
            landing.Show();
            this.Close();
        }
        // Units of selected item per service event
        private void NumberClicked(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            quantitytextbox.Text += b.Text;
        }

        // Clear quantity textbox event
        private void clearbutton_Click(object sender, EventArgs e)
        {
            quantitytextbox.Clear();
        }

        // method for filling flowlayout panel with items
        private void fill(int catid)
        {
            using (MyRestaurantDBEntities rest = new MyRestaurantDBEntities())
            {
                foreach (var item in rest.Items.Where<Item>(x => x.CatID == catid))
                {
                    // create a panel                
                    Panel p = new Panel();
                    p.BorderStyle = BorderStyle.FixedSingle;
                    p.Size = new System.Drawing.Size(184, 188);

                    // create a pictureBox
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new System.Drawing.Size(184, 150);
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.Visible = true;
                    pictureBox.Enabled = false;
                    pictureBox.BackgroundImage = convertToImage(item.ItemImage);

                    // create label for Item name
                    Label Iname = new Label();
                    Iname.BackColor = System.Drawing.Color.FloralWhite;
                    Iname.ForeColor = System.Drawing.Color.Black;
                    Iname.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    Iname.Enabled = true;
                    Iname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    Iname.Text = item.ItemName.ToString();
                    Iname.TextAlign = ContentAlignment.MiddleCenter;

                    // create location point for name label
                    Point pt = new Point();
                    pt.X = pictureBox.Location.X;
                    pt.Y = pictureBox.Location.Y + pictureBox.Height;
                    Iname.Location = pt;
                    Iname.Size = new System.Drawing.Size(184, 19);

                    // create label for item price
                    Label Iprice = new Label();
                    Iprice.TextAlign = ContentAlignment.MiddleCenter;
                    Iprice.Enabled = true;
                    Iprice.Visible = true;
                    Iprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    Iprice.Text = item.ItemPrice.ToString() + " " + "TL";
                    Iprice.ForeColor = System.Drawing.Color.Red;
                    Iprice.BackColor = System.Drawing.Color.MediumPurple;

                    // create location point for price label
                    Point pt2 = new Point();
                    pt2.X = Iname.Location.X;
                    pt2.Y = Iname.Location.Y + Iname.Height;
                    Iprice.Location = pt2;
                    Iprice.Size = new System.Drawing.Size(184, 19);

                    // tag panel to easily fill the order list
                    pictureBox.Name = item.ItemName.ToString();
                    pictureBox.Tag = item.ItemPrice.ToString();
                    Iname.Tag = item.ItemID.ToString();
                    Iprice.Tag = item.ItemID.ToString();
                    // add controls to panel
                    p.Controls.Add(Iname);
                    p.Controls.Add(Iprice);
                    p.Controls.Add(pictureBox);
                    flowLayoutPanel1.Controls.Add(p);
                    p.Click += new EventHandler(p_click);
                }
            }
            Quatitygroupbox.Enabled = true; flowLayoutPanel1.Enabled = true;
        }

        
        //  Item selection event handling
        private void p_click(object sender, EventArgs e)
        {
            if (quantitytextbox.TextLength > 0)
            {

                Panel p = (Panel)sender;
                foreach (Control c in p.Controls)
                {

                    if (c.GetType() == typeof(PictureBox))
                    {
                        name = c.Name;
                        units = Convert.ToInt32(quantitytextbox.Text);
                        unitprice = Convert.ToInt32(c.Tag);
                        im = c.BackgroundImage;
                    }
                    if (c.GetType() == typeof(Label))
                    {
                        id = Convert.ToInt32(c.Tag);
                        
                    }
                }
            }
            else
                MessageBox.Show("please enter the quantity first:(");
        }

        // Item insert with insert Button event
        private async void InsertItembutton_Click(object sender, EventArgs e)
        {
            if (quantitytextbox.TextLength > 0 && name.Length > 0)
            {
                finalpric = units * unitprice;
                grdtotal += finalpric;
                myservices.ItemID = id;
                myservices.OrderID = myorder.OrderID;
                myservices.Units = units;
                using (MyRestaurantDBEntities rest = new MyRestaurantDBEntities())
                {
                    rest.Services.Add(myservices);
                    var ord = rest.Orders.Where<Order>(x => x.OrderID == myservices.OrderID && x.OrderStatus == true).FirstOrDefault();
                    ord.OrderTotal += grdtotal;
                    await rest.SaveChangesAsync();
                }

                ListViewItem list = new ListViewItem(name);
                list.SubItems.Add(units.ToString());
                list.SubItems.Add(unitprice.ToString());
                list.SubItems.Add(finalpric.ToString());
                listView1.Items.Add(list);
                grandtotaltb.Text = grdtotal.ToString();
                quantitytextbox.Clear();
            }
            else
                MessageBox.Show("Missing Details. :)");
        }
        // Method for converting byte array to image
        public Image convertToImage(byte[] b)
        {
            using (MemoryStream ms = new MemoryStream(b))
            {
                return Image.FromStream(ms);
            }
        }

        // Category item list events
        private void StartersCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 1; 
            fill(1);
        }

        private void SaladsCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 2;
            fill(2);
        }
        public void clear()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void PastaCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 3;
            fill(3);
        }

        private void ChickenCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 4;
            fill(4);
        }

        private void FajitaChinessCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 5;
            fill(5);
        }

        private void RedmeatCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 6;
            fill(6);
        }

        private void PizzaBurgerCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 7;
            fill(7);
        }

        private void FishCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 8;
            fill(8);
        }

        private void DessertCatbutton_Click(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 9;
            fill(9);
        }

        // New order event handling
        private void NewOrderbutton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    listView1.Items.Remove(item);
                }
            }
            orderdatetextBox.Clear();
            orderidtextBox.Clear();
            TableNumbertb.Clear();
            grandtotaltb.Clear();
            date = DateTime.Now;
           foreach(Control c in TabgroupBox.Controls)
            {
                if(c.GetType() == typeof(RadioButton))
                {
                    if(c.Tag.ToString() == "OFF")
                    {
                        c.Enabled = true;
                    }
                    else
                        c.Enabled = false;
                }
            }
            grdtotal = 0;
        }

        // Ongoing order Event 
        private void CurrentOrderbutton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    listView1.Items.Remove(item);
                }
            }
            orderdatetextBox.Clear();
            orderidtextBox.Clear();
            TableNumbertb.Clear();
            grandtotaltb.Clear();
            foreach (Control c in TabgroupBox.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    if (c.Tag.ToString() == "ON")
                    {
                        c.Enabled = true;
                    }
                    else
                        c.Enabled = false;
                }
            }
            grdtotal = 0;
        }

        // Table selection event 
        private void Tab_Clicked(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            // New Order
            if (rbtn.Tag.ToString() == "OFF" && rbtn.Enabled == true)
            {
                tabnum = Convert.ToInt32(rbtn.Text);
                OrderToDb();
                MessageBox.Show("New order completed");
                loadorder(tabnum);
                rbtn.Tag = "ON";
            }
            // Ongoing Order
            else if (rbtn.Tag.ToString() == "ON" && rbtn.Enabled == true)
            {
                MessageBox.Show("Ongoing order completed");
                int currTabNum = Convert.ToInt32(rbtn.Text);
                
                using (MyRestaurantDBEntities myrest = new MyRestaurantDBEntities())
                {
                    var ord = myrest.Orders.Where<Order>(x => x.TabNum == currTabNum && x.OrderStatus == true).FirstOrDefault();
                    int currOrdId = ord.OrderID;
                    
                    DateTime currOrddatetime = (DateTime)ord.OrderDatetime;
                    grdtotal = (int)ord.OrderTotal;
                   
                    // Fill order fields
                    orderdatetextBox.Text = currOrddatetime.ToString();
                    TableNumbertb.Text = currTabNum.ToString();
                    orderidtextBox.Text = currOrdId.ToString();
                    foreach (Service ser in myrest.Services.Where<Service>(x => x.OrderID == currOrdId))
                    {
                        int currItemid = ser.ItemID;
                        int currQuantity = (int)ser.Units;
                        var currItem = myrest.Items.Where<Item>(x => x.ItemID == currItemid).FirstOrDefault();
                        string currItemname = currItem.ItemName;
                        int currItemPrice = (int)currItem.ItemPrice;
                        int currItemFinalPric = currItemPrice * currQuantity;
                        //fill the list with current order details
                        ListViewItem list = new ListViewItem(currItemname);
                        list.SubItems.Add(currQuantity.ToString());
                        list.SubItems.Add(currItemPrice.ToString());
                        list.SubItems.Add(currItemFinalPric.ToString());
                        listView1.Items.Add(list);
                    }

                    grandtotaltb.Text = grdtotal.ToString();
                }
                //loadorder(Convert.ToInt32(rbtn.Text.ToString()));
            }
            else
                return;

            foreach (Control c in TabgroupBox.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    if (c.Tag.ToString() == "OFF")
                    {
                        c.Enabled = false; ;
                    }
                }
            }

            
        }
        async void OrderToDb()
        {
            using (MyRestaurantDBEntities res = new MyRestaurantDBEntities())
            {
                myorder.TabNum = tabnum;
                myorder.OrderDatetime = date;
                myorder.OrderTotal = grdtotal;
                myorder.OrderStatus = true;
                res.Orders.Add(myorder);
                await res.SaveChangesAsync();               
            }
        }
         void loadorder(int tablenum)
        {
            using (MyRestaurantDBEntities RE = new MyRestaurantDBEntities())
            {
                var currOrder  = RE.Orders.Where<Order>(x => x.TabNum == tablenum).FirstOrDefault();
                orderdatetextBox.Text = currOrder.OrderDatetime.ToString();
                TableNumbertb.Text = currOrder.TabNum.ToString();
                orderidtextBox.Text = currOrder.OrderID.ToString();
            }
        }

        private void NewServicebutton_Click(object sender, EventArgs e)
        {
            myorder.OrderID = Convert.ToInt32(orderidtextBox.Text);
            InsertItembutton.Enabled = true; Catpanel.Enabled = true;     
        }

        private async void DeleteServicebutton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
            {
                string deletename = listView1.SelectedItems[0].Text;
                int totaldeduct = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                grdtotal -= totaldeduct;
                using (MyRestaurantDBEntities rest = new MyRestaurantDBEntities())
                {
                    var itemToDelete = rest.Items.Where<Item>(x => x.ItemName == deletename).FirstOrDefault();
                    int itemIdToDelete = itemToDelete.ItemID;
                    var serviceToDelete = rest.Services.Where<Service>(x => x.ItemID == itemIdToDelete).FirstOrDefault();
                    rest.Services.Remove(serviceToDelete);
                    int serviceIdToDelete = serviceToDelete.OrderID;
                    var orderToDeduct = rest.Orders.Where<Order>(x => x.OrderID == serviceIdToDelete).FirstOrDefault();
                    orderToDeduct.OrderTotal -= totaldeduct;
                    await rest.SaveChangesAsync();
                    grandtotaltb.Text = grdtotal.ToString();
                    MessageBox.Show("Service successfully removed. :)");
                }
            }
        }

        private void Checkoutbutton_Click(object sender, EventArgs e)
        {
            if (Table1rb.Checked)
            {
                if (Table1rb.Tag.ToString() == "ON")
                {
                    int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                    StopOrder(stopOrderid);
                    Table1rb.Enabled = false;
                    Table1rb.Tag = "OFF";
                    Table1rb.Checked = false; 
                }
            }
            else if (Table2rb.Checked)
            {
                if (Table2rb.Tag.ToString() == "ON")
                {
                    int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                    StopOrder(stopOrderid);
                    Table2rb.Enabled = false;
                    Table2rb.Tag = "OFF";
                    Table2rb.Checked = false;
                }
            }
            else if (Table3rb.Checked)
            {
                int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                StopOrder(stopOrderid);
                Table3rb.Enabled = false;
                Table3rb.Tag = "OFF";
                Table3rb.Checked = false;
            }
            else if (Table4rb.Checked)
            {
                if (Table4rb.Tag.ToString() == "ON")
                {
                    int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                    StopOrder(stopOrderid);
                    Table4rb.Enabled = false;
                    Table4rb.Tag = "OFF";
                    Table4rb.Checked = false;
                }
            }
            else if (Table5rb.Checked)
            {
                if (Table5rb.Tag.ToString() == "ON")
                {
                    int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                    StopOrder(stopOrderid);
                    Table5rb.Enabled = false;
                    Table5rb.Tag = "OFF";
                    Table5rb.Checked = false;
                }
            }
            else if (Table6rb.Checked)
            {
                if (Table6rb.Tag.ToString() == "ON")
                {
                    int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                    StopOrder(stopOrderid);
                    Table6rb.Enabled = false;
                    Table6rb.Tag = "OFF";
                    Table6rb.Checked = false;
                }
            }
            else if (Table7rb.Checked)
            {
                if (Table7rb.Tag.ToString() == "ON")
                {
                    int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                    StopOrder(stopOrderid);
                    Table7rb.Enabled = false;
                    Table7rb.Tag = "OFF";
                    Table7rb.Checked = false;
                }
            }
            else if (Table8rb.Checked)
            {
                if (Table8rb.Tag.ToString() == "ON")
                {
                    int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                    StopOrder(stopOrderid);
                    Table8rb.Enabled = false;
                    Table8rb.Tag = "OFF";
                    Table8rb.Checked = false;
                }
            }
            else if (Table9rb.Checked)
            {
                if (Table9rb.Tag.ToString() == "ON")
                {
                    int stopOrderid = Convert.ToInt32(orderidtextBox.Text);
                    StopOrder(stopOrderid);
                    Table9rb.Enabled = false;
                    Table9rb.Tag = "OFF";
                    Table9rb.Checked = false;
                }
            }
            else
                return;
        }

        // Method for stopping an ongoing order
        async void StopOrder(int stopOrderID)
        {
            using (MyRestaurantDBEntities rest = new MyRestaurantDBEntities())
            {
                var stopOder = rest.Orders.Where<Order>(x => x.OrderID == stopOrderID).FirstOrDefault();
                stopOder.OrderStatus = false;
                await rest.SaveChangesAsync();
                MessageBox.Show("Order is off");
            }

            if (listView1.Items.Count != 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    listView1.Items.Remove(item);
                }
            }
            orderdatetextBox.Clear();
            orderidtextBox.Clear();
            TableNumbertb.Clear();
            grandtotaltb.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            myit.CatID = 1;
            fill(1);
        }

        private void ClosePB_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ClosePB, "You risk reseting today's data, if you logout before the end of the days.");
        }

       
    }
    
}
