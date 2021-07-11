using System.IO;
using System.Net;
using Nfense.NProxy;

namespace Nfense.ModStatic {
    public class StaticHandler : Handler {
        public override bool OnHandle(HttpListenerContext ctx, Node node)
        {
            string dir = node.GetString("static_directory", null);
            string file = ctx.Request.Url.LocalPath;

            if (file.IndexOf("..") >= 0) {
                ctx.Response.StatusCode = 400;
                ctx.Response.Close();
                return false;
            } else {
                if (File.Exists(dir + file)) {
                    string mime = MimeType.GetMimeForFile(file);
                    byte[] data = File.ReadAllBytes(dir + file);

                    ctx.Response.ContentType = mime;
                    ctx.Response.StatusCode = 200;
                    ctx.Response.ContentLength64 = data.Length;

                    ctx.Response.OutputStream.Write(data, 0, data.Length);
                    return true;
                } else {
                    ctx.Response.StatusCode = 404;
                    ctx.Response.Close();
                    return false;
                }
            }
        }
    }
}