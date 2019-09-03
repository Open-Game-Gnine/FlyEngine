using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestDebugger
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestDebuggerSimplePasses()
        {
            // Use the Assert class to test conditions

            Debugger.Log("This is a log");
            Debugger.LogWarning("This is a warning");
            //Debugger.LogError("This is a error");
            //Debugger.LogException(new System.Exception("This is a Exception"));

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestDebuggerWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
