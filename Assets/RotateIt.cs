using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIt : MonoBehaviour
{
	public float x, y, z;
	private Vector3 vector3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		vector3 = new Vector3(x, y, z);
		transform.Rotate(vector3 * Time.deltaTime);
    }
}
