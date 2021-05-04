using UnityEngine;
using UnityEditor;

public class RampImpulse : MonoBehaviour
{
  public float launchSpeed = 10;

  [Header("Trajectory")]
  [SerializeField] bool drawTrajectory = false;
  [SerializeField] [Range(2, 20)] int resolution = 5;
  [SerializeField] [Range(0, 2)] float timeScale = 1;
  public float yOffset;

  void OnTriggerEnter(Collider other) {
    Rigidbody rb = other.GetComponent<Rigidbody>();
    if (rb == null) return;
    rb.velocity = transform.forward * launchSpeed;
  }

  private void OnDrawGizmos() {
    if (!drawTrajectory) return;
    Vector3[] points = new Vector3[resolution];
    points[0] = transform.position + Vector3.up * yOffset;
    Vector3 initialVelocity = transform.forward * launchSpeed;
    for (int i = 1; i < resolution; i++) {
      float t = i * timeScale;
      points[i] = points[0] + (initialVelocity * (i * timeScale)) + (0.5f * 9.8f * Vector3.down * Mathf.Pow(i * timeScale, 2));
    }
    Handles.DrawAAPolyLine(1, points);
  }
}
