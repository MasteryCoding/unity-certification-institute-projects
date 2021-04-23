using UnityEngine;

public class SolutionsArrayChallenge : MonoBehaviour {

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
    for (int i = 0; i < numbers.Length; i++) {
      for (int j = 0; j < numbers.Length; j++) {
        if (numbers[i] < numbers[j]) {
          int temp = numbers[j];
          numbers[j] = numbers[i];
          numbers[i] = temp;
        }
      }
    }
    return numbers;
  }

}