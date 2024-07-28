var ls = Enumerable.Range(1,8).Select(i => i.ToString() + DateTime.Now).ToList();

SaveVideosToFile(ls, "Text.txt");
static void SaveVideosToFile(List<string> videos, string filePath)
{
    using StreamWriter file = new(filePath);
    foreach (var video in videos)
    {
        file.WriteLine(video);
    }
}


/*
After publishing Github go TO Project setting then Action Tab Then General then s

Workflow permissions select

Read and write permissions  

and Tick 
Allow GitHub Actions to create and approve pull requests
*/