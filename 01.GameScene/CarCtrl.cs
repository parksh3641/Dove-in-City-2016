using UnityEngine;
using System.Collections;

public class CarCtrl : MonoBehaviour {

    private float Speed;
    private float speed;
    private float CarRandom;
    private Transform car;
    private BoxCollider2D box;

    private Transform Player;

    private int Dove;
    private float posx;
    private float posy;
    private float distance;
    private int Cooltime = 2;
    private int A;
    private int AA; //차 위로 잘 못올라가게 하는 값
    private float B;
    private float C;
    private int Car;
    private int CarValue = 0;

    private float X;
    private float Y;

    //방향정함 1은 왼쪽 2는 오른쪽
    public int Vector;
    private int SaveVector;
    private int vector = 2;

    private bool Rotation;
    private bool Right = false;
    private bool Left = false;
    private bool Up = false;
    private bool Down = false;

    private int Value = 0;

    public Sprite RCarRight;
    public Sprite RCarLeft;
    public Sprite RCarUp;
    public Sprite RCarDown;

    public Sprite YCarRight;
    public Sprite YCarLeft;
    public Sprite YCarUp;
    public Sprite YCarDown;

    public Sprite BCarRight;
    public Sprite BCarLeft;
    public Sprite BCarUp;
    public Sprite BCarDown;

