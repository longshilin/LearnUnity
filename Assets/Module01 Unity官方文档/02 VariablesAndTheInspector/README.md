# 变量和检查员

1. 创建一个Scene，并在里面创建一个GameObject。
![](https://ws1.sinaimg.cn/large/005EsThygy1g1h2v9d49aj30940cnq2w.jpg)

2. 编写一个脚本，并作为组件加载到GameObject上。
![](https://ws1.sinaimg.cn/large/005EsThygy1g1h3u9mfykj309d06hwer.jpg)

`MainPlayer`
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VariablesAndTheInspector {

    public class MainPlayer : MonoBehaviour {
        public string myName;

        // Start is called before the first frame update
        private void Start() {
            Debug.Log("I am alive and my name is " + myName);
        }

        // Update is called once per frame
        private void Update() {
        }
    }
}
```


3. 最后的文件结构是这样。
![](https://ws1.sinaimg.cn/large/005EsThygy1g1h3t6y3alj306y01qt8k.jpg)

4. 在控制台上看到log输出。
![](https://ws1.sinaimg.cn/large/005EsThygy1g1h3shxc1aj30rp06oaa2.jpg)

