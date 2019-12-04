using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easteregg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.F) && Input.GetKeyDown(KeyCode.U))
		{
			Debug.Log("hello");
			transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);


		}
	}
}
