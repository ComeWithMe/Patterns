using System;


namespace Patterns
{
    public class Singleton
    {
        private static Singleton _instanse;
        private static object _lock = new object();
        public string Name { get; private set; }
        private Lazy<Singleton> _insn;

        private Singleton(string name)
        {
            Name = name;
        }

        public static Singleton GetInstanse(string name)
        {
            if (_instanse == null)
            {
                lock (_lock)
                {
                    if (_instanse == null)
                    {
                        _instanse = new Singleton(name);
                        return _instanse;
                    }
                }
            }
            return _instanse;
        }
    }

    public class LazySingleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>();

        public static Singleton Instanse { get { return lazy.Value; } }

        private LazySingleton()
        {

        }
    }
}
