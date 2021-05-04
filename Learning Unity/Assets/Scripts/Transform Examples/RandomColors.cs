using UnityEngine;



public class RandomColors : MonoBehaviour
{
  [SerializeField] Color[] colors;
  GameObject[] objects;
  const string RANDOM_COLOR_TAG = "RandomColor";

  void Awake() {
    objects = GameObject.FindGameObjectsWithTag(RANDOM_COLOR_TAG);
    if (objects.Length == 0) {
      throw new System.Exception("No GameObjects Found with tag: " + RANDOM_COLOR_TAG);
    }
    if (colors.Length == 0) {
      throw new System.Exception("No colors found in public \"colors\" field");
    }
  }
 
  void Start()
  {
    foreach (GameObject obj in objects) {
      int colorIndex = Random.Range(0, colors.Length);
      obj.GetComponent<Renderer>().material.color = colors[colorIndex];
    }
  }
}
