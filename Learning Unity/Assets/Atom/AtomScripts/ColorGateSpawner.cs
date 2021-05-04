using UnityEngine;

public class ColorGateSpawner : MonoBehaviour
{

  public GameObject gatePrefab;
  [Range(0, 100)] public float gateCount;
  public float gateDistance;

  private float hIncrement;

  // Start is called before the first frame update
  void Start()
  {
    hIncrement = 1 / gateCount;

    for (int i = 0; i < gateCount; i++) {
      GameObject gate = Instantiate(gatePrefab, Vector3.down * i * gateDistance, Quaternion.identity);
      gate.GetComponent<ChangeColor>().color = Color.HSVToRGB(i * hIncrement, 1, 1);
    }
  }
}
