using UnityEngine;

public class Vect3Test : MonoBehaviour
{
	void Start ()
    {
        int loop = 100000000;
        Vector3 v3 = Vector3.zero;
        var sw = new System.Diagnostics.Stopwatch();
        sw.Start();
        for (int i = 0; i < loop; i++)
        {
            v3 = new Vector3(1, 0, 0);
        }
        sw.Stop();
        Debug.Log($"new Vect3=>{sw.ElapsedMilliseconds}");

        sw.Restart();
        for (int i = 0; i < loop; i++)
        {
            v3 = Vector3.right;
        }
        sw.Stop();
        Debug.Log($"Vector3.right =>{sw.ElapsedMilliseconds}");
    }
}
