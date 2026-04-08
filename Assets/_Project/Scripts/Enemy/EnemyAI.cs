using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private GameObject _player;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, _player.transform.position, 2f * Time.deltaTime);
    }

}
