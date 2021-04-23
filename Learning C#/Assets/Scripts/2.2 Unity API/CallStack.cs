using UnityEngine;

public class CallStack : MonoBehaviour
{
  float x = 4.5f;

  void Start()
  {
    int a = 5;
    int b = 2;

    for (int i = 0; i < 2; i++)
    {
      float c = 4;
      c = a + c + x;
    }

    Debug.Log(MethodScope(b));
  }

  float MethodScope(int a)
  {
    return x + a;
  }
}


