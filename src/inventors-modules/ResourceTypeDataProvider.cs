using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1
{
    public class ResourceTypeDataProvider
    {
        //create resource
        public int create(string _name, bool _isActive)
        {
            int prKey = -1;

            resourcetype moduleResourceType = new resourcetype();

            moduleResourceType.Name = _name;
            moduleResourceType.IsActive = _isActive;

            using (db539594002Entities db = new db539594002Entities())
            {
                db.resourcetype.Add(moduleResourceType);
                db.SaveChanges();
            }
            prKey = moduleResourceType.PrKey;
            
            return prKey;
        }

        //Read
        public resourcetype displayResourceTypes()
        {
            db539594002Entities db = new db539594002Entities();
             
            return db.resourcetype;
        }

        //update ResourceType if necessary
        public void updateResourceType(int prKey, string _name, bool _isActive)
        {
            using (db539594002Entities db = new db539594002Entities())
            {
                resourcetype moduleResourceType = db.resourcetype.Where(m => m.PrKey == prKey).First<resourcetype>();

                moduleResourceType.Name = _name;
                moduleResourceType.IsActive = _isActive;

                db.SaveChanges();
            }
        }

        public bool deleteResourceType(int prKey)
        {
            using (db539594002Entities db = new db539594002Entities())
            {
                resourcetype moduleResourceType = db.resourcetype.Where(m => m.PrKey == prKey).First<resourcetype>();
                moduleResourceType.IsActive = false;
                db.SaveChanges();
            }
            return true;
        }
    }
}