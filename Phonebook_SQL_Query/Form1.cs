using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook_SQL_Query
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet11);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.phone_book_table' table. You can move, or remove it, as needed.
            this.phone_book_tableTableAdapter.Fill(this.dataSet11.phone_book_table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastname=this.textBox1.Text;
            this.phone_book_tableTableAdapter.FillBy_last_name(this.dataSet11.phone_book_table, lastname);
        }
    }
}
