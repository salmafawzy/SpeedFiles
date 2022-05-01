using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
   

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(target.transform.position );
    }
}