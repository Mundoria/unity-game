using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startHealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startHealth);
        currentHealth -= _damage;

        if (currentHealth > 0)
        {
            //hurt
        }
        else
        {
            //die
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
            TakeDamage(1);
    }
}
