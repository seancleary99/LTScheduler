using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Classes
{
    public class HouseType
    {
        private int _id;
        private string _houseType;

        public int ID { get { return _id; } set { _id = value; } }
        public string HsType { get { return _houseType; } set { _houseType = value; } }

        #region Constructors
        public HouseType() { }

        public HouseType(int id, string houseType)
        {
            _id = id;
            _houseType = houseType;
        }

        public HouseType(int id)
        {
            _id = id;
            DAL db = new DAL();
            DataTable hType = db.GetHouseType(id);
            if (hType.Rows.Count == 1)
            {
                _houseType = hType.Rows[0][1].ToString();
            }
        }

        public bool Save()
        {
            bool isSaved = false;
            DAL db = new DAL();
            isSaved = db.SaveHouseType(_id, _houseType);
            return isSaved;
        }

        public bool Delete()
        {
            bool isDeleted = false;
            DAL db = new DAL();
            isDeleted = db.DeleteHouseType(_id);
            return isDeleted;
        }
        #endregion
    }


}
