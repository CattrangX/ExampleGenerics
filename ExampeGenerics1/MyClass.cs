﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampeGenerics1
{
    public class MyClass<T>
    {
        private T data;

        public T Value
        {
            get => data;
            set => data = value;
        }

        public override string ToString() => $"Value: {data}";
    }
}
