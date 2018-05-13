using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    
    public partial class Form1 : Form
    {
        private String homeUrl = "https://google.com";
        public Form1()
        {
            InitializeComponent();
        }

        //if can go back then go back.
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();

            }
        }

        //checks if can go forward if true then goes forward
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        //goes to the home url
        private void homeBtn_Click(object sender, EventArgs e)
        {
            NavigateBrowser(homeUrl);
        }

        //refreshes the browser
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        //searches
        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchButton();
        }

        //ends the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //sets the home page to the current url of the web browser
        private void setHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeUrl = webBrowser1.Url.ToString();
        }

        //tool to stop writing webBrowser1.Navigate it is also just as dynamic as a string needs to be passed.
        private void NavigateBrowser(String webUrl)
        {

            webBrowser1.Navigate(webUrl);
        }

        //shows about information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 Form2 = new form2();
            Form2.ShowDialog();
        }

        //sets home on load
        private void Form1_Load(object sender, EventArgs e)
        {
            NavigateBrowser(homeUrl);
        }

        //creates a tool to reduce copy pasting of same search code when pressing buttons or by pressing enter.
        private void searchButton()
        {

            if (textBox1.Text != "")
            {
                if (!textBox1.Text.Contains("http://") || !textBox1.Text.Contains("http://"))
                {
                    textBox1.Text = "http://" + textBox1.Text;
                    NavigateBrowser(textBox1.Text);
                    if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
                    {
                        textBox1.Text = webBrowser1.Url.ToString();
                    }
                }
                else
                {
                    
                    NavigateBrowser(textBox1.Text);
                    if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
                    {
                        textBox1.Text = webBrowser1.Url.ToString();
                    }
                    

                }
            }
        }
        //when enter is pressed run searchButton()
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.Focus();
                searchButton();
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                if (webBrowser1.CanGoBack) webBrowser1.GoBack();
            }
        }
    }
}
