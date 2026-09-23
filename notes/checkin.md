# 学习打卡表

| 日期 | Day | 完成度 | 卡点 | 明日重点 |
|------|-----|--------|------|----------|
| 2026-09-03 | D1 | ✅ 完成 | 无 | Unity安装 + 第一个场景 |
| 2026-09-04 | D2 | ✅ 完成 | 无 | 简历骨架 + 打卡表 + 仓库整理 |
| 2026-09-05 | D3 | ✅ 完成 | 无 | 启动周收尾，进入正式学习周期 |
| 2026-09-06 | D4 | ✅ 完成 | 无 | C#流程控制 + Unity物理/碰撞入门 |
| 2026-09-08 | D5 | ✅ 完成 | 无 | C#数组与方法 + Unity预制体/脚本通信 |
| 2026-09-09 | D6 | ✅ 完成 | 冒泡边界/值类型交换（已解决） | D7周复盘 + 本周知识录屏回顾 |
| 2026-09-10 | D7 | ✅ 完成 | 被球撞到无法跳跃(用Tag区分地面解决) | D8：C#面向对象-类与对象入门 |
| 2026-09-11 | D8 | ✅ 完成 | 下午Unity突发Safe Mode编译崩溃(Internal build system error)，靠删Library/Temp/obj缓存+重启解决，非代码问题 | D9 学继承 |
| 2026-09-12 | D9 | ✅ 完成 | ①Unity编译工具BeeLocalCacheTool被系统策略拦截→右键TuanjieHub管理员身份运行解决；②平滑移动加速度=10时被地面静摩擦卡住、速度攒不起来→调到15能跑；③每帧Debug.Log把Console刷成999+、淹没扣血日志→删掉每帧打印只留DrawRay | 多态 + Unity触发器/吃金币 |
| 2026-09-13 | D10 | ✅ 完成 | 智能应用控制拦截编译dll（关闭SAC解决）；UI文字曾因文本框太小/锚点不对不显示；金币绕对称轴自转看不出（改Space.World） | C#接口Interact + Unity接口实现 |
| 2026-09-14 | D11 | ✅ 完成 | Unity能看懂但独立写还不熟、一个Text被两个字段抢占覆盖、if误写在方法外 | 封装/继承/多态/接口四件套整合成角色系统 |
| 2026-09-15 | D12 | ✅ 完成 | 无 |C#查缺补漏（静态/枚举/命名空间）+Unity可玩小关 |
| 2026-09-16 | D13 | ✅ 完成 | 单例刚开始有点绕； | D14 周复盘+闭卷自测 |
| 2026-09-17 | D14 | ✅ 完成 | static 和访问修饰符混淆；单例一开始看不懂后搞懂 | D15 委托 delegate |
| 2026-09-19 | D15 | ✅ 完成 | 委托/事件一开始理解困难，用"通知群"类比后打通，Unity事件订阅已能脱稿 | Lambda 表达式 + List 泛型集合 + Unity 批量生成管理 |
| 2026-09-21 | D16 | ✅ 完成（9/22补收尾） | GetComponent漏写物体前缀导致只生成1个；边遍历边删集合；List该装物体还是组件 | Dictionary字典 + Animator动画入门 |
| 2026-09-23 | D17 | ✅ 完成 | Animator与旧Animation组件混淆、时间轴秒:帧、float配置传int需强转 | D18（按新计划图） |

## D1 回顾（9/3 周四）
- 环境搭建：Git、.NET SDK、VS Code 全套安装完成
- GitHub 仓库 `game-ai-demos` 创建，本地克隆成功
- C# 控制台 HelloWorld 编写并运行成功
- 首次 Git add → commit → push 全流程跑通

## D2 回顾（9/4 周五）
- Unity 安装完成，创建第一个场景 `FristScene`
- 编写 `PlayerMove.cs` 角色移动脚本（WASD 控制方向）
- 掌握 `Input.GetAxis`、`transform.Translate`、`Time.deltaTime` 基础用法

## D3 完成（9/5 周六）
- BOSS直聘简历搭建，求职方向锁定 U3D 游戏开发
- 教育经历、项目经历、专业技能、自我评价全部填写
- 建立打卡表 notes/checkin.md
- 整理仓库结构，更新 README
- 学习 Unity 核心概念：GameObject、Component、Transform

## D4 完成（9/6 周日）

