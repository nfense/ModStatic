namespace Nfense.ModStatic {
    public static class MimeType {
        public static string GetMimeForFile (string file) {
            string extension = file.Split(".")[file.Split(".").Length - 1];
            switch (extension) {
                case "css":
                    return "text/css";
                case "js":
                    return "application/js";
                case "jpg":
                case "jpeg":
                    return "image/jpeg";
                case "png":
                    return "image/png";
                case "gif":
                    return "image/gif";
                case "mpeg":
                case "mp4":
                    return "video/mpeg";
                case "mp3":
                    return "audio/mp3";
                case "wav":
                    return "audio/wav";
                case "ogg":
                    return "audio/ogg";
                case "zip":
                    return "application/zip";
                case "json":
                    return "application/json";
                case "exe":
                    return "application/executable";
                case "html":
                    return "text/html";
                case "txt":
                    return "text/plain";
                default:
                    return "unknown";
            }
        }
    }
}