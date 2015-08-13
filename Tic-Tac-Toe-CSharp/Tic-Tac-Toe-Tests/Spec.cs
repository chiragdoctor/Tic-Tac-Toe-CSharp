using System;
using System.Diagnostics;
using NUnit.Framework;

namespace Tic_Tac_Toe_Tests
{

    public abstract class Spec
    {
        protected Exception CaughtException;

        [TestFixtureSetUp]
        public void Run()
        {
            Setup();
            Given();

            try
            {
                When();
            }
            catch (Exception e)
            {
                CaughtException = e;
            }
        }

        protected virtual void Setup()
        {
        }

        public abstract void Given();
        public abstract void When();

        protected void AssertNoExceptionThrown()
        {
            Assert.IsNull(CaughtException);
        }

        protected void AssertExceptionThrown()
        {
            if (CaughtException != null)
            {
                Debug.WriteLine(CaughtException.GetType().Name);
                Debug.WriteLine(CaughtException.Message);
            }
            Assert.IsNotNull(CaughtException);
        }
    }

}
