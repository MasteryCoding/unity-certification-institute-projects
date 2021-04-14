using UnityEngine;

public class Rotate : MonoBehaviour
{
  public float degreesPerSecond = 1f;

  void Update()
  {
    // Calculate how much to rotate durign this frame
    float df = degreesPerSecond * Time.deltaTime;

    // Rotate the cube 'df' degrees about y axis
    transform.Rotate(Vector3.up * df);
  }
}

abstract class Signatures {

    abstract public void Rotate(Vector3 eulers);

    public static float deltaTime { get; }

}