﻿namespace SquashMyUrl.DAL
{
    //this cache is specific to DAL so leaving in .DAL
    public interface ISquashModelCache
    {
        string CheckShortenedUrlExist(string encodedUrl);
    }
}