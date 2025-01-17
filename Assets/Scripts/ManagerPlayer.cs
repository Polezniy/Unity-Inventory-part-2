using UnityEngine;
using UnityEngine.AI;

public class ManagerPlayer : MonoBehaviour
{
    public LayerMask whatCanBEClickedOn;
    private NavMeshAgent navMesh;

    private void Start()
    {
        this.navMesh = this.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo, 100, whatCanBEClickedOn))
            {
                navMesh.SetDestination(hitInfo.point);
            }
        }
    }


}
