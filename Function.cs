using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalc
{
    /// <summary>
    /// Представляет базовый класс функций
    /// </summary>
    public abstract class Function : Operation
    {
        public Function()
        {
            base.Priority = OperationPriority.High;
            this.MaxNumberOfArguments = 1;
            this.MinNumberOfArguments = 1;
        }

        /// <summary>
        /// Минимальное количество аргументов
        /// </summary>
        public int MinNumberOfArguments { get; protected set; }

        /// <summary>
        /// Максимальное количество аргументов
        /// </summary>
        public int MaxNumberOfArguments { get; protected set; }

        /// <summary>
        /// Выполняет вычисления согласно функции
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public virtual Operands Calc(params Operands[] args) { return default(Operands); }

        public int NumberOfArguments { get; set; }
    }

    public class Sqrt : Function
    {
        public Sqrt()
        {
            base.MinNumberOfArguments = 1;
            base.MaxNumberOfArguments = 1;
        }

        public override Operands Calc(params Operands[] args)
        {
            if (args.Length > NumberOfArguments)
            {
                throw new FunctionException("Слишком большое количество аргументов для данной функции");
            }
            else
            {
                Digit firstArg = args[0] as Digit;
                if (firstArg == null)
                {
                    throw new FunctionException("Неверный тип аргументов для даной функции");
                }
                else
                {
                    Digit result = Math.Sqrt(firstArg);
                    return result;
                }
            }
        }

        public override string ToString()
        {
            return "sqrt";
        }
    }

    public class Middle : Function
    {
        public Middle()
        {
            base.MinNumberOfArguments = 1;
            base.MaxNumberOfArguments = 30;
        }

        public override Operands Calc(params Operands[] args)
        {
            if (args.Length > NumberOfArguments)
            {
                throw new FunctionException("Слишком большое количество аргументов для данной функции");
            }
            else
            {
                Digit temp = 0;
                for (int i = 0; i < this.NumberOfArguments; i++)
                {
                    Digit firstArg = args[i] as Digit;
                    if (firstArg == null)
                    {
                        throw new FunctionException("Неверный тип аргументов для даной функции");
                    }
                    else
                    {
                        temp += firstArg;
                    }
                }
                Digit result = temp / this.NumberOfArguments;
                return result;
            }
        }

        public override string ToString()
        {
            return "среднее";
        }
    }

    public class Summ : Function
    {
        public Summ()
        {
            base.MinNumberOfArguments = 1;
            base.MaxNumberOfArguments = 30;
        }

        public override Operands Calc(params Operands[] args)
        {
            if (args.Length > NumberOfArguments)
            {
                throw new FunctionException("Слишком большое количество аргументов для данной функции");
            }
            else
            {
                Digit temp = 0;
                for (int i = 0; i < this.NumberOfArguments; i++)
                {
                    Digit firstArg = args[i] as Digit;
                    if (firstArg == null)
                    {
                        throw new FunctionException("Неверный тип аргументов для даной функции");
                    }
                    else
                    {
                        temp += firstArg;
                    }
                }
                return temp;
            }
        }

        public override string ToString()
        {
            return "сумма";
        }
    }

    public class Log : Function
    {
        public Log()
        {
            base.MinNumberOfArguments = 1;
            base.MaxNumberOfArguments = 1;
        }

        public override Operands Calc(params Operands[] args)
        {
            if (args.Length > NumberOfArguments)
            {
                throw new FunctionException("Слишком большое количество аргументов для данной функции");
            }
            else
            {
                Digit firstArg = args[0] as Digit;
                if (firstArg == null)
                {
                    throw new FunctionException("Неверный тип аргументов для даной функции");
                }
                else
                {
                    Digit result = Math.Log(firstArg, 10);
                    return result;
                }
            }
        }

        public override string ToString()
        {
            return "log";
        }
    }

    public class Sin : Function
    {
        public Sin()
        {
            base.MinNumberOfArguments = 1;
            base.MaxNumberOfArguments = 1;
        }

        public override Operands Calc(params Operands[] args)
        {
            if (args.Length > NumberOfArguments)
            {
                throw new FunctionException("Слишком большое количество аргументов для данной функции");
            }
            else
            {
                Digit firstArg = args[0] as Digit;
                if (firstArg == null)
                {
                    throw new FunctionException("Неверный тип аргументов для даной функции");
                }
                else
                {
                    Digit result = Math.Sin(firstArg);
                    return result;
                }
            }
        }

        public override string ToString()
        {
            return "sin";
        }
    }

    public class Cos : Function
    {
        public Cos()
        {
            base.MinNumberOfArguments = 1;
            base.MaxNumberOfArguments = 1;
        }

        public override Operands Calc(params Operands[] args)
        {
            if (args.Length > NumberOfArguments)
            {
                throw new FunctionException("Слишком большое количество аргументов для данной функции");
            }
            else
            {
                Digit firstArg = args[0] as Digit;
                if (firstArg == null)
                {
                    throw new FunctionException("Неверный тип аргументов для даной функции");
                }
                else
                {
                    Digit result = Math.Cos(firstArg);
                    return result;
                }
            }
        }

        public override string ToString()
        {
            return "cos";
        }
    }

    public class Tan : Function
    {
        public Tan()
        {
            base.MinNumberOfArguments = 1;
            base.MaxNumberOfArguments = 1;
        }

        public override Operands Calc(params Operands[] args)
        {
            if (args.Length > NumberOfArguments)
            {
                throw new FunctionException("Слишком большое количество аргументов для данной функции");
            }
            else
            {
                Digit firstArg = args[0] as Digit;
                if (firstArg == null)
                {
                    throw new FunctionException("Неверный тип аргументов для даной функции");
                }
                else
                {
                    Digit result = Math.Tan(firstArg);
                    return result;
                }
            }
        }

        public override string ToString()
        {
            return "tan";
        }
    }

    /// <summary>
    /// Представляет ошибки, возникающие при расчете функций
    /// </summary>
    [Serializable]
    public class FunctionException : Exception
    {
        public FunctionException() { }
        public FunctionException(string message) : base(message) { }
        public FunctionException(string message, Exception inner) : base(message, inner) { }
        protected FunctionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
