using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
  [SerializeField] float acceleration = 10;
  Rigidbody rb;

  public float jumpForce;

  private void Awake()
  {
    rb = GetComponent<Rigidbody>();
  }

  public void Move(Vector3 moveDirection) {
    // Ensure vector is not greater that 1 in magnitude.
    if (moveDirection.magnitude > 1) moveDirection = moveDirection.normalized;

    // Multiply by acceleration
    Vector3 forceVector = moveDirection * acceleration;

    // Use the forceVector to add an acceleration to the ball. Ignoring its mass
    rb.AddForce(forceVector, ForceMode.Acceleration);
  }

  public void Jump() {
    // Check if the ball is grounded before jumping.
    bool grounded = Physics.Raycast(transform.position, Vector3.down, 1f, LayerMask.NameToLayer("Player"));
    if (!grounded) return;
    GameManager.am.Play("Jump");
    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
  }

  public void Respawn() {
    GameObject spawnPoint = GameObject.FindGameObjectWithTag("Respawn");
    if (spawnPoint == null) return;
    // Reset Rigidbody
    rb.velocity = Vector3.zero;
    rb.angularVelocity = Vector3.zero;
    transform.rotation = Quaternion.identity;
    if (spawnPoint) {
      transform.position = spawnPoint.transform.position;
    } else {
      transform.position = Vector3.zero;
    }
  }

}
