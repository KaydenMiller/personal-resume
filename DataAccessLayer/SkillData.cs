using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class SkillData : ISkillData
    {
        private readonly IDataAccess _db;

        public SkillData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<SkillModel>> GetSkills()
        {
            var sql = "SELECT * FROM KaydenMiller.dbo.Skills";
            return _db.LoadData<SkillModel, dynamic>(sql, new {});
        }

        public Task InsertSkill(SkillModel skill)
        {
            var sql = @"INSERT INTO KaydenMiller.dbo.Skills (Name, Description, PersonalStarRating, Tooltip) 
                        VALUES (@Name, @Description, @PersonalStarRating, @Tooltip);";
            return _db.InsertData(sql, skill);
        }
    }
}