# Unity API 速查表（W1-W4 学过的全部）

> 每个 API 包含：是什么、干嘛的、参数说明、怎么用（代码示例）、什么时候用、坑。

---

## 一、生命周期（MonoBehaviour 自动调用，不用手动调）

### Awake()
- **是什么**：物体被创建时立刻执行，比 Start 早，所有物体的 Awake 跑完才跑 Start
- **干嘛的**：取组件、初始化引用、单例登记
- **什么时候用**：不依赖别的物体的初始化
- **怎么用**：
```csharp
void Awake()
{
    if (Instance != null) { Destroy(gameObject); return; }
    Instance = this;
    DontDestroyOnLoad(gameObject);
    audioSource = GetComponent<AudioSource>();
}
```
- **坑**：未激活的物体 Awake 不跑

### Start()
- **是什么**：第一帧 Update 之前执行，只一次
- **干嘛的**：需要别的物体 Awake 已完成的初始化、读存档、事件订阅
- **怎么用**：
```csharp
void Start()
{
    hpSlider.value = hp;                          // 刷初始血量
    player.OnHpChanged += RefreshHp;             // 订阅事件
    player = GameObject.FindWithTag("Player").transform;
}
```
- **坑**：物体禁用再激活，Start 不重跑（OnEnable 会）

### Update()
- **是什么**：每帧调用一次，帧率不固定
- **干嘛的**：输入检测、非物理逻辑
- **怎么用**：
```csharp
void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape)) { /* 暂停 */ }
    if (Input.GetKeyDown(KeyCode.K)) animator.SetTrigger("isAttacking");
}
```
- **坑**：移动要乘 Time.deltaTime；GetKeyDown 不能放 FixedUpdate

### FixedUpdate()
- **是什么**：固定步长（默认 0.02s）调用，慢帧会同帧补跑多次
- **干嘛的**：物理操作（刚体速度、加力）
- **怎么用**：
```csharp
void FixedUpdate()
{
    Vector3 v = rb.velocity;
    v.x = Input.GetAxis("Horizontal") * moveSpeed;
    v.z = Input.GetAxis("Vertical") * moveSpeed;
    rb.velocity = v;
}
```
- **坑**：GetKeyDown 放这里会漏按

### LateUpdate()
- **是什么**：所有 Update 跑完后执行
- **干嘛的**：相机跟随（保证角色先动、相机再跟）
- **怎么用**：
```csharp
void LateUpdate()
{
    transform.position = player.position + new Vector3(0, 8, -10);
    transform.LookAt(player.position);
}
```

### OnEnable() / OnDisable()
- **是什么**：物体每次激活/禁用时执行（SetActive 或勾选/取消勾选组件）
- **干嘛的**：随显隐反复订阅/退订
- **怎么用**：
```csharp
void OnEnable() { player.OnHpChanged += RefreshHp; }
void OnDisable() { player.OnHpChanged -= RefreshHp; }
```

### OnDestroy()
- **是什么**：物体被销毁时执行
- **干嘛的**：事件退订、清理
- **怎么用**：
```csharp
void OnDestroy() { boss.OnHpChanged -= RefreshHp; }
```

---

## 二、输入 Input

### Input.GetKey(KeyCode)
- **参数**：`KeyCode.Space`、`KeyCode.W` 等枚举
- **返回**：bool，按住期间每帧 true
- **干嘛的**：持续移动
- **怎么用**：
```csharp
if (Input.GetKey(KeyCode.W)) { /* 按住W，每帧执行 */ }
```

### Input.GetKeyDown(KeyCode)
- **参数**：同上
- **返回**：bool，按下那一帧只 true 一次
- **干嘛的**：跳跃、攻击、暂停（一次性触发）
- **怎么用**：
```csharp
if (Input.GetKeyDown(KeyCode.Space)) { Jump(); }
```
- **坑**：必须放 Update

### Input.GetKeyUp(KeyCode)
- **返回**：bool，松开那一帧 true
- **干嘛的**：蓄力释放

### Input.GetAxis(string axisName)
- **参数**：`"Horizontal"`（A/D、←/→）、`"Vertical"`（W/S、↑/↓）
- **返回**：float，-1~1，键盘有平滑渐变，手柄是模拟量
- **怎么用**：
```csharp
float h = Input.GetAxis("Horizontal");  // 按 D 为 1，A 为 -1
float v = Input.GetAxis("Vertical");
Vector3 v = new Vector3(h, 0, v);
```
- **坑**：轴名在 编辑 → 项目设置 → 输入管理器 里配置

