using UnityEngine;

public class CameraController : MonoBehaviour
{
  [Header("Control Settings")]
  [SerializeField] private float lookSensitivity;
  [SerializeField] float minX = 10;
  [SerializeField] float maxX = 80;

  [Header("Camera Position")]
  [Range(5f, 20f)]
  [SerializeField] float distance = 15f;

  [Range(1f, 3f)]
  [SerializeField] float height = 4f;

  private Camera cam;
  private GameObject player;


  public void Look(Vector2 mouseVector)
  {
    // Clamp the xRot between MIN and MAX angles
    float xRot = transform.eulerAngles.x + mouseVector.y * lookSensitivity;
    xRot = Mathf.Clamp(xRot, minX, maxX);
    float yRot = transform.eulerAngles.y + mouseVector.x * lookSensitivity;
    transform.eulerAngles = new Vector3(xRot, yRot, 0);
  }

  private void Awake()
  {
    // Get the Camera in children.
    cam = GetComponentInChildren<Camera>();
    if (cam == null)
    {
      Debug.LogError("No Camera component was found in children.");
      return;
    }

    player = GameObject.FindGameObjectWithTag("Player");
    if (player == null)
    {
      Debug.LogError("No GameObject with 'Player' tag in scene.");
      return;
    }
  }

  private void LateUpdate()
  {
    transform.position = player.transform.position;
    cam.transform.LookAt(player.transform.position);
    cam.transform.localPosition = new Vector3(0, height, -distance);
    AvoidWalls(); // Ensure camera does not get stuck in a wall.
  }

  const int MAX_TRIES = 30; // Exit condition to avoid infinite loop.
  const float STEP_AMOUNT = 0.3f; // Amount between LOS checks
  private void AvoidWalls()
  {
    int tries = 0;
    while (tries < MAX_TRIES)
    {
      tries++;
      RaycastHit hitInfo;
      // Raycast towards the player
      bool hit = Physics.Raycast(
        cam.transform.position,
        player.transform.position - cam.transform.position, // Vector subtraction slide
        out hitInfo
      );
      if (!hit) break;
      if (hitInfo.transform.CompareTag("Player")) break;
      cam.transform.localPosition += Vector3.forward * STEP_AMOUNT;
    }
  }
}
