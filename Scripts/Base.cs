using UnityEngine;

public delegate void OnBaseDestroyed(Base thisBase);

public delegate void OnTurnFinished();

[RequireComponent(typeof(Collider))]
public class Base : MonoBehaviour
{
    public OnBaseDestroyed onBaseDestroyed;
    public OnTurnFinished onTurnFinished;

    [SerializeField]
    private float maxHP = 500F;

    [SerializeField]
    private Catapult catapult;

    [SerializeField]
    private RayBeam rayBeam;

    private float currentHP;

    private bool canAttack;
    private bool defending;

    public void EnableTurn()
    {
        enabled = true;
        canAttack = true;
    }

    public void AttackWithCatapult()
    {
        Debug.Log("Used Attack with catapult");
    }

    public void AttackWithRay()
    {
        Debug.Log("Used Attack with ray");
    }

    public void Repair()
    {
        Debug.Log("Used repair");
    }

    public void Defend()
    {
        Debug.Log("Used defend");
        defending = true;
    }

    public void TakeDamage(RayBeam ray)
    {
    }

    private void TakeDamage(Projectile projectile)
    {
    }

    // Use this for initialization
    private void Start()
    {
        currentHP = maxHP;

        enabled = false;
        canAttack = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (canAttack)
        {
        }
    }
}