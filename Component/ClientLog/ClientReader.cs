using System;
using System.IO;
using System.Threading;
using LiveSplit.Options;
using LiveSplit.PathOfExile2AutoSplitter.Component.Settings;
using LiveSplit.PathOfExile2AutoSplitter.Component.Timer;

namespace LiveSplit.PathOfExile2AutoSplitter.Component.ClientLog
{
    public class ClientReader
    {
        private ComponentSettings _settings;
        private ClientParser _parser;
        private int threadCount = 0;
        
        // TODO add LoadRemoverSplitter
        public ClientReader(ComponentSettings settings, AutoSplitter splitter)
        {
            _settings = settings;
            _parser = new ClientParser(splitter);
        }

        public void Start()
        {
            threadCount++;
            
            int thisThreadCount = threadCount;

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                
                string logLocation = _settings.LogLocation;
                
                try
                {
                    using (FileStream fs = new FileStream(logLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        fs.Seek(0, SeekOrigin.End);

                        using (StreamReader sr = new StreamReader(fs))
                        {
                            while (thisThreadCount == threadCount)
                            {
                                while (!sr.EndOfStream)
                                {
                                    _parser.ProcessLine(sr.ReadLine());
                                }

                                while (sr.EndOfStream)
                                {
                                    Thread.Sleep(100);
                                }

                                _parser.ProcessLine(sr.ReadLine());
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Log.Error(e);
                }
            }).Start();
        }

        public void Stop()
        {
            threadCount++;
        }
    }
}
