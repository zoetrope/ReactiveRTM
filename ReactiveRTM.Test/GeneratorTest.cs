using System;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reflection;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Ch.Elca.Iiop.Idl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenRTM;
using omg.org.RTC;

namespace RtUtility.Test
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void ObservableStartのキャンセルって何が起きる()
        {
            Observable.Start(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(10));
                Console.WriteLine("10秒後");
                throw new Exception("hoge");
            })
            .Timeout(TimeSpan.FromSeconds(5))
            .Subscribe(_ => { }, ex => Console.WriteLine(ex.Message));

            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [TestMethod]
        public void TestMethod1()
        {
            Observable.Start(() => true).Timeout(TimeSpan.FromSeconds(5));

            var temp = GenerateTemplates(new Type[] { typeof(InPortCdr), typeof(RTObject) });

            foreach (var ns in temp)
            {
                Console.WriteLine("namespace " + ns.Namespace);
                foreach (var cl in ns.ClassTemplates)
                {
                    Console.WriteLine("  class " + cl.Classname);
                    foreach (var method in cl.MethodTemplates)
                    {
                        Console.WriteLine("    " + method.Return + " " + method.Name + " " + method.DecArgs);
                    }
                }
            }
        }

        IEnumerable<ObservableTemplate> GenerateTemplates(Type[] types)
        {
            return types.Where(t => t.IsInterface && t.GetInterfaces().Any(i => i == typeof(Ch.Elca.Iiop.Idl.IIdlEntity)))
                .Distinct()
                .GroupBy(t => t.Namespace)
                .Select(g => new ObservableTemplate
                {
                    Namespace = g.Key,
                    ClassTemplates = g.Select(t => new ClassTemplate(t))
                        .Where(t => t.MethodTemplates.Any())
                        .ToArray()
                })
                .Where(a => a.ClassTemplates.Any())
                .OrderBy(a => a.Namespace);
        }

        class ObservableTemplate
        {
            public string Namespace;
            public ClassTemplate[] ClassTemplates;
        }

        class ClassTemplate
        {
            public string Classname;
            public MethodTemplate[] MethodTemplates;

            public ClassTemplate(Type type)
            {
                Classname = type.Name;
                MethodTemplates = type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Select(a => new MethodTemplate
                    {
                        Name = a.Name,
                        Return = a.ReturnType == typeof(void) ? typeof(System.Reactive.Unit).FullName : a.ReturnType.FullName,
                        DecArgs = a.GetParameters().Count() != 0 ? "," + string.Join(",", a.GetParameters().Select(p => p.ParameterType.ToString().Replace("&", "") + " " + p.Name)) : string.Empty,
                        CallArgs = string.Join(",", a.GetParameters().Select(p => (p.IsOut ? "out " : p.ParameterType.IsByRef ? "ref " : "") + p.Name))
                    })
                    .ToArray();
            }
        }

        class MethodTemplate
        {
            public string Name, DecArgs,CallArgs, Return;
        }


    }
}
