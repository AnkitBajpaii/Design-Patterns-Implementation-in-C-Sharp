using System;
using System.Collections.Generic;

namespace Creational.Factory
{
    public interface IPage
    {
        string Content { get; set; }
    }

    public class Introduction : IPage
    {
        public string Content { get; set; }
    }

    public class Education : IPage
    {
        public string Content { get; set; }
    }

    public class Skill : IPage
    {
        public string Content { get; set; }
    }

    public class Result : IPage
    {
        public string Content { get; set; }
    }

    public class Conclusion : IPage
    {
        public string Content { get; set; }
    }

    public class Summary : IPage
    {
        public string Content { get; set; }
    }

    public interface IDocument
    {
        List<IPage> Pages { get; set; }
        void Read();
    }
    public class Resume : IDocument
    {
        public List<IPage> Pages { get; set; }
        public void Read()
        {
            foreach (var page in Pages)
            {
                Console.WriteLine(page.Content);
            }
        }
    }

    public class Report : IDocument
    {
        public List<IPage> Pages { get; set; }
        public void Read()
        {
            foreach (var page in Pages)
            {
                Console.WriteLine(page.Content);
            }
        }
    }
    public interface IDocumentCreator
    {
        IDocument CreateDocument(string type);
    }

    public class DocumentCreator : IDocumentCreator
    {
        public IDocument CreateDocument(string type)
        {
            IDocument document = null;
            if (type == "resume")
            {
                document = new Resume();
                document.Pages.Add(new Introduction { Content = "Intro content"});
                document.Pages.Add(new Education { Content = "Education content" });
                document.Pages.Add(new Skill { Content = "Skill content" });
            } else if (type == "report")
            {
                document = new Report();
                document.Pages.Add(new Introduction { Content = "Intro content" });
                document.Pages.Add(new Result { Content = "Result content" });
                document.Pages.Add(new Conclusion { Content = "Conclusion content" });
                document.Pages.Add(new Summary { Content = "Summary content" });
            }
            return document;
        }
    }

    
}
