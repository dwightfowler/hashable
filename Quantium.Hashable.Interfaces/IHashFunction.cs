using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantium.Hashable
{
    /// <summary>
    /// To use your own hash function, implement each of these methods.
    /// </summary>
    public interface IHashFunction
    {
        /// <summary>
        /// Hash an unsigned byte
        /// </summary>
        /// <param name="val">Byte to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(byte val, int hash = 0);

        /// <summary>
        /// Hash a signed byte
        /// </summary>
        /// <param name="val">Signed byte to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(sbyte val, int hash = 0);

        /// <summary>
        /// Hash an UTF-16 char
        /// </summary>
        /// <param name="val">Char to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(char val, int hash = 0);

        /// <summary>
        /// Hash an 16-bit short
        /// </summary>
        /// <param name="val">Short to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(short val, int hash = 0);

        /// <summary>
        /// Hash an unsigned 16-bit short
        /// </summary>
        /// <param name="val">Unsigned short to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(ushort val, int hash = 0);

        /// <summary>
        /// Hash a 32-bit integer
        /// </summary>
        /// <param name="val">Integer to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(int val, int hash = 0);

        /// <summary>
        /// Hash a 32-bit unsigned integer
        /// </summary>
        /// <param name="val">Unsigned integer to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(uint val, int hash = 0);

        /// <summary>
        /// Hash a 64-bit long
        /// </summary>
        /// <param name="val">Long to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(long val, int hash = 0);

        /// <summary>
        /// Hash an unsigned 64-bit long
        /// </summary>
        /// <param name="val">Unsigned long to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(ulong val, int hash = 0);

        /// <summary>
        /// Hash a 32-bit float
        /// </summary>
        /// <param name="val">Float to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(float val, int hash = 0);

        /// <summary>
        /// Hash a 64-bit double
        /// </summary>
        /// <param name="val">Double to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(double val, int hash = 0);

        /// <summary>
        /// Hash a 128-bit Decimal
        /// </summary>
        /// <param name="val">Decimal to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(decimal val, int hash = 0);

        /// <summary>
        /// Hash a string
        /// </summary>
        /// <param name="val">String to be hashed</param>
        /// <param name="hash">Pre-existing hash value to include</param>
        /// <returns>32-bit signed integer hash value</returns>
        int Hash(string val, int hash = 0);
    }
}
