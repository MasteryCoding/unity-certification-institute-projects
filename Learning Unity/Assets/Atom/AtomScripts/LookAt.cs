using UnityEngine;

public class LookAt : MonoBehaviour
{
  [SerializeField]
  Transform obj;

  // Correct Usage
  void Awake()
  {
    if (obj == null)
    {
      throw new System.Exception("No Object attached to LookAt");
    }
  }

  // Fluid Rotation
  void LateUpdate() {
    transform.LookAt(obj);
  }
}
