using Academy.Core.Entities;
using Academy.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Service
{
    public class GroupService
    {
        public AcademyDbContext academyDbContext { get; set; }
        public GroupService()
        {
            academyDbContext= new AcademyDbContext();

        }
        public List<Group> GetAll()=>academyDbContext.Groups
            .Include(g=>g.Students)
            .AsNoTracking().ToList();
        public Group GetById(int? id)
        {
            if (id is null) throw new Exception("");
            var existGroup = academyDbContext.Groups.AsNoTracking().FirstOrDefault(g=>g.ID==id);
            if (existGroup is null) throw new Exception("");
            return existGroup;


        }
        public void Create (Group group)
        {
            var existGroup = academyDbContext.Groups.Any(g => g.Name.Equals(group.Name, StringComparison.OrdinalIgnoreCase));
            if (existGroup)
            {
                throw new Exception("");

            }
            else
            {
                academyDbContext.Groups.Add(group);
                academyDbContext.SaveChanges();

            }
        }
        public void Update(int id, Group group)
        {
            if (id is null) throw new Exception("");
            var existGroup= academyDbContext.Groups.FirstOrDefault(g=>g.ID==id);

        }


        
    }
}
