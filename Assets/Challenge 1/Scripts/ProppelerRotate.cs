using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProppelerRotate : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float anglePS = 45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.localEulerAngles;
        rotation.z += anglePS *100* Time.deltaTime;
        transform.localEulerAngles = rotation;
    }
}
