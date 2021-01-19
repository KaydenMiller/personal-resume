using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public interface ISkillCategoryData
    {
        public Task<List<SkillCategoryModel>> GetSkillCategories();
        public Task InsertSkillCategory(SkillCategoryModel skill);
    }
}