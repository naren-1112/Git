using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using DataAccessLayer;

namespace HELPER
{
    public class Helper
    {
        DAL dal = null;
        public Helper()
        {
            dal = new DAL();
        }

        /*---------student----------------*/
        public bool AddE(BAL schooll)
        {
            return dal.Insert(schooll);

        }

        public bool Edit(BAL schooll)
        {
            return dal.Update(schooll);
        }

        public BAL search(int id)
        {
            return dal.Find(id);
        }
        public List<BAL> List()
        {
            return dal.List();
        }
        public bool remove(int id)
        {
            return dal.Delete(id);
        }
        /*---subject------*/
        public List<BAL> subList()
        {
            return dal.List1();
        }
        public bool Addsub(BAL schooll)
        {
            return dal.Insert1(schooll);

        }

        public bool editsub(BAL schooll)
        {
            return dal.Update1(schooll);
        }

        public BAL searchsub(int id)
        {
            return dal.Find1(id);
        }
        public bool removesub(int id)
        {
            return dal.Delete1(id);
        }

        /*----------class------------*/
        public List<BAL> classList()
        {
            return dal.List2();
        }
        public bool Addclass(BAL schooll)
        {
            return dal.Insert2(schooll);

        }

        public bool editclass(BAL schooll)
        {
            return dal.Update2(schooll);
        }

        public BAL searchclass(int id)
        {
            return dal.Find2(id);
        }
        public bool removeclass(int id)
        {
            return dal.Delete2(id);
        }
    }
}