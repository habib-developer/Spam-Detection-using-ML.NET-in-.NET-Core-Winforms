using Spam_Detection_WinformsML.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spam_Detection_Winforms
{
    public partial class SpamDetection : Form
    {
        public SpamDetection()
        {
            InitializeComponent();
        }

        private void SpamDetection_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Get message from text box
            var msg = txtMessage.Text;
            //Make prediction
            var prediction=ConsumeModel.Predict(new ModelInput
            {
                Message=msg,
            });
            //Show result
            MessageBox.Show($"Prediction: {(prediction.Prediction?"Spam":"Not Spam")} Score: {prediction.Score}");
        }
    }
}
