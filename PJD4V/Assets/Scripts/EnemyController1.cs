using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController1 : MonoBehaviour
{
    private Vector2 Direncion;
    [SerializeField] private float changeDirectionTime;
    private float _currentChangeTime;
    private Animator EnemyAI;
    
    // Start is called before the first frame update
    void Start()
    {
       
        EnemyAI = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoverDirection();
        CountTime();
    }

    public void SetDirencion(Vector2 Direction)
    {
        Direncion = Direction;
    }

    public void MoverDirection()
    {
        transform.Translate(Direncion * Time.deltaTime);
    }

    public void CountTime()
    {
        if (_currentChangeTime <= changeDirectionTime)
        {
            _currentChangeTime += Time.deltaTime;
        }
        else
        {
            _currentChangeTime = 0; 
            // mudar a direcao de andar 
            EnemyAI.SetTrigger("ChangeDiretion");
        }
    }
}
