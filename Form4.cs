using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Buenafe_Lab1_Prefi;

namespace lab2

{
    public partial class FrmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;


        public long StudentNumber(string studNum)
        {
            try
            {
                _StudentNo = long.Parse(studNum);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Exception Message: " + fe.Message);
            }
            return _StudentNo;

        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {

            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                MessageBox.Show("Invalid Input");

            }

            return _Age;
        }
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

           
            string getStudNo = txtStudentNo.Text;
            string getLName = txtLastName.Text;
            string getFName = txtFirstName.Text;
            string getMName = txtMiddleInitial.Text;
            string getAge = txtAge.Text;
            string getProgram = cbPrograms.Text;
            string getGender = cbGender.Text;
            string getBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            string getContact = txtContactNo.Text;

            FrmFileName filename = new FrmFileName();
            filename.ShowDialog();

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))

            {
                outputFile.WriteLine("Student No.:" + getStudNo);
                

                outputFile.WriteLine("Last Name:" + getLName);
                

                outputFile.WriteLine("First Name: " + getFName);
                

                outputFile.WriteLine("Middle Initial: " + getMName);
                

                outputFile.WriteLine("Age: " + getAge);
                

                outputFile.WriteLine("Program: " +getProgram);
                

                outputFile.WriteLine("Gender: " + getGender);
                

                outputFile.WriteLine("Birthday: " +getBirthday);
                

                outputFile.WriteLine("Contact No.: " + getContact);
                


            }

            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtStudentNo.Clear();
            txtContactNo.Clear();
            txtAge.Clear();

            Close();


        }
    }
}