- C# 基础：变量声明/赋值、6种数据类型（int/float/double/bool/string/char）
- 运算符：算术（+ - * / %）、比较（== != > <）、逻辑（&& || !）
- 控制台输入输出：Console.ReadLine() + int.Parse() 实现键盘交互
- 综合练习：输入两数计算和差积商余、判断奇偶、摄氏转华氏
- Unity Transform 实操：代码设置 position、Translate() 匀速移动
- Rotate() 绕轴旋转、WASD 键盘控制物体位移
- 新建 DailyPractice 目录管理每日练习，Git 提交推送

## D5 完成（9/8 周二）

- C# 条件：if/else if/else 多分支、switch 固定值匹配、三元运算符 `条件?a:b`
- C# 循环：for（定次数）、while（看条件）、do-while（至少一次）、break/continue
- 嵌套循环：外层管行内层管列，写出九九乘法表与星号三角形
- 两个套路：累加器(sum=sum+i)求和、计数器(count++)数个数
- 综合实战：密码登录（最多3次），用 bool 标志位区分"成功/次数用完"
- Unity 物理：认识 Rigidbody 刚体与 Collider 碰撞体分工
- 刚体参数：Mass、Use Gravity、Is Kinematic、Constraints 冻结旋转X/Z
- velocity 物理移动：GetComponent取刚体、FixedUpdate写物理、保留rb.velocity.y
- AddForce(ForceMode.Impulse) + GetKeyDown 实现物理跳跃
- OnCollisionEnter/Exit + isGrounded 做落地检测，杜绝空中连跳
- 斜坡/台阶/边缘测试：摩擦决定滑动、碰撞阻挡不穿透、悬空会坠落
- 晚间练习：猜数字游戏（Random.Next(1,101) + while + if + 计数器）

## D6 完成（9/9 周三）

- C#数组：三种声明、下标从0/Length、for与foreach遍历、用户输入存数组、string.Join打印
- C#方法：参数/返回值/return提前退出与卫语句、方法间互相复用；理解值类型传参是副本
- 冒泡排序：相邻比较交换、双层for（外层Length-1轮、内层Length-1-i），亲手写通
- 独立写出 Max(int[]) 打擂台求最大值（初始用arr[0]而非0，避免全负出错）
- Unity预制体Prefab：物体拖入Project存成模板、public槽拖拽赋值、忘拖会空引用
- Instantiate生成物体、用变量接住返回值、for循环批量生成一排
- Input.GetAxis平滑输入(-1~1)替代4个if，Debug.Log输出到Console
- 综合成品：按空格Instantiate小球+刚体velocity，做出"发射器"

## D7 完成（9/10 周四）第1周复盘日
- 上午：把D4-D6的C#整理成系统笔记 notes/CSharp_Basics.md（变量运算/流程控制/数组/方法/算法五大块+16条避坑清单），每个知识点亲手写例子并逐块批改
- 查漏补缺：纠正 for里i与arr[i]混淆、Console.ReadLine漏前缀、string.Join把逗号写成+导致CS0121等问题；独立默写出冒泡排序
- 下午：跑通本周Unity三功能（WASD刚体移动 / 空格跳跃 / J键发射）；整理脚本——禁用AxisMove只留PlayerPhysicsMove，发射键由空格改J避免和跳跃冲突
- 修复bug：玩家被自己发射的球撞到后不能跳——根因是碰撞检测没区分对象，用 CompareTag("Ground") 只认地面解决
- 第一周成果录屏存档（手机拍屏，移动+跳跃+发射）
- 晚上：写第1周周总结 notes/week1.md，规划第2周面向对象主线
- git：提交并推送 CSharp_Basics、week1、脚本改动到 GitHub

## D8 完成（9/11 周五）

- 🌞 上午 C# 面向对象入门：类=图纸/对象=实物/new=造对象；字段、构造函数(同名无返回类型、new时自动执行)、this 区分同名字段与参数；对象可以当参数传，实现两个对象互相攻击。
- 🌤 下午 Unity 碰撞：OnCollisionEnter 在接触那一帧自动执行一次；碰撞三条件(双方Collider+至少一个Rigidbody+都不勾IsTrigger)；用 Tag + CompareTag("Trap") 区分机关；实现碰红方块掉血并打印剩余血量；体会刚体 Mass/Drag——velocity 不吃质量阻力、AddForce 吃(质量×10跳不起来)。
- 🌙 晚上：第一次脱稿独立写出 Enemy 类 + while 回合制对打，掌握"先手打完立刻判死亡再break"，不让尸体反击；踩了 private 默认访问、死亡顺序两个坑并自己改对。
- 🛠 排错：Unity Safe Mode / Internal build system error 排查全过程(看有无CS错误→删缓存→空项目测试→重启)，确认是环境不是代码，项目没丢。
- 📌 明日(D9)重点：学继承；早上先做 ≤10 分钟复现——脱稿写一个"字段+构造函数(this)+方法"的类，并 new 两个对象调用。

