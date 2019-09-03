using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inbuilt delegate method
            Button delegateButton = new Button();
            delegateButton.Location = new Point(30, 100);

            delegateButton.Text = "Delegate Click";
            delegateButton.Click += DelegateButton_Click;

            //Anonymous method
            //Implements simpler method of creating button object
            Button anonButton = new Button
            {
                Location = new Point(120, 100),
                Text = "Anonymous function"
            };
            anonButton.Click += new EventHandler(
                    delegate (object eventSender, EventArgs eventArgs)
                    {
                        MessageBox.Show("Called via anonymous function");
                    }
                );

            //Lambda function
            Button lambdaButton = new Button
            {
                Location = new Point(220, 100),
                Text = "Lambda  function"
            };
            lambdaButton.Click += new EventHandler((object eventSender, EventArgs eventArgs) => { MessageBox.Show("Called via Lambda function"); });

            Controls.Add(delegateButton);
            Controls.Add(anonButton);
            Controls.Add(lambdaButton);
        }

        private void DelegateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Called via inbuilt function type");
        }
    }
}
