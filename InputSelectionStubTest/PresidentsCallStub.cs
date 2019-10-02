using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;


namespace ListOfUSAPresidents
{
  abstract class Call
  {
    public abstract void CallWH();
  }

  [TestFixture]
  class ProgramTestStub : Call
  {
    //Assert
    public override void CallWH()
    {
      Console.WriteLine("It works");
    }

    [Test]
    public void MainConsoleConditional_InputReadingCorrectWord_ReturnsMessageConfirmingInputRecognized()
    {

      //Arrange
      string input = "Presidents";

      //Act
      if (input.Contains("Presidents"))
      {
        CallWH();
      }
      else
      {
        Console.WriteLine("Input not gotten.");
      }
    }

    [TearDown]
    public void EndTest()
    {
      string input = null;
      string output = null;
    }
  }
}