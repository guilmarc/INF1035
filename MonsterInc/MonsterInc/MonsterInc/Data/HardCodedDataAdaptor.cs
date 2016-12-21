
using System;
using System.Collections.Generic;
using Core.Database;

namespace Core.Data
{
    public class HardCodedDataAdaptor<T> : IDataAdaptor<T>
    {
        public List<T> GetObjects()
        {
            switch (typeof(T).Name)
            {
                case "MonsterTemplate": return MonsterTemplateData.MonsterTemplates as List<T>;
                case "Item": return ItemData.Items as List<T>;
                case "Skill": return SkillData.Skills as List<T>;
                case "Difficulty": return DifficultyData.Difficulty as List<T>;
                case "Trainer": return TrainerData.TrainerNames as List<T>;
                default: return null;
            }
        }
    }
}