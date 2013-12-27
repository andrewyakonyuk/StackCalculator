using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalc
{
    public abstract class Operation
    {
        /// <summary>
        /// Возращает приоритет операции
        /// </summary>
        public OperationPriority Priority { get; protected set; }
    }
}
