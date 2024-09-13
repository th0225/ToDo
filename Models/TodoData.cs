namespace ToDo.Models;

public class ToDoData
{
    public string ID { get; set;}
    // 內容
    public string Content { get; set; }
    // 已完成
    public bool IsDone { get; set; }
}

public class AllToDoDatas
{
    // 單例模式
    #region Singleton
    private static volatile AllToDoDatas? instance;
    private static readonly object syncRoot = new();

    public static AllToDoDatas Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    instance ??= new AllToDoDatas();
                }
            }
            return instance;
        }
    }
    private AllToDoDatas() { }
    #endregion

    // 已完成資料
    public List<ToDoData> AllDatas { get; set; } = new();
    // 未完成資料
}