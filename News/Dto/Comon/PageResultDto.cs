﻿namespace News.Dto.Comon
{
    public class PageResultDto<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalItem { get; set; }
    }
}
