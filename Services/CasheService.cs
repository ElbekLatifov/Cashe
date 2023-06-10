namespace CasheApplication.Services;
public class CasheService
{
    public Dictionary<string, object> CasheDictionary { get; set; } = new Dictionary<string, object>();

    public void Set(string key, object value)
    {
        CasheDictionary.Add(key, value); 
    }

    public bool Get(string key, out object? value)
    {
        //if (CasheDictionary.ContainsKey(key))
        //{
        //    value = CasheDictionary[key];
        //    return true;
        //}
        //else
        //{
        //    value = null;
        //    return false;
        //}
        return CasheDictionary.TryGetValue(key, out value);
    }


}


