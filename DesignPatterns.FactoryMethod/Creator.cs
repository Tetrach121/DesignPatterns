using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod_Documents
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            // Konstruktor wywołuje abstrakcyjną metodę CreatePages(), która implementowana jest w ConcreteCreator
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Metoda Wytwórcza - Factory Method
        public abstract void CreatePages();
    }
}
