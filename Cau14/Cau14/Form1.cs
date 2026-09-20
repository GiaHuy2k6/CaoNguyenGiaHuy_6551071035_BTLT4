using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cau14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Move selected items from lstLopA to lstLopB
            chuyenDuLieu(lstLopA, lstLopB);
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }

            lstLopA.Items.Add(txtTen.Text);
            txtTen.Clear();
            txtTen.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Move selected items from lstLopA to lstLopB (same as button4)
            chuyenDuLieu(lstLopA, lstLopB);
        }

        // Helper: move selected items from source list to destination list with confirmation
        private void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            if (lst1.Items.Count == 0)
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
                return;
            }

            var hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (hoiChuyen != DialogResult.Yes)
                return;

            // Collect selected items first to avoid modifying the collection while iterating
            var toMove = new List<object>();
            for (int i = 0; i < lst1.Items.Count; i++)
            {
                if (lst1.GetSelected(i))
                    toMove.Add(lst1.Items[i]);
            }

            foreach (var item in toMove)
            {
                lst2.Items.Add(item);
                lst1.Items.Remove(item);
            }
        }
    }
}
