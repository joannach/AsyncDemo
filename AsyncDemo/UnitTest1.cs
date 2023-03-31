using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace AsyncDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Delegate()
        {
            DoSomethingDelegate d = new DoSomethingDelegate(DoSomething);
            AsyncCallback callback = new AsyncCallback(TheCallback);
            IAsyncResult ar = d.BeginInvoke(callback, null);
            d.EndInvoke(ar);
        }

        private void DoSomething()
        {
            Debug.WriteLine("doing something");
        }

        delegate void DoSomethingDelegate();

        private static void TheCallback(IAsyncResult sr)
        {

        }
    }
}
