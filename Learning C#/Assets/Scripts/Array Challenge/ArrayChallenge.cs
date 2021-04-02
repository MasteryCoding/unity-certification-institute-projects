using UnityEngine;

public class ArrayChallenge : MonoBehaviour {

  // // Receives: an array of integers. 
  // // Returns: the integer with the highest value.
  // public int FindMax(int[] numbers) {
  //   // ...
  //  return 0;
  // }

  // // Receives: an array of integers. 
  // // Returns: the integer with the lowest value.
  // public int FindMin(int[] numbers) {
  //   // ...
  //   return 0;
  // }
  
  // // Receives: an array of integers and a value to search for.
  // // Returns: the index where the value was first found.
  // public int FindElement(int[] numbers, int value) {
  //   // ...
  //   return 0;
  // }

  // // Receives: an array of integers. 
  // // Returns: a new array with the same integers in reverse order.
  // public int[] Reverse(int[] numbers) {
  //   // ...
  //   return new int[1];
  // }

  // // Receives: an array of integers.
  // // Returns: a new array with only the even-indexed integers.
  // public int[] OnlyEvens(int[] numbers) {
  //   // ...
  //   return new int[1];
  // }

  // // Receives: an array of integers. 
  // // Returns: a new array with only the odd-indexed integers.
  // public int[] OnlyOdds(int[] numbers) {
  //   // ...
  //   return new int[1];
  // }

  // // Receives: two arrays of integers. 
  // // Returns: true if the two arrays are identical, false if not.
  // public bool ArraysEqual(int[] numbersA, int[] numbersB) {
  //   // ...
  //   return true;
  // }

  // // Receives: an array of integers. 
  // // Returns: a new array with the same integers, sorted from least to greates.
  // public int[] SortNumbers(int[] numbers) {
  //   // ...
  //   return new int[1];
  // }

  public int FindMax(int[] numbers) {
    int king = -101;
    foreach(int n in numbers)
    {
      if (n <= king) continue;
      king = n;
    }
    return king;
  }

  public int FindMin(int[] numbers) {
    int king = 101;
    foreach(int n in numbers)
    {
      if (n >= king) continue;
      king = n;
    }
    return king;
  }

  public int FindElement(int[] numbers, int value) {
    for (int i = 0; i < numbers.Length; i++)
    {
      if (numbers[i] != value) continue;
      return i;
    }
    return -1;
  }

  public int[] Reverse(int[] numbers) {
    int[] reversed = new int[numbers.Length];
    for(int i = 0; i < numbers.Length; i++) {
      reversed[reversed.Length - 1 - i] = numbers[i]; 
    }
    return reversed;
  }

  public int[] OnlyEvens(int[] numbers) {
    bool isOdd = numbers.Length % 2 != 0;
    int length = numbers.Length / 2;
    if (isOdd) length++;
    int[] evens = new int[length];
    for (int i = 0; i < evens.Length; i++) {
      evens[i] = numbers[i * 2];
    }
    return evens;
  }

  public int[] OnlyOdds(int[] numbers) {
    int length = numbers.Length / 2;
    int[] odds = new int[length];
    for (int i = 0; i < odds.Length; i++) {
      odds[i] = numbers[(i * 2) + 1];
    }
    return odds;
  }

  public bool ArraysEqual(int[] numbersA, int[] numbersB) {
    if (numbersA.Length != numbersB.Length) return false;
    for (int i = 0; i < numbersA.Length; i++) {
      if (numbersA[i] != numbersB[i]) return false;
    }
    return true;
  }

  public int[] SortNumbers(int[] numbers) {
    int[] arrayToSort = (int[])numbers.Clone();
    for (int i = 0; i < arrayToSort.Length; i++) {
      for (int j = 0; j < arrayToSort.Length; j++) {
        if (arrayToSort[i] < arrayToSort[j]) {
          int temp = arrayToSort[j];
          arrayToSort[j] = arrayToSort[i];
          arrayToSort[i] = temp;
        }
      }
    }
    return arrayToSort;
  }

}