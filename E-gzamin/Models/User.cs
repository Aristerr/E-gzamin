﻿namespace E_gzamin.Models {
    public class User : BaseEntity {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
    }
}