## D9 完成（9/12 周六）
- C# 继承：`class 子类:父类` 子类白捡父类字段和方法，构造函数不继承；`:base(参数)` 把参数转交父类构造，`base.方法()` 可调父类原版
- 方法重写：父类 `virtual`、子类 `override` 成对出现，签名（方法名/参数/返回类型）必须一致、方法体自由；分清完全替换（删base）与扩展增强（留base再追加）
- 访问修饰符：对比 `public`/`protected`/`private` 可见范围，字段用 `protected` 做封装（本类+子类可见、类外不可见），外部只能通过 public 方法间接改
- 上午练习：Character 父类（protected字段+构造+TakeDamage/Attack+virtual Move）+ Player/Enemy 子类（base构造+各自override Move）
- Unity 射线地面检测：`Physics.Raycast(起点,方向,长度)` 每帧从脚下向下探测，取代 OnCollisionEnter/Exit，落地才返回true、空中false，实现落地能跳、空中不连跳
- `Debug.DrawRay(起点,方向*长度,颜色)` 在 Scene 视图画红线辅助调试、不进Console；每帧的 `Debug.Log` 会刷成999+还会淹没别的日志，看明白就删、只留画线
- 平滑移动：先算目标速度（水平按键决定、y保持`rb.velocity.y`），再用 `Mathf.MoveTowards(当前,目标,每步最大变化)` 让 x/z 逐帧逼近目标，产生加速起步/滑行减速手感
- Unity 固定套路：改刚体速度要先拷进临时变量 `v`、改完再 `rb.velocity=v` 整体写回，不能直接 `rb.velocity.x=...`；只平滑水平 x/z，竖直 y 不动以免破坏重力跳跃
- 每帧最大变化量 `= 加速度 * Time.fixedDeltaTime`，保证不同帧率手感一致
- 理解 Vector3 本质：就是装 x/y/z 三个 float 的盒子，位置、速度、方向、旋转、力都用它，含义看存在哪个属性里
- 踩坑：加速度太小每帧增量被静摩擦抵消、看着像不动，调大到15能跑；最终手感参数 MoveSpeed=8、MoveAcceleration=15、JumpForce=5、GroundDistance=0.55
- 晚上多态练习（独立默写）：Animal 父类 virtual Speak + Dog/Cat override Speak；父类变量能装子类对象，调虚方法以 `new` 出来的真实对象为准执行对应版本
- 多态用法：父类数组 `Animal[]` 混装 Dog/Cat，`foreach` 里一句 `a.Speak()` 各叫各的，新增子类只要override+塞进数组、循环不用改（对扩展开放）
- 认识 C#12 主构造函数简写 `class Dog(string name):Animal(name){}`，等价于完整版构造+base，现阶段仍写完整版打基础
- 环境排错：团结引擎报 Win32Exception / BeeLocalCacheTool 被"应用程序控制策略"拦截（即昨天 -532462766 根因），右键 TuanjieHub 以管理员身份运行解决，并在 属性→兼容性 勾"以管理员身份运行此程序"一劳永逸
- Git：提交推送 Day9_Practice、Day9_Animal、FristScene 脚本改动、StudyNotes 与 checkin

## D10 完成（9/13 周日）

