using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLGUI.EventsLib;

namespace XMLGUI.Forms
{
    
    public partial class DeleteItems : Form
    {
        public event EventHandler<DeleteChangeEventArgs> DeleteChangeEvent;
        public DeleteItems()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            EventHandler<DeleteChangeEventArgs> handler = DeleteChangeEvent;
            handler?.Invoke(this, new DeleteChangeEventArgs(this.paramTxtBox.Text, this.btnName.Name));
            this.Close();
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            EventHandler<DeleteChangeEventArgs> handler = DeleteChangeEvent;
            handler?.Invoke(this, new DeleteChangeEventArgs(this.paramTxtBox.Text, this.btnId.Name));
            this.Close();
        }

        private void btnDateOfOrder_Click(object sender, EventArgs e)
        {
            EventHandler<DeleteChangeEventArgs> handler = DeleteChangeEvent;
            handler?.Invoke(this, new DeleteChangeEventArgs(this.paramTxtBox.Text, this.btnDateOfOrder.Name));
            this.Close();
        }
    }

    
}
