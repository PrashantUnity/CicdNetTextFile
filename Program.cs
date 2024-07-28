var ls = Enumerable.Range(1,8).Select(i => i.ToString()).ToList();




SaveVideosToFile(ls, "Text.txt");
static void SaveVideosToFile(List<string> videos, string filePath)
{
    using StreamWriter file = new(filePath);
    foreach (var video in videos)
    {
        file.WriteLine(video);
    }
}