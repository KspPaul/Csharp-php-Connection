using System;
using System.IO;
using System.Net;
using System.Text;

class Web
{
    public static string GetPost(string Url, string UserName, string name)
    {
        string result = string.Empty;
        string data = string.Empty;
        ASCIIEncoding ascii = new ASCIIEncoding();

        data += string.Format("{0}={1}", UserName, name);

        byte[] bytesarr = ascii.GetBytes(data);
        try
        {
            WebRequest request = WebRequest.Create(Url);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytesarr.Length;

            Stream streamwriter = request.GetRequestStream();
            streamwriter.Write(bytesarr, 0, bytesarr.Length);
            streamwriter.Close();

            WebResponse response = request.GetResponse();
            streamwriter = response.GetResponseStream();

            StreamReader streamread = new System.IO.StreamReader(streamwriter);
            result = streamread.ReadToEnd();
            streamread.Close();
        }
        catch
        {

        }
        return result;
    }
}