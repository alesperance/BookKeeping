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
        protected List<double> _listPurchases;
        protected List<double> _listSupplies;
        protected List<double> _listMembership;
        protected List<double> _listEducation;
        protected List<double> _listTravel;
        protected List<double> _listPostage;
        protected List<double> _listTelephone;
        protected List<double> _listRent;
        protected List<double> _listInsurance;

        //Fields for lists of expenses
        protected double _totalPurchase     { get; private set; }
        protected double _totalSupplies     { get; private set; }
        protected double _totalMembership   { get; private set; }
        protected double _totalEducation    { get; private set; }
        protected double _totalTravel       { get; private set; }
        protected double _totalPostage      { get; private set; }
        protected double _totalTelephone    { get; private set; }
        protected double _totalRent         { get; private set; }
        protected double _totalInsurance    { get; private set; }
        protected double _totalMonthly      { get; private set; }

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

    }
}
