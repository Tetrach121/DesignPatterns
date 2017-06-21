using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        private static object syncLock = new object();

        /// <summary>
        /// Singleton
        /// </summary>
        protected LoadBalancer()
        {
            _servers.Add("Server I");
            _servers.Add("Server II");
            _servers.Add("Server III");
            _servers.Add("Server IV");
            _servers.Add("Server V");
        }


        /// <summary>
        /// Fuction ensuring existence of single instance of SingletonClass
        /// </summary>
        /// <returns>Singleton instance</returns>
        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        /// <summary>
        /// Get "access" to random server name
        /// </summary>
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
