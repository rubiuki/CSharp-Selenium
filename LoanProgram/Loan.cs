using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProgram
{
    abstract internal class Loan
    {
        public string loanNumber;
        public string firstName;
        public string lastName;
        public double interestRate;
        public decimal loanAmount;
        public double numberOfYears;

        public string LoanNumber 
        {
            get { return loanNumber; }
            set { loanNumber = value; }
        }
        public string FirstName 
        { 
            get { return firstName;  }
            set { firstName = value; }
        }
        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double InterestRate { 
            get { return interestRate; } 
            set { interestRate = value; } 
        }
        public decimal LoanAmount 
        {
            get { return loanAmount; } 
            set { loanAmount = value; }
        }
        public double NumberOfYears 
        { 
            get { return  numberOfYears; } 
            set { numberOfYears = value; } 
        }

        public Loan (string number, string fname, string lname, double rate, decimal amount, double year)
        {
            LoanNumber = number;
            FirstName = fname;
            LastName = lname;
            InterestRate = rate;
            LoanAmount = amount;
            NumberOfYears = year;
        }

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return "Customer:  " + FirstName + " " + LastName + 
                "\nLoan amount:  " + LoanAmount.ToString("C") + 
                "\nInterest Rate:  " + InterestRate.ToString("p2") + 
                "\nLoan Duration:  " + NumberOfYears;
        }
    }
}
