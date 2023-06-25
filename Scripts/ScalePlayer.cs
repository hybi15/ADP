using UnityEngine;

public class ScalePlayer : MonoBehaviour
{
    GameObject Player = GameObject.FindGameObjectsWithTag("Player");

    [SerializeField]
    private float Scale = 1.0f;

    private void Resize()
    {
        Player.transform.localScale = Vector3.one * Scale;
    }

    void Start()
    {
        Resize();
    }
}