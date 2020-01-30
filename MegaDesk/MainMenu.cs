using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Events Below give function to the buttons 
        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote NewQuote = new AddQuote();
            NewQuote.Tag = this;
            NewQuote.Show(this);         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes allQuotes = new ViewAllQuotes();
            allQuotes.Tag = this;
            allQuotes.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes Search = new SearchQuotes();
            Search.Tag = this;
            Search.Show(this);
        }
        // Below are KeyPress Events
        private void A(object sender, KeyPressEventArgs e)
        {
            AddQuote NewQuote = new AddQuote();
            NewQuote.Tag = this;
            NewQuote.Show(this);
        }
        private void S(object sender, KeyPressEventArgs e)
        {
            SearchQuotes Search = new SearchQuotes();
            Search.Tag = this;
            Search.Show(this);
        }
        private void X(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void V(object sender, KeyPressEventArgs e)
        {
            ViewAllQuotes allQuotes = new ViewAllQuotes();
            allQuotes.Tag = this;
            allQuotes.Show(this);
        }
    }
}
