﻿using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

namespace Shawn.Common.Ioc.AccessorDependencyInjection
{
    public class ObjectAccessor<T> : IObjectAccessor<T>
    {
        public T Value { get; set; }

        public ObjectAccessor()
        {

        }

        public ObjectAccessor([CanBeNull] T obj)
        {
            Value = obj;
        }
    }
}
