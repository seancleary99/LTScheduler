using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Classes
{
    public class CraneHire
    {
        private int _id;
        private string _craneName;

        public int ID { get { return _id; } set { _id = value; } }
        public string CraneName { get { return _craneName; } set { _craneName = value; } }

        #region Constructors
        public CraneHire() { }

        public CraneHire(int id, string craneName)
        {
            _id = id;
            _craneName = craneName;
        }

        public CraneHire(int id)
        {
            _id = id;
            DAL db = new DAL();
            DataTable dtCrane = db.GetCraneHire(id);
            if (dtCrane.Rows.Count == 1)
            {
                _craneName = dtCrane.Rows[0][1].ToString();
            }
        }

        public bool Save()
        {
            bool isSaved = false;
            DAL db = new DAL();
            isSaved = db.SaveCraneHire(_id, _craneName);
            return isSaved;
        }

        public bool Delete()
        {
            bool isDeleted = false;
            DAL db = new DAL();
            isDeleted = db.DeleteCraneHire(_id);
            return isDeleted;
        }
        #endregion
    }
}
