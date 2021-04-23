using UnityEngine;
using UnityEditor;
using Testing;

[UnityEditor.CustomEditor(typeof(Tester))]
public class TesterEditor : Editor
{
  Vector2 scrollPosition;
  GUIStyle styles;
  bool initDone = false;

  void InitStyles()
  {
    initDone = true;
    styles = new GUIStyle(GUI.skin.label)
    {
      richText = true
    };
  }
  public override void OnInspectorGUI()
  {
    if (!initDone) InitStyles();
    if (!EditorApplication.isPlaying) return;
    Tester tester = (Tester)target;
    Test[] tests = tester.tests;
    if (GUILayout.Button("Run All Tests"))
    {
      tester.RunAllTests();
    }
    for (int i = 0; i < tests.Length; i++)
    {
      if (GUILayout.Button(tests[i].methodName))
      {
        tester.RunTest(i);
      }
    }
    if (tester.lastTestsResult == "") return;
    GUILayout.Label("Results");
    GUILayout.Label(tester.lastTestsResult, styles);

  }
}