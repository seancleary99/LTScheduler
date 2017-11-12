using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Classes
{
    public class Erector
    {
        private int _id;
        private string _erectorName;

        public int ID { get { return _id; } set { _id = value; } }
        public string ErectorName { get { return _erectorName; } set { _erectorName = value; } }

        #region Constructors
        public Erector() { }

        public Erector(int id, string name) {
            _id = id;
            _erectorName = name;
        }

        public Erector(int id)
        {
            _id = id;
            DAL db = new DAL();
            DataTable dtErector = db.GetErector(id);
            if (dtErector.Rows.Count == 1)
            {
                _erectorName = dtErector.Rows[0][1].ToString();
            }
        }

        public bool Save() {
            bool isSaved = false;
            DAL db = new DAL();
            isSaved = db.SaveErector(_id, _erectorName);
            return isSaved;
        }

        public bool Delete() {
            bool isDeleted = false;
            DAL db = new DAL();
            isDeleted = db.DeleteErector(_id);
            return isDeleted;
        }
        #endregion

    }
}