### Input.GetMouseButtonDown(int button)
- **参数**：0=左键，1=右键，2=中键
- **返回**：bool，按下那一帧 true
- **怎么用**：
```csharp
if (Input.GetMouseButtonDown(0)) { Attack(); }
```

---

## 三、Transform（位置/旋转/缩放）

### transform.position
- **是什么**：世界坐标位置（Vector3）
- **怎么用**：
```csharp
Vector3 p = transform.position;
p.x = 0;
transform.position = p;          // 瞬移（刚体也会跟着走）
```
- **坑**：刚体推荐用 rb.position 或 MovePosition

### transform.Translate(Vector3 translation)
- **参数**：移动向量（相对距离，不是目标位置）
- **干嘛的**：不经过物理的简单移动
- **怎么用**：
```csharp
transform.Translate(Vector3.forward * speed * Time.deltaTime);
```
- **坑**：会穿墙

### transform.Rotate(Vector3 eulerAngles, Space relativeTo)
- **参数**：旋转角度（Vector3）、坐标系（Space.Self 局部 / Space.World 世界）
- **怎么用**：
```csharp
transform.Rotate(Vector3.up * 90f * Time.deltaTime, Space.World);  // 金币自转
```
- **坑**：绕世界竖直轴用 Space.World，否则局部轴歪了看不出来

### transform.LookAt(Vector3 target)
- **参数**：目标世界坐标
- **干嘛的**：正 Z 轴朝向目标
- **怎么用**：
```csharp
Vector3 target = player.position;
target.y = transform.position.y;   // 拍平 y，不朝天歪
transform.LookAt(target);
```

### transform.localScale
- **是什么**：缩放（Vector3）
- **怎么用**：
```csharp
transform.localScale = Vector3.Lerp(baseScale, baseScale * 1.15f, p);
```

---

## 四、物理 Rigidbody

### GetComponent<Rigidbody>()
- **返回**：Rigidbody 引用，找不到返回 null
- **怎么用**：
```csharp
private Rigidbody rb;
void Awake() { rb = GetComponent<Rigidbody>(); }
```

### rb.velocity
- **是什么**：刚体速度（Vector3）
- **怎么用**：
```csharp
Vector3 v = rb.velocity;
v.x = moveInput * moveSpeed;
v.z = moveInput * moveSpeed;
// y 保留重力！
rb.velocity = v;
```
- **坑**：不能直接 `rb.velocity.x = ...`，要整体写回

### rb.AddForce(Vector3 force, ForceMode mode)
- **参数**：
  - `force`：力的方向和大小
  - `mode`：`ForceMode.Impulse`（瞬间冲量，适合跳跃）、`ForceMode.Force`（持续力）
- **怎么用**：
```csharp
rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
```
- **坑**：受 Mass 影响，质量大跳不起来

### Rigidbody 检查器参数
- **Mass（质量）**：AddForce 受影响，velocity 不受
- **Use Gravity（使用重力）**：勾上受重力
- **Is Kinematic（运动学）**：勾上不受物理，代码控制位置（触发区域用）
- **Constraints（约束）**：冻结旋转 X/Z 防止摔倒

---

## 五、碰撞与触发

### OnCollisionEnter(Collision other)
- **参数**：`Collision other`，对方信息（other.gameObject 取物体）
- **触发条件**：双方 Collider + 至少一个 Rigidbody + 都不勾 Is Trigger
- **怎么用**：
```csharp
void OnCollisionEnter(Collision other)
{
    if (other.collider.CompareTag("Ground")) isGrounded = true;
}
```

### OnTriggerEnter(Collider other)
- **参数**：`Collider other`，对方碰撞体（other.gameObject 取物体）
- **触发条件**：一方勾 Is Trigger + 至少一个 Rigidbody
- **怎么用**：
```csharp
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        GameManager.Instance.AddScore(1);
        Destroy(gameObject);
    }
}
```

### CompareTag(string tag)
- **参数**：标签名（检查器 Tag 里设置）
- **返回**：bool
- **比 `other.tag == "x"` 好**：tag 为 null 时不报错

