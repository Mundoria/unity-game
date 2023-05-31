using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown1;
    [SerializeField] private float attackCooldown2;
    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown1 && playerMovement.canAttack())
            Attack1();

        if (Input.GetMouseButton(1) && cooldownTimer > attackCooldown2 && playerMovement.canAttack())
            Attack2();

        cooldownTimer += Time.deltaTime;

    }

    private void Attack1()
    {
        anim.SetTrigger("attack1");
        cooldownTimer = 0;
    }

    private void Attack2()
    {
        anim.SetTrigger("attack2");
        cooldownTimer = 0;
    }

}

