using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class SkillData : ISkillData, ISkillCategoryData
    {
        private readonly IDataAccess _db;

        public SkillData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<SkillModel>> GetSkills()
        {
            var sql = "SELECT * FROM KaydenMiller.dbo.Skills";
            return _db.LoadData<SkillModel, dynamic>(sql, new { });
        }

        public Task InsertSkill(SkillModel skill)
        {
            var sql = @"INSERT INTO KaydenMiller.dbo.Skills (SkillCategoryId, Name, Description, PersonalStarRating, Tooltip) 
                        VALUES (@SkillCategoryId, @Name, @Description, @PersonalStarRating, @Tooltip);";
            return _db.InsertData(sql, skill);
        }

        public Task<List<SkillCategoryModel>> GetSkillCategories()
        {
            var sql = "SELECT * FROM KaydenMiller.dbo.SkillCategories";
            return _db.LoadData<SkillCategoryModel, dynamic>(sql, new { });
        }

        public Task InsertSkillCategory(SkillCategoryModel skill)
        {
            throw new System.NotImplementedException();
        }
    }
}