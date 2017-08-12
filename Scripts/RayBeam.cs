using UnityEngine;

public class RayBeam : MonoBehaviour
{
    [SerializeField]
    private float damage;

    [SerializeField]
    private float rayDistance = 50F;

    [SerializeField]
    private GameController gController;

    public Vector3 targetLocation;
    private Vector3 targetDirection;

    private void Awake()
    {
        gController = GameObject.Find("Main Camera").GetComponent<GameController>();
    }

    private void Update()
    {
        targetLocation = gController.TargetLocation;
    }

    public float DamagePts
    {
        get
        {
            return damage;
        }
    }

    public void Fire()
    {
        Ray ray = new Ray(transform.position, targetLocation);
        RaycastHit hit;

        if (Physics.Raycast(ray,out hit))
        {
            if (hit.collider.gameObject.transform.position == targetLocation)
                Debug.Log("Damage");
        }

        Debug.DrawRay(transform.position, targetLocation, Color.green, 2f);
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, targetDirection,Color.green,1f);
    }
}