using UnityEngine;


public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offSet;
    private void FixedUpdate()
    {
        transform.position = target.position+offSet;
    }

}
