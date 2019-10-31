﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Shawn.Common.Ioc.IocObject
{
    /// <summary>
    /// 此工程基于autofac无法替换
    /// 对于Net依赖注入框架
    /// autofac功能是最强大的
    /// </summary>
    public interface IIocManager:IDisposable
    {
        IContainer Icontainer { get; }

        ContainerBuilder BuilderContainer { get; }

        //IWindsorContainer AddFacility<TFacility>(Action<TFacility> onCreate) where TFacility : IFacility, new();
    }
}