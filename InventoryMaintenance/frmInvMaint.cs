using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the list of items.
        List<InvItem> items = null;

        //Nathan Burns
        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Add a statement here that gets the list of items.
            items = InvItemDB.GetItems();
            FillItemListBox();
        }

        //Nathan Burns
        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            items.ForEach(i => lstItems.Items.Add(i.GetDisplayText(" ")));
        }

        //Nathan Burns
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            // and then gets a new item from that form.
            frmNewItem newItemForm = new frmNewItem();
            InvItem item = newItemForm.GetNewItem();
            if (item != null)
            {
                items.Add(item);
                InvItemDB.SaveItems(items);
                FillItemListBox();
            }
        }

        //Nathan Burns
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                // Add code here that displays a dialog box to confirm
                // the deletion and then removes the item from the list,
                // saves the list of products, and refreshes the list box
                // if the deletion is confirmed.
                InvItem item = items[i];
                string message = "Are you sure you want to delete " + item.Description + "?";
                DialogResult button = MessageBox.Show(message, "ConfirmDelete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    items.Remove(item);
                    InvItemDB.SaveItems(items);
                    FillItemListBox();
                }
            }
        }

        //Nathan Burns
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
