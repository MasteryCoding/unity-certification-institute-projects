// using System.Collections.Generic;
// using System.Linq;
// using UnityEngine;

// public class TestArrayChallenge : MonoBehaviour {
//   private int[][] cases = new int[5][]; 
//   delegate void Test(int[] list, TestArrayChallenge p, int index);
//   ArrayChallenge _t = null;
//   Queue<TestFail> failedTests = new Queue<TestFail>();

//   void Awake() {
//     _t = GetComponent<ArrayChallenge>();
//     cases[0] = new int[]{26, 77, 47, 86, -21, 25, 33, -27, -71, 99, 67, 0, 2, 75};
//     cases[1] = new int[]{93, 2, 83, 81, 60, -94, 78, 82, 59, 41, 0, -57, 73, 26, 34};
//     cases[2] = new int[]{73, 22, -69, -80, 85, 46, -45, 66, 77, -59, 64, -82, -50, 91, 83};
//     cases[3] = new int[]{-99, -62, -21, -91, -27, -11, -24, -31, -88, -30, -7, -26, -74, -63};
//     cases[4] = new int[]{29, 36, 69, 57, 14, 82, 50, 10, 16, 4, 95, 85, 12, 71, 42};
//   }

//   void Start() {
//     Test[] tests = new Test[]{
//       TestFindMax,
//       TestFindMin,
//       TestFindElement,
//       TestReverse,
//       TestOnlyEvens,
//       TestOnlyOdds,
//       TestArraysEqual,
//       TestSortNumbers,
//     };

//     string[] testNames = {
//       "FindMax",
//       "FindMin",
//       "FindElement",
//       "Reverse",
//       "OnlyEvens",
//       "OnlyOdds",
//       "ArraysEqual",
//       "SortNumbers",
//     };

//     for(int i = 0; i < tests.Length; i++) {
//       for (int j = 0; j < cases.Length; j++) {
//         try {
//           tests[i](cases[j], this, j);
//         } catch(System.IndexOutOfRangeException e) {
//           if (e != null) {
//             failedTests.Enqueue(new TestFail(
//               testNames[i],
//               "Looks like you're trying to access an element outside of a array.",
//               j
//             ));
//           }
//         } catch(System.ArrayTypeMismatchException e) {
//           if (e != null) {
//              failedTests.Enqueue(new TestFail(
//               testNames[i],
//               "Looks like the data types in an array are mismatched.",
//               j
//             ));
//           }
//         } catch(System.NullReferenceException e) {
//           if (e != null) {
//             failedTests.Enqueue(new TestFail(
//               testNames[i],
//               "Looks like you're trying to use a property or variable with nothing in it.",
//               j
//             ));
//           }
//         } catch(System.InvalidCastException e) {
//           if (e != null) {
//             failedTests.Enqueue(new TestFail(
//               testNames[i],
//               "Looks like you're assigning a value to a variable designed to hold something else.",
//               j
//             ));
//           }
//         }
//         catch(System.Exception e) {
//           if (e != null) {
//             Debug.LogError("At " + testNames[i] + " " + j + ": " + e.Message);
//           }
//         }
//       }
//     }

//     if (failedTests.Count == 0) {
//       Debug.Log("All tests passed successfully. Great work!" );
//     } else {
//       Debug.LogError(failedTests.Count + "/" + (testNames.Length * 5) + " Tests Failed." );
//       foreach (TestFail tf in failedTests) {
//         Debug.LogError(tf.Msg());
//       }
//     }

//   }
//   Test TestFindMax = (int[] list, TestArrayChallenge p, int index) => {
//     int[] solutions = {99, 93, 91, -7, 95};
//     int response = p._t.FindMax(list);
//     if (response != solutions[index]) {
//       p.failedTests.Enqueue(
//         new TestFail("FindMax", solutions[index], response, index)
//       );
//     }
//   };

//   Test TestFindMin = (int[] list, TestArrayChallenge p, int index) => {
//     int[] solutions = {-71, -94, -82, -99, 4};
//     int response = p._t.FindMin(list);
//     if (response != solutions[index]) {
//       p.failedTests.Enqueue(
//         new TestFail("FindMin", solutions[index], response, index)
//       );
//     }
//   };

//   Test TestFindElement = (int[] list, TestArrayChallenge p, int index) => {
//     int[] solutions = {2, 8, -1, 3, 14};
//     int[] testValues = {47, 59, 140, -91, 42};
//     int response = p._t.FindElement(list, testValues[index]);
//     if (response != solutions[index]) {
//       p.failedTests.Enqueue(
//         new TestFail("FindElement", solutions[index], response, index)
//       );
//     }
//   };

//   Test TestReverse = (int[] list, TestArrayChallenge p, int index) => {
//     int[][] solutions = new int[5][];
//     solutions[0] = new int[]{75, 2, 0, 67, 99, -71, -27, 33, 25, -21, 86, 47, 77, 26};
//     solutions[1] = new int[]{34, 26, 73, -57, 0, 41, 59, 82, 78, -94, 60, 81, 83, 2, 93};
//     solutions[2] = new int[]{83, 91, -50, -82, 64, -59, 77, 66, -45, 46, 85, -80, -69, 22, 73};
//     solutions[3] = new int[]{-63, -74, -26, -7, -30, -88, -31, -24, -11, -27, -91, -21, -62, -99};
//     solutions[4] = new int[]{42, 71, 12, 85, 95, 4, 16, 10, 50, 82, 14, 57, 69, 36, 29};
//     int[] response = p._t.Reverse(list);
//     if (!Enumerable.SequenceEqual(response, solutions[index])) {
//       p.failedTests.Enqueue(
//         new TestFail(
//           "Reverse",
//           "[" + string.Join(", ", solutions[index]) + "]",
//           "[" + string.Join(", ", response) + "]",
//           index
//         )
//       );
//     }
//   };

