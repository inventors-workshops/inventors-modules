using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1
{
    public class ResourceTypeDataProvider
    {
        //create resource type
        public int Create(string _name, bool _isActive)
        {
            int prKey = -1;

            ResourceType moduleResourceType = new ResourceType();

            moduleResourceType.Name = _name;
            moduleResourceType.IsActive = _isActive;

            using (DBEntities db = new DBEntities())
            {
                db.ResourceTypes.Add(moduleResourceType);
                db.SaveChanges();
            }
            prKey = moduleResourceType.PrKey;

            return prKey;
        }
        //display the resourceType
        public IEnumerable<ResourceType> DisplayAllResourceTypes()
        {
            using (DBEntities db = new DBEntities())
            {
                return db.ResourceTypes.ToArray<ResourceType>();
            }
        }

        //update ResourceType if necessary
        public void UpdateResourceType(int prKey, string _name, bool _isActive)
        {
            using (DBEntities db = new DBEntities())
            {
                ResourceType moduleResourceType = db.ResourceTypes.Where(m => m.PrKey == prKey).First<ResourceType>();

                moduleResourceType.Name = _name;
                moduleResourceType.IsActive = _isActive;

                db.SaveChanges();
            }
        }

        public bool deleteResourceType(int prKey)
        {
            using (DBEntities db = new DBEntities())
            {
                ResourceType moduleResourceType = db.ResourceTypes.Where(m => m.PrKey == prKey).First<ResourceType>();
                moduleResourceType.IsActive = false;
                db.SaveChanges();
            }
            return true;
        }
    }
}