### Is Trigger（是触发器）
- **勾上**：不阻挡，物体穿过，只发 OnTrigger 事件
- **不勾**：有物理碰撞，发 OnCollision 事件

---

## 六、射线 Raycast

### Physics.Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
- **参数**：
  - `origin`：射线起点
  - `direction`：射线方向（需归一化）
  - `out hitInfo`：碰到的信息（位置、碰到的物体）
  - `maxDistance`：射线最大长度
- **返回**：bool，碰到了 true
- **怎么用**：
```csharp
float groundDistance = 0.55f;
if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, groundDistance))
{
    isGrounded = true;
}
```

### Debug.DrawRay(Vector3 start, Vector3 dir, Color color)
- **参数**：起点、方向（要乘长度）、颜色
- **干嘛的**：Scene 视图画线辅助调试，不进游戏画面
- **怎么用**：
```csharp
Debug.DrawRay(transform.position, Vector3.down * 0.55f, Color.red);
```

---

## 七、Vector3 向量

### new Vector3(float x, float y, float z)
- **是什么**：装三个 float 的结构体
- **怎么用**：
```csharp
Vector3 pos = new Vector3(0f, 1f, 0f);
```

### Vector3.Distance(Vector3 a, Vector3 b)
- **参数**：两个点
- **返回**：float，直线距离（= (a-b).magnitude）
- **怎么用**：
```csharp
if (Vector3.Distance(player.position, enemy.position) <= attackRange)
    Attack();
```

### Vector3.MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
- **参数**：
  - `current`：当前位置
  - `target`：目标位置
  - `maxDistanceDelta`：这一步最多移动多远（通常 speed × Time.deltaTime）
- **返回**：新位置（不会超过目标）
- **怎么用**：
```csharp
transform.position = Vector3.MoveTowards(
    transform.position, target, speed * Time.deltaTime);
```

### Vector3.Lerp(Vector3 a, Vector3 b, float t)
- **参数**：a 起点、b 终点、t 比例（0=a，1=b）
- **返回**：插值结果
- **怎么用**：
```csharp
transform.localScale = Vector3.Lerp(baseScale, baseScale * 1.15f, t / windupTime);
```

### vector.magnitude
- **是什么**：向量长度 √(x²+y²+z²)
- **怎么用**：
```csharp
float dist = dir.magnitude;
if (dir.magnitude < 5.5f) { /* 太近 */ }
```

### vector.Normalize()
- **是什么**：把向量长度变成 1，方向不变
- **怎么用**：
```csharp
Vector3 dir = (player.position - boss.position);
dir.y = 0;
dir.Normalize();
player.position = boss.position + dir * 5.5f;
```
- **坑**：零向量不能归一化，先判 magnitude < 0.01

### 常用常量
- `Vector3.zero` = (0,0,0)
- `Vector3.forward` = (0,0,1)，`Vector3.back` = (0,0,-1)
- `Vector3.up` = (0,1,0)，`Vector3.down` = (0,-1,0)
- `Vector3.right` = (1,0,0)，`Vector3.left` = (-1,0,0)

---

## 八、组件操作

### GetComponent<T>()
- **是什么**：在自己身上找 T 类型组件
- **返回**：T 引用，找不到 null
- **怎么用**：
```csharp
Slider s = GetComponent<Slider>();
```

### GetComponentInChildren<T>(bool includeInactive)
- **参数**：`includeInactive` 传 true 包含未激活的子物体
- **怎么用**：
```csharp
Text t = GetComponentInChildren<Text>(true);
```

### gameObject.AddComponent<T>()
- **是什么**：动态新建一个 T 组件挂到自己身上（代码版"添加组件"按钮）
- **返回**：新建的组件
- **和 GetComponent 区别**：GetComponent 找已有的，AddComponent 新建
- **怎么用**：
```csharp
bgmSource = gameObject.AddComponent<AudioSource>();
```

### GameObject.FindWithTag(string tag)
- **参数**：标签名
- **返回**：GameObject，找不到 null
- **怎么用**：
```csharp
player = GameObject.FindWithTag("Player").transform;
```
- **坑**：每帧调用耗性能，Start 里找一次存起来

---

## 九、协程 Coroutine

