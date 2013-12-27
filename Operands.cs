using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalc
{
    /// <summary>
    /// Представляет собой операнд, с которым проводится вычисление
    /// </summary>
    public class Operands
    {
        public Operands(object value)
        {
            this.Value = value;
        }

        public Operands() { }

        /// <summary>
        /// Возвращает или задает значение операнда 
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Возвращает строковое представление операнда
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }

    /// <summary>
    /// Представляет число с плавающей запятой
    /// </summary>
    public class Digit : Operands
    {
        public Digit(double d) { Value = d; }

        public Digit() { }

        /// <summary>
        /// Приведение типа Digit к типу double
        /// </summary>
        /// <example>
        /// <code>
        /// Digit digit = new Digit(5);
        /// double some_double = digit;
        /// </code>
        /// </example>
        public static implicit operator double(Digit d)
        {
            return (double)d.Value;
        }

        /// <summary>
        /// Приведение типа double к типу Digit
        /// </summary>
        public static implicit operator Digit(double d)
        {
            return new Digit(d);
        }

    }
}
