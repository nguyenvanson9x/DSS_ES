using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_Demo
    {
        private string name;

        public DTO_Demo()
        {

        }

        public DTO_Demo(string name)
        {
            this.name = name;
        }
        public string Name { get; set; }
    }
}
