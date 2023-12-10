
using UnityEngine;

public class Gaze : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward,out RaycastHit hit))
        {
            hit.transform.SendMessage("HitByRay");
            GameObject go = hit.collider.gameObject;
            name = hit.collider.gameObject.name;
        }
    }
}
