using System;
using System.Collections.Generic;
using System.Web;

namespace XiaolouT.Learning.PracticalPattern.Common
{
    public class GenericContext
    {
        class NameBasedDictionary : Dictionary<string, object>
        {

        }

        [ThreadStatic]
        private static NameBasedDictionary threadCache;

        private static readonly bool isWeb = CheckeWhetherIsWeb();

        private const string ContextKey = "xiaolouT.Learnig.context.web";


        public GenericContext()
        {
            if (isWeb && HttpContext.Current.Items[ContextKey] == null)
            {
                HttpContext.Current.Items[ContextKey] = new NameBasedDictionary();
            }
        }

        public object this[string name]
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    return null;
                }
                var cache = GetCache();
                if (cache.Count <= 0)
                {
                    return null;
                }
                object result;
                if (cache.TryGetValue(name, out result))
                {
                    return result;
                }
                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var cache = GetCache();
                    if (cache.ContainsKey(name))
                    {
                        cache[name] = value;
                    }
                    else
                    {
                        cache.Add(name, value);
                    }
                }
            }
        }

        private static NameBasedDictionary GetCache()
        {
            NameBasedDictionary cache;
            if (isWeb)
            {
                cache = (NameBasedDictionary)HttpContext.Current.Items[ContextKey];

            }
            else
            {
                cache = threadCache;
            }
            if (cache == null)
            {
                cache = new NameBasedDictionary();
            }
            if (isWeb)
            {
                HttpContext.Current.Items[ContextKey] = cache;
            }
            else
            {
                threadCache = cache;
            }
            return cache;
        }

        private static bool CheckeWhetherIsWeb()
        {
            bool result = false;
            AppDomain domain = AppDomain.CurrentDomain;
            try
            {
                if (domain.ShadowCopyFiles)
                {
                    result = HttpContext.Current != null;
                }
            }
            catch
            {


            }
            return result;
        }
    }
}
