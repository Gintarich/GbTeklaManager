using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;

namespace Extensions
{
    public static class ModelObjectEnumExtensensions
    {
        public static List<ModelObject> ToList(this ModelObjectEnumerator modelObjectEnumerator)
        {
            List<ModelObject> list = new List<ModelObject>();
            while (modelObjectEnumerator.MoveNext())
            {
                list.Add(modelObjectEnumerator.Current);
            }
            return list;
        }

        public static List<T> ToList<T>(this ModelObjectEnumerator modelObjectEnumerator) where T : ModelObject
        {
            List<T> list = new List<T>();
            while (modelObjectEnumerator.MoveNext())
            {
                list.Add((T)modelObjectEnumerator.Current);
            }
            return list;
        }
    }
}