- 多态调用规则：声明类型（左边）决定能不能点出成员，实际类型（new 的是谁）决定虚方法执行哪个版本，口诀"能不能调看左边，执行谁看new"
- 抽象类：`abstract class` + 抽象方法 `public abstract void Speak();`（无方法体、分号结尾），抽象类不能 `new`，子类必须 `override` 全部抽象方法；普通字段/构造/普通方法仍可写
- virtual 与 abstract 区别：virtual 有默认实现、子类可选重写；abstract 无实现、子类必须重写、类必须加 abstract
- 类型判断：`if(s is Circle c)` 判断并转换一步到位（推荐），`as` 失败返回 null 要判空，直接强转失败会崩；通用行为靠多态、子类特有行为才用 is/as
- List<T> 集合：要 `using System.Collections.Generic;`，`Add` 加元素、`Count` 取个数（数组是 Length）、`foreach` 遍历、`{ }` 集合初始化器、`list[下标]` 取单个；长度可变
- 抽象类动态创建：不能 `new 抽象类自己`，但子类可无限 new，运行时按输入的种类用 if/switch 决定 new 哪个子类、父类引用接住再 Add（刷怪雏形）
- Unity 触发器：Collider 勾 `Is Trigger` 变触发器，物体穿过不阻挡、只发事件；触发三条件=双方都有Collider+一方勾Is Trigger+至少一个刚体
- Collider vs Trigger（面试高频）：碰撞体不勾、有物理碰撞、用 `OnCollisionEnter`；触发器勾上、无碰撞只触发、用 `OnTriggerEnter(Collider other)`
- 吃金币：玩家 Tag 设 `Player`，金币挂 Coin 脚本，`OnTriggerEnter` 里 `other.CompareTag("Player")` 命中则 `static int score` 加一并 `Destroy(gameObject)` 销毁金币；static 让所有金币共用一份分数
- UI 分数：右键 UI→旧版→文本 Text，自动建 Canvas/EventSystem；锚点定左上角、文本框宽高要大于字号、溢出设 Overflow；ScoreUI 脚本 `using UnityEngine.UI`、`GetComponent<Text>()`、每帧 `scoreText.text = "分数：" + Coin.score` 刷新
- 组件认知：组件是装着属性和方法的对象，Inspector 每一栏对应代码里一个属性，`组件.属性=值` 等于运行时改面板；改屏幕文字用 `Text组件.text`
- 金币旋转：物体被手动旋转后局部轴会歪，`transform.Rotate(..., Space.World)` 绕世界竖直轴转才明显，纯色圆盘绕中心对称轴自转肉眼看不出
- 环境排错：Win11 智能应用控制（SAC）拦截无签名的本地编译 dll（0x800711C7），不认 Defender 白名单、管理员也绕不过，开发机在"应用和浏览器控制"里关闭 SAC 并重启解决
- 命名规范：类名/方法名/属性名用大驼峰 PascalCase（Attack、Speak），变量/参数用小驼峰 camelCase（playerName、循环变量 dog 而非单字母）

## D11 完成（9/14 周一）

- 学会接口 `interface`：方法只有签名以分号结尾、不写 public、不能有字段和构造函数，类用冒号实现、一个类可实现多个接口
- 理解接口多态：接口也是类型，可用 `接口[]` / `List<接口>` 装不同对象并 `foreach` 统一调用
- 梳理接口 vs 抽象类：接口是 can-do（能做什么）、可多实现；抽象类是 is-a（是什么）、只能单继承（面试高频）
- 控制台项目 `Day11_Interface`、`Day11_InterfaceDrill`、`Day11_Interact`：实现 `IMovable`/`IDamageable`/`IInteractable`，并学会接口方法带 `bool` 返回值、调用方用变量接住判断
- Unity 新建 `IMovable.cs`、`IDamageable.cs`（纯接口不继承 `MonoBehaviour`、不是组件不能挂物体）
- `PlayerPhysicsMove` 实现 `IMovable`，水平移动封进 `Move()`，`FixedUpdate` 里调用
- `PlayerHealth` 实现 `IDamageable`，掉血封进 `TakeDamage(int)`，`hp` 用普通 public 字段不用 static
- 新增木箱 `BoxHealth`（耐久归零 `Destroy`）和炸弹 `Bomb`
- `Bomb` 用 `List<IDamageable>` 配合 `OnTriggerEnter/Exit` 维护范围内名单，按 K 用 `foreach` 统一 `TakeDamage`，一颗炸弹同时让玩家掉血、木箱碎裂，体会接口解耦
- 弄清模型 `Scale`（视觉大小）与碰撞体 `Radius`（判定范围）相互独立；固定触发区域挂刚体并勾 `Is Kinematic` 才能检测无刚体对象
- 用 `public PlayerHealth player;` 在 Inspector 拖引用做血量 UI（`HpUI`），区分 static（全局唯一总分）与拖引用（具体物体的数据）
- 踩坑：一个物体只有一个某类型组件，两个字段都 `GetComponent<Text>()` 会指向同一文本框互相覆盖，多行 UI 要建多个 Text 物体

