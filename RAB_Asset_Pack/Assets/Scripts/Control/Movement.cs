using UnityEngine;


// Attach to Player
// Move is called by UserInput
public class Movement : MonoBehaviour
{

  [SerializeField] private float forceMultiplier;
  [SerializeField] private float jumpForce;
  [SerializeField] private float maxSpeed ;
  [SerializeField] private float jumpCooldown = 1;
  [SerializeField] bool debug = false;
  [SerializeField] [Range(0, 1)] float debugLineScale = 1;
  

  private Rigidbody rb;
  private float lastJumpTime;

  private void Awake() {
    rb = GetComponentInChildren<Rigidbody>();
  }

  private void Start() {
    lastJumpTime = Time.time;
  }

  private bool isGrounded{
    get {
      return Physics.Raycast(transform.position, Vector3.down, 1f, LayerMask.NameToLayer("Player"));
    }
  }

  public void Move(Vector3 movementVector)
  {
    if (!isGrounded) return;
    // Add the movement vector to rigidbody times the speed and deltaTime
    rb.AddForce(movementVector * forceMultiplier * Time.fixedDeltaTime, ForceMode.Acceleration);
    // Set a Max Speed
    if (rb.velocity.magnitude > maxSpeed)
    {
      rb.velocity = rb.velocity.normalized * maxSpeed;
    }
  }

  public void Jump() {
    if (!isGrounded) return;
    if ((Time.time - lastJumpTime) > jumpCooldown) {
      rb.AddForce(Vector3.up * jumpForce * rb.mass, ForceMode.Impulse);
      lastJumpTime = Time.time;
      Debug.Log("Jumped");
    }
  }

  void DrawDebug() {
    // x
    Debug.DrawLine(transform.position, transform.position + rb.velocity.x * Vector3.right * debugLineScale, Color.red);
    // y
    Debug.DrawLine(transform.position, transform.position + rb.velocity.y * Vector3.up * debugLineScale, Color.green);
    // z
    Debug.DrawLine(transform.position, transform.position + rb.velocity.z * Vector3.forward * debugLineScale, Color.blue);
    Debug.DrawLine(transform.position, transform.position + rb.velocity * debugLineScale, Color.white);
  }

}
