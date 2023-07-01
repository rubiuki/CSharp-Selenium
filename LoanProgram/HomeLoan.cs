using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    internal class HomeLoan : Loan
    {
        public string homeAddress;
        public int homeYearBuilt;
        public int homeSquareFootage;

        public string HomeAddress
        {
            get { return homeAddress; }
            set { homeAddress = value; }
        }
        public int HomeYearBuilt
        {
            get { return homeYearBuilt; }
            set { homeYearBuilt = value; }
        }
        public int HomeSquareFootage
        {
            get { return homeSquareFootage; }
            set { homeSquareFootage = value; }
        }

        public HomeLoan(string number, string fname, string lname, double rate, decimal amount, double year, string address,
            int yearBuilt, int squareFootage) : base(number, fname, lname, rate, amount, year )
        {
            HomeAddress = address;
            HomeYearBuilt = yearBuilt;
            HomeSquareFootage = squareFootage;
        }

        public override decimal CalculateInterest()
        {
            return (Convert.ToDecimal(InterestRate) / (Convert.ToDecimal(NumberOfYears) / 12M) *
                (LoanAmount + 5000));
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nHome Loan Address " + HomeAddress 
                 + "\n Calculated Interest :" + CalculateInterest().ToString("C"); 
        }

    }
}
