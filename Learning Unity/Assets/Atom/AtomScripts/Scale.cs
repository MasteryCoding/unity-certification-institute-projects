using UnityEngine;

public class Scale : MonoBehaviour
{
  
  [SerializeField] float frequency;
  [SerializeField] float min;
  [SerializeField] float max;
  float l, a, f, y;

  // Update is called once per frame
  void Update()
  {
    transform.localScale = (Vector3.one * Mathf.Abs(min + Mathf.Sin(Time.time * frequency) * (max - min)));
    
    y = l + a * Mathf.Sin(Time.time * f);

  }
}
