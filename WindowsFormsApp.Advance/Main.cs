using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Advance
{
    public partial class Main : Form
    {
      
        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelMemu.Visible = true;
        }
        private void hideSubMemu()
        {

        }
        private void showSubMemu( Panel subMemu)
        {
         /*   if (subMemu.Visible == false)
            {
                hideSubMemu();
                subMemu.Visible = true;
            }
            else
            {
                subMemu.Visible = false;
            }*/
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            showSubMemu(panelMemu);
            openChildForm(new FormMedicament());
        }
        private Form activateForm = null;
        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
                activateForm.Close();
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            openChildForm(new FormFacture());
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCommande());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClient());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUser());
        }
    }



    
    }

