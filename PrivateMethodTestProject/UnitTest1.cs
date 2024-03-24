using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PrivateMethodTest;

namespace PrivateMethodTestProject {
  [TestClass]
  public class UnitTest1 {
    private PrivateObject _privateObject = null;

    [TestInitialize]
    public void init() {
      var writer  = new Writer();
      _privateObject = new PrivateObject(writer);
    }

    [TestMethod]
    public void TestWritePrivate() {
      var actual = _privateObject.Invoke("WritePrivate");

      Assert.AreEqual(actual, "private");
    }

    [TestMethod]
    public void TestWritePrivateParamString() {
      var actual = _privateObject.Invoke("WritePrivate", "Hello");

      Assert.AreEqual(actual, "private Hello");
    }

    [TestMethod]
    public void TestWritePrivateParamInt() {
      var actual = _privateObject.Invoke("WritePrivate", 1);

      Assert.AreEqual(actual, "private 1");
    }
  }
}
