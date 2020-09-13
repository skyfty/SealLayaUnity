using UnityEngine;
using System.Collections;
public class Sphere_demo : MonoBehaviour
{
    public GameObject go;
    public float rotationX;
    public float rotationY;
    public float scartX;
    public float scartY;
    public float a, b, c, d;
    void Start()
    {
        b = Random.Range(1, 3);

        if (b == 1)
        {
            rotationX = Random.Range(-70, 70);
            transform.rotation = Quaternion.Euler(new Vector3(rotationX, 0, 0));
            scartY = 2 / Mathf.Cos(rotationX / 180 * 3.1415f);
            go.transform.localScale = new Vector3(2, scartY, 0.1f);

            a = Random.Range(-4, 4);
            transform.position = new Vector3(transform.position.x, transform.position.y, a);
        }

        if (b == 2)
        {
            rotationY = Random.Range(-70, 70);
            transform.rotation = Quaternion.Euler(new Vector3(0, rotationY, 0));
            scartX = 2 / Mathf.Cos(rotationY / 180 * 3.1415f);
            go.transform.localScale = new Vector3(scartX, 2, 0.1f);

            a = Random.Range(-4, 4);
            transform.position = new Vector3(transform.position.x, transform.position.y, a);
        }
    }

    
}