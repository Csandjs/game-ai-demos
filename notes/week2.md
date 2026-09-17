# 第2周学习总结（D8 ~ D14）

## 一、本周主题总览

| Day | 主题 | 主要产出 |
|---|---|---|
| D8 | 面向对象入门 + 碰撞事件 | 类/对象/构造函数/this；Player 类互相攻击；OnCollisionEnter 踩机关掉血 |
| D9 | C#继承 + Unity 移动跳跃 | base/virtual/override/protected；Character 基类 + Player/Enemy；射线地面检测防空跳 |
| D10 | 多态 + 触发器吃金币 | 多态三要素、List<Character> 统一调用；Trigger 吃金币 + Destroy + Canvas 分数 UI |
| D11 | 接口 + 本周整合 | interface 能力契约、IDamageable/IInteractable；炸弹 List<IDamageable> 范围伤害 |
| D12 | 面向对象大综合 | 四件套角色系统 + 回合制对战；PlayerController/Health 组件化；CharacterFactory 工厂 |
| D13 | 查漏补缺 + 可玩小关 | static/enum/namespace/属性深入；GameManager 单例；MiniLevel 完整通关 + 胜利锁操作 |
| D14 | W2 复盘 + 闭卷自测 | 脱稿四件套角色系统；static/enum/单例换皮练习；MiniLevel 录屏；README/周总结整理 |

## 二、本周核心知识

### C#

- 类与对象：class 是图纸、new 出实例；字段/属性/方法；构造函数初始化对象；this 指当前对象
- 封装：private 字段 + public 属性（get/set、get; private set; 只读、计算属性如 IsDead），外部不能乱改数据
- 继承：`class 子类 : 父类` 自动拥有父类成员；base(...) 调父类构造；protected 父子可见、外部不可见
- 多态：virtual/override 成对出现；父类引用指向子类对象（Character p = new Player()），同一方法名不同表现
- 接口：interface 只写方法签名不写实现，是"能力契约"；一个类可实现多个接口；List<接口> 统一调用一批对象
- 静态成员：static 字段/属性/方法属于类、所有对象共享一份；静态方法只能直接访问静态成员
- 两个维度：static 管"属于类还是对象"，public/private 管"谁能访问"，互不替代
- 枚举 enum：给一组状态起名字（默认从 0 编号，(int) 强转可看底层数字），配 switch 写状态机
- 命名空间 namespace：组织代码、避免重名（了解）
- 设计模式：工厂（传字符串返回对应角色对象，多态+封装的综合）、单例（全局唯一对象）
- List<T> 泛型集合：Add/遍历/Count，比数组灵活

### Unity

- 生命周期：Awake（出生一次）/Start/Update（每帧）/FixedUpdate（物理帧）/LateUpdate（相机跟随）
- Rigidbody：velocity 直接给速度移动、AddForce(Impulse) 跳跃、drag/mass 调手感、冻结旋转
- 碰撞 vs 触发：OnCollisionEnter(Collision) 有物理反弹；OnTriggerEnter(Collider) 配 Is Trigger 只发事件不碰撞，参数类型不能混
- 地面检测：Physics.Raycast 向下打射线 + IsGrounded，防止空中连跳
- 输入：Input.GetKey（按住）/GetKeyDown（按一下）、KeyCode.Space
- 吃金币：金币设 Trigger，碰到 score++ + Destroy(gameObject) + Canvas/Text 实时刷新分数
- 相机跟随：CameraFollow 放 LateUpdate，用 offset 偏移 + LookAt
- 接口驱动范围伤害：炸弹 Trigger 区域 + List<IDamageable> 循环 TakeDamage
- 组件化：PlayerController 管移动跳跃、Health 管血量，职责分开
- 单例 GameManager：public static Instance + Awake 里 Instance=this + DontDestroyOnLoad 切场景不销毁
- 游戏状态：enum GameState + 卫语句，胜利后锁定玩家操作
- 其他：Mathf.MoveTowards 平滑移动、SetActive 显隐、CompareTag 区分对象、Instantiate/Prefab/Destroy

### 工具/工程化

- Git：add/commit/push；push 常遇 443 超时（网络问题，多重试，本地 commit 不丢）；Unity 的 .meta 必须一起提交
- 仓库整理：README 维护目录树和阶段作品、按周写 week 总结、checkin 每日打卡
- 闭卷自测方法：不看资料脱稿写 → 卡住的地方就是没掌握 → 针对性补，比重复看笔记有效

