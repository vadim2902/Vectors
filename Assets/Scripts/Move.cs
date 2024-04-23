using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour {

    public GameObject Goal;
    public float Speed;
    private Vector3 _direction;
    

    void Start()
    {
        //_direction = Goal.transform.position - this.transform.position;

    }

    private void LateUpdate()
    {
        _direction = Goal.transform.position - transform.position;
        transform.LookAt(Goal.transform.position);
        if (_direction.magnitude > 2)
        {
            Vector3 velocity = _direction.normalized * Speed * Time.deltaTime;
            transform.position = transform.position + velocity;
        }
        
        
    }
}
