using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]
    private GameObject projectileToFire;

    [SerializeField]
    private Transform projectileSpawnTranform;

    [SerializeField]
    public GameObject enemyBase;
    private Vector3 posFinal;
    public float bulletTime = 2f;

    private void Start()
    {
        posFinal = new Vector3(transform.position.x + 20, transform.position.y + 2f, transform.position.z);
    }

    public void Fire()
    {
        GameObject.Instantiate(projectileToFire, transform.position, transform.rotation);
        projectileToFire.transform.position = Vector3.Slerp(this.transform.position, posFinal,bulletTime); 
        Debug.Log("Disparo Catapulta");
    }
}