## 三、看得见的成果

- **MiniLevel（W2 里程碑）**：第一个完整可玩小关——镜头跟随 → WASD 移动/空格跳障碍 → 吃金币加分（UI 实时变）→ 到终点弹胜利文字 → 胜利后锁操作，已手机录屏存档
- **Practice_Rebuild**：空场景脱稿训练场，独立搭出刚体移动 + 触发检测
- **Day14_Exam**：闭卷脱稿写出 Character 基类 + Player/Enemy 子类 + IDamageable 接口的回合制对战，一次跑通
- **Day14_Examples**：static 计数（Slime）、enum 敌人状态机（EnemyState + switch 遍历）、单例（SaveSystem/AudioManager）
- 控制台 DailyPractice：Day4 ~ Day14 每日练习齐全
- notes：四件套对比表、week2 总结；README 更新到 W2 并新增"阶段作品"板块

## 四、本周踩坑记录（错题本）

1. static 和 public/private 是两个独立维度：写了 static 不等于外面能访问，类成员不写修饰符默认 private（Slime.Count 报 CS0122）
2. 修饰符顺序约定俗成：`public static`，不是 static public
3. 属性 PascalCase：`ATk` 应为 `Atk`；构造参数 `int atk` 小驼峰本来就对，不用改
4. 数组下标跟变量名不跟类型名、从 0 开始；for 变量必须初始化 `int i = 0`
5. switch 不能直接判断数组：`switch(states)` 错，要 `switch(states[i])` 取当前一个；想遍历所有状态用数组 + for/foreach 喂进去
6. 单例字段和属性不能同名：私有字段小写 `instance`、公开属性大写 `Instance`，否则 CS0102 重复定义
7. 单例控制台版 vs Unity 版：控制台靠 private 构造锁 new、声明时就 new 好；Unity 的 MonoBehaviour 不能 new，在 Awake 里 `Instance=this` 登记，场景里必须真挂物体，否则 Instance 为 null 空引用
8. 单例不是功能是"规矩"：防止 new 出多个管家各记各的数据（两个 SaveSystem 的 Coin 互不相通）
9. OnTriggerEnter(Collider) 配 Is Trigger；OnCollisionEnter(Collision) 配实体碰撞，参数类型别混
10. velocity 是"速度"不乘 deltaTime；Translate 是"位移"才乘 deltaTime
11. 多态右边必须 new 具体子类，不能 new 基类；子类想 override，父类方法必须先标 virtual
12. private set 不是完全只读，类内部（构造函数、TakeDamage）仍能赋值，只是类外面不能
13. 复制 UI 物体会连带复制脚本组件，多余的要 Remove Component

## 五、还不太熟、下周继续巩固（自己补充）

- 单例今天刚从根上弄懂，目标是不看资料能随时默写出控制台版三行，并回头把 Unity 的 GameManager 每行讲明白
- 接口 vs 抽象类的区别（面试高频）要能脱口而出
- 工厂模式还要再脱稿写一次
- Unity "看得懂但自己写没思路"仍存在，继续坚持引导式 + 脱稿重建，不直接要完整代码
- （自己补充：）

## 六、下周计划（D15~D21 · W3）

### 本周主线

- 技术 A·C#：委托 delegate → 事件 event → Lambda 表达式（消息/回调机制，为 UI、吃金币、掉血等游戏事件解耦打基础）
- 技术 B·Unity：Animator 动画系统（动画状态机、状态切换、用代码参数控制走/跳/胜利动画）

### 节奏要求

- 每天上午 C#、下午 Unity、晚上练习 + 脱稿变式，当天代码当天 git 提交
- 新概念先给"作用 + 最小示例"，不一次灌全天内容
- 复盘日产出一个能跑的小 Demo，继续攒作品

### 阶段大目标（D35 = 10/8 前）

- W1 定的"移动 + 跳跃 + 撞敌掉血 + 吃金币加分迷你场景"已由 MiniLevel 完成 ✅
- 新目标：给 MiniLevel 角色接上 Animator 动画（ idle/跑/跳/胜利），并用委托/事件把"吃金币、掉血、胜利"的通知解耦
- 四件套 + 单例能随时脱稿默写，面试能讲清封装/继承/多态/接口的区别
