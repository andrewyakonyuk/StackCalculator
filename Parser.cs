using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalc
{
    /// <summary>
    /// Превращает строку из инфиксной нотации в постфиксную (Польская запись)
    /// </summary>
    public static class PolishNotationParser
    {
        static Dictionary<string, Operator> _dictionaryOperator;
        static Dictionary<string, Function> _dictionaryFunctions = new Dictionary<string, Function>();
        static string operator_string = string.Empty;
        static string function_string = string.Empty;

        /// <summary>
        /// Выполняет инициализацию операторов и функций, с которыми может работать парсер
        /// </summary>
        static PolishNotationParser()
        {
            PolishNotationParser._dictionaryOperator = new Dictionary<string, Operator>();
            Operator op1 = new Add();
            _dictionaryOperator.Add(op1.ToString(), op1);

            Operator op2 = new Multiple();
            _dictionaryOperator.Add(op2.ToString(), op2);

            Operator op3 = new Divide();
            _dictionaryOperator.Add(op3.ToString(), op3);

            Operator op4 = new Substract();
            _dictionaryOperator.Add(op4.ToString(), op4);

            Operator op5 = new Module();
            _dictionaryOperator.Add(op5.ToString(), op5);

            Operator op6 = new Pow();
            _dictionaryOperator.Add(op6.ToString(), op6);

            Operator op7 = new Sign();
            _dictionaryOperator.Add(op7.ToString(), op7);

            Function func2 = new Sqrt();
            _dictionaryFunctions.Add(func2.ToString(), func2);

            Function func3 = new Middle();
            _dictionaryFunctions.Add(func3.ToString(), func3);

            Function func4 = new Summ();
            _dictionaryFunctions.Add(func4.ToString(), func4);

            Function func5 = new Log();
            _dictionaryFunctions.Add(func5.ToString(), func5);

            Function func6 = new Sin();
            _dictionaryFunctions.Add(func6.ToString(), func6);

            Function func7 = new Cos();
            _dictionaryFunctions.Add(func7.ToString(), func7);

            Function func8 = new Tan();
            _dictionaryFunctions.Add(func8.ToString(), func8);

            foreach (var item in _dictionaryOperator)
            {
                PolishNotationParser.operator_string += item.ToString() + " ";
            }

            foreach (var item in _dictionaryFunctions)
            {
                PolishNotationParser.function_string += item.ToString() + " ";
            }
        }

        /// <summary>
        /// Разбирает входную строку на токены и преобразует её в польскую нотацию
        /// </summary>
        /// <param name="input_string"></param>
        /// <returns></returns>
        public static object[] Parse(string input_string)
        {

            //  Пока есть ещё символы для чтения:
            //  Читаем очередной символ.
            //  Если символ является числом, добавить его к выходной строке.
            //  Если символ является символом функции, помещаем его в стек.
            //  Если символ является открывающей скобкой, помещаем его в стек.
            //  Если символ является закрывающей скобкой:
            //  До тех пор, пока верхним элементом стека не станет открывающая скобка, выталкиваем элементы из стека в выходную строку. 
            //  При этом открывающая скобка удаляется из стека, но в выходную строку не добавляется. Если после этого шага на вершине стека оказывается символ функции, 
            //  выталкиваем его в выходную строку. Если стек закончился раньше, чем мы встретили открывающую скобку, это означает, 
            //  что в выражении либо неверно поставлен разделитель, либо не согласованы скобки.
            //  Если символ является оператором о1, тогда:
            //  1) пока… 
            //  … (если оператор o1 ассоциированный, либо лево-ассоциированный) приоритет o1 меньше либо равен приоритету оператора, находящегося на вершине стека…
            //  … (если оператор o1 право-ассоциированый) приоритет o1 меньше приоритета оператора, находящегося на вершине стека…
            //  … выталкиваем верхние элементы стека в выходную строку;
            //  2) помещаем оператор o1 в стек.
            //  Когда входная строка закончилась, вытолкнуть все символы из стека в выходную строку. В стеке должны были остаться только символы операторов; 
            //  если это не так, значит в выражении не согласованы скобки.

            List<object> output_list = new List<object>();
            Stack<Operation> operatorStack = new Stack<Operation>();
            try
            {
                for (int i = 0; i < input_string.Length; i++)
                {
                    ///<summary>
                    /// Проверка на наличие операндов
                    ///</summary>
                    if (Char.IsDigit(input_string[i]))
                    {
                        string temp = string.Empty;
                        while (i < input_string.Length)
                            if (Char.IsDigit(input_string[i]))
                            {
                                temp += input_string[i++].ToString();
                            }
                            else if ((input_string[i]) == ',')
                            {
                                temp += input_string[i++].ToString();
                            }
                            else
                                break;
                        i--;
                        output_list.Add(GetNumber(temp));
                    }
                    else if (input_string[i] == '(')
                    {
                        operatorStack.Push(new Special());
                    }
                    else if (input_string[i] == ')')
                    {
                        while (true)
                        {
                            if (operatorStack.Peek() is Special)
                            {
                                operatorStack.Pop();
                                break;
                            }
                            else
                            {
                                output_list.Add(operatorStack.Pop());
                            }
                        }
                    }
                    /// <summary>
                    /// Проверка на наличие функций
                    /// </summary>
                    else if (Char.IsLetter(input_string[i]))
                    {
                        string temp = string.Empty;
                        string argsLine = string.Empty;
                        int countArgs = 0;
                        while (i < input_string.Length)
                            if (Char.IsLetter(input_string[i]))
                            {
                                temp += input_string[i++].ToString();
                            }
                            else if (input_string[i] == '(')
                            {
                                i++;
                                while (input_string[i] != ')')
                                {
                                    argsLine += input_string[i++].ToString();
                                }
                                string[] argsValue = argsLine.Split(';');
                                foreach (var item in argsValue)
                                {
                                    output_list.Add(PolishNotationParser.GetNumber(PolishNotationParser.Calculate(item)));
                                    countArgs++;
                                }
                            }
                            else break;
                        temp = temp.ToLower();
                        if (function_string.IndexOf(temp) != -1)
                        {
                            if ((operatorStack.Count != 0) && (_dictionaryFunctions[temp].Priority < operatorStack.Peek().Priority))
                            {
                                output_list.Add(operatorStack.Pop());
                                _dictionaryFunctions[temp].NumberOfArguments = countArgs;
                                operatorStack.Push(_dictionaryFunctions[temp]);
                            }
                            else
                            {
                                _dictionaryFunctions[temp].NumberOfArguments = countArgs;
                                operatorStack.Push(_dictionaryFunctions[temp]);
                            }
                        }
                        else
                        {
                            output_list.Add(temp);
                        }
                    }
                    /// <summary>
                    /// Проверяет наличие односимвольных операторов, не являющихся словами или буквами наподобие +,-,*,/
                    /// </summary>
                    else if (operator_string.IndexOf(input_string[i]) != -1)
                    {
                        if (input_string[i] == ' ')
                            continue;
                        if ((operatorStack.Count != 0) && (_dictionaryOperator[input_string[i].ToString()].Priority <= operatorStack.Peek().Priority))
                        {
                            if (!(operatorStack.Peek() is Special))
                            {
                                output_list.Add(operatorStack.Pop());
                                operatorStack.Push(_dictionaryOperator[input_string[i].ToString()]);
                            }
                            else
                                operatorStack.Push(_dictionaryOperator[input_string[i].ToString()]);
                        }
                        else
                        {
                            operatorStack.Push(_dictionaryOperator[input_string[i].ToString()]);
                        }
                    }
                }
                while (operatorStack.Count > 0)
                {
                    output_list.Add(operatorStack.Pop());
                }
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Обнаружена ошибка в формуле. Не достает оператора или закрывающей скобки");
            }
            return output_list.ToArray();
        }

        /// <summary>
        /// Проводит вычисление согласно введенных операндов и операторов
        /// </summary>
        /// <param name="tokens">Коллекция составляющих операторов и операндов вычисляемого выражения</param>
        /// <returns>Результат вычисления</returns>
        public static Operands Calculate(object[] tokens)
        {
            Operands result = null;
            Stack<object> temp = new Stack<object>();
            Stack<Operands> operandsStack = new Stack<Operands>();
            try
            {
                for (int i = tokens.Length - 1; i >= 0; i--)
                {
                    temp.Push(tokens[i]);
                }
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i] is Operator)
                    {
                        Operator op = ((Operator)tokens[i]);
                        Operands local_result = null;
                        Operands[] local_operands = new Operands[op.NumberOperands];
                            for (int j = 0; j < op.NumberOperands; j++)
                            {
                                local_operands[j] = operandsStack.Pop();
                            }
                        Array.Reverse(local_operands);
                        local_result = (Operands)op.Calc(local_operands);
                        operandsStack.Push((Operands)local_result);
                    }
                    else if (tokens[i] is Operands)
                    {
                        operandsStack.Push((Operands)tokens[i]);
                    }
                    else if (tokens[i] is Function)
                    {
                        Function func = ((Function)tokens[i]);
                        Operands local_result = null;
                        Operands[] local_operands = new Operands[func.NumberOfArguments];
                        if (func.NumberOfArguments >= func.MinNumberOfArguments && func.NumberOfArguments <= func.MaxNumberOfArguments)
                        {
                            for (int j = 0; j < func.NumberOfArguments; j++)
                            {
                                local_operands[j] = operandsStack.Pop();
                            }
                            Array.Reverse(local_operands);
                            local_result = (Operands)func.Calc(local_operands);
                            operandsStack.Push((Operands)local_result);
                        }
                        else return null;
                    }
                }
                result = (Operands)operandsStack.Pop();
            }
            catch (InvalidOperationException)
            {
                throw new Exception("Обнаружена ошибка в формуле. Не достает оператора или закрывающей скобки");
            }
            return result;
        }

        /// <summary>
        /// Выполняет полную процеуру вычисления, включая разбор на составляющие, 
        /// работу стекового калькулятора и обработку ошибок
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Calculate(string input)
        {
            object[] tokens = PolishNotationParser.Parse(input);
            Operands result = PolishNotationParser.Calculate(tokens);
            if (result == null)
                return "#Ошибка";
            else
            {
                string result_str = result.ToString();
                return result_str;
            }
        }

        /// <summary>
        /// Превращает строку в число
        /// </summary>
        /// <param name="some_number">Строка с предполагаемым числом</param>
        /// <returns>Число, если такое преобразование возможно, или null, если невозможно</returns>
        static Digit GetNumber(string some_number)
        {
            Digit result = 0.0;
            try
            {
                result = Double.Parse(some_number);
            }
            catch (FormatException)
            {
                return null;
            }
            return result;
        }
    }
}
