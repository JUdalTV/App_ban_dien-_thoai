﻿namespace News.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }


        public bool IsDeleted { get; set; }
    }
}
