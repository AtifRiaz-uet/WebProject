using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using WebAPI.Database;
using System.Configuration;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.Runtime.Caching;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController

    {
        // GET: studentInfo
        
        public string Get()
        {
            ObjectCache cache = MemoryCache.Default;
            if (cache["students"] == null)
            {
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTimeOffset.Now.AddDays(1);

                GetStd student = new GetStd();

                CacheItem cacheItem = new CacheItem("students", student.GetRecord());
                cache.Add(cacheItem, cacheItemPolicy);

                return student.GetRecord();
            }
            return cache.Get("students").ToString();
        }
        
    }
}
