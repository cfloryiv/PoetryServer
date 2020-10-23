using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PS.BR
{
    public class Poems
    {
        public string Path { get; set; }
        public List<Poem> PoemList { get; set; } = new List<Poem>();
        public List<Poem> GetList()
        {
            return PoemList;
        }
        public void Import()
        {
            string[] files = Directory.GetFiles(Path);
            foreach (var file in files.Take(5))
            {
                var poem = new Poem
                {
                    Path = file
                };
                poem.Import();
                PoemList.Add(poem);
            }
            
        }
        public void ImportText()
        {
            string[] files = Directory.GetFiles(Path);
            foreach (var file in files)
            {
                if (file.ToLower().EndsWith("docx")) continue;

                var poem = new Poem
                {
                    Path = file
                };
                poem.ImportText();
                PoemList.Add(poem);
            }

        }
    }
}
