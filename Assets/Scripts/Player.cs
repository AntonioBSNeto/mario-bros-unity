using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSpriteRenderer smallRenderer;
    public PlayerSpriteRenderer bigRenderer;

    public DeathAnimation deathAnimation;

    public bool Big => bigRenderer.enabled;
    public bool Small => smallRenderer.enabled;
    public bool Dead => deathAnimation.enabled;

    private void Awake()
    {
        deathAnimation = gameObject.GetComponent<DeathAnimation>();
    }
    public void Hit()
    {
        if (Big)
        {
            Shrink();
        } else
        {
            Death();
        }
    }

    private void Shrink()
    {
        // todo
    }

    private void Death()
    {
        smallRenderer.enabled = false;
        bigRenderer.enabled = false;
        deathAnimation.enabled = true;

        GameManager.Instance.ResetLevel(3f);
    }
}
