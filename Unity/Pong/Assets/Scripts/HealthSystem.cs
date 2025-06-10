using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public Image[] hearts;

    public bool AddDeath()
    {
        return --health > 0;
    }
    private void Update()
    {
        for (var i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = (i < health);
        }
    }
}
