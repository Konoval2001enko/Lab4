using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_4.Models
{
    public class Record
    {
        public int RecordID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Record()
        {

        }

        public Record(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public Record(int recordID, string name, string phone)
        {
            this.RecordID =recordID;
            this.Name = name;
            this.Phone = phone;
        }

        public override string ToString() => Name + " " + Phone;
    }
}