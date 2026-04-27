static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string deptString = (department ?? "OWNER").ToUpper();
        
        if(id == null)
        {
            return $"{name} - {deptString}";
        }

        return $"[{id}] - {name} - {deptString}";
    }
}
