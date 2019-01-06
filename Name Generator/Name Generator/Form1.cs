using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//Yeah I know, don't call libraries in the header. I didn't feel like going System.IO.XXXX on every line in this little project.

namespace Name_Generator
{
    public partial class Form1 : Form
    {

        string FirstNameFile = @"C:\Users\Michal\Documents\Visual Studio 2015\Projects\Name Generator\Name Generator\bin\Debug\FirstNames.txt"; // Path to the text file containing first names.
        string LastNameFile = @"C:\Users\Michal\Documents\Visual Studio 2015\Projects\Name Generator\Name Generator\bin\Debug\LastNames.txt"; // Path to the text file containing last names.

        string[] FirstNameArray;
        string[] LastNameArray;

        string FirstName, LastName;

        int x = 0, y = 0, a = 0, b = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { } //Really hate how you can't delete this after you put it in w/o breaking the Form.

        private void button1_Click(object sender, EventArgs e) //Generates the name
        {
            //Just takes the lists of first and last names and loads them into arrays.
            //Rolls two numbers with an RNG on a range from 0 to n where n is the max array size.
            //Takes the names on those locations and prints them as a single string.

            FirstNameArray = File.ReadAllLines (FirstNameFile);
            LastNameArray = File.ReadAllLines(LastNameFile);

            x = FirstNameArray.Length;
            y = LastNameArray.Length;

            Random RNG1 = new System.Random();
            Random RNG2 = new System.Random();

            a = RNG1.Next(0, x);
            b = RNG2.Next(0, y);

            FirstName = FirstNameArray[a];
            LastName = LastNameArray[b];

            textBox1.Text = FirstName + " " + LastName;
        }
    }
}
