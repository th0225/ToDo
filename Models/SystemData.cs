namespace ToDo.Models;

public class SystemData
{
    // 單例模式
    #region Singleton
    private static volatile SystemData? instance;
    private static readonly object syncRoot = new();

    public static SystemData Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    instance ??= new SystemData();
                }
            }
            return instance;
        }
    }
    private SystemData() { }
    #endregion

    // App名稱
    public string AppName { get; private set; } = "ToDo";
    // 版本號碼
    public string Version { get; set; } = "0.1.0";
    // 啟用深色主題
    public bool DarkMode { get; set; } = true;
}