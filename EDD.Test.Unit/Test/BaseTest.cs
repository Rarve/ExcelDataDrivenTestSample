using EDD.Data.Excel;
using NUnit.Framework;
using System.Threading;

namespace EDD.Test.Unit.Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class BaseTest
    {
        [Test, Order(1), TestCaseSource(typeof(Reader), Constant.InputFileRreaderMethod, new object[] { Constant.InputFile })]
        public void Test1(string Id, double groupId, string desc, string input1, double input2)
        {
            Thread.Sleep(5000);
        }

        [Test, Order(2), TestCaseSource(typeof(Reader), Constant.InputFileRreaderMethod, new object[] { Constant.InputFile })]
        public void Test2(string Id, double groupId, string desc, string input1, double input2)
        {
            Thread.Sleep(5000);
        }
    }
}