## D12 完成（9/15 周二）
- 封装：`private` 字段 + `public` 只读属性（只有 `get`），掉血只能走 `TakeDamage` 受控修改
- 接口：`IDamageable` 只有 `TakeDamage` 签名，`Character` 实现，子类靠继承白捡
- 继承多态：`Character` 基类 + `Player/Enemy/Boss` 子类，`virtual/override` 不同攻击力，父类引用必须 `new` 具体子类
- 回合对战：`while(true)` 轮流攻击，攻击后立刻判 `Hp<=0` 用 `break` 结束，防止死人还手
- 简单工厂：`CharacterFactory.Create(类型)` 返回父类 `Character`，内部按字符串 new 子类，调用处先接结果再判 `!= null`
- Unity 单一职责：`PlayerPhysicsMove` 管移动跳跃、`PlayerHealth` 管血量、UI 管显示，组件独立协作
- UI 改事件触发：删掉 `Update` 轮询，掉血时调 `RefreshHp(hp)`、吃金币时调 `ReportScore(score)`，`Start` 里先刷一次初始值
- 易错点：文件名=类名；`using` 不手滑选错；工厂判空判创建结果而不是输入字符串

## D13 完成（9/16 周三）
- 上午查漏：`static` 静态成员、`private set` 自动属性、计算属性 `IsDead`、`enum` 游戏状态机、`namespace`
- 下午：空场景脱稿重建刚体移动+触发检测；`CameraFollow` 摄像机跟随（`LateUpdate`/`LookAt`）；`GameManager` 单例（`static Instance`/`Awake`/`DontDestroyOnLoad`）；`enum GameState` + 卫语句实现胜利锁操作；整合成可玩小关并手机录屏

## D14 完成（9/17 周四）

- 闭卷脱稿写出 `Character`/`Player`/`Enemy`/`IDamageable` 回合制对战（Day14_Exam），一次跑通
- 换皮练习：static 计数、enum + switch 敌人状态机、单例 `SaveSystem`/`AudioManager`（私有构造 + 静态 Instance）
- 搞懂单例"锁门、存独苗、开窗口"，以及控制台版与 Unity `GameManager`（Awake 注册）的区别
- MiniLevel 通关录屏存档；更新 README、写完 week2.md，W2 收官

## D15 完成（9/19 周六）

- 委托与事件：`delegate`、多播 `+=/-=`、`event` 访问保护、`Action`/`Action<int>`/`Func<T,T,TResult>`、`?.Invoke()`
- Unity 事件驱动：`GameManager` 金币事件 + `CollectCoin` 中继方法，`ScoreUI`/`CoinSound` 订阅，`OnDestroy` 退订
- 脱稿练习：`Day15_Quit` 按 Q 退出三系统响应、`Day15_Func` 武器伤害公式插槽

## D16 完成（9/21 周一，9/22 补收尾）

- Lambda 四种形态（单参省括号、零参/多参带括号、多行加大括号并 return），配合 `Func`/`Action`
- `List<T>` 动态数组：`Add`/`Remove`/`RemoveAt`/`RemoveAll`/`Contains`/`Count`/初始化器/`foreach`
- 查找四件套：`Contains`、`Exists` 返回 bool，`Find` 返单个（找不到 null），`FindAll` 返新列表；`Sort` 升序 `a-b`、降序 `b-a`，原地排序
- Unity 生成器模式：`Instantiate` → `obj.GetComponent<T>()` → 回填 `spawner` → 列表登记
- `List<GameObject>` 管理 10 枚金币；`List<Enemy>` 管理 5 个敌人波次，全灭 `Count==0` 调 `WinGame()`
- 群体技能按 K：`FindAll` 出副本再 `foreach` 调 `Die()`，避免边遍历边修改原列表
- 踩坑：GetComponent 漏前缀在自己身上找组件返回 null、场景残留旧金币、`this`（组件）与 `gameObject`（柜子）的区别、类体里不能写执行语句

# D17 完成（9/23 周三）
- `Dictionary<K,V>` 增删查改、TryGetValue 兜底、背包堆叠计数器、值类型复印件
- Unity Animator：Idle/Move/Jump 三片段、状态机四根过渡线、`SetBool` 随移动/跳跃切换、胜利复位
- 静态类 `GameConfig` 配置表查表（控制台+Unity），理解序列化覆盖与静态类/单例区别
- 加深：`Dictionary<string,Action>` 按键映射（命令模式雏形）