using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;
using System.Collections.Generic;

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

    [TestMethod]

    public void findAllergiesMethod_TakesScoreAndGivesBackAllergies_List()
    {
      //Arrange
      AllergyList list = new AllergyList(3);
      List<string> findAllergies = list.findAllergies();
      //Act
      List<string> testList = new List<string> {"eggs","peanuts"};
      //Assert
      Assert.AreEqual(findAllergies, testList);

    }

  }
}

