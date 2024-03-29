﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_user nu = new new_user();
            nu.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);

        }

        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Units un = new Units();
            un.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_products ap = new add_products();
            ap.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_department ad = new new_department();
            ad.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_category nc = new new_category();
                nc.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_supplier ns = new new_supplier();
            ns.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            
        }

        private void dealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dealer_info di = new dealer_info();
            di.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase pur = new purchase();
                pur.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales sal = new sales();
            sal.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase_report rep = new purchase_report();
            rep.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search ser = new Search();
            ser.Show();
            this.BackColor = Color.FromArgb(56, 111, 178);
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
