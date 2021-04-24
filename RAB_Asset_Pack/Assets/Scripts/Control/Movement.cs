using UnityEngine;


// Attach to Player
// Move is called by UserInput
[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{

  [SerializeField] private float speed;
  [SerializeField] private float jumpForce;
  [SerializeField] private float maxSpeed;

  private Rigidbody rb;

  private void Awake() {
    rb = GetComponent<Rigidbody>();
  }

  public void Move(Vector3 movementVector) {
    
    // Add the movement vector to rigidbody times the speed and deltaTime
    rb.AddForce(movementVector * speed * Time.deltaTime);

    // Set a Max Speed
    if (rb.velocity.magnitude > maxSpeed) {
      rb.velocity = rb.velocity.normalized * maxSpeed;
    }
  }


  

}
