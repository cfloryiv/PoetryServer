
using NetOffice.WordApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PS.BR
{
    public class Poem
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public List<string> Contents { get; set; }
        public void ImportText()
        {
            Contents = new List<string>();
            string[] lines = File.ReadAllLines(Path);
            foreach(var line in lines)
            {
                Contents.Add(line);
            }
            Title = Contents[0];
        }
        public void Import()
        {
            Contents = new List<string>();

            Application app = new Application();
            Document doc;
            try
            {
                doc = app.Documents.Open(Path, false, true);
                if (doc != null)
                        {
                    int count = doc.Content.Paragraphs.Count;
                    for (int i=1; i<=count; i++)
                    {
                        string test = doc.Content.Paragraphs[i].Range.Text;
                        Contents.Add(test);
                    }
                    doc.Close();
                }
            }
            catch (Exception ex)
            {

            }
         
            finally
            {
            app.Quit();
            }
           
        }
    }
}
