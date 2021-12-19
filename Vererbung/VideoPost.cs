using System;

namespace Vererbung
{
    internal class VideoPost
    {
        private string v1;
        private string v2;
        private string v3;
        private bool v4;
        private int v5;

        public VideoPost(string v1, string v2, string v3, bool v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        internal void Stop()
        {
            throw new NotImplementedException();
        }
    }

      

    
