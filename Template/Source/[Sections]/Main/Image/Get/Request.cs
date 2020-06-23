﻿using SCVault;
using ServiceStack;

namespace Main.Image.Get
{
    [Route("/api/image/{ID}.jpg")] //jpg extension is used so files can be cached by CDNs and browsers
    public class Request : IRequest<Nothing>
    {
        public string ID { get; set; }
    }
}
