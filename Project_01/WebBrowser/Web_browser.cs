using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Web_browser : Form
    {
        public Web_browser()
        {
            InitializeComponent();

        }

        //the feature of refresh button
        private void refreshBut_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        //the feature of ">" button (next viewed website)
        private void forwardBut_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        //the feature of "<" button (previous website)
        private void prevBut_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        //the feature of "GO" button to visit the website of the URL entered
        private void goBut_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(URL.Text);
        }

        //visit the URL when the user press the Enter key on the keyboard (same usage as "GO" button)
        private void URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //the ascii of Enter key is 13
            if(e.KeyChar == (char) 13)
            {
                webBrowser1.Navigate(URL.Text);
            }
            
        }

        //the feature of "Encrypt Now" button
        private void encryptBut_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient encrypt;
            //Use try catch to avoid running this service oriented feature in the .exe file without any configuration files
            try
            {
                encrypt = new EncryptService.ServiceClient();
            }
            catch (Exception)
            {
                MessageBox.Show("Configuration file missing or local server connection lost!!! \nPlease check your running environment.", "Encryptor Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //check if nothing to encrypt when hit the encrypt button
            if(msg.Text.Length > 0)
            {
                encryptRes.Text = encrypt.Encrypt(msg.Text);
                decryptRes.Text = encrypt.Decrypt(encryptRes.Text); //show the decrypt text for confirmation
            }
            
        }

        //the feature of "=" of the calculator
        private void equBut_Click(object sender, EventArgs e)
        {
            var getOp = opChoice.SelectedItem;
            //show a message when the user does not select a operator
            if (getOp == null)
            {
                MessageBox.Show("Invalid Operator!!!", "Calculator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //try catch method to check if the number input is legal and show an error message
            try
            {
                double.Parse(fstNum.Text);
                double.Parse(sndNum.Text);
            } catch (Exception)
            {
                MessageBox.Show("Invalid Number Input!!!", "Calculator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fstNum.Text.Length > 0 && sndNum.Text.Length > 0)
            {
                //get the selected operator
                var op = char.Parse(getOp.ToString());
                switch (op)
                {
                    case '+':
                        //do the addition calculation
                        calRes.Text = (double.Parse(fstNum.Text) + double.Parse(sndNum.Text)).ToString();
                        break;
                    case '-':
                        //do the substruction calculation
                        calRes.Text = (double.Parse(fstNum.Text) - double.Parse(sndNum.Text)).ToString();
                        break;
                    case '*':
                        //do the multiplication calculation
                        calRes.Text = (double.Parse(fstNum.Text) * double.Parse(sndNum.Text)).ToString();
                        break;
                    case '/':
                        //show an error message if the dividend is 0
                        if (double.Parse(sndNum.Text) == 0)
                        {
                            MessageBox.Show("Invalid Dividend!!!", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //do the division calculation
                        calRes.Text = (double.Parse(fstNum.Text) / double.Parse(sndNum.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
            
        }

        //create a holder for captcha checking
        string stringHolder;
        //the feature of the click of image area
        private void imageVer_Click(object sender, EventArgs e)
        {
            ImgVerService.ServiceClient verifier;
            //Use try catch to avoid running this service oriented feature in the .exe file without any configuration files
            try
            {
                verifier = new ImgVerService.ServiceClient();  
            }
            catch (Exception)
            {
                MessageBox.Show("Configuration file missing or local server connection lost!!! \nPlease check your running environment.", "Varifier Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //show a message if the string length is not input
            if(length.Text.Length == 0)
            {
                MessageBox.Show("Please enter your string length!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //try catch method to check if the entered string length is legal and show a message when it is illegal
            string verifyStr = "";
            try
            {
                verifyStr = verifier.GetVerifierString(length.Text);
                imageVer.Image = Image.FromStream(verifier.GetImage(verifyStr));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid String Length!!!", "Varifier Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            stringHolder = verifyStr;
        }

        //the feature of "Submit" button
        private void submitBut_Click(object sender, EventArgs e)
        {
            //check if the entered string is matched with the captcha given and show the message
            if(stringHolder != enterStr.Text)
            {
                MessageBox.Show("Oh,no! Captcha mismatch!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Cheers! Captcha match!!!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
        }

    }
}
