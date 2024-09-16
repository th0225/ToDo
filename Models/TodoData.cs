namespace ToDo.Models;

public class ToDoData
{
    // ID
    public string? ID { get; set;} = string.Empty;
    // 內容
    public string? Content { get; set; } = string.Empty;
    // 已完成
    public bool IsDone { get; set; } = false;
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

    // 所有資料
    public List<ToDoData> AllDatas { get; set; } = [];
}