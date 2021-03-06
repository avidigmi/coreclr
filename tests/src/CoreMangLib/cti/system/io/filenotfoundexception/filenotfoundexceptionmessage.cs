using System;
using System.IO;
/// <summary>
///Message
/// </summary>
public class FileNotFoundExceptionMessage
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new FileNotFoundException instance.");

        try
        {
            string expectString = "this is a error";
            //Create the application domain setup information.
            FileNotFoundException myFileNotFoundException = new FileNotFoundException(expectString);
            if (myFileNotFoundException.Message != expectString)
            {
                TestLibrary.TestFramework.LogError("001.1", "the FileNotFoundException ctor error occurred,the message should be " + expectString);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: Create a new FileNotFoundException instance,string is empty.");

        try
        {
            string expectString = string.Empty;
            //Create the application domain setup information.
            FileNotFoundException myFileNotFoundException = new FileNotFoundException(expectString);
            if (myFileNotFoundException.Message != expectString)
            {
                TestLibrary.TestFramework.LogError("002.1", "the FileNotFoundException ctor error occurred.the message should be " + expectString);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest3()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest3: Create a new FileNotFoundException instance,string is null,then its inner exception set to a null reference .");

        try
        {
            string expectString = null;
            //Create the application domain setup information.
            FileNotFoundException myFileNotFoundException = new FileNotFoundException(expectString);
            if (myFileNotFoundException.Message != null)
            {
                TestLibrary.TestFramework.LogError("003.1", "the FileNotFoundException ctor error occurred. the message should be null");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    #endregion

    #endregion

    public static int Main()
    {
        FileNotFoundExceptionMessage test = new FileNotFoundExceptionMessage();

        TestLibrary.TestFramework.BeginTestCase("FileNotFoundExceptionMessage");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

}
