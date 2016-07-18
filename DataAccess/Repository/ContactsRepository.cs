namespace DataAccess.Repository
{
    using System;
    using DataAccess.Entity;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ContactsRepository : BaseRepository<ContactEntity>
    {
        public ContactsRepository(string pathToFile) 
            : base(pathToFile)
        {
        }

        protected override void WriteItemToStream(StreamWriter sw, ContactEntity item)
        {
            sw.WriteLine(item.UserId);
            sw.WriteLine(item.FullName);
            sw.WriteLine(item.Email);
        }

        protected override void ReadItemFromStream(StreamReader sr, ContactEntity item)
        {
            item.UserId = Convert.ToInt32(sr.ReadLine());
            item.FullName = sr.ReadLine();
            item.Email = sr.ReadLine();
        }

        public List<ContactEntity> GetAll(int userId)
        {
            return GetAll().FindAll(c => c.UserId == userId);
        }
    }
}
