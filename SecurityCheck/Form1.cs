namespace SecurityCheck
{
    public partial class Form1 : Form
    {
        Dictionary<Keys, Button> keyButtonXrefDict = new Dictionary<Keys, Button>();

        public Form1()
        {
            InitializeComponent();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            securityCodeTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D1, button1);
            keyButtonXrefDict.Add(Keys.NumPad1, button1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D2, button2);
            keyButtonXrefDict.Add(Keys.NumPad2, button2);   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D3, button3);
            keyButtonXrefDict.Add(Keys.NumPad3, button3);   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D4, button4);
            keyButtonXrefDict.Add(Keys.NumPad4, button4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D5, button5);
            keyButtonXrefDict.Add(Keys.NumPad5, button5);   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D6, button6);
            keyButtonXrefDict.Add(Keys.NumPad6, button6);   
        }

        private void button8_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D7, button7);
            keyButtonXrefDict.Add(Keys.NumPad7, button7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D8, button8);
            keyButtonXrefDict.Add(Keys.NumPad8, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            keyButtonXrefDict.Add(Keys.D9, button9);
            keyButtonXrefDict.Add(Keys.NumPad9, button9);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            // Determine if the pressed key (e.KeyCode) exists in the cross reference dictionary
            if (keyButtonXrefDict.ContainsKey(e.KeyCode))
            {
                // If it does, simulate a click event on the button
                keyButtonXrefDict[e.KeyCode].PerformClick();
            }
            securityCodeTextBox.Focus();
        }

        private void securityCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if 
        }
    }
}