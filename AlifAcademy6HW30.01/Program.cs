using System;

namespace AlifAcademy6HW30._01
{
    class Program
    {
        private const string proKey = "pro123";
        private const string expKey = "exp123";
        static void Main(string[] args)
        {
            //task2
            //    DocumentWorker docWorker;
            //    Console.WriteLine("Please enter key: ");
            //    string key = Console.ReadLine();
            //    if (key == proKey)
            //    {
            //        docWorker = new ProDocumentWorker();
            //    }
            //    else if (key == expKey)
            //    {
            //        docWorker = new ExpertDocumentWorker();
            //    }
            //    else
            //        docWorker = new DocumentWorker();

            //    docWorker.OpenDocument();
            //    docWorker.EditDocument();
            //    docWorker.SaveDocument();

            /////task3
            //IPlayable play = new Player();
            //play.Play();
            //play.Pause();
            //play.Stop();

            //Console.WriteLine("---------------");

            //IRecordable record = new Player();
            //record.Record();
            //record.Pause();
            //record.Stop();


        }
    }
    //task2
    //class DocumentWorker
    //{
    //    public void OpenDocument()
    //    {
    //        Console.WriteLine("File Opened");
    //    }
    //    public virtual void EditDocument()
    //    {
    //        Console.WriteLine("Changes available in pro version");
    //    }
    //    public virtual void SaveDocument()
    //    {
    //        Console.WriteLine("Saving document available in pro version");
    //    }
    //}
    //class ProDocumentWorker : DocumentWorker
    //{
    //    public override void EditDocument()
    //    {
    //        Console.WriteLine("Document edited");
    //    }
    //    public override void SaveDocument()
    //    {
    //        Console.WriteLine("Document saved in previous format, saving in different format " +
    //            "available in Expert version");
    //    }
    //}
    //class ExpertDocumentWorker : ProDocumentWorker
    //{
    //    public override void SaveDocument()
    //    {
    //        Console.WriteLine("Document saved in new format");
    //    }
    //}


    /// Task3

    //interface IPlayable
    //{
    //    void Play();
    //    void Pause();
    //    void Stop();
    //}
    //interface IRecordable
    //{
    //    void Record();
    //    void Pause();
    //    void Stop();
    //}
    //class Player : IPlayable , IRecordable 
    //{
    //    public void Play()
    //    {
    //        Console.WriteLine("Play");
    //    }
    //    public void Pause()
    //    {
    //        Console.WriteLine("Pause");
    //    }
    //    public void Stop()
    //    {
    //        Console.WriteLine("Stop");
    //    }
    //    public void Record()
    //    {
    //        Console.WriteLine("Record");
    //    }
    //}
}



