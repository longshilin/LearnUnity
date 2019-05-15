using UnityEngine;

public class Test1 : MonoBehaviour
{
    // 成员变量
    public GameObject testItem;
    public GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
        testItem = GameObject.CreatePrimitive(PrimitiveType.Cube);
        testItem.transform.position = new Vector3(1, 1, 1);
        InstantiateObj();
        DestroyObject();
        Example();
    }

 
    // 销毁obj
    private void DestroyObject()
    {
        UnityEngine.Object.Destroy(this.obj);
    }

    // 复制testItem，并返回赋值给obj
    private void InstantiateObj()
    {
        this.obj = UnityEngine.Object.Instantiate(this.testItem) as GameObject;

    }

    void ApplyDamage(float damage)
    {
        print(damage);
    }

    void Example()
    {
        // 调用的目标方法名是ApplyDamage，参数是5.0F
        BroadcastMessage("ApplyDamage", 5.0F);
        
    }

    
    
}
