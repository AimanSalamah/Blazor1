using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mkabbani.Data
{
    public class Customers : BaseTable
    {
        public string Name { get; set; }
    }

    public interface IBaseTable
    {
        int ID { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
        int AddressID { get; set; }
    }
    public class BaseTable : IBaseTable
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
    }
    public class Address : BaseTable
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
