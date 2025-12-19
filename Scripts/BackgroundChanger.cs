using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    [SerializeField] private Sprite[] backgrounds;
    [SerializeField] private float changeTime = 3f;

    private SpriteRenderer sr;
    private int index = 0;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        InvokeRepeating(nameof(ChangeBG), changeTime, changeTime);
    }

    void ChangeBG()
    {
        if (backgrounds.Length == 0) return;

        sr.sprite = backgrounds[index];
        index++;

        if (index >= backgrounds.Length)
        {
            index = 0;
        }
    }
}
