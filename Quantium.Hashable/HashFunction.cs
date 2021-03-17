using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantium.Hashable
{
    /// <summary>
    /// Default hash function
    /// </summary>
    public sealed class HashFunction : IHashFunction
    {
        private const int initPrime = 2147483647;

        /// <summary>
        /// Calculate the hash of a byte
        /// </summary>
        /// <param name="val">Byte value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(byte val, int hash = 0)
        {
            return Hash(new byte[] { val }) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of a 
        /// </summary>
        /// <param name="val"> value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(sbyte val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of a char
        /// </summary>
        /// <param name="val">Char value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(char val, int hash = 0)
        {
            return Hash(new char[] { val }) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of a short 
        /// </summary>
        /// <param name="val">Short value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(short val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of an unsigned short
        /// </summary>
        /// <param name="val">Unsigned short value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(ushort val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of an integer
        /// </summary>
        /// <param name="val">Integer value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(int val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of an unsigned integer
        /// </summary>
        /// <param name="val">Unsigned integer value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(uint val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of a long
        /// </summary>
        /// <param name="val">Long value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(long val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of an unsigned long
        /// </summary>
        /// <param name="val">Unsigned long value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(ulong val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of a float
        /// </summary>
        /// <param name="val">Float value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(float val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of a double
        /// </summary>
        /// <param name="val">Double value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(double val, int hash = 0)
        {
            return Hash(BitConverter.GetBytes(val)) ^ hash;
        }

        /// <summary>
        /// Calculate the hash of a decimal
        /// </summary>
        /// <param name="val">Decimal value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(decimal val, int hash = 0)
        {
            int result = hash;
            foreach (int i in Decimal.GetBits(val))
            {
                result ^= Hash(BitConverter.GetBytes(i));
            }
            return result;
        }

        /// <summary>
        /// Calculate the hash of a string
        /// </summary>
        /// <param name="val">String value</param>
        /// <param name="hash">Include the pre-existing hash value</param>
        /// <returns>32-bit hash value</returns>
        public int Hash(string val, int hash = 0)
        {
            return Hash(val.ToCharArray()) ^ hash;
        }

        /// <summary>
        /// A variation on the Jenkins hash <br/>
        /// <a href="https://en.wikipedia.org/wiki/Jenkins_hash_function"/>
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static int Hash(byte[] values)
        {
            uint hash = initPrime;

            foreach (byte key in values)
            {
                hash += key;
                hash += hash << 10;
                hash ^= hash >> 6;
            }
            hash += hash << 3;
            hash ^= hash >> 11;
            hash += hash << 15;
            return (int)hash;
        }

        /// <summary>
        /// A variation on the Jenkins hash <br/>
        /// <a href="https://en.wikipedia.org/wiki/Jenkins_hash_function"/>
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static int Hash(char[] values)
        {
            uint hash = initPrime;

            foreach (char key in values)
            {
                hash += key;
                hash += hash << 10;
                hash ^= hash >> 6;
            }
            hash += hash << 3;
            hash ^= hash >> 11;
            hash += hash << 15;
            return (int)hash;
        }
    }
}
