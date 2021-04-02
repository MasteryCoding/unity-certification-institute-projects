using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Testing
{
  public class TestFindMax : Test
  {
    public TestFindMax(Tester _tester) : base(_tester, "Test FindMax") { }
    protected override void RunCase(int[] testCase, int index)
    {
      int[] solutions = { 99, 93, 91, -7, 95 };
      int response = tester.target.FindMax(testCase);
      if (response != solutions[index])
      {
        failedCases.Enqueue(
          new TestFail(methodName, testCase, solutions[index], response, index)
        );
      }
    }
  }
  public class TestFindMin : Test
  {
    public TestFindMin(Tester _tester) : base(_tester, "Test  FindMin") { }
    protected override void RunCase(int[] testCase, int index)
    {
      int[] solutions = {-71, -94, -82, -99, 4};
      int response = tester.target.FindMin(testCase);
      if (response != solutions[index]) {
        failedCases.Enqueue(
          new TestFail("FindMin", testCase, solutions[index], response, index)
        );
      }
    }
  }

  public class TestFindElement : Test {
    public TestFindElement(Tester _tester) : base(_tester, "Test  FindElement"){}
    protected override void RunCase(int[] testCase, int index) {
      int[] solutions = {2, 8, -1, 3, 14};
      int[] testValues = {47, 59, 140, -91, 42};
      int response = tester.target.FindElement(testCase, testValues[index]);
      if (response != solutions[index]) {
        failedCases.Enqueue(
          new TestFail("FindElement", testCase, solutions[index], response, index)
        );
      }
    }
  }
  public class TestReverse : Test {
    public TestReverse(Tester _tester) : base(_tester, "Test  Reverse"){}
    protected override void RunCase(int[] testCase, int index) {
      int[][] solutions = new int[5][];
    solutions[0] = new int[]{75, 2, 0, 67, 99, -71, -27, 33, 25, -21, 86, 47, 77, 26};
    solutions[1] = new int[]{34, 26, 73, -57, 0, 41, 59, 82, 78, -94, 60, 81, 83, 2, 93};
    solutions[2] = new int[]{83, 91, -50, -82, 64, -59, 77, 66, -45, 46, 85, -80, -69, 22, 73};
    solutions[3] = new int[]{-63, -74, -26, -7, -30, -88, -31, -24, -11, -27, -91, -21, -62, -99};
    solutions[4] = new int[]{42, 71, 12, 85, 95, 4, 16, 10, 50, 82, 14, 57, 69, 36, 29};
    int[] response = tester.target.Reverse(testCase);
    if (!Enumerable.SequenceEqual(response, solutions[index])) {
      failedCases.Enqueue(
        new TestFail(
          "Reverse",
          testCase,
          "[" + string.Join(", ", solutions[index]) + "]",
          "[" + string.Join(", ", response) + "]",
          index
        )
      );
    }
    }
  }
  public class TestOnlyEvens : Test {
    public TestOnlyEvens(Tester _tester) : base(_tester, "Test  OnlyEvens"){}
    protected override void RunCase(int[] testCase, int index)
    {
      int[][] solutions = new int[5][];
      solutions[0] = new int[] { 26, 47, -21, 33, -71, 67, 2 };
      solutions[1] = new int[] { 93, 83, 60, 78, 59, 0, 73, 34 };
      solutions[2] = new int[] { 73, -69, 85, -45, 77, 64, -50, 83 };
      solutions[3] = new int[] { -99, -21, -27, -24, -88, -7, -74 };
      solutions[4] = new int[] { 29, 69, 14, 50, 16, 95, 12, 42 };
      int[] response = tester.target.OnlyEvens(testCase);
      if (!Enumerable.SequenceEqual(response, solutions[index]))
      {
        failedCases.Enqueue(
          new TestFail(
            "OnlyEvens",
            testCase,
            "[" + string.Join(", ", solutions[index]) + "]",
            "[" + string.Join(", ", response) + "]",
            index
          )
        );
      }
    }
  }
  public class TestOnlyOdds : Test {
    public TestOnlyOdds(Tester _tester) : base(_tester, "Test  OnlyOdds"){}
    protected override void RunCase(int[] testCase, int index)
    {
      int[][] solutions = new int[5][];
      solutions[0] = new int[] { 77, 86, 25, -27, 99, 0, 75 };
      solutions[1] = new int[] { 2, 81, -94, 82, 41, -57, 26 };
      solutions[2] = new int[] { 22, -80, 46, 66, -59, -82, 91 };
      solutions[3] = new int[] { -62, -91, -11, -31, -30, -26, -63 };
      solutions[4] = new int[] { 36, 57, 82, 10, 4, 85, 71 };
      int[] response = tester.target.OnlyOdds(testCase);
      if (!Enumerable.SequenceEqual(response, solutions[index]))
      {
        failedCases.Enqueue(
          new TestFail(
            "OnlyOdds",
            testCase,
            "[" + string.Join(", ", solutions[index]) + "]",
            "[" + string.Join(", ", response) + "]",
            index
          )
        );
      }
    }
  }

  public class TestArraysEqual : Test {
    public TestArraysEqual(Tester _tester) : base(_tester, "Test  ArraysEqual"){}
    protected override void RunCase(int[] testCase, int index)
    {
      int[][] testValues = new int[5][];
      testValues[0] = new int[] { 26, 77, 47, 86, -21, 25, 33, -27, -71, 98, 67, 0, 2 };
      testValues[1] = new int[] { 93, 2, 83, 81, 60, -94, 78, 82, 59, 41, 0, -57, 73, 26, 34 };
      testValues[2] = new int[] { 73, 22, -69, -80, 85, 46, 45, 66, 77, -59, 64, -82, -50, 91, 83 };
      testValues[3] = new int[] { -99, -62, -21, -91, -27, -11, -24, -31, -88, -30, -7, -26, -74, -63 };
      testValues[4] = new int[] { 29, 36, 69, 57, 14, 82, 50, 10, 16, 4, 95, 85 };

      bool[] solutions = { false, true, false, true, false };
      bool response = tester.target.ArraysEqual(testCase, testValues[index]);

      if (response != solutions[index])
      {
        failedCases.Enqueue(
          new TestFail(
            "ArraysEqual",
            testCase,
            "[" + string.Join(", ", solutions[index]) + "]",
            "[" + string.Join(", ", response) + "]",
            index
          )
        );
      }
    }
  }

  public class TestSortNumbers : Test {
    public TestSortNumbers(Tester _tester) : base(_tester, "Test  SortNumbers"){}
    protected override void RunCase(int[] testCase, int index)
    {
      int[][] solutions = new int[5][];
      solutions[0] = new int[] { -71, -27, -21, 0, 2, 25, 26, 33, 47, 67, 75, 77, 86, 99 };
      solutions[1] = new int[] { -94, -57, 0, 2, 26, 34, 41, 59, 60, 73, 78, 81, 82, 83, 93 };
      solutions[2] = new int[] { -82, -80, -69, -59, -50, -45, 22, 46, 64, 66, 73, 77, 83, 85, 91 };
      solutions[3] = new int[] { -99, -91, -88, -74, -63, -62, -31, -30, -27, -26, -24, -21, -11, -7 };
      solutions[4] = new int[] { 4, 10, 12, 14, 16, 29, 36, 42, 50, 57, 69, 71, 82, 85, 95 };

      int[] response = tester.target.SortNumbers(testCase);

      if (!Enumerable.SequenceEqual(response, solutions[index]))
      {
        failedCases.Enqueue(
          new TestFail(
            "SortNumbers",
            testCase,
            "[" + string.Join(", ", solutions[index]) + "]",
            "[" + string.Join(", ", response) + "]",
            index
          )
        );
      }
    }
  }

  public class Tester : MonoBehaviour
  {

    public Test[] tests;

    public ArrayChallenge target;

    public string lastTestsResult;

    public int[][] cases = new int[5][];
    private void Start()
    {
      // Initialize Cases
      target = GetComponent<ArrayChallenge>();
      // Initialize Cases
      cases[0] = new int[] { 26, 77, 47, 86, -21, 25, 33, -27, -71, 99, 67, 0, 2, 75};
      cases[1] = new int[] { 93, 2, 83, 81, 60, -94, 78, 82, 59, 41, 0, -57, 73, 26, 34};
      cases[2] = new int[] { 73, 22, -69, -80, 85, 46, -45, 66, 77, -59, 64, -82, -50, 91, 83};
      cases[3] = new int[] { -99, -62, -21, -91, -27, -11, -24, -31, -88, -30, -7, -26, -74, -63};
      cases[4] = new int[] { 29, 36, 69, 57, 14, 82, 50, 10, 16, 4, 95, 85, 12, 71, 42};
      tests = new Test[] { 
        new TestFindMax(this), 
        new TestFindMin(this),
        new TestFindElement(this),
        new TestReverse(this),
        new TestOnlyEvens(this),
        new TestOnlyOdds(this),
        new TestArraysEqual(this),
        new TestSortNumbers(this),
      };
    }

    public void RunAllTests()
    {
      lastTestsResult = "";
      for (int i = 0; i < tests.Length; i++)
      {
        tests[i].Run();
        lastTestsResult += tests[i].results;
      }
    }
    public void RunTest(int i)
    {
      lastTestsResult = "";
      tests[i].Run();
      lastTestsResult += tests[i].results;
    }
  }

  public class Test
  {
    protected Tester tester;
    public string methodName { get; set; }
    public Queue<TestFail> failedCases = new Queue<TestFail>();
    public Test(Tester _tester, string _methodName)
    {
      tester = _tester;
      methodName = _methodName;
    }
    public void Run()
    {
      failedCases = new Queue<TestFail>();
      for (int i = 0; i < tester.cases.Length; i++)
      {
        RunCaseAndHandleErrors(i);
      }
    }
    public string results {
      get {
        string successColor = failedCases.Count == 0 ? "<color=green>" : "<color=red>";
        string endColor = "</color>";

        string resultMessage = successColor;
        resultMessage += methodName + "():  " + (tester.cases.Length - failedCases.Count)  + "/" + tester.cases.Length + " tests passed." + endColor + "\n";
        foreach (var tf in failedCases)
        {
          resultMessage += tf.Msg();
        }
        return resultMessage;
      }
    }
    protected virtual void RunCase(int[] testCase, int index) { }
    protected void RunCaseAndHandleErrors(int index)
    {
      int[] testCase = new int[tester.cases[index].Length];
      Array.Copy(tester.cases[index], testCase, tester.cases[index].Length);
      try
      {
        RunCase(testCase, index);
        if (!Enumerable.SequenceEqual(tester.cases[index], testCase)) {
          failedCases.Enqueue(new TestFail(
            methodName,
            "Remember that you can't modify the original array! You must return a <b>new</b> one.",
            index
          ));
          return;
        } 
      }
      catch (System.IndexOutOfRangeException e)
      {
        if (e != null)
        {
          failedCases.Enqueue(new TestFail(
            methodName,
            "Looks like you're trying to access an element outside of a array.",
            index
          ));
        }
      }
      catch (System.ArrayTypeMismatchException e)
      {
        if (e != null)
        {
          failedCases.Enqueue(new TestFail(
          methodName,
          "Looks like the data types in an array are mismatched.",
          index
        ));
        }
      }
      catch (System.NullReferenceException e)
      {
        if (e != null)
        {
          failedCases.Enqueue(new TestFail(
            methodName,
            "Looks like you're trying to use a property or variable with nothing in it.",
            index
          ));
        }
      }
      catch (System.InvalidCastException e)
      {
        if (e != null)
        {
          failedCases.Enqueue(new TestFail(
            methodName,
            "Looks like you're assigning a value to a variable designed to hold something else.",
            index
          ));
        }
      }
      catch (System.Exception e)
      {
        if (e != null)
        {
          Debug.LogError("At " + methodName + " " + index + ": " + e.Message);
        }
      }
    }
  }

  public class TestFail
  {
    string methodName, expected, actual, systemError;
    int index;
    string input;

    public TestFail(string _methodName, int[] _input, string _expected, string _actual, int _index)
    {
      methodName = _methodName;
      expected = _expected;
      actual = _actual;
      index = _index;
      input = "[" + string.Join(", ", _input) + "]";
    }

    public TestFail(string _methodName, int[] _input, int _expected, int _actual, int _index)
    {
      methodName = _methodName;
      expected = _expected.ToString();
      actual = _actual.ToString();
      index = _index;
      input = "[" + string.Join(", ", _input) + "]";
    }

    public TestFail(string _methodName, string _systemError, int _index)
    {
      methodName = _methodName;
      systemError = _systemError;
      index = _index;
    }

    public string Msg()
    {
      string message = "";
      message += " Test <b>" + (index + 1) + "</b>\n";
      if (systemError != null)
      {
        message += systemError + "\n\n";
        return message;
      }
      message += " Input: " + input + "\n";
      message += " Expected: " + expected + "\n";
      message += " Received: " + actual + "\n\n";
      return message;
    }
  }
}
