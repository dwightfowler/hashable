using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quantium.Hashable
{
    /// <summary>
    /// Hashing extension
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Calculate the hash on any object that marks it's fields using [HashableAttribute] 
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>A 32-bit hash of all field values that have the [HashableAttribute]</returns>
        public static int Hash(this Object obj)
        {
            int result = 0;
            if (obj is null)
                return result;

            var fields = from field in obj.GetType().GetRuntimeFields()
                         where field.GetCustomAttribute<HashableAttribute>(true) is object
                         select (new FieldData(){ Field = field, Obj = obj});

            HashFunction fnc = new HashFunction();
            foreach(var field in fields)
            {
                result = HashIt(fnc, field, result);
            }
            return result;
        }

        internal class FieldData
        {
            internal FieldInfo Field;
            internal object Obj;
        }

        internal static int HashIt(IHashFunction fnc, FieldData data, int hash)
        {
            int result = hash;

            object val = data.Field.GetValue(data.Obj);
            switch (val)
            {
                case byte i:
                    result = fnc.Hash(i, hash);
                    break;
                case sbyte i:
                    result = fnc.Hash(i, hash);
                    break;
                case char i:
                    result = fnc.Hash(i, hash);
                    break;
                case short i:
                    result = fnc.Hash(i, hash);
                    break;
                case ushort i:
                    result = fnc.Hash(i, hash);
                    break;
                case int i:
                    result = fnc.Hash(i, hash);
                    break;
                case uint i:
                    result = fnc.Hash(i, hash);
                    break;
                case long i:
                    result = fnc.Hash(i, hash);
                    break;
                case ulong i:
                    result = fnc.Hash(i, hash);
                    break;
                case float i:
                    result = fnc.Hash(i, hash);
                    break;
                case double i:
                    result = fnc.Hash(i, hash);
                    break;
                case decimal i:
                    result = fnc.Hash(i, hash);
                    break;
                case string i:
                    result = fnc.Hash(i, hash);
                    break;

                default:
                    result = val.Hash() ^ hash;
                    break;
            }

            return result;
        }
    }
}
