using UnityEngine;

public class Transforms : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Points the blue z-axis of the GameObject to the origin.
        transform.LookAt(Vector3.zero);

        // Get the x component of the GameObject's global position.
        float globalX = transform.position.x;

        // Rotates an object around the orgin's y axis, by 15 degrees.
        transform.RotateAround(Vector3.zero, Vector3.up, 15);
  }
}
