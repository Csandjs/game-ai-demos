# 第1周学习总结（D1 ~ D7）

## 一、本周主题总览
| Day | 主题 | 主要产出 |
|---|---|---|
| D1 | 环境搭建 | 装好Unity/Git，建game-ai-demos仓库，跑通C# HelloWorld |
| D2 | Unity入门 | 认识编辑器、GameObject/Component/Transform，写物体移动脚本 |
| D3 | 工程与规划 | 搭简历骨架、建checkin打卡表、读Unity官方基础文档 |
| D4 | C#语法基础+脚本移动 | 变量/类型/运算符/流程控制；Translate+deltaTime移动 |
| D5 | C#循环+Unity物理 | 刚体velocity移动、AddForce跳跃、碰撞落地检测 |
| D6 | 数组方法+预制体 | 数组/方法/冒泡/打擂台；Prefab、Instantiate发射 |
| D7 | 第1周复盘 | C#系统笔记、三功能整合、修碰撞bug、录屏存档 |

## 二、本周核心知识
### C#
- 变量与类型：int/float/double/bool/char/string/var；小驼峰命名
- 运算符：算术(+ - * / %，注意整数除法)、比较、逻辑(&& || !)
- 类型转换：(int)/(double)强转、int.Parse、ToString
- 流程控制：if/else if/else、switch(每case要break)、while/do-while、for、foreach、break/continue
- 数组：下标从0、Length、for/foreach遍历、越界、输入存数组、string.Join
- 方法：四件套(返回类型/方法名/参数/方法体)、static、return两作用、卫语句、值类型传参是副本
- 入门算法：冒泡排序、打擂台求最值

### Unity
- 生命周期：Start执行一次 / Update每帧 / FixedUpdate物理帧
- transform.Translate + Vector3方向 × speed × Time.deltaTime（帧率无关）
- 输入：GetKey(按住)/GetKeyDown(按一下)、KeyCode、GetAxis平滑输入(-1~1)
- 物理：Rigidbody刚体、velocity移动、AddForce(Impulse)跳跃、摩擦力/冻结旋转、Collider碰撞体
- 碰撞：OnCollisionEnter/Exit、isGrounded落地、CompareTag区分碰撞对象
- 预制体：Prefab可复用模板、public槽拖拽、Instantiate生成并可接住返回值继续控制

### 工具/工程化
- Git：add/commit/push/status、.gitignore、GitHub远程仓库；VS Code要"打开文件夹"
- 笔记体系：checkin打卡 + 按天StudyNotes + 按主题CSharp_Basics

## 三、看得见的成果
- GitHub仓库 game-ai-demos，保持每日提交
- 控制台练习：Day4/5/6_Practice
- Unity迷你场景：WASD刚体移动 + 空格跳跃 + J键发射小球，全部能跑
- notes/CSharp_Basics.md 系统笔记（五大块+16条避坑）
- 第一周成果录屏一份

## 四、本周踩坑记录（错题本）
1. 终端从C盘打开 → VS Code必须"打开文件夹"到仓库根
2. 符号要英文；WriteLine大小写；Console.ReadLine前缀别丢
3. for里 i 是下标、arr[i] 才是值
4. 整数除法 5/2=2，要小数得强转或用5.0
5. 值类型传方法是副本，方法里改不到外面
6. string.Join("分隔符",数组)两参数用逗号，写成+会报CS0121
7. Translate和刚体velocity别同时启用，会打架
8. 被自己发射的球撞到不能跳 → 碰撞没区分对象，用CompareTag("Ground")解决
9. Instantiate不接返回值物体也不会消失，只是拿不到引用去控制它

## 五、还不太熟、下周继续巩固（自己补充）
- 冒泡排序还要能独立默写
- Unity API名字（Translate/AddForce/Instantiate）多写才熟
- 有一些操作步骤代码关键点还得练习

## 六、下周计划（D8~D14 · 阶段1地基期 W2）
### 本周主线
- 技术A·C#（重点，全新概念，放慢）：面向对象编程
  类(class)与对象 → 字段/属性/方法 → 构造函数 → 封装 → 继承 → 多态 → 接口
- 技术B·Unity：刚体/碰撞/移动/跳跃本周已提前学完，下周以巩固+小综合为主，
  为后面"撞敌掉血、吃金币加分"的完整迷你场景做准备，逐步接触动画与UI
### 节奏要求
- 每天：上午学C#面向对象概念，下午在Unity/控制台动手练，当天代码当天git提交
- D8开始每天由带学拆成单步任务，一次一步，不赶进度
### 阶段大目标（D35 = 10/8 前）
- 能独立做出"移动 + 跳跃 + 撞敌掉血 + 吃金币加分"的迷你场景
- 能不查资料独立写一个"继承 + 多态"的小例子
