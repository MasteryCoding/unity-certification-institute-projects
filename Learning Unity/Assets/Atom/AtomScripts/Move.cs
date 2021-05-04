using UnityEngine;

public class Move : MonoBehaviour
{
  public float maxDistance;
  public float speed;
  public Vector3 direction;

  Vector3 startPosition;

  void Start() {
    startPosition = transform.localPosition;
    direction = direction.normalized;
  }

  // void Update()
  // {
  //   // Runs into issues
  //   float distanceFromStart = Vector3.Distance(startPosition, transform.position);
  //   if (distanceFromStart > maxDistance) {
  //     direction = -direction;
  //   }
  //   transform.Translate(direction * speed * Time.deltaTime);
  // }

  // Using Mathf.Sin()
  void Update() {
    transform.localPosition = startPosition + direction * maxDistance * Mathf.Sin(Time.time * speed);
  }
}
