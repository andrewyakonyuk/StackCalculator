using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalc
{
    /// <summary>
    /// Определяет приоритет выполнения оператора
    /// </summary>
    public enum OperationPriority
    {
        /// <summary>
        /// Низкий приоритет выполнения операции
        /// </summary>
        Low = 0,
        /// <summary>
        /// Средний приоритет выполнения операции
        /// </summary>
        Medium = 1,
        /// <summary>
        /// Высокий приоритет выполнения операции
        /// </summary>
        High = 2
    }

    /// <summary>
    /// Представляет некоторый оператор, умеющий взаимодействовать с некоторым типом
    /// </summary>
    public abstract class Operator : Operation
    {
        int _numberOperands = 2;

        /// <summary>
        /// Выполняет операцию, требуемую от данного оператора
        /// </summary>
        /// <param name="op1">Перый операнд</param>
        /// <param name="op2">Второй операнд</param>
        /// <returns>Результат операции</returns>
        public virtual Operands Calc(params Operands[] operands) { return default(Operands); }

        /// <summary>
        /// Возвращает число операндов, с которыми взаимодействует оператор
        /// </summary>
        public int NumberOperands
        {
            get { return _numberOperands; }
            protected set { _numberOperands = value; }
        }
    }

    /// <summary>
    /// Инкапсулирует операцию сложения операндов
    /// </summary>
    public class Add : Operator
    {
        public Add()
        {
            base.Priority = OperationPriority.Low;
        }

        public override Operands Calc(params Operands[] operands)
        {
            Digit first = operands[0] as Digit;
            Digit second = operands[1] as Digit;
            if (first != null && second != null)
            {
                Digit result = first + second;
                return result;
            }
            else return null;
        }

        /// <summary>
        /// Отображает символьный вид оператора
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "+";
        }
    }

    /// <summary>
    /// Реализует операцию умножения операндов
    /// </summary>
    public class Multiple : Operator
    {
        public Multiple()
        {
            base.Priority = OperationPriority.Medium;
        }

        public override Operands Calc(params Operands[] operands)
        {
            Digit first = operands[0] as Digit;
            Digit second = operands[1] as Digit;
            if (first != null && second != null)
            {
                Digit result = first * second;
                return result;
            }
            else return null;
        }

        /// <summary>
        /// Отображает символьный вид оператора
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "*";
        }
    }

    /// <summary>
    /// Реализует операцию деления операндов
    /// </summary>
    public class Divide : Operator
    {
        public Divide()
        {
            base.Priority = OperationPriority.Medium;
        }

        public override Operands Calc(params Operands[] operands)
        {
            Digit first = operands[0] as Digit;
            Digit second = operands[1] as Digit;
            if (first != null && second != null)
            {
                Digit result = first / second;
                return result;
            }
            else return null;
        }

        /// <summary>
        /// Отображает символьный вид оператора
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "/";
        }
    }

    /// <summary>
    /// Реализует операцию вычитания операндов
    /// </summary>
    public class Substract : Operator
    {
        public Substract()
        {
            base.Priority = OperationPriority.Low;
        }

        public override Operands Calc(params Operands[] operands)
        {
            Digit first = operands[0] as Digit;
            Digit second = operands[1] as Digit;
            if (first != null && second != null)
            {
                Digit result = ((double)first) - ((double)second);
                return result;
            }
            return null;
        }

        /// <summary>
        /// Отображает символьный вид оператора
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "-";
        }
    }

    /// <summary>
    /// Реализует операцию взятия остачи от деления
    /// </summary>
    public class Module : Operator
    {
        public Module()
        {
            base.Priority = OperationPriority.Medium;
        }

        public override Operands Calc(params Operands[] operands)
        {
            Digit first = operands[0] as Digit;
            Digit second = operands[1] as Digit;
            if (first != null && second != null)
            {
                Digit result = first % second;
                return result;
            }
            else return null;
        }

        /// <summary>
        /// Отображает символьный вид оператора
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "%";
        }
    }

    /// <summary>
    /// Реализует операцию вознесения в степень
    /// </summary>
    public class Pow : Operator
    {
        public Pow()
        {
            base.Priority = OperationPriority.High;
        }

        public override Operands Calc(params Operands[] operands)
        {
            Digit first = operands[0] as Digit;
            Digit second = operands[1] as Digit;
            if (first != null && second != null)
            {
                Digit result = Math.Pow(first, second);
                return result;
            }
            else return null;
        }

        /// <summary>
        /// Отображает символьный вид оператора
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "^";
        }
    }

    /// <summary>
    /// Реализует операцию вычитания операндов
    /// </summary>
    public class Sign : Operator
    {
        public Sign()
        {
            base.Priority = OperationPriority.High;
            base.NumberOperands = 1;
        }

        public override Operands Calc(params Operands[] operands)
        {
            Digit first = operands[0] as Digit;
            if (first != null)
            {
                Digit result = 0 - first;
                return result;
            }
            return null;
        }

        /// <summary>
        /// Отображает символьный вид оператора
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "~";
        }
    }

    /// <summary>
    /// Специальный оператор. Используется для разделения операций
    /// </summary>
    public class Special : Operator
    {
        public Special()
        {
            base.Priority = OperationPriority.Low;
        }
    }
}
