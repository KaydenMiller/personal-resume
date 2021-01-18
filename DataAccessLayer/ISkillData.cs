using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public interface ISkillData
    {
        public Task<List<SkillModel>> GetSkills();
        public Task InsertSkill(SkillModel skill);
    }
}