//   Test TestOnlyEvens = (int[] list, TestArrayChallenge p, int index) => {
//     int[][] solutions = new int[5][];
//     solutions[0] = new int[] {26, 47, -21, 33, -71, 67, 2};
//     solutions[1] = new int[] {93, 83, 60, 78, 59, 0, 73, 34};
//     solutions[2] = new int[] {73, -69, 85, -45, 77, 64, -50, 83};
//     solutions[3] = new int[] {-99, -21, -27, -24, -88, -7, -74};
//     solutions[4] = new int[] {29, 69, 14, 50, 16, 95, 12, 42};
//     int[] response = p._t.OnlyEvens(list);
//     if (!Enumerable.SequenceEqual(response, solutions[index])) {
//       p.failedTests.Enqueue(
//         new TestFail(
//           "OnlyEvens", 
//           "[" + string.Join(", ", solutions[index]) + "]",
//           "[" + string.Join(", ", response) + "]",
//           index
//         )
//       );
//     }
//   };

//   Test TestOnlyOdds = (int[] list, TestArrayChallenge p, int index) => {
//     int[][] solutions = new int[5][];
//     solutions[0] = new int[] {77, 86, 25, -27, 99, 0, 75};
//     solutions[1] = new int[] {2, 81, -94, 82, 41, -57, 26};
//     solutions[2] = new int[] {22, -80, 46, 66, -59, -82, 91};
//     solutions[3] = new int[] {-62, -91, -11, -31, -30, -26, -63};
//     solutions[4] = new int[] {36, 57, 82, 10, 4, 85, 71};
//     int[] response = p._t.OnlyOdds(list);
//     if (!Enumerable.SequenceEqual(response, solutions[index])) {
//       p.failedTests.Enqueue(
//         new TestFail(
//           "OnlyOdds",
//           "[" + string.Join(", ", solutions[index]) + "]",
//           "[" + string.Join(", ", response) + "]",
//           index
//         )
//       );
//     }
//   };

//   Test TestArraysEqual = (int[] list, TestArrayChallenge p, int index) => {
//     int[][] testValues = new int[5][];
//     testValues[0] = new int[]{26, 77, 47, 86, -21, 25, 33, -27, -71, 98, 67, 0, 2};
//     testValues[1] = new int[]{93, 2, 83, 81, 60, -94, 78, 82, 59, 41, 0, -57, 73, 26, 34};
//     testValues[2] = new int[]{73, 22, -69, -80, 85, 46, 45, 66, 77, -59, 64, -82, -50, 91, 83};
//     testValues[3] = new int[]{-99, -62, -21, -91, -27, -11, -24, -31, -88, -30, -7, -26, -74, -63};
//     testValues[4] = new int[]{29, 36, 69, 57, 14, 82, 50, 10, 16, 4, 95, 85};

//     bool[] solutions = {false, true, false, true, false};
//     bool response = p._t.ArraysEqual(list, testValues[index]);

//     if (response != solutions[index]) {
//       p.failedTests.Enqueue(
//         new TestFail(
//           "ArraysEqual", 
//           "[" + string.Join(", ", solutions[index]) + "]",
//           "[" + string.Join(", ", response) + "]",
//           index
//         )
//       );
//     }
//   };

//   Test TestSortNumbers = (int[] list, TestArrayChallenge p, int index) => {
//     int[][] solutions = new int[5][];
//     solutions[0] = new int[] {-71, -27, -21, 0, 2, 25, 26, 33, 47, 67, 75, 77, 86, 99};
//     solutions[1] = new int[] {-94, -57, 0, 2, 26, 34, 41, 59, 60, 73, 78, 81, 82, 83, 93};
//     solutions[2] = new int[] {-82, -80, -69, -59, -50, -45, 22, 46, 64, 66, 73, 77, 83, 85, 91};
//     solutions[3] = new int[] {-99, -91, -88, -74, -63, -62, -31, -30, -27, -26, -24, -21, -11, -7};
//     solutions[4] = new int[] {4, 10, 12, 14, 16, 29, 36, 42, 50, 57, 69, 71, 82, 85, 95};

//     int[] response = p._t.SortNumbers(list);

//     if (!Enumerable.SequenceEqual(response, solutions[index])) {
//       p.failedTests.Enqueue(
//         new TestFail(
//           "SortNumbers", 
//           "[" + string.Join(", ", solutions[index]) + "]",
//           "[" + string.Join(", ", response) + "]",
//           index
//         )
//       );
//     }
//   };
// }

// class TestFail {
//   string methodName, expected, actual, systemError;
//   int index;

//   public TestFail(string _methodName, string _expected, string _actual, int _index) {
//     methodName = _methodName;
//     expected = _expected;
//     actual = _actual;
//     index = _index;
//   }

//   public TestFail(string _methodName, int _expected, int _actual, int _index) {
//     methodName = _methodName;
//     expected = _expected.ToString();
//     actual = _actual.ToString();
//     index = _index;
//   }

//   public TestFail(string _methodName, string _systemError, int _index) {
//     methodName = _methodName;
//     systemError = _systemError;
//     index = _index;
//   }

//   public string Msg() {
//     string message = methodName + " Test " + (index + 1) + " Failed. ";
//     if (systemError != null) {
//       message += systemError;
//       return message;
//     }
//     message += "Expected: " + expected + ".\n";
//     message += "Instead got: " + actual;
//     return message;
//   }
// }