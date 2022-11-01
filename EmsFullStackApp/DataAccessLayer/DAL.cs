using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;


namespace DataAccessLayer
{

        public class MyContext : DbContext
        {
            public MyContext() : base("Myc")
            {


                Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
            }

            public virtual DbSet<EmpProfiles> emptable { get; set; }


        }
        public class DAL
        {
            public List<EmpProfiles> GetCustomers()
            {
                MyContext context = new MyContext();

                List<EmpProfiles> clist = context.emptable.ToList();
                List<EmpProfiles> cblists = new List<EmpProfiles>();
                foreach (var item in clist)
                {
                    cblists.Add(new EmpProfiles
                    {
                        EmpCode = item.EmpCode,
                        EmpName = item.EmpName,
                        Email = item.Email,

                        DeptCode = item.EmpCode
                    });



                }
                return cblists;




            }
            public void Insertcustomer(EmpProfiles bal)
            {
                MyContext context = new MyContext();
                EmpProfiles i = new EmpProfiles();
                i.EmpCode = bal.EmpCode;
                i.EmpName = bal.EmpName;
                i.Email = bal.Email;

                i.DeptCode = bal.DeptCode;
                context.emptable.Add(i);
                context.SaveChanges();

            }
            public void UpdateCustomer(EmpProfiles bal)
            {
                MyContext context = new MyContext();
                List<EmpProfiles> customers = context.emptable.ToList();
                EmpProfiles u
                    = customers.Find(cust => cust.EmpCode == bal.EmpCode);
                u.EmpCode = bal.EmpCode;
                u.EmpName = bal.EmpName;
                u.Email = bal.Email;

                u.DeptCode = bal.DeptCode;
            
            context.SaveChanges();


            }


            public void Remove(int id)
            {
                MyContext context = new MyContext();
                var ans = context.emptable.ToList().Find(temp => temp.EmpCode == id);
                context.emptable.Remove(ans);
                context.SaveChanges();
            }
            public EmpProfiles search(int id)
            {
                MyContext context = new MyContext();
                var customers = context.emptable.ToList();
                var obj = customers.Find(cust => cust.EmpCode == id);

                // List<BLClass1> cblist = new List<BLClass1>();
                EmpProfiles s= new EmpProfiles();
                s.EmpName = obj.EmpName;
                s.EmpCode = obj.EmpCode;
                s.Email = obj.Email;
                s.DeptCode = obj.DeptCode;



                return s;

                //context.SaveChanges();
            }
        }
    }

