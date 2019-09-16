using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace NetworkHelper.Common
{
    /// <summary>  
    /// 返回HTTP请求的Response
    /// </summary>  
    public class HttpRequest
    {
        private static readonly string DefaultUserAgent =
            "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; QQWubi 133; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; CIBA; InfoPath.2)";

        /// <summary>
        /// 测试网络是否可用
        /// </summary>
        /// <returns></returns>
        public static bool TestNetworkStatus()
        {
            var urls = new string[] { "http://www.baidu.com", "http://www.qq.com/" };
            int count = 0;
            foreach (var url in urls)
            {
                try
                {
                    var resp = HttpResponseGet(url, method: "HEAD", timeout: 5000);
                    if (resp.StatusCode == HttpStatusCode.OK)
                    {
                        count++;
                    }
                }
                catch { }
            }
            return count > 0;
        }

        /// <summary>  
        /// 创建GET方式的HTTP请求  
        /// </summary>  
        /// <param name="url">请求的URL</param>  
        /// <param name="timeout">请求的超时时间（毫秒）</param>  
        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>  
        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>  
        /// <returns></returns>  
        public static string HttpResponseGetString(string url, int? timeout = null, string userAgent = null,
            CookieCollection cookies = null, string method = "GET")
        {
            using (var response = HttpResponseGet(url, timeout, userAgent, cookies, method))
            {
                return GetResponseString(response);
            }
        }

        /// <summary>  
        /// 创建GET方式的HTTP请求  
        /// </summary>  
        /// <param name="url">请求的URL</param>  
        /// <param name="timeout">请求的超时时间(毫秒)</param>  
        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>  
        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>  
        /// <returns></returns>  
        public static HttpWebResponse HttpResponseGet(string url, int? timeout = null, string userAgent = null,
            CookieCollection cookies = null, string method = "GET", string cookieStr = null)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = method;
            request.AllowAutoRedirect = true;
            if (!string.IsNullOrEmpty(userAgent))
            {
                request.UserAgent = userAgent;
            }
            else
            {
                request.UserAgent = DefaultUserAgent;
            }
            if (timeout.HasValue)
            {
                request.Timeout = timeout.Value;
            }
            request.CookieContainer = new CookieContainer();
            if (cookies != null)
            {
                if (cookies.Count > 0)
                {
                    request.CookieContainer.Add(cookies);
                }
            }

            if (cookieStr != null)
            {
                request.Headers.Add("Cookie", cookieStr);
            }
            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary>  
        /// 创建POST方式的HTTP请求  
        /// </summary>  
        /// <param name="url">请求的URL</param>  
        /// <param name="parameters">随同请求POST的参数名称及参数值字典</param>  
        /// <param name="timeout">请求的超时时间</param>  
        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>  
        /// <param name="requestEncoding">发送HTTP请求时所用的编码</param>  
        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>  
        /// <returns></returns>  
        public static string HttpResponsePostString(string url, string postData = null,
            Encoding requestEncoding = null, int? timeout = null, string userAgent = null,
            CookieCollection cookies = null)
        {
            try
            {
                using (var response = HttpResponsePost(url, postData, requestEncoding, timeout, userAgent, cookies))
                {
                    return GetResponseString(response);
                }
            }
            catch //(Exception ex)
            {
                throw;// new Exception("网络通讯异常！\r\n发送网络请求失败!\r\n请重试！");
                //return "{\"errcode\":\"0\",\"errmsg\":\"网络通讯异常！\r\n发送网络请求失败!\r\n请重试！\"}";
            }

        }

        public static string Post(string url, string data, Encoding requestEncoding = null, int? timeout = null,
            string userAgent = null, CookieCollection cookie = null, string token = null)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", token);
            HttpWebResponse response = HttpResponsePost(url, data, requestEncoding, timeout, userAgent, cookie, headers);
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                return sr.ReadToEnd();
            }
        }
        public static string Post(string url, Dictionary<string, object> data, Encoding requestEncoding = null,
            int? timeout = null, string userAgent = null, CookieCollection cookie = null, string token = null)
        {
            string postData = DicToUrlParameter(data);
            return Post(url, postData, requestEncoding, timeout, userAgent, cookie, token);
        }

        public static string Post(string url, Dictionary<string, object> data, Dictionary<string, object> headers,
            Encoding requestEncoding = null, int? timeout = null, string userAgent = null, CookieCollection cookie = null, string token = null)
        {
            string postData = DicToUrlParameter(data);
            return Post(url, postData, requestEncoding, timeout, userAgent, cookie, token);
        }

        private static string DicToUrlParameter(Dictionary<string, object> data)
        {
            string postData = string.Empty;
            if (data != null)
            {
                foreach (var a in data)
                {
                    postData += "" + a.Key + "=" + a.Value == null ? "" : a.Value.ToString();
                }
            }

            return postData;
        }

        /// <summary>  
        /// 创建POST方式的HTTP请求  
        /// </summary>  
        /// <param name="url">请求的URL</param>  
        /// <param name="parameters">随同请求POST的参数名称及参数值字典</param>  
        /// <param name="timeout">请求的超时时间</param>  
        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>  
        /// <param name="requestEncoding">发送HTTP请求时所用的编码</param>  
        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>  
        /// <returns></returns>  
        public static HttpWebResponse HttpResponsePost(string url, string postData = null,
            Encoding requestEncoding = null, int? timeout = null, string userAgent = null,
            CookieCollection cookies = null, Dictionary<string, string> headers = null)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (requestEncoding == null)
            {
                requestEncoding = Encoding.UTF8;
            }
            HttpWebRequest request = null;
            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback =
                    new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
                request.KeepAlive = false;
                // 这里设置了协议类型。
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;// SecurityProtocolType.Tls1.2; 
                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
                ServicePointManager.CheckCertificateRevocationList = true;
                ServicePointManager.DefaultConnectionLimit = 100;
                ServicePointManager.Expect100Continue = false;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }

            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.AllowAutoRedirect = true;
            if (!string.IsNullOrEmpty(userAgent))
            {
                request.UserAgent = userAgent;
            }
            else
            {
                request.UserAgent = DefaultUserAgent;
            }

            if (timeout.HasValue)
            {
                request.Timeout = timeout.Value;
            }
            request.CookieContainer = new CookieContainer();
            if (cookies != null)
            {
                request.CookieContainer.Add(cookies);
            }

            if (headers != null)
            {
                foreach (var a in headers)
                {
                    try
                    {
                        request.Headers.Add(a.Key, a.Value);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            //如果需要POST数据  
            if (!string.IsNullOrEmpty(postData))
            {
                byte[] data = requestEncoding.GetBytes(postData);
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                }
            }
            return request.GetResponse() as HttpWebResponse;
        }

        /// <summary>
        /// 从Response中获取字符串结果
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private static string GetResponseString(HttpWebResponse response)
        {
            Stream stream = response.GetResponseStream();
            if (stream != null)
            {
                StreamReader sr = new StreamReader(stream);
                string result = sr.ReadToEnd();

                stream.Close();
                stream.Dispose();
                sr.Close();
                sr.Dispose();

                return result;
            }
            return string.Empty;
        }

        /// <summary>
        /// 屏蔽https的服务器证书验证,总是返回true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors errors)
        {
            return true; //总是接受  
        }

        public static string GetCookieStr(HttpWebResponse response)
        {
            if (response != null)
            {
                if (response.Headers != null)
                {
                    string cookie = response.Headers["Set-Cookie"];

                    return cookie;
                }
            }
            return null;
        }

        public static CookieCollection GetCookie(HttpWebResponse response)
        {
            if (response != null)
            {
                if (response.Headers != null)
                {
                    string cookie = response.Headers["Set-Cookie"];
                    int index = cookie.IndexOf("=");
                    CookieCollection collection = new CookieCollection();
                    string val = cookie.Substring(index + 1);
                    collection.Add(new Cookie("JSESSIONID", val, "/"));
                    return collection;
                }
            }
            return null;
        }
    }
}
