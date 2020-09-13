using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public const float maxPositionZ = 1.2f;
    public const float maxRotation = 70f;
    public float tempPositionZ;
    public float tempRotation;
    public float tempScale;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.transform.childCount);
        Initial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initial() {
        for (int i=0;i<this.transform.childCount;i++) {
            //tempPositionZ = Random.Range(-Vector3.Distance(this.transform.localPosition,Vector3.zero), 90f);
            tempPositionZ = Random.Range(-maxPositionZ, maxPositionZ);
            tempRotation = Random.Range(-maxRotation, maxRotation);
            tempScale = 1 / Mathf.Cos(tempRotation / 180 * 3.1415f);
            if (Random.Range(0, 2) == 0) {
                this.transform.GetChild(i).transform.localRotation = Quaternion.Euler(new Vector3(tempRotation, 0, 0));
                this.transform.GetChild(i).transform.localScale = new Vector3(1f, tempScale, 1f);
            } else {
                this.transform.GetChild(i).transform.localRotation = Quaternion.Euler(new Vector3(0, tempRotation, 0));
                this.transform.GetChild(i).transform.localScale = new Vector3(tempScale, 1f, 1f);
            }
            this.transform.GetChild(i).transform.localPosition = new Vector3(this.transform.GetChild(i).transform.localPosition.x, this.transform.GetChild(i).transform.localPosition.y, tempPositionZ);
            //this.child[i].transform.localPosition = new Vector3
            //Debug.Log(this.transform.childCount);
        }
    }
    
}
