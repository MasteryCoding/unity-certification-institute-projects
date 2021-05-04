using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class RampUV : MonoBehaviour
{
  [SerializeField]
  float scrollSpeed = 0.5f;
  Renderer rend;

  void Awake()
  {
    rend = GetComponent<Renderer>();
    Debug.Log(rend);
  }

  void Update()
  {
    float offset = Time.time * -scrollSpeed;
    rend.materials[0].SetTextureOffset("_MainTex", new Vector2(0, offset));
  }
}