### StartCoroutine(IEnumerator routine)
- **参数**：协程方法调用（方法名+括号）
- **返回**：Coroutine 句柄（存下来可精准停止）
- **怎么用**：
```csharp
private Coroutine spawnRoutine;
spawnRoutine = StartCoroutine(SpawnLoop());
```

### StopCoroutine(Coroutine routine) / StopAllCoroutines()
- **参数**：StartCoroutine 返回的句柄
- **怎么用**：
```csharp
if (attackRoutine != null) { StopCoroutine(attackRoutine); attackRoutine = null; }
```
- **坑**：禁用脚本组件不停协程；SetActive(false)/销毁才停

### IEnumerator 协程方法
- **签名**：`IEnumerator 方法名() { yield return ...; }`
- **需要**：`using System.Collections;`
- **怎么用**：
```csharp
IEnumerator AttackRoutine()
{
    state = State.Attack;
    yield return new WaitForSeconds(0.7f);   // 前摇
    DamagePlayer();
    yield return new WaitForSeconds(0.9f);   // 后摇
    state = State.Chase;
}
```

### yield return null
- **等**：下一帧 Update 之后
- **用途**：逐帧动画
```csharp
float t = 0;
while (t < 1f) { t += Time.deltaTime; yield return null; }
```

### yield return new WaitForSeconds(float seconds)
- **参数**：等几秒（受 timeScale 影响）
- **用途**：倒计时、Boss 登场

### yield return new WaitForFixedUpdate()
- **等**：下一次 FixedUpdate 之后

### yield return new WaitForEndOfFrame()
- **等**：本帧渲染结束（最末尾）

### 协程原理
- 不是多线程，和 Update 在同一主线程
- yield return 交还控制权，Unity 每帧轮询所有协程的等待条件
- 状态切换时要想"还有谁在跑、醒来会不会覆盖我"

---

## 十、场景管理

### SceneManager.LoadScene(string sceneName)
- **参数**：场景名（Build Settings 里必须有）
- **干嘛的**：同步加载（会卡一帧）
- **怎么用**：
```csharp
SceneManager.LoadScene("MiniLevel");
```
- 重载自己：`SceneManager.LoadScene(SceneManager.GetActiveScene().name);`

### SceneManager.LoadSceneAsync(string sceneName)
- **参数**：场景名
- **返回**：AsyncOperation
- **属性**：
  - `progress`：0~0.9（0.9 是等待放行）
  - `allowSceneActivation`：false 扣住不切换
- **怎么用**：
```csharp
AsyncOperation op = SceneManager.LoadSceneAsync("MiniLevel");
op.allowSceneActivation = false;
while (op.progress < 0.9f) {
    slider.value = op.progress / 0.9f;
    yield return null;
}
op.allowSceneActivation = true;
```

### SceneManager.GetActiveScene()
- **返回**：当前场景对象，`.name` 取名字

### DontDestroyOnLoad(Object target)
- **参数**：切场景时保留的物体
- **怎么用**：
```csharp
DontDestroyOnLoad(gameObject);
```
- **坑**：切回主菜单会出现第二个，Awake 必须判重

---

## 十一、UI（UGUI）

### Button.onClick.AddListener(UnityAction call)
- **参数**：无参数方法
- **怎么用**：
```csharp
using UnityEngine.UI;
startButton.onClick.AddListener(OnStartClick);
void OnStartClick() { SceneManager.LoadScene("MiniLevel"); }
```

### Slider
- **属性**：
  - `value`：当前值
  - `minValue` / `maxValue`：量程（maxValue 默认 1！）
  - `onValueChanged`：值变化事件，带 float 参数
- **怎么用**：
```csharp
hpSlider.maxValue = maxHp;
hpSlider.value = hp;
volumeSlider.onValueChanged.AddListener(OnVolumeSlider);
void OnVolumeSlider(float value) { AudioListener.volume = value; }
```

### Toggle
- **属性**：
  - `isOn`：bool，当前开/关
  - `onValueChanged`：状态变化事件，带 bool 参数
- **怎么用**：
```csharp
musicToggle.isOn = SaveManager.LoadMusicOn();
musicToggle.onValueChanged.AddListener(OnMusicToggle);
void OnMusicToggle(bool isOn) { AudioManager.Instance.SetMusicOn(isOn); }
```

### Text.text
- **属性**：字符串
- **怎么用**：
```csharp
resultText.text = "胜利！\n分数：" + score;
```

