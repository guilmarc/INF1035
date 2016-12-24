using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Core.Model;

namespace Core
{
    /// <summary>
    /// Méthodes d'extensions utiles
    /// </summary>
    public static class Extensions
    {

        public static void OnPropertyCHange(this PropertyChangedEventHandler propertyChanged, object sender, string propertyName)
        {
            if (propertyChanged != null)
            {
                propertyChanged(sender, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Conversion en Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string value)
        {
            return (T) Enum.Parse(typeof(T), value, true);
        }
        
        /// <summary>
        /// Retoure un élément au hasard dans la liste
        /// </summary>
        private static readonly Random _random = new Random();
        public static T Random<T>(this List<T> objects)
        {
            return objects.Count == 0 ? default(T) : objects[_random.Next(objects.Count - 1)];
        }

        /// <summary>
        /// Retoune seulement les monstes en vie dans la liste
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<Monster> Alive(this List<Monster> list)
        {
            return list.Where(x => x.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual > 0).ToList();
        }

        /// <summary>
        /// Réinitialisations des caractéristiques des monstres dans la liste
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int Reset(this List<Monster> list)
        {
            list.ForEach(x => x.ResetCaracterictics());
            return list.Count;
        }

        /// <summary>
        /// Réénergisation des monstres dans la liste
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int Energize(this List<Monster> list)
        {
            list.ForEach(x => x.Energize());
            return list.Count;
        }

        /// <summary>
        /// Moyenne des points d'expériences des monstres dans la liste
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int AverageExperiencePoints(this List<Monster> list)
        {
            return (int)list.Average(x => x.ExperiencePoint);
        }

        /// <summary>
        /// Moyenne des niveau d'expérience des monstres dans la liste
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int AverageExperienceLevel(this List<Monster> list)
        {
            return (int)list.Average(x => x.ExperienceLevel);
        }
    }
}

