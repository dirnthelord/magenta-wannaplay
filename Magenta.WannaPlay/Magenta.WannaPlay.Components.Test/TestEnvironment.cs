using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HibernatingRhinos.NHibernate.Profiler.Appender;
using NUnit.Framework;

namespace Magenta.WannaPlay.Components
{
    [SetUpFixture]
    public class TestEnvironment
    {
        [SetUp]
        public void Setup()
        {
            NHibernateProfiler.Initialize();
        }
    }
}