using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    int speedScale = 0.1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindWithTag("Player").transform.position += new Vector3(System.Convert.ToSingle(Input.GetKey(KeyCode.A)) - System.Convert.ToSingle(Input.GetKey(KeyCode.D)), System.Convert.ToSingle(Input.GetKey(KeyCode.S)) - System.Convert.ToSingle(Input.GetKey(KeyCode.W)), 0) * speedScale;
    }
}
