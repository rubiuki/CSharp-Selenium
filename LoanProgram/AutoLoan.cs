using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    internal class AutoLoan : Loan
    {
        public int autoYearBuilt;
        public string autoModel;
        public string autoMake;
        public string autoColor;

        public int AutoYearBuilt
        {
            get { return autoYearBuilt; }
            set { autoYearBuilt = value; }
        }
        public string AutoModel
        {
            get { return autoModel; }
            set { autoModel = value; }
        }
        public string AutoMake
        {
            get { return autoMake; }
            set { autoMake = value; }
        }
        public string AutoColor
        {
            get { return autoColor; }
            set { autoColor = value; }
        }

        public AutoLoan(string number, string fname, string lname, double rate, decimal amount, double year, int yearBuilt, 
            string model, string make, string color) : base(number, fname, lname, rate, amount, year)
        {
            AutoYearBuilt = yearBuilt;
            AutoModel = model;
            AutoMake = make;
            AutoColor = color;
        }

        public override decimal CalculateInterest()
        {
            return (Convert.ToDecimal(InterestRate) / (Convert.ToDecimal(NumberOfYears) / 12M) *
                (LoanAmount + 1000)) ;
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nType of Car: " + AutoYearBuilt + " " + AutoModel + "\n Calculated Interest :" + 
                CalculateInterest().ToString("C");
        }
    }
}
