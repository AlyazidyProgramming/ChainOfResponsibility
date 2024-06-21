using DesginPattern;
using System;
using System.Windows.Forms;

namespace ChainOfResposibilility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnReason_Click(object sender, EventArgs e)
        {

            //this input with out validation for toutrial and testing only.
            Material material = new Material()
            {
                Name = txtName.Texts,
                PartNumber = txtPortNumber.Texts,
                DrawingNumber = txtDrawingNumber.Texts,
                Budget = decimal.Parse(txtBudget.Texts),
            };


            //instantiation chain objects.
            EngrenninerApprover sherif = new EngrenninerApprover();
            PurchasingApprover Mohammed = new PurchasingApprover();
            FinanaceApprover Joker = new FinanaceApprover();

            //chain process order start from low level to heigh level.
            sherif.SetNextApprover(Mohammed);
            Mohammed.SetNextApprover(Joker);

            string reason = "";

            if (sherif.ApproveMaterial(material, ref reason))
                reason = "Approved. " + reason;
            else
                reason = "Disapproved. " + reason;


            txtResult.Text = reason;
        }
    }
}
