using System;

namespace ThrowNewExcetion2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string empty = Name;

            IFormatProvider provider;
            DateTime dateTime = ToDateTime(provider);
        }

        /// <summary>
        /// Null coalescing operator:
        /// A throw expression is used to throw an exception if the string assigned to a Name property is null
        /// </summary>
        public static string Name
        {
            get => name;
            set => name = value ??
                throw new ArgumentNullException(paramName: nameof(value), message: "Name cannot be null");
        }

        /// <summary>
        /// Expression-bodied lambda/method:
        /// Throws an InvalidCastException because a conversion to a DateTime value is not supported
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        private static DateTime ToDateTime(IFormatProvider provider) =>
         throw new InvalidCastException("Conversion to a DateTime is not supported.");
    }
}