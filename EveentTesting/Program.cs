using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveentTesting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Form2 form = new Form2();
            form.Click += form.Action;
            form.ShowDialog();*/
            /* Form3 form = new Form3();
             form.ShowDialog();*/
            //Controller controller = new Controller(form);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    /*class Form2 : Form
    {
        internal void Action(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }*/

    /*class Form3 : Form
    {
        private TextBox textBox;
        private Button button;

        public Form3()
        {
            this.button = new Button();
            this.textBox = new TextBox();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.ButtonClicked;
            this.button.Text = "Click";
            this.button.Top = 20;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "hello world!!!!!!!!!!!!!!!!!!!!";
        }

        internal void Action(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }*/

    /*class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            if (form != null)
            {
                this.form = form;
                this.form.Click += this.FormClicked;
            }
        }

        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }*/
}