### GameObject.SetActive(bool value)
- **参数**：true 显示，false 隐藏
- **怎么用**：
```csharp
pausePanel.SetActive(true);
```
- **坑**：隐藏的物体 Start 不跑；`activeSelf` 查自己是否激活

---

## 十二、动画 Animator

### Animator.SetBool(string name, bool value)
- **参数**：参数名（要和 Animator 窗口里一致）、bool
- **怎么用**：
```csharp
animator.SetBool("isMoving", isMoving);
animator.SetBool("isJumping", !isGrounded);
```

### Animator.SetTrigger(string name)
- **参数**：Trigger 参数名
- **干嘛的**：瞬时触发，消费后自动重置（不用手动设回 false）
- **怎么用**：
```csharp
animator.SetTrigger("isAttacking");
```

### Animator.SetFloat(string name, float value)
- **参数**：参数名、float
- **干嘛的**：混合树根据速度播动画

### 过渡线配置（检查器）
- **Has Exit Time（有退出时间）**：勾=等当前动画播完；取消=条件满足立刻切
- **Transition Duration（过渡持续时间）**：两动画混合时间，0=硬切
- **Conditions（条件）**：过渡触发条件（参数名+类型+值）
- **Any State**：从任何状态都能切过来（适合"随时能攻击"）

---

## 十三、音频 Audio

### AudioSource.PlayOneShot(AudioClip clip)
- **参数**：要播的音效
- **特点**：临时播，可叠加多个，不需要 source.clip
- **怎么用**：
```csharp
audioSource.PlayOneShot(coinClip);
```

### AudioSource.Play()
- **是什么**：播 source.clip 存的那首
- **怎么用**：
```csharp
bgmSource.clip = bgmClip;
bgmSource.loop = true;
bgmSource.Play();
```

### AudioSource 属性
- `clip`（AudioClip）：要播的音频
- `loop`（bool）：是否循环
- `mute`（bool）：true 静音
- `volume`（float）：0~1
- `playOnAwake`（bool）：唤醒时自动播

### AudioListener.volume
- **是什么**：全局音量（static，0~1）
- **怎么用**：
```csharp
AudioListener.volume = 0.5f;
```
- **坑**：Inspector 看不到，是 static

### 双 AudioSource 架构
```csharp
// 音效喇叭：编辑器挂好，PlayOneShot
audioSource = GetComponent<AudioSource>();
// BGM 喇叭：代码新建，loop
bgmSource = gameObject.AddComponent<AudioSource>();
bgmSource.clip = bgmClip;
bgmSource.loop = true;
bgmSource.volume = 0.3f;
bgmSource.Play();
```

---

## 十四、存档 PlayerPrefs + JSON

### PlayerPrefs.SetInt(string key, int value) / GetInt(string key, int defaultValue)
- **参数**：key 键名、value 值、GetInt 第二参数是键不存在时的默认值
- **怎么用**：
```csharp
PlayerPrefs.SetInt("HighScore", 100);
int high = PlayerPrefs.GetInt("HighScore", 0);
PlayerPrefs.SetInt("MusicOn", isOn ? 1 : 0);  // 用 int 存 bool
bool on = PlayerPrefs.GetInt("MusicOn", 1) == 1;
```

### PlayerPrefs.SetFloat / GetFloat
- **怎么用**：
```csharp
PlayerPrefs.SetFloat("Volume", 0.8f);
float v = PlayerPrefs.GetFloat("Volume", 1f);
```

### PlayerPrefs.SetString / GetString
- **怎么用**：
```csharp
PlayerPrefs.SetString("SaveData", json);
string json = PlayerPrefs.GetString("SaveData", "");
```

### PlayerPrefs.HasKey(string key)
- **返回**：bool，键存不存在
- **怎么用**：
```csharp
if (PlayerPrefs.HasKey("SaveData")) { /* 读档 */ }
```

### PlayerPrefs.Save()
- **干嘛的**：强制写入硬盘（SetInt 等默认在内存，退出时自动写）

### PlayerPrefs.DeleteKey(string key) / DeleteAll()
- **怎么用**：
```csharp
PlayerPrefs.DeleteKey("SaveData");
PlayerPrefs.DeleteAll();
```

