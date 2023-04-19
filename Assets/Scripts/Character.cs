using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    private Animator animator;
    private Grid grid;
    GameObject Object;
    StageClearControl stageClearControl;
    private Scene scene;
    public bool MoveFront = false;
    public bool MoveFrontLeft = false;
    public bool MoveFrontRight = false;
    public bool MoveBack = false;
    public bool MoveBackLeft = false;
    public bool MoveBackRight = false;
    public bool Pause = false;
    public bool Clear = false;
    public bool Fail = false;
    public int Stage;
    public int Food;
    public int[] Foods = new int[] { 3, 6, 5, 10, 5, 10};
    public int Tool;
    // Left°¡ true, Right°¡ false
    public bool CrossWalk_2 = false;
    // 0 : ¿Þ-Áß-¿À, 1 : ¿Þ-¿À-Áß, 2 : ¿À-Áß-¿Þ, 3 : ¿À-¿Þ-Áß, 4: Áß-¿Þ-¿À, 5: Áß-¿À-¿Þ
    public int CrossWalk_3 = 0;
    public bool MeetDeadEnd = false;
    public int BackCrossWalk = 0;
    Vector3 moveVelocity = Vector3.zero;
    public float moveSpeed = 0.3f;

    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        grid = transform.parent.GetComponentInParent<Grid>();
        transform.position = grid.CellToWorld(new Vector3Int(-2, 0, 0));

        Object = GameObject.Find("StageClearController");
        stageClearControl = Object.GetComponent<StageClearControl>();

        scene = SceneManager.GetActiveScene();
        bool parse = int.TryParse(scene.name.Substring(scene.name.Length-1, 1), out int stage);
        Stage = stage;
        Food = Foods[Stage-1];
        Tool = 0;
    }

    // 2_CrossWalk is called once per frame
    void Update()
    {
        if (MoveFront)
        {
            animator.SetInteger("WalkType", 1);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(1, 0, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontLeft)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(0, -1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontRight)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(0, 1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackLeft)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, -1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackRight)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, 1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBack)
        {
            animator.SetInteger("WalkType", 3);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, 0, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (Pause)
        {
            animator.SetInteger("WalkType", 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Clear)
        {
            animator.SetBool("Clear", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = Vector3.zero;
            stageClearControl.stageClear[Stage - 1] = true;
        }
        if (Fail)
        {
            animator.SetBool("Clear", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Food--;
        if (collision.gameObject.name =="FrontLeft_4" && Food == Foods[3] - 1)
        {
            Food++;
        }
        if (collision.gameObject.name == "FrontRight_6_1" && Food == Foods[5] - 1)
        {
            Food++;
        }

        if (collision.gameObject.tag == "Front")
        {
            CommandClear();
            MoveFront = true;
        }
        else if (collision.gameObject.tag == "FrontLeft")
        {
            CommandClear();
            MoveFrontLeft = true;
        }
        else if (collision.gameObject.tag == "FrontRight")
        {
            CommandClear();
            MoveFrontRight = true;
        }
        else if (collision.gameObject.tag == "Back")
        {
            CommandClear();
            MoveBack = true;
        }
        else if (collision.gameObject.tag == "BackRight")
        {
            CommandClear();
            MoveBackRight = true;
        }
        else if (collision.gameObject.tag == "BackLeft")
        {
            CommandClear();
            MoveBackLeft = true;
        }

        else if (collision.gameObject.tag == "Road_56")
        {
            if (MoveFrontRight)
            {
                CommandClear();
                MoveFrontLeft = true;
            }
            else
            {
                CommandClear();
                MoveBackLeft=true;
            }
        }
        else if (collision.gameObject.tag == "Road_12")
        {
            if (MoveBack)
            {
                CommandClear();
                MoveFrontRight = true;
            }
            else
            {
                CommandClear();
                MoveFront = true;
            }
        }
        else if (collision.gameObject.tag == "Road_45")
        {
            if (MoveFront)
            {
                CommandClear();
                MoveBackLeft = true;
            }
            else
            {
                CommandClear();
                MoveBack = true;
            }
        }

        else if (collision.gameObject.tag == "CrossWalk_246")
        {
            if (MoveFront)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontLeft = true;
                }
                else
                {
                    MoveFrontRight = true;
                }
            }
            else if(MoveBackRight)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontRight = true;
                }
                else
                {
                    MoveBack = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBack = true;
                }
                else
                {
                    MoveFrontLeft = true;
                }
            }
        }
        else if (collision.gameObject.tag == "CrossWalk_356")
        {
            if (MoveFrontRight)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontLeft = true;
                }
                else
                {
                    MoveBackRight = true;
                }
            }
            else if (MoveBackRight)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackRight = true;
                }
                else
                {
                    MoveBackLeft = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackLeft = true;
                }
                else
                {
                    MoveFrontLeft = true;
                }
            }
        }
        else if (collision.gameObject.tag == "CrossWalk_236")
        {
            if (MoveFrontLeft)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontLeft = true;
                }
                else
                {
                    MoveFrontRight = true;
                }
            }
            else if (MoveBackRight)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontRight = true;
                }
                else
                {
                    MoveBackRight = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackRight = true;
                }
                else
                {
                    MoveFrontLeft = true;
                }
            }
        }
        else if (collision.gameObject.tag == "CrossWalk_235")
        {
            if (MoveFrontRight)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontRight = true;
                }
                else
                {
                    MoveBackRight = true;
                }
            }
            else if (MoveBackLeft)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackRight = true;
                }
                else
                {
                    MoveBackLeft = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackLeft = true;
                }
                else
                {
                    MoveFrontRight = true;
                }
            }
        }
        else if (collision.gameObject.tag == "CrossWalk_256")
        {
            if (MoveFrontRight)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontLeft = true;
                }
                else
                {
                    MoveFrontRight = true;
                }
            }
            else if (MoveBackLeft)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackLeft = true;
                }
                else
                {
                    MoveFrontLeft = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontRight = true;
                }
                else
                {
                    MoveBackLeft = true;
                }
            }
        }
        else if (collision.gameObject.tag == "CrossWalk_135")
        {
            if (MoveFrontRight)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFront = true;
                }
                else
                {
                    MoveBackRight = true;
                }
            }
            else if (MoveFrontLeft)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackLeft = true;
                }
                else
                {
                    MoveFront = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackRight = true;
                }
                else
                {
                    MoveBackLeft = true;
                }
            }
        }
        else if (collision.gameObject.tag == "CrossWalk_145")
        {
            if (MoveFrontRight)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFront = true;
                }
                else
                {
                    MoveBack = true;
                }
            }
            else if (MoveFront)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBackLeft = true;
                }
                else
                {
                    MoveFront = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBack = true;
                }
                else
                {
                    MoveBackLeft = true;
                }
            }
        }
        else if (collision.gameObject.tag == "CrossWalk_124")
        {
            if (MoveFront)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFront = true;
                }
                else
                {
                    MoveFrontRight = true;
                }
            }
            else if (MoveBack)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontRight = true;
                }
                else
                {
                    MoveBack = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveBack = true;
                }
                else
                {
                    MoveFront = true;
                }
            }
        }
        else if (collision.gameObject.tag == "CrossWalk_146")
        {
            if (MoveFront)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontLeft = true;
                }
                else
                {
                    MoveFront = true;
                }
            }
            else if (MoveBack)
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFrontLeft = true;
                }
                else
                {
                    MoveBack = true;
                }
            }
            else
            {
                CommandClear();
                if (CrossWalk_2)
                {
                    MoveFront = true;
                }
                else
                {
                    MoveBack = true;
                }
            }
        }
        // 0 : ¿Þ-Áß-¿À, 1 : ¿Þ-¿À-Áß, 2 : ¿À-Áß-¿Þ, 3 : ¿À-¿Þ-Áß, 4: Áß-¿Þ-¿À, 5: Áß-¿À-¿Þ
        else if (collision.gameObject.tag == "CrossWalk_2356")
        {
            if (!MeetDeadEnd)
            {
                BackCrossWalk = 0;
            }
            MeetDeadEnd = false;

            if (MoveFrontRight)
            {
                CommandClear();

                if (BackCrossWalk == 0)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 1)
                    {
                        MoveFrontLeft = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 3)
                    {
                        MoveBackRight = true;
                    }
                    else
                    {
                        MoveFrontRight = true;
                    }
                    BackCrossWalk++;
                }
                else if (BackCrossWalk == 1)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 5)
                    {
                        MoveFrontLeft = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 4)
                    {
                        MoveBackRight = true;
                    }
                    else
                    {
                        MoveFrontRight = true;
                    }
                    BackCrossWalk++;
                }
                else if (BackCrossWalk == 2)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 3)
                    {
                        MoveFrontLeft = true;
                    }
                    else if (CrossWalk_3 == 1 || CrossWalk_3 == 2)
                    {
                        MoveBackRight = true;
                    }
                    else
                    {
                        MoveFrontRight = true;
                    }
                    BackCrossWalk++;
                }
                else
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 4)
                    {
                        MoveFrontLeft = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 5)
                    {
                        MoveBackRight = true;
                    }
                    else
                    {
                        MoveFrontRight = true;
                    }
                    BackCrossWalk = 0;
                }
            }
            else if (MoveBackLeft)
            {
                CommandClear();
                if (BackCrossWalk == 0)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 1)
                    {
                        MoveBackRight = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 3)
                    {
                        MoveFrontLeft = true;
                    }
                    else
                    {
                        MoveBackLeft = true;
                    }
                    BackCrossWalk++;
                }
                else if (BackCrossWalk == 1)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 5)
                    {
                        MoveBackRight = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 4)
                    {
                        MoveFrontLeft = true;
                    }
                    else
                    {
                        MoveBackLeft = true;
                    }
                    BackCrossWalk++;
                }
                else if (BackCrossWalk == 2)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 3)
                    {
                        MoveBackRight = true;
                    }
                    else if (CrossWalk_3 == 1 || CrossWalk_3 == 2)
                    {
                        MoveFrontLeft = true;
                    }
                    else
                    {
                        MoveBackLeft = true;
                    }
                    BackCrossWalk++;
                }
                else
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 4)
                    {
                        MoveBackRight = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 5)
                    {
                        MoveFrontLeft = true;
                    }
                    else
                    {
                        MoveBackLeft = true;
                    }
                    BackCrossWalk = 0;
                }
            }
            else if (MoveFrontLeft)
            {
                CommandClear();
                if (BackCrossWalk == 0)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 1)
                    {
                        MoveBackLeft = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 3)
                    {
                        MoveFrontRight = true;
                    }
                    else
                    {
                        MoveFrontLeft = true;
                    }
                    BackCrossWalk++;
                }
                else if (BackCrossWalk == 1)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 5)
                    {
                        MoveBackLeft = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 4)
                    {
                        MoveFrontRight = true;
                    }
                    else
                    {
                        MoveFrontLeft = true;
                    }
                    BackCrossWalk++;
                }
                else if (BackCrossWalk == 2)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 3)
                    {
                        MoveBackLeft = true;
                    }
                    else if (CrossWalk_3 == 1 || CrossWalk_3 == 2)
                    {
                        MoveFrontRight = true;
                    }
                    else
                    {
                        MoveFrontLeft = true;
                    }
                    BackCrossWalk++;
                }
                else
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 4)
                    {
                        MoveBackLeft = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 5)
                    {
                        MoveFrontRight = true;
                    }
                    else
                    {
                        MoveFrontLeft = true;
                    }
                    BackCrossWalk = 0;
                }
            }
            else
            {
                CommandClear();
                if (BackCrossWalk == 0)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 1)
                    {
                        MoveFrontRight = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 3)
                    {
                        MoveBackLeft = true;
                    }
                    else
                    {
                        MoveBackRight = true;
                    }
                    BackCrossWalk++;
                }
                else if (BackCrossWalk == 1)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 5)
                    {
                        MoveFrontRight = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 4)
                    {
                        MoveBackLeft = true;
                    }
                    else
                    {
                        MoveBackRight = true;
                    }
                    BackCrossWalk++;
                }
                else if (BackCrossWalk == 2)
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 3)
                    {
                        MoveFrontRight = true;
                    }
                    else if (CrossWalk_3 == 1 || CrossWalk_3 == 2)
                    {
                        MoveBackLeft = true;
                    }
                    else
                    {
                        MoveBackRight = true;
                    }
                    BackCrossWalk++;
                }
                else
                {
                    if (CrossWalk_3 == 0 || CrossWalk_3 == 4)
                    {
                        MoveFrontRight = true;
                    }
                    else if (CrossWalk_3 == 2 || CrossWalk_3 == 5)
                    {
                        MoveBackLeft = true;
                    }
                    else
                    {
                        MoveBackRight = true;
                    }
                    BackCrossWalk = 0;
                }
            }
        }

        else if (collision.gameObject.tag == "DeadEnd")
        {
            if (MoveFrontLeft)
            {
                CommandClear();
                MoveBackRight = true;
            }
            else if (MoveFrontRight)
            {
                CommandClear();
                MoveBackLeft = true;
            }
            else if (MoveBackLeft)
            {
                CommandClear();
                MoveFrontRight = true;
            }
            else if(MoveBackRight)
            {
                CommandClear();
                MoveFrontLeft = true;
            }
            else if (MoveFront)
            {
                CommandClear();
                MoveBack = true;
            }
            else
            {
                CommandClear();
                MoveFront = true;
            }
            MeetDeadEnd = true;
        }

        else if (collision.gameObject.tag == "Goal")
        {
            CommandClear();
            Clear = true;
        }

        if (collision.gameObject.tag == "Trap")
        {
            Food++;
            if (Tool > 0)
            {
                Tool--;
                collision.gameObject.SetActive(false);
            }
            else
            {
                CommandClear();
                if (!Clear)
                {
                    Fail = true;
                }
            }
        }

        if (collision.gameObject.tag == "Tool")
        {
            Food++;
            Tool++;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag=="Monster")
        {
            Food++;
            CommandClear();
            if (!Clear)
            {
                Fail = true;
            }
        }

        if (Food == 0)
        {
            CommandClear();
            if (!Clear)
            {
                Fail = true;
            }
        }
    }
 
    private void CommandClear()
    {
        MoveFront = false;
        MoveFrontLeft = false;
        MoveFrontRight = false;
        MoveBack = false;
        MoveBackLeft = false;
        MoveBackRight = false;
    }
}
