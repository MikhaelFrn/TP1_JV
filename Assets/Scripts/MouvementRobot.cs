using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class MouvementRobot : MonoBehaviour
{
    [SerializeField] private float vitesse = 5f;
    private Rigidbody2D corps;
    private Vector2 direction;
    [SerializeField] private Animator animator;

    private void Awake()
    {
        corps = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {     
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        animator.SetBool("EnMouvement", direction.sqrMagnitude > 0.01f);
        direction = new Vector2(horizontal, vertical).normalized;
    }

    private void FixedUpdate()
    {     
        corps.MovePosition(corps.position + direction * vitesse * Time.fixedDeltaTime);
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * Les lignes ne sont pas dans le bon ordre.
     *
     */
}