### JsonUtility.ToJson(object obj)
- **参数**：可序列化对象（类要 `[Serializable]`，只打包 public 字段）
- **返回**：JSON 字符串
- **怎么用**：
```csharp
SaveData d = new SaveData();
d.highScore = 100;
string json = JsonUtility.ToJson(d);
```

### JsonUtility.FromJson<T>(string json)
- **参数**：JSON 字符串
- **返回**：T 类型新对象
- **怎么用**：
```csharp
SaveData d = JsonUtility.FromJson<SaveData>(json);
```
- **坑**：不支持 Dictionary、属性

---

## 十五、其他常用

### Time.deltaTime
- **是什么**：上一帧到这一帧的时间（秒）
- **用途**：Update 里乘它保证帧率无关
```csharp
transform.Translate(Vector3.forward * speed * Time.deltaTime);
```

### Time.fixedDeltaTime
- **是什么**：FixedUpdate 的固定时间步长（默认 0.02）

### Time.timeScale
- **是什么**：时间缩放（0=暂停，1=正常，0.5=慢动作）
- **怎么用**：
```csharp
Time.timeScale = 0;   // 暂停
Time.timeScale = 1;   // 恢复
```
- **坑**：粘性，切场景不重置；UI 点击不受影响

### Random.Range(int min, int max)
- **参数**：min、max（int 版含 min **不含** max；float 版都含）
- **怎么用**：
```csharp
float x = Random.Range(-4f, 4f);
int n = Random.Range(0, 5);   // 0~4
```

### Instantiate(Object original, Vector3 position, Quaternion rotation)
- **参数**：预制体、位置、旋转
- **返回**：生成的物体
- **怎么用**：
```csharp
GameObject go = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
```
- **坑**：用变量接住返回值才能操作

### Destroy(Object obj)
- **参数**：要销毁的物体/组件
- **怎么用**：
```csharp
Destroy(gameObject);
```

### Debug.Log(object message)
- **参数**：打印内容
- **怎么用**：
```csharp
Debug.Log("当前分数：" + score);
```
- **坑**：每帧打印会刷爆控制台

### Application.Quit()
- **干嘛的**：退出游戏（编辑器无效，打包后生效）

### ?. 空条件运算符
- **等价**：`if (a != null) a.Method()`
- **怎么用**：
```csharp
AudioManager.Instance?.PlayHit();   // Instance 为 null 不报错
```

---

## 十六、高频固定模式

### 单例三件套
```csharp
public static AudioManager Instance;
void Awake()
{
    if (Instance != null) { Destroy(gameObject); return; }
    Instance = this;
    DontDestroyOnLoad(gameObject);
}
```

### 事件订阅三件套
```csharp
void Start() { player.OnHpChanged += RefreshHp; }
void RefreshHp(int hp) { hpSlider.value = hp; }
void OnDestroy() { player.OnHpChanged -= RefreshHp; }
```

### 状态机 FSM
```csharp
enum EnemyState { Patrol, Chase, Attack }
EnemyState state = EnemyState.Patrol;
void Update()
{
    // 先按条件切状态
    if (dist <= 1.5f) state = EnemyState.Attack;
    else if (dist <= 5f) state = EnemyState.Chase;
    else state = EnemyState.Patrol;
    // 再分发
    switch (state)
    {
        case EnemyState.Patrol: PatrolBehavior(); break;
        case EnemyState.Chase: ChaseBehavior(); break;
        case EnemyState.Attack: AttackBehavior(); break;
    }
}
```

### 冷却计时器
```csharp
float attackTimer = 0f;
void Update()
{
    attackTimer -= Time.deltaTime;
    if (attackTimer <= 0f && Input.GetKeyDown(KeyCode.J))
    {
        CastSkill();
        attackTimer = 3f;   // 3 秒 CD
    }
}
```

### 协程逐帧动画模板
```csharp
IEnumerator ScaleOver(Transform t, Vector3 from, Vector3 to, float duration)
{
    float timer = 0f;
    while (timer < duration)
    {
        timer += Time.deltaTime;
        float p = timer / duration;
        t.localScale = Vector3.Lerp(from, to, p);
        yield return null;
    }
}
```

### 读存档设 UI 初始值
```csharp
void Start()
{
    volumeSlider.value = AudioListener.volume = SaveManager.LoadVolume();
    musicToggle.isOn = SaveManager.LoadMusicOn();
}
```

---

> 持续更新，学到新 API 就往里加。
