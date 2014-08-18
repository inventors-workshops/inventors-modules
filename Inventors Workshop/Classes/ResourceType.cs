using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Inventors_Workshop.Classes
{
    public class ResourceType 
    {
        public int ResourceTypeID { get; set; }

        //Not sure if char is what you'd want here
        public char Name { get; set; }
        public bool IsActive { get; set; }

        //Create
        public void Create()
        {
            ResourceType list = new ResourceType();
            list.Add();
            
        }

        //Read 
        public string Details()
        {
            return;
            
        }

        //Edit
        public void Edit()
        {
            
        }

        //Delete
        public void Delete()
        {
            
        }
    }
}