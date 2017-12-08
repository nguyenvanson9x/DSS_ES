using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Demo
    {
        private DAL_Demo dalDemo = new DAL_Demo();

        public DataTable getDemo()
        {
            return dalDemo.getDemo();
        }

        public bool themDemo(DTO_Demo d)
        {
            return dalDemo.themDemo(d);
        }

        public bool suaDemo(DTO_Demo d)
        {
            return dalDemo.suaDemo(d);
        }

        public bool xoaDemo(string name)
        {
            return dalDemo.xoaDemo(name);
        }
    }
}
