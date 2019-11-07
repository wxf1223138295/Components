using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

namespace Shawn.Common.Ioc.AccessorDependencyInjection
{
    public interface IObjectAccessor<out T>
    {
        [CanBeNull]
        T Value { get; }
    }
}
