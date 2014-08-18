using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace inventors_modules.Classes
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
            
        }

        //Read 
        public string Details(string info)
        {
            return info;
        }

        //Edit
        public void Update()
        {
           
        }

        //Delete
        public void Delete()
        {

        }
    }
}