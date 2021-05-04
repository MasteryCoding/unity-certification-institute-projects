using UnityEngine;

public class Vel : MonoBehaviour
{
  public float speed = 1;
  // Start is called before the first frame update
  void Start()
  {
    Rigidbody rb = GetComponent<Rigidbody>();
    rb.velocity = new Vector3(speed,0,0);
  }
}
