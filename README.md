#ConsolePresidents
###USA Presidents data from the console with C# unit testing

####Set-up:

1. On a Windows PC, download [Release](https://github.com/GProSoftware828/ConsolePresidents/releases) to the desktop.
2. Rt. click and extract all, then open the Solution file in the project directory with Visual Studio (ListOfUSAPresidents.sln)
* can install a free community version of Visual Studio from the Microsoft website

**Always open the solution file in the folder of the download- you will know it's correct if you double click and Visual
Studio is chosen to open the file automatically.**

3. In the Visual Studio interface at the top, click the green arrow and type answers into the console pop-up window and press
enter to follow along and read some interesting history of the American heritage beginning when the English people 
founded the country and formed governance with their political parties, forming a new nation of the same people, similarly
to the English forming a new nation with the same people in Australia, or how Chinese people branched off and formed Japan and
the Japanese people.
**Interesting stuff! I like to know what to tell people when they ask my ethnicity!**


Now the advanced stuff- running the tests:


If the download works:
1. Go to 'Test' at the top of Visual Studio, click Windows -> Test Explorer; click green arrow in Test Explorer pane to the
far left and the tests will populate their response.
2. Read through the test source code- one test confirms output formatting from the data streaming in and one test confirms
that the correct input is used to run the data retrieval- the latter you can click 'Open additional output for this result' in
the 'Test Detail Summary' after clicking to highlight the final nested title for the test (the test class name). This will
show you the passing output message, or the failing message if it failed (then try to find the message in the code).

If the download doesn't work:
1. Download the project and sometimes the tests don't get compressed correctly, so delete the empty test projects in the 
'Solution Explorer'.
2. Right click the Solution listed at the top of the Solution Explorer and chose Add Item.
3. Add a NUnit Test .NET Core item.
4. Right click the new project in the Solution Explorer and chose add -> reference. Chose the name of the project (should come
up automatically, ListOfUSAPresidents). The test now references the project.
5. Copy and paste one of the tests' source code from this repository into the unit test file in the test project you just
created. For example, a new test calls the test file 'UnitTest1.cs'- double click that file to open it, remove the given code, 
and copy and paste in the code from this repository under DataFormatTest -> CSVOutputTest.cs.
6. Then right click on the test project folder and click Build.
7. Repeat this process for both tests, DataFormatTest and InputSelectionStubTest.
8. Go to 'Test' in the top menu, -> Windows -> Text Explorer and in the Test Explorer click the green arrow to the far left to
run the tests.
