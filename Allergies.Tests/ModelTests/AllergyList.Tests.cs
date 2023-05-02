using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]

  public class AllergyListTests
  {
    [TestMethod]

    public void AllergyListConstructor_CreatesAllergyList_AllergyList()
    {
      AllergyList list = new AllergyList(200);
      Assert.AreEqual(typeof(AllergyList),list.GetType());
    }

  }
}

