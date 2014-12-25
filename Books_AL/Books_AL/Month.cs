using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_AL
{
    public class Month
    {
        //Lists of specific expenses
        public List<double> _listPurchases   { get; private set; }
        public List<double> _listSupplies { get; private set; }
        public List<double> _listMembership { get; private set; }
        public List<double> _listEducation { get; private set; }
        public List<double> _listTravel { get; private set; }
        public List<double> _listPostage { get; private set; }
        public List<double> _listTelephone { get; private set; }
        public List<double> _listRent { get; private set; }
        public List<double> _listInsurance { get; private set; }

        //Fields for lists of expenses
        public double _totalPurchase     { get; private set; }
        public double _totalSupplies     { get; private set; }
        public double _totalMembership   { get; private set; }
        public double _totalEducation    { get; private set; }
        public double _totalTravel       { get; private set; }
        public double _totalPostage      { get; private set; }
        public double _totalTelephone    { get; private set; }
        public double _totalRent         { get; private set; }
        public double _totalInsurance    { get; private set; }
        public double _totalMonthly      { get; private set; }

        //Methods to add prices to the lists of expenses
        public void addPurchases(double purchase)       { _listPurchases.Add(purchase); }
        public void addSupplies(double supply)          { _listSupplies.Add(supply); }
        public void addMembership(double membership)    { _listMembership.Add(membership); }
        public void addEducation(double education)      { _listEducation.Add(education); }
        public void addTravel(double travel)            { _listTravel.Add(travel); }
        public void addPostage(double postage)          { _listPostage.Add(postage); }
        public void addTelephone(double telepone)       { _listTelephone.Add(telepone); }
        public void addRent(double rent)                { _listRent.Add(rent); }
        public void addInsurance(double insurance)      { _listInsurance.Add(insurance); }


        /// <summary>
        /// Constructor for month object.  Initializes all expense lists.
        /// </summary>
        public Month()
        {
            _listPurchases  = new List<double>();
            _listSupplies   = new List<double>();
            _listMembership = new List<double>();
            _listEducation  = new List<double>();
            _listTravel     = new List<double>();
            _listPostage    = new List<double>();
            _listTelephone  = new List<double>();
            _listRent       = new List<double>();
            _listInsurance  = new List<double>();
        }


        public double getTotals(List<double> expenseList)
        {
            double total = 0;
            foreach (double d in expenseList)
            {
                total += d;
            }
            return total;
        }

    }
}
