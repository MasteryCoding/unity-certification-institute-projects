using UnityEngine;

public class Rotate : MonoBehaviour
{
  [SerializeField]
  public float degreesPerSecond = 1f;

  void Update()
  {
    // Calculate how much to rotate during this frame
    float df = degreesPerSecond * Time.deltaTime;

    // Rotate the cube 'df' degrees about y axis
    transform.Rotate(Vector3.up * df);
  }
}