    public Sprite MCarRight;
    public Sprite MCarLeft;
    public Sprite MCarUp;
    public Sprite MCarDown;
    void Awake()
    {
        Value = Random.Range(0, 4);
        Rotation = false;
        car = GetComponent<Transform>();
        box = GetComponent<BoxCollider2D>();
        posx = car.position.x;
        posy = car.position.y;

        SaveVector = Vector;

        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Player = GameObject.FindWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Player = GameObject.FindWithTag("White").GetComponent<Transform>();
        }
        else if (Dove == 2)
        {
            Player = GameObject.FindWithTag("Eagle").GetComponent<Transform>();
        }
        else if (Dove == 3)
        {
            Player = GameObject.FindWithTag("Dori").GetComponent<Transform>();
        }
    }

    void OnEnable()
    {
        Speed = Random.Range(GameManager.bgspeed * 0.8f, GameManager.bgspeed * 1.2f);
        speed = Speed;
        CarRandom = GameManager.CarRandom;
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

        X = transform.position.x;
        Y = transform.position.y;

        Vector = SaveVector;
        vector = Vector;

        Right = false;
        Left = false;
        Up = false;
        Down = false;

        float Z = Random.Range(0, 100);
        if(Z < CarRandom)
        {
            if (Vector == 1) //왼쪽/오른쪽/위/아래
            {
                Left = true;
                box.offset = new Vector2(-0.32f, 0.6f);
                box.size = new Vector3(4.6f, 3f);
                carLeft();
            }
            else if (Vector == 2)
            {
                Right = true;
                box.offset = new Vector2(-0.32f, 0.6f);
                box.size = new Vector3(4.6f, 3f);
                carRight();
            }
            else if (Vector == 3)
            {
                Up = true;
                box.offset = new Vector2(-0.14f, 0.3f);
                box.size = new Vector3(2.9f, 4.3f);
                carUp();
            }
            else if (Vector == 4)
            {
                Down = true;
                box.offset = new Vector2(-0.14f, 0.3f);
                box.size = new Vector3(2.9f, 4.3f);
                carDown();
            }
            StartCoroutine(ModeCheck());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        transform.position = new Vector3(X, Y, transform.position.z);
        StopAllCoroutines();
    }

    void PlayerDie()
    {
        Speed = 0;
    }
    void PlayerLive()
    {
        Speed = speed;
    }

    void Update()
    {
        if (Right == true)
        {
            if(CarValue ==0)
            {
                transform.Translate(Speed * Time.deltaTime, 0, 0);
            }
            else if(CarValue ==1)
            {
                transform.Translate(Speed *0.2f* Time.deltaTime, 0, 0);
            }
            else if(CarValue ==2)
            {
                transform.Translate(Speed *2f* Time.deltaTime, 0, 0);
            }
        }
        else if (Left == true)
        {
            if (CarValue == 0)
            {
                transform.Translate(-Speed * Time.deltaTime, 0, 0);
            }
            else if (CarValue == 1)
            {
                transform.Translate(-Speed * 0.2f * Time.deltaTime, 0, 0);
            }
            else if (CarValue == 2)
            {
                transform.Translate(-Speed * 2f * Time.deltaTime, 0, 0);
            }
        }
        else if (Up == true)
        {
            if (CarValue == 0)
            {
                transform.Translate(0,Speed * Time.deltaTime, 0);
            }
            else if (CarValue == 1)
            {
                transform.Translate(0,Speed * 0.2f * Time.deltaTime, 0);
            }
            else if (CarValue == 2)
            {
                transform.Translate(0,Speed * 2f * Time.deltaTime, 0);
            }
        }
        else if (Down == true)
        {
            if (CarValue == 0)
            {
                transform.Translate(0, -Speed * Time.deltaTime, 0);
            }
            else if (CarValue == 1)
            {
                transform.Translate(0, -Speed * 0.2f * Time.deltaTime, 0);
            }
            else if (CarValue == 2)
            {
                transform.Translate(0, -Speed * 2f * Time.deltaTime, 0);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Rotation")
        {
            RandomRotationA();
        }
        if (coll.gameObject.tag == "RotationC")
        {
            Rotation = true;
            RandomRotationC();
        }
        if (coll.gameObject.tag == "RotationD")
        {
            Rotation = true;
            RandomRotationD();
        }
        if (coll.gameObject.tag == "RoadEnd")
        {
            RandomRotationE();
        }
        //if (coll.gameObject.tag == "RotationB")
        //{
        //    RandomRotationB();
        //}
    }

    void RandomRotationA()
    {
        A = Random.Range(0, 3); //왼오위아래

        if (vector == 1) //왼
        {
            if (A == 0)
            {
                vector = 1;
            }
            else if (A == 1)
            {
                AA = Random.Range(0, 3);
                if(AA == 0)
                {
                    RandomRotationA();
                }
                else
                {
                    Left = false;
                    Right = false;
                    Up = true;
                    Down = false;
                    vector = 3;
                    carUp();
                }
            }
            else if (A == 2)
            {
                Left = false;
                Right = false;
                Up = false;
                Down = true;
                vector = 4;
                carDown();
            }
        }
        else if (vector == 2) //오
        {
            if (A == 0)
            {
                vector = 2;
            }
            else if (A == 1)
            {
                AA = Random.Range(0, 3);
                if (AA == 0)
                {
                    RandomRotationA();
                }
                else
                {
                    Left = false;
                    Right = false;
                    Up = true;
                    Down = false;
                    vector = 3;
                    carUp();
                }
            }
            else if (A == 2)
            {
                Left = false;
                Right = false;
                Up = false;
                Down = true;
                vector = 4;
                carDown();
            }
        }
        else if (vector == 3) //위
        {
            if (A == 0)
            {
                vector = 3;
            }
            else if (A == 1)
            {
                Left = true;
                Right = false;
                Up = false;
                Down = false;
                vector = 1;
                carLeft();
            }
            else if (A == 2)
            {
                Left = false;
                Right = true;
                Up = false;
                Down = false;
                vector = 2;
                carRight();
            }
        }
        else if (vector == 4) //↑ 돌진
        {
            if (A == 0)
            {
                AA = Random.Range(0, 3);
                if (AA == 0)
                {
                    RandomRotationA();
                }
                else
                {
                    vector = 4;
                }
            }
            else if (A == 1)
            {
                Left = true;
                Right = false;
                Up = false;
                Down = false;
                vector = 1;
                carLeft();
            }
            else if (A == 2)
            {
                Left = false;
                Right = true;
                Up = false;
                Down = false;
                vector = 2;
                carRight();
            }
        }
    }
    void RandomRotationB()
    {
        float A = Random.Range(0, 2);

        if (vector == 1)
        {
            if (B == 0)
            {
                if (A == 0)
                {
                    vector = 1;
                }
                else if (A == 1)
                {
                    B = 1;
                    Left = false;
                    Right = true;
                    Up = false;
                    Down = false;
                    vector = 2;
                    carRight();
                }
            }
            else if (B == 1)
            {
                B = 0;
                if (A == 0)
                {
                    Left = true;
                    Right = false;
                    Up = false;
                    Down = false;
                    vector = 0;
                    carLeft();
                }
                else if (A == 1)
                {
                    Left = false;
                    Right = true;
                    Up = false;
                    Down = false;
                    vector = 2;
                    carRight();
                }
            }
        }
        else if (vector == 2)
        {
            if (B == 1)
            {
                Left = false;
                Right = false;
                Up = false;
                Down = true;
                vector = 1;
                carDown();
            }
        }
        else if (vector == 3)
        {
            if (C == 1)
            {
                Left = true;
                Right = false;
                Up = false;
                Down = false;
                vector = 0;
                carLeft();
            }
        }
        else if (vector == 0)
        {
            if (C == 0)
            {
                if (A == 0)
                {
                    vector = 0;
                }
                else if (A == 1)
                {
                    C = 1;
                    Left = false;
                    Right = false;
                    Up = true;
                    Down = false;
                    vector = 3;
                    carUp();
                }
            }
            else if (C == 1)
            {
                C = 0;
                if (A == 0)
                {
                    Left = false;
                    Right = false;
                    Up = true;
                    Down = false;
                    vector = 3;
                    carUp();
                }
                else if (A == 1)
                {
                    Left = false;
                    Right = false;
                    Up = false;
                    Down = true;
                    vector = 1;
                    carDown();
                }
            }
        }
    } //안쓰임
    void RandomRotationC()
    {
        A = Random.Range(0, 2);
        if (vector == 1) //왼
        {
            if (A == 0)
            {
                vector = 1;
            }
            else if (A == 1)
            {
                AA = Random.Range(0, 3);
                if (AA == 0)
                {
                    RandomRotationA();
                }
                else
                {
                    Left = false;
                    Right = false;
                    Up = true;
                    Down = false;
                    vector = 3;
                    carUp();
                }
            }
        }
        else if (vector == 2) //오
        {
            if (A == 0)
            {
                vector = 2;
            }
            else if (A == 1)
            {
                AA = Random.Range(0, 3);
                if (AA == 0)
                {
                    RandomRotationA();
                }
                else
                {
                    Left = false;
                    Right = false;
                    Up = true;
                    Down = false;
                    vector = 3;
                    carUp();
                }
            }
        }
        else if (vector == 4)
        {
            if (A == 0)
            {
                Left = true;
                Right = false;
                Up = false;
                Down = false;
                vector = 1;
                carLeft();
            }
            else if (A == 1)
            {
                Left = false;
                Right = true;
                Up = false;
                Down = false;
                vector = 2;
                carRight();
            }
        }
    }
    void RandomRotationD()
    {
            A = Random.Range(0, 2);
        if (vector == 1) //왼
        {
            if (A == 0)
            {
                vector = 1;
            }
            else if (A == 1)
            {
                Left = false;
                Right = false;
                Up = false;
                Down = true;
                vector = 4;
                carDown();
            }
        }
        else if (vector == 2) //오
        {
            if (A == 0)
            {
                vector = 2;
            }
            else if (A == 1)
            {
                Left = false;
                Right = false;
                Up = false;
                Down = true;
                vector = 4;
                carDown();
            }
        }
        else if (vector == 3)
        {
            if (A == 0)
            {
                Left = true;
                Right = false;
                Up = false;
                Down = false;
                vector = 1;
                carLeft();
            }
            else if (A == 1)
            {
                Left = false;
                Right = true;
                Up = false;
                Down = false;
                vector = 2;
                carRight();
            }
        }
    }
    void RandomRotationE()
    {
        if (vector == 3) //위
        {
            Left = false;
            Right = false;
            Up = false;
            Down = true;
            vector = 4;
            carDown();
        }
        else if (vector == 4)
        {
            Left = false;
            Right = false;
            Up = true;
            Down = false;
            vector = 3;
            carUp();
        }
    }
    IEnumerator ModeCheck()
    {
        //x축이동제한
        if (transform.localPosition.x > 11)
        {
            Left = true;
            Right = false;
            Up = false;
            Down = false;
            vector = 1;
            carLeft();
        }
        else if (transform.localPosition.x < -11)
        {
            Left = false;
            Right = true;
            Up = false;
            Down = false;
            vector = 2;
            carRight();
        }

        distance = Vector3.Distance(Player.transform.position, transform.position);

        if (transform.position.y < Player.position.y - 1f)
        {
            transform.rotation = Quaternion.identity;
            gameObject.SetActive(false);
        }

        Car = PlayerPrefs.GetInt("Car", 0);
        if(Car ==0)
        {
            CarValue = 0;
        }
        else if(Car ==1)
        {
            CarValue = 1;
        }
        else if(Car == 2)
        {
            CarValue = 2;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(ModeCheck());
    }

    void carLeft()
    {
        if (Value == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = RCarLeft;
        }
        else if (Value == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = YCarLeft;
        }
        else if (Value == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BCarLeft;
        }
        else if (Value == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = MCarLeft;
        }
    }
    void carUp()
    {
        if (Value == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = RCarUp;
        }
        else if (Value == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = YCarUp;
        }
        else if (Value == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BCarUp;
        }
        else if (Value == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = MCarUp;
        }
    }
    void carDown()
    {
        if (Value == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = RCarDown;
        }
        else if (Value == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = YCarDown;
        }
        else if (Value == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BCarDown;
        }
        else if (Value == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = MCarDown;
        }
    }
    void carRight()
    {
        if (Value == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = RCarRight;
        }
        else if (Value == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = YCarRight;
        }
        else if (Value == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BCarRight;
        }
        else if (Value == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = MCarRight;
        }
    }
}
