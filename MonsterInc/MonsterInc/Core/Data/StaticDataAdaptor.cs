
using System;
using System.Collections.Generic;
using Core.Data.Static;

namespace Core.Data
{
    /// <summary>
    /// Implémantation d'un adapteur de données lié à des données statiques en code
    /// </summary>
    /// <typeparam name="T">Type de liste à obtenir</typeparam>
    public class StaticDataAdaptor<T> : IDataAdaptor<T>
    {
        /// <summary>
        /// Retourne une liste typée selon le type demandé
        /// </summary>
        /// <returns></returns>
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