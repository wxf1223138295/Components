using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Shawn.Common.Ioc.IocObject
{
    public class IocManager: IIocManager
    { 
        /// <summary>
        /// 单例
        /// </summary>
        public static IocManager Instance { get; private set; }

        public ContainerBuilder BuilderContainer { get; private set; }
        static IocManager()
        {
            Instance = new IocManager();
        }
      
        public IContainer Icontainer { get; private set; }
        public IocManager()
        {
            BuilderContainer = new ContainerBuilder();

            //Register self!
            BuilderContainer
                .RegisterInstance(this)
                .As<IIocManager>();
        }
        public void Dispose()
        {
            Icontainer.Dispose();
        }


    }
}
