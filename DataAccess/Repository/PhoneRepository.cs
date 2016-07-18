namespace DataAccess.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DataAccess.Entity;
    using System.IO;

    public class PhoneRepository : BaseRepository<PhoneEntity>
    {
        public PhoneRepository(string pathToFile)
            : base(pathToFile)
        {
        }

        protected override void WriteItemToStream(StreamWriter sw, PhoneEntity item)
        {
            sw.WriteLine(item.ContactId);
            sw.WriteLine(item.Phone);
        }

        protected override void ReadItemFromStream(StreamReader sr, PhoneEntity item)
        {
            item.ContactId = Convert.ToInt32(sr.ReadLine());
            item.Phone = sr.ReadLine();
        }

        public List<PhoneEntity> GetAll(int ContactId)
        {
            return GetAll().FindAll(p => p.ContactId == ContactId);
        }
    }
}
