using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class Contractor
    {
        private int _id;
        private string _contName;

        public int ID { get { return _id; } set { _id = value; } }
        public string ContractorName { get { return _contName; } set { _contName = value; } }

        #region Constructors
        public Contractor() { }

        public Contractor(int id, string name) {
            _id = id;
            _contName = name;
        }

        public bool Save() {
            bool isSaved = false;
            DAL db = new DAL();
            isSaved = db.SaveContractor(_id, _contName);
            return isSaved;
        }

        public bool Delete() {
            bool isDeleted = false;
            DAL db = new DAL();
            isDeleted = db.DeleteContractor(_id);
            return isDeleted;
        }
        #endregion

    }
}
