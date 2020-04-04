# 创建和使用脚本

1. 创建一个Scene，并在里面创建一个GameObject。
![](https://ws1.sinaimg.cn/large/005EsThygy1g1h2v9d49aj30940cnq2w.jpg)

2. 编写一个脚本，并作为组件加载到GameObject上。
![](https://ws1.sinaimg.cn/large/005EsThygy1g1h2vhgifgj309d063weq.jpg)

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreateAndUsingScripts {

    public class MainPlayer : MonoBehaviour {

        // Start is called before the first frame update
        private void Start() {
            Debug.Log("I am alive!");
        }

        // Update is called once per frame
        private void Update() {
        }
    }
}
```


3. 最后的文件结构是这样。
![](https://ws1.sinaimg.cn/large/005EsThygy1g1h2ydu1zrj306401rt8k.jpg)

4. 在控制台上看到log输出。
![](https://ws1.sinaimg.cn/large/005EsThygy1g1h2wap0jmj30rp06omx5.jpg)
