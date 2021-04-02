using UnityEngine;

public class VariablesAndAssignment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Declaration - Only creates the variable
        string name;

        // Assignment - Takes an existing variable and replaces the value
        name = "Larry Sankonquinoloquist";

        // Initialization - Declares and Assigns a variable on the same line
        int amountOfFingers = 10;

        // Unused variables display a yellow underline to warn you
        // float frustrationPercentage = 0.12f;

        Debug.Log(name);
        Debug.Log(amountOfFingers);

        // These variable names are not allowed:

        // string full Name = "Jimmy Man";
        // int 3tries = 3;
        // int TrIeS_3_All0wEd = 3;
        // string for = "my sweater";
    }
}
