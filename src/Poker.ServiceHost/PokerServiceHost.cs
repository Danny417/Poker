using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using Poker.Main.Service;
using System.Threading.Tasks;

namespace Poker.ServiceHost
{
    /// <summary>
    /// Poker Game service that running in the background
    /// </summary>
    public partial class PokerServiceHost : ServiceBase
    {
        private System.ServiceModel.ServiceHost _gameHost;

        /// <summary>
        /// Constructor of Game Service
        /// </summary>
        public PokerServiceHost()
        {
            InitializeComponent();

            //Custom event log
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("PokerSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "PokerSource", "PokerServiceLog");
            }
            eventLog1.Source = "PokerSource";
            eventLog1.Log = "PokerServiceLog";

            _gameHost = new System.ServiceModel.ServiceHost(typeof(GameService));
        }

        #region Override Methods
        /// <summary>
        /// Override ServiceBase OnStart, trigger when the service is started
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            Thread.Sleep(30000);
            try
            {
                base.OnStart(args);
                _gameHost.Open();
                PrintServiceInfo(_gameHost);
                eventLog1.WriteEntry("The poker game service has started.");
            }
            catch (Exception e)
            {
                eventLog1.WriteEntry(e.StackTrace, EventLogEntryType.Error);
                _gameHost.Abort();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnPause()
        {
            try
            {
                _gameHost.Close();
            }
            catch (Exception e)
            {
                eventLog1.WriteEntry(e.StackTrace, EventLogEntryType.Error);
                _gameHost.Abort();
            }
            base.OnPause();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnContinue()
        {
            try
            {
                _gameHost.Open();
            }
            catch (Exception e)
            {
                eventLog1.WriteEntry(e.StackTrace, EventLogEntryType.Error);
                _gameHost.Abort();
            }
            base.OnContinue();
        }

        /// <summary>
        /// Override ServiceBase OnStop, trigger when the service is stopped
        /// </summary>
        protected override void OnStop()
        {
            try
            {
                _gameHost.Close();
                eventLog1.WriteEntry("The poker game service has stopped.");
            }
            catch (Exception e)
            {
                eventLog1.WriteEntry(e.StackTrace, EventLogEntryType.Error);
                _gameHost.Abort();
            }
            base.OnStop();
        }
        
        #endregion

        #region Private Methods
        /// <summary>
        /// Printing some info about listening endpoints for debugging purpose
        /// </summary>
        /// <param name="host">The host service</param>
        private void PrintServiceInfo(System.ServiceModel.ServiceHost host)
        {
            Console.WriteLine("{0} is up and running with these endpoints:",
                host.Description.ServiceType);
            foreach (ServiceEndpoint se in host.Description.Endpoints)
                eventLog1.WriteEntry(se.Address.ToString());
        }
        
        #endregion
    }
}
